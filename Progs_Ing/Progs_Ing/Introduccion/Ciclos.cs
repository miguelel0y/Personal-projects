namespace Progs_Ing.Introduccion;

public class Ciclos
{

    public Ciclos()
    {

        int n, i;

        Console.WriteLine("ingresa el numero a multiplicar");
        n = Convert.ToInt32(Console.ReadLine());
        for (i = 1; i <= 10; i++)
        {
            Console.WriteLine(n + " x " + i + " = " + n * i);
            Console.WriteLine();
        }

        bool flag = false;
        while (flag)
        {
            Console.WriteLine("Hola");
            Console.WriteLine("Desea continuar? (s/n)");
            n = int.Parse(Console.ReadLine());
            if (!flag)
            {
                Console.WriteLine("Adios");
            }

        }

        Console.ReadKey();

    }
}