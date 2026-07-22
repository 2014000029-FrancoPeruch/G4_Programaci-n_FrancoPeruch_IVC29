internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Grados °C: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("a. Fahrenheit: "+(c * 9 / 5) + 32+" °F");
        Console.WriteLine("b. Celsius: "+c+" °C");
        Console.WriteLine("c. Kelvin: "+c + 273.15+" K");
    }
}