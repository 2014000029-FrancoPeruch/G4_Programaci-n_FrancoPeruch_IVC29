internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Precio: "); 
        int precio = int.Parse(Console.ReadLine());
        Console.Write("Pago: "); 
        int pago = int.Parse(Console.ReadLine());

        int cambio = pago - precio;
        Console.WriteLine("Cambio Total: Q"+cambio);

        int b200 = cambio / 200; cambio %= 200;
        int b100 = cambio / 100; cambio %= 100;
        int b50 = cambio / 50; cambio %= 50;
        int b20 = cambio / 20; cambio %= 20;

        Console.WriteLine("Billetes = Q200: "+b200+", Q100: "+b100+", Q50: "+b50+", Q20: "+b20);
        Console.WriteLine("Monedas = Q"+cambio);
    }
}