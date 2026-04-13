namespace Progs_Ing.Introduccion;

public class Cantidad_Pares
{

    public Cantidad_Pares()
    {

        int min, max, i = 0, contador = 0;
        
        Console.WriteLine("cantidad minima: ");
        min=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("cantidad maxima: ");
        max=Convert.ToInt32(Console.ReadLine());

        if (max > min && min > 0)
        {
            if (i % 2 == 0)
            {
                contador++;
                Console.WriteLine(contador);
            }
        }

    }

}