using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace DuplexWCFHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Sample3WcfService.Service1));
            host.Open();
            Console.WriteLine("Service Started");

            Console.ReadKey();  
        }
    }
}
