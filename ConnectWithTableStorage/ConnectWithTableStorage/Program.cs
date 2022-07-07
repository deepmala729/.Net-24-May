using Azure;
using Azure.Data.Tables;
using System;

namespace ConnectWithTableStorage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client = new TableClient(new Uri("https://levelupsolutions2.table.core.windows.net"), "tblSample", new TableSharedKeyCredential("levelupsolutions2", "AreogH0tXgpK70H7oEJFB4PhIlwiZi0p+v1u+5aJQ6J6yZ1YR0VYKfTxh9ImneFAL48w9Py4x0rp+AStRMIVJg=="));
            Pageable<TableEntity> queryableTable = client.Query<TableEntity>();
            foreach (TableEntity item in queryableTable)
            {
                Console.WriteLine(item.GetString("Name"));
            }
        }
    }
}