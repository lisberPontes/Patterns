using System;

namespace BridgePattern.Bridges_Implementors
{
    /// <summary>
    /// A 'ConcreteImplementor' class
    /// </summary>
    internal sealed class TextSenderBridge : IMessageSenderBridge
    {
        public void SendMessage(string subject, string body)
        {
            var messageType = nameof(TextSenderBridge);

            Console.WriteLine($"{messageType}");
            Console.WriteLine("--------------");
            Console.WriteLine($"Subject:  {subject} from {messageType}\nBody:  {body}\n");
        }
    }
}