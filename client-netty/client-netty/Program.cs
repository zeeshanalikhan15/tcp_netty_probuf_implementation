using DotNetty.Codecs;
using DotNetty.Codecs.Protobuf;
using DotNetty.Handlers.Logging;
using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels;
using DotNetty.Transport.Channels.Sockets;
using System;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace client_netty
{
    internal class Program
    {
        static async Task RunClientAsync()
        {
            var group = new MultithreadEventLoopGroup();
            
            try
            {
                var bootstrap = new Bootstrap();
                bootstrap
                    .Group(group)
                    .Channel<TcpSocketChannel>()
                    .Option(ChannelOption.TcpNodelay, true)
                    .Handler(new ActionChannelInitializer<ISocketChannel>(channel =>
                    {
                        IChannelPipeline pipeline = channel.Pipeline;

                        pipeline.AddLast(new LoggingHandler());
                        pipeline.AddLast(new ProtobufVarint32FrameDecoder());
                        //pipeline.AddLast(new ProtobufDecoder(AgentEvent.Descriptor.Parser));
                        //pipeline.AddLast(new ProtobufDecoder(CallEvent.Descriptor.Parser));
                        pipeline.AddLast(new ProtobufVarint32LengthFieldPrepender());
                        pipeline.AddLast(new ProtobufEncoder());

                        pipeline.AddLast("echo", new EchoClientHandler());
                    }));

                IChannel clientChannel = await bootstrap.ConnectAsync(new IPEndPoint(ClientSettings.Host, ClientSettings.Port));

                Console.ReadLine();

                await clientChannel.CloseAsync();
            }
            finally
            {
                await group.ShutdownGracefullyAsync(TimeSpan.FromMilliseconds(100), TimeSpan.FromSeconds(1));
            }
        }

        static void Main() => RunClientAsync().Wait();
    }
}
