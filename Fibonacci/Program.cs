using System;

namespace Fibonacci
{
    delegate int MyDelegate(int n);
    class Program
    {
        // через рекурсию
        public static int GetFibonacci(int n)
        {
            int m = Math.Abs(n);

            if (m == 0)
            {
                return 0;
            }

            if (m == 1)
            {
                if (n < 0)
                    return -1;
                else
                    return 1;
            }

            if (n > 1)
                return GetFibonacci(m - 1) + GetFibonacci(m - 2);
            else
                return -(GetFibonacci(m - 1) + GetFibonacci(m - 2));


        }

        // через цикл
        public static int GetFibonacciCircle(int n)
        {
            int m = Math.Abs(n);

            if (m == 0)
            {
                return 0;
            }

            if (m == 1)
            {
                if (n < 0)
                    return -1;
                else
                    return 1;
            }
            int result = 1;
            int f1 = 1;
            int f2 = 1;

            for (int i = 2; i < m; i++)
            {
                result = f1 + f2;
                f1 = f2;
                f2 = result;
            }

            if (n > 0)
                return result;
            else
                return -result;

        }



        static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                N = 5,
                Expected = 5, 
                ExpectedException = null

            };

            var testCase2 = new TestCase()
            {
                N = -12,
                Expected = -144,
                ExpectedException = null
            };

            var testCase3 = new TestCase()
            {
                N = 21,
                Expected = 10946,
                ExpectedException = null
            };

            Control.TestFibonacci(GetFibonacci, testCase1);
            Control.TestFibonacci(GetFibonacci, testCase2);
            Control.TestFibonacci(GetFibonacci, testCase3);
            Control.TestFibonacci(GetFibonacciCircle, testCase1);
            Control.TestFibonacci(GetFibonacciCircle, testCase2);
            Control.TestFibonacci(GetFibonacciCircle, testCase3);
        }
    }
}
