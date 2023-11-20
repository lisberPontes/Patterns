using BridgePattern.Abstractions;

namespace BridgePatternTester.Clients.SystemMessages
{
    internal class SystemMessageClient
    {
        private IMessage Message { get; }

        public SystemMessageClient(IMessage message)
        {
            Message = message;
        }

        public void Send()
        {
            Message.Send();
        }
    }
}