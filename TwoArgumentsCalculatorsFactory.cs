using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulator
{
    public static class TwoArgumentsCalculatorsFactory
    {
        public static ITwoArgumentsOperation CreateCalculator (string calculatorName)
        {
            switch (calculatorName)
            {
                case "Sum":
                    return new Addition();

                    break;

                case "Min":
                    return new Subtraction();
                    break;

                case "Mul":
                    return new Multiply();
                    break;

                case "Div":
                    return new Division();
                    break;

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
