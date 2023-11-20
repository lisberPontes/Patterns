using BridgePattern.Bridges_Implementors;

namespace BridgePattern.Abstractions
{
    /// <summary>
    /// A 'RefinedAbstraction' class
    /// </summary>
    internal sealed class SystemMessage : IMessage
    {
        private IMessageSenderBridge MessageSenderBridge { get; }

        public SystemMessage(IMessageSenderBridge iMessageSenderBridge)
        {
            MessageSenderBridge = iMessageSenderBridge;
        }

        #region IMessage

        public string Subject { get; set; }
        public string Body { get; set; }

        public void Send()
        {
            MessageSenderBridge.SendMessage(Subject, Body);
        }

        #endregion
    }
}