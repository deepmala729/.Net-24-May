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
            var client = new TableClient(new Uri("https://levelupsolutions7.table.core.windows.net"), "tblSample1", new TableSharedKeyCredential("levelupsolutions7", "FiSVbXke6LVIeL9akFTlTh4DL0qyagh4gBFuqBEwXu1E65ITfbXk8YvPjsV+fOZuRR8jt+Wik7hy+ASt8YoLZg=="));
            Pageable<TableEntity> queryableTable = client.Query<TableEntity>();
            foreach (TableEntity item in queryableTable)
            {
                Console.WriteLine(item.GetString("Name"));
            }
        }
    }
}