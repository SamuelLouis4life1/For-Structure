using System;
using System.Globalization;

/// <summary>
/// a program to read a temperature in celcius and show the equivalent in fahrenheit. 
/// Then ask if the user wants to repeat (Y / N). if the user types "S", repeat the program.
/// </summary>

namespace FahrenheitTemperature
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celcius, Fahrenheit;
            char repeat;

            do
            {
                Console.WriteLine("Enter the temperature in Celcius: ");
                Celcius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Fahrenheit = 9.0 * Celcius / 5.0 + 32.0;
                Console.WriteLine("Equivalent in Fahrenheit : " + Fahrenheit.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Do you want to repeat (Y/N) ");
                repeat = char.Parse(Console.ReadLine());
            } while (repeat == 'y');
            Console.ReadLine();
        }
    }
}
