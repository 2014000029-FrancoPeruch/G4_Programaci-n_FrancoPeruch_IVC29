internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Peso (kg): "); 
        double peso = double.Parse(Console.ReadLine());
        Console.Write("Altura (m): ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);
        Console.WriteLine("Su IMC es: "+imc);
    }
}