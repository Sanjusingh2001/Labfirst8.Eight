//Develop a C# program that searches for a specific value in an integer array using loops and sorting techniques.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labfirst8.Eight
{
    class Eight
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter 5 Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }
            Console.WriteLine("Array is:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

            }
            Console.WriteLine();
            Console.WriteLine("Second Minimum is: " + arr[1]);
            Console.ReadLine();

        }
    }
}
