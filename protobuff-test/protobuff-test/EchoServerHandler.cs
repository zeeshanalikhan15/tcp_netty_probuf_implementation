using DotNetty.Buffers;
using DotNetty.Transport.Channels;
using Google.Protobuf;
using System;
using System.Text;

namespace protobuff_test
{
    public class EchoServerHandler : ChannelHandlerAdapter
    {
        public override void ChannelRead(IChannelHandlerContext context, object message)
        {
            var mq_message = message as MQMessage;
            if (mq_message.AgentEvent != null)
            {
                var agent = mq_message.AgentEvent;
                Console.WriteLine("Received Agent from client: " + agent.ToString());
            }
            else if (mq_message.CallEvent != null)
            {
                var call = mq_message.CallEvent;
                Console.WriteLine("Received Call from client: " + call.ToString());

            }
            else 
            {
                Console.WriteLine("Received Unknow from client: ");
            }

        }

        public override void ChannelReadComplete(IChannelHandlerContext context) => context.Flush();

        public override void ExceptionCaught(IChannelHandlerContext context, Exception exception)
        {
            Console.WriteLine("Exception: " + exception);
            context.CloseAsync();
        }

        public override void ChannelRegistered(IChannelHandlerContext context)
        {
            Console.WriteLine("Server Registered ");
            base.ChannelRegistered(context);
        }

        public override void ChannelActive(IChannelHandlerContext context)
        {
            Console.WriteLine("Server Active ");
            base.ChannelActive(context);
        }


    }
}
