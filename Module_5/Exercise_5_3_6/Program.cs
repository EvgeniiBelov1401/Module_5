﻿namespace Exercise_5_3_6
{
    internal class Program
    {
        static void BigDataOperation(in int[] arr)
        {
            arr[0] = 4;
        }
        static void Main(string[] args)
        {
            var arr = new[] { 1, 2, 3 };
            Console.WriteLine(arr[0]);

            BigDataOperation(arr);
            Console.WriteLine(arr[0]);

            Console.ReadKey();
        }
    }
}
