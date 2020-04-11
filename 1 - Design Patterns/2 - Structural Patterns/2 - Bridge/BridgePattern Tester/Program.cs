using System;
using BridgePattern.Abstractions;
using BridgePattern.Bridges_Implementors;
using BridgePatternTester.Clients.SystemMessages;

namespace BridgePattern_Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = "A Message";
            var body = "Hi there, Please accept this message.";

            //1º Text Message
            IMessage message = new SystemMessage(new TextSenderBridge())
            {
                Subject = subject,
                Body = body
            };

            var systemMessageTextClient = new SystemMessageClient(message);
            systemMessageTextClient.Send();

            //2º WebService Message
            message = new SystemMessage(new WebServiceSenderBridge())
            {
                Subject = subject,
                Body = body
            };

            systemMessageTextClient = new SystemMessageClient(message);
            systemMessageTextClient.Send();

            Console.ReadLine();
        }
    }
}