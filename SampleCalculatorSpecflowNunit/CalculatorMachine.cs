using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCalculatorSpecflowNunit
{
    public class CalculatorMachine
    {
        public int a;
        public int b;
        public int CalculateSum()
        {
            int sum;
            sum = a * b;
            return sum; 
        }
    }
}
