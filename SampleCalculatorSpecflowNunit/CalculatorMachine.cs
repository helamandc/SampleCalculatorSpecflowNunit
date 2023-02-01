using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCalculatorSpecflowNunit
{
    public class CalculatorMachine
    {
        public int res { get; set; }
        public int a;
        public int b;
        public int Calculate(string sign)
        {
            int result;
            switch (sign)
            {
                case "+":
                    result = a + b;
                    res = result;
                    break;
                case "*":
                    result = a * b;
                    res = result;
                    break;
            }
            return res;
        }
    }
}
