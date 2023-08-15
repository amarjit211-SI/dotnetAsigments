using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssigment1
{
    internal class CopyArrayElement
    {
        static void Main3(string[] args)
        {
            Console.Write("Enter the number of elements in the array: ");
            int length = int.Parse(Console.ReadLine());

            int[] sourceArray = new int[length];
            int[] destinationArray = new int[length];

            Console.WriteLine("Enter the elements of the source array:");

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                sourceArray[i] = int.Parse(Console.ReadLine());
            }

            // Copy elements from sourceArray to destinationArray
            for (int i = 0; i < sourceArray.Length; i++)
            {
                destinationArray[i] = sourceArray[i];
            }

            Console.WriteLine("\nSource Array:");
            PrintArray(sourceArray);

            Console.WriteLine("\nDestination Array (Copied):");
            PrintArray(destinationArray);
        }

        static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}