using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DashboardDesignerAsyncModeExample
{
    public class SalesData
    {
        public int Id {get;set;}
        public string SalesPerson { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }

        public static List<SalesData> CreateData()
        {
            List<SalesData> data = new List<SalesData>();
            Random rand = new Random();
            string[] salesPersons = { "Andrew Fuller", "Michael Suyama", "Robert King", "Nancy Davolio",
                "Margaret Peacock", "Laura Callahan", "Steven Buchanan", "Janet Leverling" };

            for (int i = 0; i < 1000; i++)
            {
                SalesData record = new SalesData();
                record.Id = i;
                record.SalesPerson = salesPersons[rand.Next(0, salesPersons.Length)];
                record.Quantity = rand.Next(0, 100);
                record.OrderDate = new DateTime(DateTime.Today.Year, 1, 1).AddDays(rand.Next(1, 365));
                data.Add(record);
                Delay();
            }
            return data;
        }

        private static void Delay()
        {
            string[] arrayStr = Enumerable.Range(0, 20*1000).Select((i => i.ToString())).ToArray();
        }
    }
}
