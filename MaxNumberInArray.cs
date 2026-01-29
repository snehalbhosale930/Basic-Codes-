using System;

namespace BasicCodes
{
    internal class MaxNumberInArray
    {
        public static void MaxNumInArray()
        {
            Console.WriteLine("Enter The Size:");
            int Length = Convert.ToInt32 (Console.ReadLine());

            int[] array = new int[Length];
            for (int i = 0; i < Length; i++) 
            {
                Console.WriteLine("Enter the element:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = array[0];
            for(int i = 1; i < Length; i++) 
            {
                if(max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Greater Number is:" + max);
        }
    }
}
