// See https://aka.ms/new-console-template for more information

int numero;
while (true)
{
    Console.WriteLine("Introduce un número del 1 al 7 (o 0 para salir):");
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

    if (numero >=1 && numero <=7)
    {
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


        }

    }
    else
    {
        Console.WriteLine("Valor no válido, intenta de nuevo.");
        continue;
    }

}
Console.WriteLine("Presiona cualquier tecla para salir.");
Console.ReadKey();