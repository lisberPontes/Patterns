using System;

namespace BridgePattern.Bridges_Implementors
{
    /// <summary>
    /// A 'ConcreteImplementor' class
    /// </summary>
    internal sealed class WebServiceSenderBridge : IMessageSenderBridge
    {
        public void SendMessage(string subject, string body)
        {
            var messageType = nameof(WebServiceSenderBridge);

            Console.WriteLine($"{messageType}");
            Console.WriteLine("--------------");
            Console.WriteLine($"Subject:  {subject} from {messageType}\nBody:  {body}\n");
        }
    }
}