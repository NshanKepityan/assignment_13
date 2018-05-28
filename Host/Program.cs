using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using Library;
namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8880/Library");
            using (ServiceHost host = new ServiceHost(typeof(Library.Library), baseAddress))
            {
                try
                {
                    host.AddServiceEndpoint(typeof(ILibrary), new BasicHttpBinding(), baseAddress);

                    ServiceMetadataBehavior serviceBehavior = new ServiceMetadataBehavior();
                    serviceBehavior.HttpGetEnabled = true;
                    host.Description.Behaviors.Add(serviceBehavior);
                    host.Open();

                    Console.WriteLine("The service is ready at {0}", baseAddress);
                    Console.WriteLine("Press any key to stop the service.");
                    Console.ReadKey();

                    host.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something gone wrong with service");
                    throw ex;
                }
            }
        }
    }
}
