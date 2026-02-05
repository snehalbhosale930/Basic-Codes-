namespace BasicCodes
{
    internal class PatternPrinting
    {
        public static void print1to5Trangle()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public static void print1to5Stars()
        {
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int k = rows - i; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void HolloPyramid()
        {
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int k = rows - i; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    if (i > 2 && i < rows)
                    {
                        if (j == 1 || j == i)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                    else
                    {
                        Console.Write("* ");
                    }

                }
                Console.WriteLine();
            }
        }
        public static void HolloAngle()
        {
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int k = rows - i; k > 0; k--)
                {
                    Console.Write(" ");
                }
                 
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (i > 1 && i < rows)
                        {
                            if (j == 1 || i == rows)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write("  ");
                            }
                        }
                        else
                        {

                            Console.Write("* ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
