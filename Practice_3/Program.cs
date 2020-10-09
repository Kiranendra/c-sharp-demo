using System;

namespace Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // by default the array is filled with 0's.
            // the indexing starts from '0'.
            int[] a = new int[5];
            // Console.WriteLine(a[0]);

            // Another way of declaring an array
            int[] b = { 1, 2, 3, 4, 5 };
            // Console.WriteLine(b[2]);

            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}