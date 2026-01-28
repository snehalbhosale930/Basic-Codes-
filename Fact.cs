

namespace BasicCodes
{
    internal class Fact
    { 
        public static void Num(int a)
        {
            int count = 1;
            if (a>0)
            {
                while (a>0)
                {
                    count = count * a;
                    a = a - 1;
                }
            }
            else
            {
                Console.WriteLine("Factorial of " + a + "is :" + count);
            }
            Console.WriteLine("Factorial of " + a + "is :" + count);
        }
    }
}
