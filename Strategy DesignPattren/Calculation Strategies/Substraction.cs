using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_DesignPattren.Calculation_Strategies
{
    class Substraction : ICalculation
    {
        public int Calculate(int Value1, int Value2)
        {
            return Value1 - Value2;
        }
    }
}
