using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    {
    public class Calculator
        static void Main(string[] args)
        {
        }
        public int Add(int a, int b)
        {
            try
            {
                checked
                {
                    return a + b;
                }

            }
            catch (OverflowException)
            {
                throw new OverflowException("Overflow on Add");
            }
        }

        public int Substract(int a,int b)
        {
            try
            {
                checked
                {
                    return a - b;
                }

            }
            catch (OverflowException)
            {
                throw new OverflowException("Overflow on Substract");
            }
        }

        public int Multiply(int a, int b)
        {
            try
            {
                checked
                {
                    return a * b;
                }

            }
            catch (OverflowException)
            {
                throw new OverflowException("Overflow on Multiply");
            }
        }

        public double Divide(int a, int b)
        {

            if (b == 0)
            {
                throw new DivideByZeroException("Dividing by zero");
            }
            try
            {
                checked
                {
                    double c = (double)a / b;
                    return c;
                }

            }
            catch (OverflowException)
            {
                throw new OverflowException("Overflow on Divide");
            }

        }
    }
}
