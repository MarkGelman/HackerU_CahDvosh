using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Helper_Static_Class
{
    static class MathHelper
    {
        public static double Pow(double baseValue, int power)
        {
            double numInPower = 1;
            for (int i = 0; i < Math.Abs(power); i++)
                numInPower *= baseValue;
            if (power < 0)
                return 1 / numInPower;
            return numInPower;
        }

        public static double Abs(double number)
        {
            if (number < 0)
                return number * -1;
            return number;
        }

        public static double Max(params double[] numbers)
        {
            double max = numbers[0];
            foreach (double number in numbers)
                if(max < number )
                    max = number;
            return max;

        }

        public static double Min(params double[] numbers)
        {
            double min = numbers[0];
            foreach (double number in numbers)
                if (Max(min, number) == min)
                    min = number;
            return min;

        }

        public static int Factorial(int number)
        {
            if (number == 0)
                return 1;
            return number * Factorial(number - 1);
        }

        public static double Sum(params double[] numbers)
        {
            double sum = 0;
            foreach (double number in numbers)
                
                    sum += number;
            return sum;
        }

        public static double Avarage(params double[] numbers)
        {
            return Sum(numbers)/ numbers.Length;
        }

        public static string IsPrime(int number)
        {
            int limit = (int)number / 2 + 1;
            for (int i = 2; i < limit; i++)
                if (number % i == 0)
                    return "not prime";
            return "is prime";
        }

        public static int Fibonacchi (int num)
        {
            if (num <= 2)
                return num;
            return Fibonacchi(num - 1) + Fibonacchi(num - 2);
        }

        public static double[] Reverse(double[] numbers)
        {
            double[] reverse = new double[numbers.Length];
            int i_reverse = 0;
            for(int i=numbers.Length - 1; i >= 0; i--)
            {
                reverse[i_reverse] = numbers[i];
                i_reverse++;
            }
            return reverse;
        }
    }
}
