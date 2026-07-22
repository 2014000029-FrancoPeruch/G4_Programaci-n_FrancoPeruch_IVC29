internal class Program
{
    private static void Main(string[] args)
    {
        string[] nombres = new string[10];
        string[] telefonos = new string[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Nombre [{i}]: "); nombres[i] = Console.ReadLine();
            Console.Write($"Teléfono [{i}]: "); telefonos[i] = Console.ReadLine();
        }

        Console.WriteLine("Ingrese posición a consultar (0-9): ");
        int pos = int.Parse(Console.ReadLine());

        if (pos >= 0 && pos < 10) 
            Console.WriteLine(pos+" Nombre: "+nombres[pos]+", Tel: "+telefonos[pos]);
        else 
            Console.WriteLine("Posición fuera de rango.");
    }
}