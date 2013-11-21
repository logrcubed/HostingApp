using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System;
using System.ServiceModel;
using System.IO;
using System.Collections.Generic;
using System.Xml;
using System.Net;
using System.ServiceModel;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System;


namespace RestImageProcessor
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, 
        ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext=false)]
    public class ImageUploadService : IImageUpload
    {
        private ServiceHost host = null;

        public ImageUploadService()
        {
            host = new ServiceHost(typeof(ImageUploadService),
                    new Uri("http://localhost:7635/ImageUploadService"));
            BasicHttpBinding b = new BasicHttpBinding();
            b.Security.Mode = (BasicHttpSecurityMode)SecurityMode.None;
            b.Security.Message.ClientCredentialType = (BasicHttpMessageCredentialType)MessageCredentialType.None;
            b.MaxReceivedMessageSize = 671088640;
            b.MaxBufferPoolSize = 671088640;
            b.MaxBufferSize = 671088640;
            b.TransferMode = TransferMode.Streamed;
            b.CloseTimeout = new TimeSpan(0, 10, 0);
            b.SendTimeout = new TimeSpan(0, 10, 0);
            b.OpenTimeout = new TimeSpan(0, 10, 0);
            b.ReceiveTimeout = new TimeSpan(0, 10, 0);
            //b.ReaderQuotas.MaxArrayLength = 671088640;
            //b.ReaderQuotas.MaxDepth = 64;
            //b.ReaderQuotas.MaxStringContentLength = 671088640;
            //b.ReaderQuotas.MaxBytesPerRead = 671088640;
            //b.ReaderQuotas.MaxStringContentLength = 671088640;
            //b.ReaderQuotas.MaxNameTableCharCount = 671088640;
            host.AddServiceEndpoint(typeof(IImageUpload),
                b, "FileUpload");
            host.Open();
        }

        public void FileUpload( Stream fileStream)
        {
            String fileName = "test.jpg";
            FileStream fileToupload = new FileStream("C:\\Users\\trilok.rangan\\Desktop\\RPi\\Images\\Destination\\" + fileName, FileMode.Create);


            byte[] bytearray = new byte[2147483647];
            int bytesRead, totalBytesRead = 0;
            do
            {
                bytesRead = fileStream.Read(bytearray, 0, bytearray.Length);
                totalBytesRead += bytesRead;
            } while (bytesRead > 0);

            fileToupload.Write(bytearray, 0, bytearray.Length);
            fileToupload.Close();
            fileToupload.Dispose();

        }
    }
}
