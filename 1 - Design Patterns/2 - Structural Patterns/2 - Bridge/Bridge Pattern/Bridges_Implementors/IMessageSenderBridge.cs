namespace BridgePattern.Bridges_Implementors
{
    /// <summary>
    /// The 'Bridge/Implementor' interface
    /// </summary>
    internal interface IMessageSenderBridge
    {
        void SendMessage(string subject, string body);
    }
}