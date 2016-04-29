using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;

namespace RSS1
{
    [Serializable]
    class NonStaticDB
    {
         public Dictionary<DateTimeOffset, SyndicationItem> data1 = new Dictionary<DateTimeOffset, SyndicationItem>();
         public Dictionary<DateTimeOffset, SyndicationItem> data2 = new Dictionary<DateTimeOffset, SyndicationItem>();
         public Dictionary<DateTimeOffset, SyndicationItem> data3 = new Dictionary<DateTimeOffset, SyndicationItem>();
         public Dictionary<DateTimeOffset, SyndicationItem> data4 = new Dictionary<DateTimeOffset, SyndicationItem>();
         public Dictionary<DateTimeOffset, SyndicationItem> data5 = new Dictionary<DateTimeOffset, SyndicationItem>();

        public NonStaticDB(
            Dictionary<DateTimeOffset, SyndicationItem> data1,
            Dictionary<DateTimeOffset, SyndicationItem> data2,
            Dictionary<DateTimeOffset, SyndicationItem> data3,
            Dictionary<DateTimeOffset, SyndicationItem> data4,
            Dictionary<DateTimeOffset, SyndicationItem> data5
            )
        {
            this.data1 = data1;
            this.data2 = data2;
            this.data3 = data3;
            this.data4 = data4;
            this.data5 = data5;
        }
    }
}
