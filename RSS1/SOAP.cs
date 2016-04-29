using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace RSS1
{
    class SOAP
    {
        public static void Serialise(object db1)
        {
            SoapFormatter soapFormatter = new SoapFormatter();
            Stream fStream = new FileStream("feed.dat1", FileMode.CreateNew, FileAccess.Write, FileShare.None);
            
            soapFormatter.Serialize(fStream, db1);
            Console.WriteLine("SOAP Сохранение {0} в {1}", db1.GetType().ToString(), "feed.dat");



        }


    }
}
