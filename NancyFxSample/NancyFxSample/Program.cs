using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy.Hosting.Self;

namespace NancyFxSample
{
    public class SampleModule : Nancy.NancyModule
    {
        public SampleModule()
        {
            Get["/"] = _ => "Hello World!";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var hostConfiguration = new HostConfiguration
            {
                UrlReservations = new UrlReservations() { CreateAutomatically = true }
            };
            using (var nancyHost = new NancyHost(hostConfiguration, new Uri("http://localhost:8888/nancy/"), new Uri("http://127.0.0.1:8898/nancy/"), new Uri("http://localhost:8889/nancytoo/")))
            {
                nancyHost.Start();

                Console.WriteLine("Nancy now listening - navigating to http://localhost:8888/nancy/. Press enter to stop");
                Console.ReadKey();
            }

            Console.WriteLine("Stopped. Good bye!");
        }
    }
}
