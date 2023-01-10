using DotNetty.Codecs;
using DotNetty.Codecs.Protobuf;
using DotNetty.Handlers.Logging;
using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels;
using DotNetty.Transport.Channels.Sockets;
using DotNetty.Transport.Libuv;
using System;
using System.Threading.Tasks;

namespace protobuff_test
{
    internal class Program
    {
        static async Task RunServerAsync()
        {
            IEventLoopGroup bossGroup;
            IEventLoopGroup workerGroup;

            if (ServerSettings.UseLibuv)
            {
                var dispatcher = new DispatcherEventLoopGroup();
                bossGroup = dispatcher;
                workerGroup = new WorkerEventLoopGroup(dispatcher);
            }
            else
            {
                bossGroup = new MultithreadEventLoopGroup(1);
                workerGroup = new MultithreadEventLoopGroup();
            }

            try
            {
                var bootstrap = new ServerBootstrap();
                bootstrap.Group(bossGroup, workerGroup);

                if (ServerSettings.UseLibuv)
                {
                    bootstrap.Channel<TcpServerChannel>();
                }
                else
                {
                    bootstrap.Channel<TcpServerSocketChannel>();
                }

                bootstrap
                    .Option(ChannelOption.SoBacklog, 100)
                    .Handler(new LoggingHandler("SRV-LSTN"))
                    .ChildHandler(new ActionChannelInitializer<IChannel>(channel =>
                    {
                        IChannelPipeline pipeline = channel.Pipeline;
                        pipeline.AddLast(new LoggingHandler("SRV-CONN"));
                        //pipeline.AddLast("framing-enc", new LengthFieldPrepender(2));
                        //pipeline.AddLast("framing-dec", new LengthFieldBasedFrameDecoder(ushort.MaxValue, 0, 2, 0, 2));
                        pipeline.AddLast(new ProtobufVarint32FrameDecoder());
                        //pipeline.AddLast(new ProtobufDecoder(AgentEvent.Descriptor.Parser));
                        pipeline.AddLast(new ProtobufDecoder(MQMessage.Descriptor.Parser));
                        pipeline.AddLast(new ProtobufVarint32LengthFieldPrepender()); 
                        pipeline.AddLast(new ProtobufEncoder());
                        pipeline.AddLast("echo", new EchoServerHandler());
                    }));

                IChannel boundChannel = await bootstrap.BindAsync(ServerSettings.Port);
                
                Console.WriteLine("here: " + boundChannel.Active);
                Console.ReadLine();

                await boundChannel.CloseAsync();
            }
            finally
            {
                await Task.WhenAll(
                    bossGroup.ShutdownGracefullyAsync(TimeSpan.FromMilliseconds(100), TimeSpan.FromSeconds(1)),
                    workerGroup.ShutdownGracefullyAsync(TimeSpan.FromMilliseconds(100), TimeSpan.FromSeconds(1)));
            }
        }

        static void Main() => RunServerAsync().Wait();
    }

    public static class ServerSettings
    {
        public static bool IsSsl
        {
            get
            {
                string ssl = "false";
                return !string.IsNullOrEmpty(ssl) && bool.Parse(ssl);
            }
        }

        public static int Port => int.Parse("59000");

        public static bool UseLibuv
        {
            get
            {
                string libuv = "true";
                return !string.IsNullOrEmpty(libuv) && bool.Parse(libuv);
            }
        }
    }
}
