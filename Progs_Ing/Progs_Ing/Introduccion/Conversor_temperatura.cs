namespace Progs_Ing.Introduccion;

public class Conversor_temperatura
{

    public Conversor_temperatura() {

        double c, k, f;

        Console.WriteLine("Conversor de Temperatura");
        Console.WriteLine("Ingrese la temperatura en Celcius: ");
        c = Convert.ToDouble(Console.ReadLine());

        k = c + 273.15;
        f = (c * 1.8) + 32;

        Console.WriteLine("Celcius a kelvin equivale a: " + k);
        Console.WriteLine("Celcius a fahrenheit equivale a: " + f);

    }
}