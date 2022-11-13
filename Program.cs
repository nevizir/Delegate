using System;
using System.Security.Cryptography;

namespace Delegate
{
    internal class Program
    {

        static void Initialize(int[] array, Func<int, int> init)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = init(i);
            }
        }

        static void ShowArray<T>(T[] array, string title)
        {
            Console.Write($"{title}: ");
            foreach (var item in array) Console.Write(item + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] numbers = new int [10];
            Initialize(numbers, (i) => (int)Math.Pow(2, i));
            ShowArray(numbers, "2 in degree");

            Initialize(numbers, (i) => i * 3);
            ShowArray(numbers, "+3"); 

            Initialize(numbers, (i) => new Random().Next(100));
            ShowArray(numbers, "random");


        }
    }
}
