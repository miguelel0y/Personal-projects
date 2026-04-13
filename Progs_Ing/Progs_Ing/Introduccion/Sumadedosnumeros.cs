namespace Progs_Ing.Introduccion;


public class Sumadedosnumeros
{

    public Sumadedosnumeros()
    {
        double n1, n2, s, r, m, d;

        Console.Write("Diversas operaciones");
        Console.Write("Ingresa el primer numero: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingresa el segundo numero: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        s = n1 + n2;
        r = n1 - n2;
        m = n1 * n2;
        d = n1 / n2;


        Console.WriteLine("El resultado de la suma es: " + s);
        Console.WriteLine("El resultado de la resta es: " + r);
        Console.WriteLine("El resultado de la multiplicacion es: " + m);
        Console.WriteLine("El resultado de la division es: " + d);

    }
}