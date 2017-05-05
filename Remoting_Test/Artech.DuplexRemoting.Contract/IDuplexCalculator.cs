using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artech.DuplexRemoting.Contract
{
    public interface IDuplexCalculator
    {
        void Add(double x, double y, ICalculatorCallback callback);
    }
}
