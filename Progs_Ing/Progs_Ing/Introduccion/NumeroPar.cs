namespace Progs_Ing.Introduccion;

public class NumeroPar
{

    public NumeroPar()
    {

        int numero;

        Console.WriteLine("identificador de numero par");
        Console.WriteLine("Ingresa un numero: ");
        numero = Convert.ToInt32(Console.ReadLine());
        if (numero % 2 == 0)
        {
            Console.WriteLine("El numero es par");
        }
        else
        {
            Console.WriteLine("El numero es impar");
        }

    }

}