internal class Program
{
    private static void Main(string[] args)
    {
        string resp;
        do
        {
            Console.Write("\nMonto local: ");
            double m = double.Parse(Console.ReadLine());

            Console.WriteLine("USD: "+m * 0.13+" | EUR: "+m * 0.12+" | MXN: "+m * 2.25+" | GBP: "+m * 0.10+" | CAD: "+m * 0.18);
            Console.Write("¿Desea repetir? (s/n): ");
            resp = Console.ReadLine().ToLower();
        } while (resp == "s");
    }
}