namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(54);
            Console.WriteLine($"54 farenheit is {celsius} degrees fahrenheit");
            var fahrenheit = TempConverter.CelsiusToFahrenheit(celsius);
            Console.WriteLine($"It is {fahrenheit} converted back to fahrenheit");

        }
    }
}
