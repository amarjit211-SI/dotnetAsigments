using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssigment1
{
    internal class SubString
    {
        static void Main8()
        {
            Console.Write("Enter the main string: ");
            string mainString = Console.ReadLine();

            Console.Write("Enter the substring to search: ");
            string substring = Console.ReadLine();

            int position = SearchSubstring(mainString, substring);

            if (position != -1)
            {
                Console.WriteLine($"Substring found at position: {position}");
            }
            else
            {
                Console.WriteLine("Substring not found in the main string.");
            }
        }

        static int SearchSubstring(string mainString, string substring)
        {
            int index = mainString.IndexOf(substring);
            return index;
        }
    }
}