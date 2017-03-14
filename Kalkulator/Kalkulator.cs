using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    public class Kalkulator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public Double DivideNumbers(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b; 
        }
    }
}
