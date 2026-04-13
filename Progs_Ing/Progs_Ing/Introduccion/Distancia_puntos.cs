namespace Progs_Ing.Introduccion;

public class Distancia_puntos
{

    public Distancia_puntos()
    {

        double punto1, punto2, x1, x2, y1, y2, resultado;

        Console.WriteLine("Distancia entre dos puntos");
        Console.WriteLine("Ingresa el valor de x1: ");
        x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresa el valor de y1: ");
        y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresa el valor de x2: ");
        x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresa el valor de y2: ");
        y2 = Convert.ToDouble(Console.ReadLine());

        resultado = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine("La distancia entre los puntos es: " + resultado);

    }
}