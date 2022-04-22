using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsScratchpad
{
    public class Calculator
    {
        public bool IsCalculating { get; private set; }

        public int Calculate(string oper, int a, int b)
        {
            IsCalculating = true;

            int result;
            try
            {


                switch (oper)
                {
                    case "+":
                        result = Add(a, b);
                        break;
                    case "-":
                        result = Subtract(a, b);
                        break;
                    case "*":
                        result = Multiply(a, b);
                        break;
                    case "/":
                        result = Divide(a, b);
                        break;
                    default:
                        throw new ArgumentException($"'{oper}' is not a valid operator");
                }
            }
            finally
            {
                IsCalculating = false;
            }

            return result;
        }

        private int Add(int a, int b)
        {
            return a + b;
        }

        private int Subtract(int a, int b)
        {
            return a - b;
        }

        private int Multiply(int a, int b)
        {
            return a * b;
        }

        private int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
