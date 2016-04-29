using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Threading;

namespace RSS1
{
    class Formatters
    {
        public static void Datafeed1()
            {
           
                XmlReader reader = XmlReader.Create("http://nnmclub.to/forum/rssp.xml");
                var formatter = new Rss20FeedFormatter();
                formatter.ReadFrom(reader);
                var feed = formatter.Feed;
                foreach (SyndicationItem item in feed.Items)
                { 
                        try { Database.data1.Add(item.PublishDate, item); }  catch { }
                }
                
        }

        public static void Datafeed2()
        {
            XmlReader reader = XmlReader.Create("http://pogoda.by/rss2/cityrss.php?q=27612");
            var formatter = new Rss20FeedFormatter();
            
                
                formatter.ReadFrom(reader);
                var feed = formatter.Feed;
                foreach (SyndicationItem item in feed.Items)
                {
                    try { Database.data2.Add(item.PublishDate, item); } catch { }
                }
                
            
        }
        public static void Datafeed3()
        {
            XmlReader reader = XmlReader.Create("http://ria.ru/export/rss2/society/index.xml");
            var formatter = new Rss20FeedFormatter();
            
                
                formatter.ReadFrom(reader);
                var feed = formatter.Feed;
                foreach (SyndicationItem item in feed.Items)
                {
                    try { Database.data3.Add(item.PublishDate, item); } catch { }
                }
                
        }
        public static void Datafeed4()
        {

            XmlReader reader = XmlReader.Create("http://ria.ru/export/rss2/moscow/index.xml");
            var formatter = new Rss20FeedFormatter();
            
                formatter.ReadFrom(reader);
                var feed = formatter.Feed;
                foreach (SyndicationItem item in feed.Items)
                {
                    try { Database.data4.Add(item.PublishDate, item); } catch { }
                }
               
        }
        public static void Datafeed5()
        {
            XmlReader reader = XmlReader.Create("http://ria.ru/export/rss2/tourism/index.xml");
            var formatter = new Rss20FeedFormatter();
            
                
                formatter.ReadFrom(reader);
                var feed = formatter.Feed;
                foreach (SyndicationItem item in feed.Items)
                {
                    try { Database.data5.Add(item.PublishDate, item); } catch { }
                }
            
        }



        public static Rss20FeedFormatter formatter2()
        {
            XmlReader reader = XmlReader.Create("http://nnmclub.to/forum/rssp.xml");
            var formatter = new Rss20FeedFormatter();
            formatter.ReadFrom(reader);
            return formatter;
        }

        

            public static Rss20FeedFormatter formatter3()
        {
            XmlReader reader = XmlReader.Create("http://pogoda.by/rss2/cityrss.php?q=27612");
            var formatter = new Rss20FeedFormatter();
            formatter.ReadFrom(reader);
            return formatter;
        }


        
        public static  Rss20FeedFormatter formatter1()
        {

            SyndicationFeed feed = new SyndicationFeed("Как я изучал RSS C#",
                "Тут находится краткое описание, как конкретно я это делал",
                new Uri("http://localhost/feed1"));

            SyndicationItem item1 = new SyndicationItem(
                    "Item One",
                    "This is the content for item one",
                    new Uri("http://localhost/Content/One"),
                    "ItemOneID",
                    DateTime.Now);

            SyndicationItem item2 = new SyndicationItem(
                "Item Two",
                "This is the content for item two",
                new Uri("http://localhost/Content/Two"),
                "ItemTwoID",
                DateTime.Now);

            SyndicationItem item3 = new SyndicationItem(
                "Item Three",
                "This is the content for item three",
                new Uri("http://localhost/Content/three"),
                "ItemThreeID",
                DateTime.Now);

            List<SyndicationItem> items = new List<SyndicationItem>();
            items.Add(item1);
            items.Add(item2);
            items.Add(item3);

            feed.Items = items;
            return new Rss20FeedFormatter(feed);

        }
    }
}
