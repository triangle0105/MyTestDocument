using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artech.DuplexRemoting.Contract;

namespace Artech.DuplexRemoting.Client
{
    class CalculatorCallbackHandler : MarshalByRefObject, ICalculatorCallback
    {
        public void ShowResult(double x, double y, double result)
        {
            Console.WriteLine("x + y = {2} where x = {0} and y = {1}", x, y, result);
        }
    }
}
