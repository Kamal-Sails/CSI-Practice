using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_DesignPattren.Calculation_Strategies
{
    class CalculationOfValues
    {
        private ICalculation calculation;

        public CalculationOfValues(ICalculation strategy)
        {
            calculation = strategy;
        }

        public int Calculate(int Value1, int Value2)
        {
            return calculation.Calculate(Value1, Value2);
        }
    }
}
