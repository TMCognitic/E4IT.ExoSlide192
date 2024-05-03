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


            EQ2D first = new EQ2D() { A = 0, B = 2, C = 10 };
            bool firstResult = first.Resoudre(out double? firstX1, out double? firstX2);
            PrintResult(firstResult, firstX1, firstX2);

            EQ2D second = new EQ2D() { A = 1, B = 1, C = -2 };
            bool secondResult = second.Resoudre(out double? secondX1, out double? secondX2);
            PrintResult(secondResult, secondX1, secondX2);

            EQ2D third = new EQ2D() { A = 1, B = 1, C = 1 };
            bool thirdResult = third.Resoudre(out double? thirdX1, out double? thirdX2);
            PrintResult(thirdResult, thirdX1, thirdX2);

            EQ2D fourth = new EQ2D() { A = 4, B = 4, C = 1 };
            bool fourthResult = fourth.Resoudre(out double? fourthX1, out double? fourthX2);
            PrintResult(fourthResult, fourthX1, fourthX2);
        }

        private static void PrintResult(bool firstResult, double? x1, double? x2)
        {
            Console.WriteLine(!firstResult ? "Pas de résultat" : $"x1 : {x1} - x2 : {x2}");
        }
    }

}
