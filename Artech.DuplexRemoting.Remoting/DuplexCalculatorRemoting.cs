using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artech.DuplexRemoting.Contract;

namespace Artech.DuplexRemoting.Remoting
{
    public class DuplexCalculatorRemoting : MarshalByRefObject, IDuplexCalculator
    {
        public void Add(double x, double y, ICalculatorCallback callback)
       {
           Console.WriteLine("Invoke the method Add({0},{1}).", x, y);
           double result = x + y;
           callback.ShowResult(x, y, result);
       }
    }
}
