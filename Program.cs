


namespace BasicCodes
{
    public class Program
    {
        static void Main(string[] args)
        {
           //PatternPrinting.NumberIncreasePyramid();
           //PatternPrinting.LeftHalfPyramid();
           //PatternPrinting.HolloTriangePyramid();
           //PatternPrinting.HolloAngle();
           //PatternPrinting.RightHalfPyramid();
           //PatternPrinting.RevrighthalfPyramid();
           //PatternPrinting.SquareFillpattern();
           //PatternPrinting.RevNoTriangle();
           //PatternPrinting.RhombusPattern();
            PatternPrinting.revHalfPyramid();
            
            

            //Fizz/buzz();
            // FindMaxIn3Numbers();
            //GuessthecorrectNumber();
            //TraverseArray();
            //SquareOfAllNumbers();
            //ReverseArray();
            //TraverseStringAsChar();
            //ReverseNumber.ReverseTheNumber();
            //MaxNumberInArray.MaxNumInArray();
            //AddSubMulDiv.cal();
            //Print10Numbers.Numbers();
            //SquareOfNumbers.SquareOfNumber();
            //EvenNumbers.EvenNumber();
            //CountDigits.CountDigit();
            //AdditionOfDigits.AdditionOfDigit();
            //MulOf2Int.MultiOf2Int();
            //Dividewithoutsign();
        }
        private static void FizzBuzz()
        {
            int i;
            for (i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        private static void FindMaxIn3Numbers()
        {
            Console.WriteLine("Enter Number 1");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 3");
            int c = Convert.ToInt32(Console.ReadLine());

            int Max = a;
            if (Max < b)
            {
                Max = b;
            }
            if (Max < c)
            {
                Max = c;
            }
            Console.WriteLine("Max value is" + Max);
        }
        public static void GuessthecorrectNumber()
        {
            Random rnd = new Random();
            int on = rnd.Next(1, 101);

            int un = 0;
            while (true)
            {
                Console.WriteLine("Enter guess:");
                un = Convert.ToInt32(Console.ReadLine());
                if (un == on)
                {
                    Console.WriteLine("You guess Correct");
                    break;
                }
                else if (un > on)
                {
                    Console.WriteLine("guess is Too High");
                }
                else if (un < on)
                {
                    Console.WriteLine("guess is Too Low");
                }
            }
        }
        private static void TraverseArray()
        {
            int[] a = new int[1];
            for (int i = 0; i < a.Length; i++)
            {
                //type[] name of array = new type [size];
                Console.WriteLine("Enter Number" + (i + 1));
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You have entered below number...");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

        }
        public static void SquareOfAllNumbers()
        {
            int[] a = new int[5];
            for (int i = 0; i < a.Length; i++)
            {
                //type[] name of array = new type [size];
                Console.WriteLine("Enter Number" + (i + 1));
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You have Square Of numbers");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] * a[i]);
            }

        }
        public static void ReverseArray()
        {
            //type[] name of array = new type [size];
            int[] a = new int[5];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Number" + (i + 1));
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int temp = 0;
            int j = a.Length - 1;
            for (int i = 0; i < j; i++, j--)
            {
                temp = a[i];
                a[i] = a[j]; 
                a[j] = temp;
            }
            Console.WriteLine("Reverse Of Array...");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
            }
        }
        public static void TraverseStringAsChar()
        {
            string a = Console.ReadLine();
            string b = " ";

            for (int j = a.Length - 1; j >= 0; j--)
            {
                b = b + a[j];
            }
            if (a == b)
            {
                Console.WriteLine("Given String Is Palindrome");
            }
            else
            {
                Console.WriteLine("Given String Is Not Palindrome");
            }
        }
        public static void Dividewithoutsign()
        {
          int a = 10;
          int b = 5;
          int result = 0;
          for (int i = 1; i <= a; i--)
          {
           result = result - b;
           }
           Console.WriteLine(result);
         }
    }
}







