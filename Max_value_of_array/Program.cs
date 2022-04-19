using System;

namespace Bigest_Array_s_index
{
    class Program
    {
        static void Main(string[] args)
        {
            int C = 0;
            int maxValue = 0;
            int[] arr = { 999, 8, 49, 17, 5 ,102,33,895,3};

            for (int i = arr.Length - 1; i > -1; i--)
            {
                C = arr[i];

                if (C > maxValue)
                {
                    maxValue = C;
                }
                
            }
            Console.WriteLine(maxValue);
        }
    }
}
