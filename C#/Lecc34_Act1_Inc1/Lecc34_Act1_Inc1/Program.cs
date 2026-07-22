internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("1. Decimal a Binario\n2. Binario a Decimal\nOpción: ");
        int opc = int.Parse(Console.ReadLine());

        if (opc == 1)
        {
            Console.Write("Decimal: ");
            int dec = int.Parse(Console.ReadLine());
            Console.WriteLine("Binario: "+Convert.ToString(dec, 2));
        }
        else
        {
            Console.Write("Binario: ");
            string bin = Console.ReadLine();
            Console.WriteLine("Decimal: "+Convert.ToInt32(bin, 2));
        }
    }
}