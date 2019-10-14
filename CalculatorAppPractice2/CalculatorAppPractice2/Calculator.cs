using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppPractice2
{
    class Calculator
    {
        public double firstNumber;
        public double secondNumber;
        public double result;

        public double Add()
        {
            result = firstNumber + secondNumber;
            return result;
        }
        public double Subtract()
        {
            result = firstNumber - secondNumber;
            return result;
        }
        public double Multiply()
        {
            result = firstNumber * secondNumber;
            return result;
        }
        public double Divide()
        {
            result = firstNumber / secondNumber;
            return result;
        }
    }
}
