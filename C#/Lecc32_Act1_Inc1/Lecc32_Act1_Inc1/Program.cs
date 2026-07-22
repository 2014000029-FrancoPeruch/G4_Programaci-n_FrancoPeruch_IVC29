internal class Program
{
    private static void Main(string[] args)
    {
        double metros;
        string opcion;

        Console.Write("Ingrese cantidad en metros: ");
        metros = double.Parse(Console.ReadLine());

        Console.WriteLine("a. Milímetros\nb. Centímetros\nc. Decímetros\nd. Hectómetros\ne. Kilómetros");
        Console.Write("Seleccione opción: ");
        opcion = Console.ReadLine().ToLower();

        switch (opcion)
        {
            case "a": 
                Console.WriteLine(metros+ "metros equivale a "+metros * 1000+" milímetros"); 
                break;
            case "b": 
                Console.WriteLine(metros+" metros equivale a "+metros * 100+" centímetros"); 
                break;
            case "c": 
                Console.WriteLine(metros+" metros equivale a "+metros * 10+" decímetros"); 
                break;
            case "d": 
                Console.WriteLine(metros+" metros equivale a "+metros / 100+" hectómetros"); 
                break;
            case "e": 
                Console.WriteLine(metros+" metros equivale a "+metros / 1000+" kilómetros"); 
                break;
            default: 
                Console.WriteLine("Opción inválida."); 
                break;
        }
    }
}