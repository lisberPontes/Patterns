namespace BridgePattern.Abstractions
{
    /// <summary>
    /// The 'Abstraction'
    /// </summary>
    internal interface IMessage
    {
        string Subject { get; set; }
        string Body { get; set; }
        void Send();
    }
}