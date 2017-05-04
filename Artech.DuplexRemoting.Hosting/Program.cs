using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artech.DuplexRemoting.Hosting
{
    class Program
    {
        private static void Main(string[] args)
        {
            System.Runtime.Remoting.RemotingConfiguration.Configure("Artech.DuplexRemoting.Hosting.exe.config", false);
            Console.WriteLine("Calculator service has begun to listen ");
            Console.Read();
        }
    }
}
