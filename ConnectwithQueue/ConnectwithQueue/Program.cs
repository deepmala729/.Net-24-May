using Azure.Storage.Queues;
using System;

namespace ConnectwithQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            InsertMessage("Order with ORD13234 is proccessed");
        }

        public static void InsertMessage(string message)
        {
            string connectionstring = "DefaultEndpointsProtocol=https;AccountName=levelupsolutions2;AccountKey=AreogH0tXgpK70H7oEJFB4PhIlwiZi0p+v1u+5aJQ6J6yZ1YR0VYKfTxh9ImneFAL48w9Py4x0rp+AStRMIVJg==;EndpointSuffix=core.windows.net";
            QueueClient queueClient = new QueueClient(connectionstring, "sample-queue");
            queueClient.CreateIfNotExists();
            if (queueClient.Exists())
            {
                queueClient.SendMessage(message);
            }
            Console.WriteLine("Message is inserted");
        }
    }
}