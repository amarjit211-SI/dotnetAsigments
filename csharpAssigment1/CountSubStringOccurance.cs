using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpAssigment1
{
    internal class CountSubStringOccurance
    {
        static void Main2(string[] args)
        {
            Console.Write("Enter a text: ");
            string line = Console.ReadLine();

            Console.Write("Enter the character to be count: ");
            char targetCharacter = Console.ReadKey().KeyChar;
            Console.WriteLine(); 

            int count = CountOccurrences(line, targetCharacter);

            Console.WriteLine($"The character '{targetCharacter}' appears {count} times in the text.");
        }

        static int CountOccurrences(string text, char target)
        {
            int count = 0;
            foreach (char character in text)
            {
                if (character == target)
                {
                    count++;
                }
            }
            return count;
        }
        
    }
}
