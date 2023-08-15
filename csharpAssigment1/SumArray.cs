using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssigment
{
    internal class SumArray
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Enter the Length of the Array");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("Enter the Number");
            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            int sumArray = 0;

            for (int i = 0; i < num; i++)
            {
                sumArray += arr[i];

            }
            Console.WriteLine("Sum of the array: " + sumArray);

        }
    }
}