using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;

namespace RSS1
{
    [Serializable]
    static class Database
    {
        static public Dictionary<DateTimeOffset, SyndicationItem> data1 = new Dictionary<DateTimeOffset, SyndicationItem>();
        static public Dictionary<DateTimeOffset, SyndicationItem> data2 = new Dictionary<DateTimeOffset, SyndicationItem>();
        static public Dictionary<DateTimeOffset, SyndicationItem> data3 = new Dictionary<DateTimeOffset, SyndicationItem>();
        static public Dictionary<DateTimeOffset, SyndicationItem> data4 = new Dictionary<DateTimeOffset, SyndicationItem>();
        static public Dictionary<DateTimeOffset, SyndicationItem> data5 = new Dictionary<DateTimeOffset, SyndicationItem>();
    }
}
