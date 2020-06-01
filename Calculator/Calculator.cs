using System;

namespace Services
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
            throw new NotImplementedException("Please create a test case first.");
        }

        public int Subtract(int a, int b)
        {
            return a - b;
            throw new NotImplementedException("Please create a test case first.");
        }

        public int Divide(int a, int b)
        {
            return a / b;
            throw new NotImplementedException("Please create a test case first.");
        }

        public int Multiply(int a, int b)
        {
            return a * b;
            throw new NotImplementedException("Please create a test case first.");
        }

        public int Mod(int a, int b)
        {
            return a % b;
            throw new NotImplementedException("Please create a test case first.");
        }

        public double DecimalDivide(double a, double b)
        {
            return a / b;
            throw new NotImplementedException("Please create a test case first.");
        }

        public int Average(int a, int b)
        {
            return Divide(Add(a, b), 2);
            throw new NotImplementedException("This function has not been implemented.");
        }

        public double DecimalAverage(double a, double b)
        {
            return DecimalDivide((a + b),  2);
            throw new NotImplementedException("This function has not been implemented.");
        }

        public double DecimalPower(double b, double exp)
        {
            return Math.Pow(b, exp);
            throw new NotImplementedException("This function has not been implemented.");
        }

        public int Power(int b, int exp)
        {
            if(exp == 0)
            {
                return 1;
            }

            if(exp == 1)
            {
                return b;
            }

            else
            {
                return b * Power(b, exp - 1);
            }

            throw new NotImplementedException("This function has not been implemented.");
        }

    }
}