using System.Text;

namespace ExoSlide192
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celsius celsius = new Celsius() { Temperature = 30 };
            Fahrenheit fahrenheit = celsius.ToFahrenheit();
            celsius = fahrenheit.ToCelsius();

            Celsius mySecondCelsiusVariable = new Celsius() { Temperature = 10 };

            Console.WriteLine($"{celsius.Temperature} °C <=> {fahrenheit.Temperature} °F");

            Console.WriteLine(celsius.Temperature);
            Console.WriteLine(mySecondCelsiusVariable.Temperature);




        }
    }

}
