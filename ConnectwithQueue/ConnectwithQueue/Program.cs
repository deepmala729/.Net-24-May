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
            string connectionstring = "DefaultEndpointsProtocol=https;AccountName=levelupsolutions7;AccountKey=FiSVbXke6LVIeL9akFTlTh4DL0qyagh4gBFuqBEwXu1E65ITfbXk8YvPjsV+fOZuRR8jt+Wik7hy+ASt8YoLZg==";
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