using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;

namespace RSS1
{
    class Program
    {
        static void Main(string[] args)
        {
            OldMethod();
        }

        private static void DontWork()
        {
            Formatters.Datafeed1();
            Formatters.Datafeed2();
            Formatters.Datafeed3();
            Formatters.Datafeed4();
            Formatters.Datafeed5();
            NonStaticDB db1 = new NonStaticDB(Database.data1, Database.data2, Database.data3, Database.data4, Database.data5);
            SOAP.Serialise(db1);

            Console.ReadKey();
        }

        private static void OldMethod()
        {
            var formatter = Formatters.formatter2();

            var feed = formatter.Feed;

            Console.WriteLine("Feed Title: {0}", feed.Title.Text);
            Console.WriteLine("Feed Description: {0}", feed.Description.Text);


            Console.WriteLine("Feed items Count: {0}", feed.Items.Count());

            foreach (SyndicationItem item in feed.Items)
            {
                Console.WriteLine(item.Title.Text);
                Console.WriteLine(item.PublishDate.ToString());
                Console.WriteLine(item.Summary.Text);
                Console.WriteLine(item.Id.ToString());


                Console.WriteLine();

            }



            Console.ReadKey();
        }
    }
}