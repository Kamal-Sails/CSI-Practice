using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_DesignPattren.Calculation_Strategies
{
    public interface ICalculation
    {
        int Calculate(int Value1 ,int Value2);
    }
    public class StrategyForCalculation
    {
        public static ICalculation CalculationUsingStrategy(Calculationstrategy calculationstrategy)
        {
            switch(calculationstrategy)
            {
                case Calculationstrategy.additionstategy:
                    return new Addition();
                case Calculationstrategy.substractionstaregy:
                    return new Substraction();
                case Calculationstrategy.multiplicationstrategy:
                    return new Multiplication();
                default:
                    throw new Exception();
            }
        }
    }
    public enum Calculationstrategy
    {
        additionstategy,
        substractionstaregy,
        multiplicationstrategy
    }
}
