using System;

namespace BasicCodes
{
    internal class EvenNumbers
    {
        public static void EvenNumber()
        {
            for (int i = 1; i <= 10; i++) 
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
