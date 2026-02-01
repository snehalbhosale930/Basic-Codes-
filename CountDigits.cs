using System;

namespace BasicCodes
{
    internal class CountDigits
    {
        public static void CountDigit()
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (num != 0)
            {
                num /= 10;
                count++;
            }
            Console.WriteLine("Number of Digits: " + count);
        }
    }
}
