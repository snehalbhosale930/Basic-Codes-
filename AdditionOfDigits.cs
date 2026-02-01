using System;
using System.ComponentModel.Design;

namespace BasicCodes
{
    internal class AdditionOfDigits
    {
        public static void AdditionOfDigit()
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            num = Math.Abs(num);

           while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine("sum of digits:" + sum);
            return;
        }
    }
}
