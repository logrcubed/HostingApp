using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using System;
using System.ServiceModel;
using System.IO;
using System.Collections.Generic;
using System.Xml;
using System.Net;

namespace RestImageProcessor
{
    class Program
    {
        static void Main(string[] args)
        {

            //BasicHttpBinding binding = new BasicHttpBinding();
            //binding.Name = "binding1";
            //binding.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;
            //binding.Security.Mode = BasicHttpSecurityMode.None;

            //Uri baseAddress = new Uri("http://localhost:8000/Service");
            //Uri address = new Uri("http://localhost:8000/Service/FileUpload");

            //// Create a ServiceHost for the CalculatorService type and provide the base address.
            //ServiceHost serviceHost = new ServiceHost(typeof(ImageUploadService), baseAddress);

            //serviceHost.AddServiceEndpoint(typeof(IImageUpload), binding, address);

            //// Open the ServiceHostBase to create listeners and start listening for messages.
            //serviceHost.Open();
            ImageUploadService im = new ImageUploadService();

            // The service can now be accessed.
            Console.WriteLine("The service is ready.");
            Console.WriteLine("Press <ENTER> to terminate service.");
            Console.WriteLine();
            Console.ReadLine();
	    
            // Close the ServiceHostBase to shutdown the service.
            //serviceHost.Close();
            //string baseAddress = "http://localhost:8000/Service";
            //ServiceHost host = new ServiceHost(typeof(ImageUploadService), new Uri(baseAddress));
            //host.AddServiceEndpoint(typeof(IImageUpload), new BasicHttpBinding(), "").EndpointBehaviors.Add(IEndpointBehavior x);
            ////host.AddServiceEndpoint(typeof(IImageUpload), new WebHttpBinding(), "").Behaviors.Add(new WebHttpBehavior());
            //host.Open();
            //Console.WriteLine("Host opened");
            //Console.ReadKey(true);
        }
    }
}
