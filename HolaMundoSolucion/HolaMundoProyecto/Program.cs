internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine(@"  ___  ___  ___  ___  ___.---------------.");
        Console.WriteLine(@".'\__\'\__\'\__\'\__\'\__,`   .  ____ ___ \");
        Console.WriteLine(@"|\/ __\/ __\/ __\/ __\/ _:\   |`.  \  \___ \");
        Console.WriteLine(@" \\'\__\'\__\'\__\'\__\'\_`.__|""`. \  \___ \");
        Console.WriteLine(@"  \\/ __\/ __\/ __\/ __\/ __:                \");
        Console.WriteLine(@"   \\'\__\'\__\'\__\ \__\'\_;-----------------`");
        Console.WriteLine(@"    \\/   \/   \/   \/   \/ :               hh|");
        Console.WriteLine(@"     \|______________________;________________|");



        int numero;
        while (true)
        {
            Console.WriteLine("Introduce un número del 1 al 7 (o 0 para salir): ");
            if (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Entrada no válida, por favor introduce un número.");
                continue;
            }

            if (numero == 0)
            {
                Console.WriteLine("¡Hasta luego!");
                break;
            }

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Valor no válido, intenta de nuevo.");
                    break;

            }

        }

    }
}