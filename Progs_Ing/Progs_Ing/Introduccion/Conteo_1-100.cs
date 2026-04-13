namespace Progs_Ing.Introduccion;

public class Conteo_1100
{

    public Conteo_1100()
    {

        Console.WriteLine("suma de 1-100 usando for");
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            sum += i;
        }
        Console.WriteLine("La suma es: " + sum);

    }
}