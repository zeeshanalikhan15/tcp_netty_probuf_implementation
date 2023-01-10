using DotNetty.Buffers;
using DotNetty.Transport.Channels;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace client_netty
{
    public class EchoClientHandler : ChannelHandlerAdapter
    {
        readonly AgentEvent defualtAgentEvent;
        readonly CallEvent defualtCallEvent;

        public EchoClientHandler()
        {
            defualtAgentEvent = new AgentEvent();
            defualtAgentEvent.AgentId = "Agent1";
            defualtAgentEvent.SkillId = "Skill1";
            defualtAgentEvent.EventTime = DateTime.UtcNow.Ticks;
            defualtAgentEvent.EventType = EventType.AgentBusy;


            defualtCallEvent = new CallEvent
            {
                AgentId = "Agent2",
                CallId = "Call1-test1-1232",
                ConnectedTime = DateTime.UtcNow.Ticks,
                EventType = EventType.CallConnected
            };
        }

        public override void ChannelActive(IChannelHandlerContext context) 
        {
            context.WriteAndFlushAsync(new MQMessage() { AgentEvent = defualtAgentEvent });
            context.WriteAndFlushAsync(new MQMessage() { CallEvent = defualtCallEvent });
        }

        public override void ChannelReadComplete(IChannelHandlerContext context) => context.Flush();

        public override void ExceptionCaught(IChannelHandlerContext context, Exception exception)
        {
            Console.WriteLine("Exception: " + exception);
            context.CloseAsync();
        }
    }

    public class ClientSettings
    {
        public static IPAddress Host => IPAddress.Parse("127.0.0.1");

        public static int Port => int.Parse("59000");

        public static int Size => int.Parse("256");
    }
}
