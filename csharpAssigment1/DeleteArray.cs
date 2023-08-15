using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssigment1
{
    internal class DeleteArray
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter the Length of the Array:");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];

            Console.WriteLine("Enter the Numbers in the Array:");
            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the Position (0 to " + (num - 1) + ") of the Element to Delete:");
            int positionToDelete = Convert.ToInt32(Console.ReadLine());

            if (positionToDelete >= 0 && positionToDelete < num)
            {

                int[] newArr = new int[num - 1];
                int index = 0;


                for (int i = 0; i < num; i++)
                {
                    if (i != positionToDelete)
                    {
                        newArr[index] = arr[i];
                        index++;
                    }
                }

                Console.WriteLine("Original Array:");
                DisplayArray(arr);

                Console.WriteLine("Array after deleting element at position " + positionToDelete + ":");
                DisplayArray(newArr);
            }
            else
            {
                Console.WriteLine("Invalid position. Please enter a position within the range 0 to " + (num - 1) + ".");
            }
        }


        static void DisplayArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }
}