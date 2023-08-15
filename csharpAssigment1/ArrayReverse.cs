using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpAssigment1
{
    internal class ArrayReverse

    {
        static void Main4()

    
    {
        Console.Write("Enter the number of values: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] values = new int[n];

        Console.WriteLine("Enter the values:");

        for (int i = 0; i<n; i++)
        {
            Console.Write($"Value {i + 1}: ");
            values[i] = Convert.ToInt32(Console.ReadLine());
            }

    Console.WriteLine("\nValues in Reverse Order:");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(values[i] + " ");
        }
    }
}
    }

