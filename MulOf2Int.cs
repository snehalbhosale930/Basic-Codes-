using System;

namespace BasicCodes
{
    internal class MulOf2Int
    {
        public static void MultiOf2Int()
        {
            Console.WriteLine("Enter Number 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < num2; i++)
            {
                result += num1;
            }
            Console.WriteLine("Product:" + result);
        }
    }
}
