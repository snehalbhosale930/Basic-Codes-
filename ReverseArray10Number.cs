namespace BasicCodes
{
    internal class ReverseArray10Number
    {
        public static void ReverseA10Number()
        {
            //type[] name of array = new type [size];
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Number 10 Number:" + (i + 1));
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
    }
}
