internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine();

        char[] caracteres = new char[frase.Length];

        for (int i = 0; i < frase.Length; i++)
        {
            caracteres[i] = frase[i];
        }

        string fraseInvertida = "";

        for (int i = caracteres.Length - 1; i >= 0; i--)
        {
            fraseInvertida = fraseInvertida + caracteres[i];
        }

        Console.WriteLine("La frase invertida es: " + fraseInvertida);
    }
}