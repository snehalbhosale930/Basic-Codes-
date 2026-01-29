using System;

namespace BasicCodes
{
    internal class ReverseNumber
    {
        public static void ReverseTheNumber()
        {
            int Num, temp, rev = 0;
            Console.WriteLine("Enter The Number");
            Num = Convert.ToInt32(Console.ReadLine());
            temp = Num;
            while (temp > 0)
            {
                int digit = Num % 10;
                rev = rev * 10 + digit;
                Num = Num / 10;
            }
            Console.WriteLine("Reverse Number:" + rev);
            if (temp == rev)
                Console.WriteLine("The Number Is Palindrome");
            else
                Console.WriteLine("The Number Is Not Palindrome");
        }
    }
}
