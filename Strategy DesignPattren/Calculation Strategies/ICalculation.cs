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
        public static ICalculation CalculationUsingStrategy(CalculationStrategy calculationStrategy)
        {
            switch(calculationStrategy)
            {
                case CalculationStrategy.AdditionStategy:
                    return new Addition();
                case CalculationStrategy.SubstractionStaregy:
                    return new Substraction();
                case CalculationStrategy.MultiplicationStrategy:
                    return new Multiplication();
                default:
                    throw new Exception();
            }
        }
    }
    public enum CalculationStrategy
    {
        AdditionStategy,
        SubstractionStaregy,
        MultiplicationStrategy
    }
}
