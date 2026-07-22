internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        string[] opciones = { "", "Piedra", "Papel", "Tijeras" };
        string resp;

        do
        {
            Console.WriteLine("\n1. Piedra | 2. Papel | 3. Tijeras");
            Console.Write("Elija su opción (1-3): ");
            int user = int.Parse(Console.ReadLine());
            int pc = rnd.Next(1, 4);

            Console.WriteLine($"Tú: "+opciones[user]+" vs PC: "+opciones[pc]);

            if (user == pc) Console.WriteLine("¡Empate!");
            else if ((user == 1 && pc == 3) || (user == 2 && pc == 1) || (user == 3 && pc == 2)) Console.WriteLine("¡Ganaste!");
            else Console.WriteLine("Gana la PC.");

            Console.Write("¿Jugar de nuevo? (s/n): ");
            resp = Console.ReadLine().ToLower();
        } while (resp == "s");
    }
}