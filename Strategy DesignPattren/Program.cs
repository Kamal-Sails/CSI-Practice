using Strategy_DesignPattren.Calculation_Strategies;
using System;

namespace Strategy_DesignPattren
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculationOfValues substract = new CalculationOfValues(new Substraction());
            Console.WriteLine("Substraction: " + substract.Calculate(15, 1));

            CalculationOfValues add = new CalculationOfValues(new Addition());
            Console.WriteLine("Addition: " + add.Calculate(15, 1));

            CalculationOfValues multiply = new CalculationOfValues(new Multiplication());
            Console.WriteLine("Multiplication: " + multiply.Calculate(6, 2));
        }
    }
}
