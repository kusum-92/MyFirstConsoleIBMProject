using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIBMProject
{
    internal class Calculator
    {
        public Calculator() { }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }
        public int Division(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            else
            {

                return x / y;
            }
        }

    }
}
