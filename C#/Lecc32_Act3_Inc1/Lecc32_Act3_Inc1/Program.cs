internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Lado 1: "); 
        double l1 = double.Parse(Console.ReadLine());
        Console.Write("Lado 2: "); 
        double l2 = double.Parse(Console.ReadLine());
        Console.Write("Lado 3: "); 
        double l3 = double.Parse(Console.ReadLine());

        if (l1 == l2 && l2 == l3) 
            Console.WriteLine("Triángulo Equilátero");
        else if (l1 == l2 || l1 == l3 || l2 == l3) 
            Console.WriteLine("Triángulo Isósceles");
        else 
            Console.WriteLine("Triángulo Escaleno");
    }
}