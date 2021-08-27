using System;

namespace Alg1
{
    public enum Output
    {
        Простое,
        Не_простое
    }

    class Program
    {
      
       
        static bool Trivial(int n)

        {
            int d = 0;
            int i = 2;

            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                    i++;
                }
                else
                    i++;

            }


            return d == 0;
        }

        public static Output Itog(int n)
        {
            Output r;
            bool a = Trivial(n);

            if (a)
                r = Output.Простое;
            else
                r = Output.Не_простое;

            return r;
        }

        static void TestTrivial(TestCase testCase)
        {
            try
            {
                var actual = Itog(testCase.N);
                if (actual == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("ÏNVALID TEST");
                }
            }
            catch(Exception)
            {
                if(testCase.ExpectedException != null)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("ÏNVALID TEST");
                }
            }


        }
        static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                N = 7,
                Expected = Output.Простое,
                ExpectedException = null

            };

            var testCase2 = new TestCase()
            {
                N = 70,
                Expected = Output.Не_простое,
                ExpectedException = null
            };

            TestTrivial(testCase1);
            TestTrivial(testCase2);

        }
    }
}
