using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artech.DuplexRemoting.Contract;

namespace Artech.DuplexRemoting.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Runtime.Remoting.RemotingConfiguration.Configure("Artech.DuplexRemoting.Client.exe.config", false);

            InvocateDuplexCalculator("http://localhost:8080/Calculator/DuplexCalculator.soap");
        }

        static void InvocateDuplexCalculator(string remoteAddress)
        {
            IDuplexCalculator proxy = (IDuplexCalculator)Activator.GetObject(typeof(IDuplexCalculator), remoteAddress);
            proxy.Add(1, 2, new CalculatorCallbackHandler());
            Console.Read();
        }
    }
}
