using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssigment1
{
    internal class ControlStructureTemperature
    {
        static void Main()
        {
            const int SENTINEL = -1;
            const int MIN_TEMPERATURE = 20;
            const int MAX_TEMPERATURE = 130;

            int count = 0;
            int totalTemperature = 0;

            Console.WriteLine("Enter the daily high temperatures 20 to 130 Fahrenheit or enter -1 to end input:");

            while (true)
            {
                Console.Write("Enter temperature: ");
                int temperature;

                if (int.TryParse(Console.ReadLine(), out temperature))
                {
                    if (temperature == SENTINEL)
                        break;

                    if (temperature >= MIN_TEMPERATURE && temperature <= MAX_TEMPERATURE)
                    {
                        totalTemperature += temperature;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid temperature. Valid temperatures range from 20 to 130 Fahrenheit.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Invalid input. Please enter a valid integer temperature or -1 to end input.");
                }
            }

            if (count > 0)
            {
                double averageTemperature = (double)totalTemperature / count;
                Console.WriteLine($"Number of temperatures entered: {count}");
                Console.WriteLine($"Average temperature: {averageTemperature:F2} Fahrenheit");
            }
            else
            {
                Console.WriteLine("No valid temperatures entered.");
            }
        }
    }
}