internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese mes de nacimiento (1-12): ");
        int mes = int.Parse(Console.ReadLine());
        Console.Write("Ingrese día de nacimiento (1-31): ");
        int dia = int.Parse(Console.ReadLine());

        string signo = "";
        string horoscopo = "";

        if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 19))
        {
            signo = "Aries";
            horoscopo = "Energía renovada para iniciar nuevos proyectos.";
        }
        else if ((mes == 4 && dia >= 20) || (mes == 5 && dia <= 20))
        {
            signo = "Tauro";
            horoscopo = "La paciencia y la perseverancia traerán grandes frutos hoy.";
        }
        else if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20))
        {
            signo = "Géminis";
            horoscopo = "Excelente día para comunicarse y aprender algo nuevo.";
        }
        else if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 22))
        {
            signo = "Cáncer";
            horoscopo = "Confía en tu intuición para tomar decisiones familiares.";
        }
        else if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 22))
        {
            signo = "Leo";
            horoscopo = "Tu brillo natural atraerá oportunidades laborales interesantes.";
        }
        else if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22))
        {
            signo = "Virgo";
            horoscopo = "Momento ideal para organizar tus pendientes y finanzas.";
        }
        else if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22))
        {
            signo = "Libra";
            horoscopo = "Busca el equilibrio y evita los conflictos innecesarios.";
        }
        else if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
        {
            signo = "Escorpio";
            horoscopo = "Un misterio o duda se resolverá a tu favor.";
        }
        else if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
        {
            signo = "Sagitario";
            horoscopo = "Buen día para planear viajes o actividades al aire libre.";
        }
        else if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19))
        {
            signo = "Capricornio";
            horoscopo = "Tu disciplina te acercará a tu meta profesional.";
        }
        else if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 18))
        {
            signo = "Acuario";
            horoscopo = "Tu creatividad estará al máximo, aprovecha tus ideas.";
        }
        else if ((mes == 2 && dia >= 19) || (mes == 3 && dia <= 20))
        {
            signo = "Piscis";
            horoscopo = "Conecta con tu lado empático y ayuda a un ser querido.";
        }
        else
        {
            signo = "Desconocido";
            horoscopo = "Fecha no válida.";
        }

        Console.WriteLine("Tu signo zodiacal es: " +signo);
        Console.WriteLine("Horóscopo: " +horoscopo);
    }
}