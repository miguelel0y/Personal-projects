namespace Progs_Ing.Introduccion;

public class Recopilado_de_datos
{

    public Recopilado_de_datos()
    {

        string n, c;
        int edad;

        Console.WriteLine("Ingresa tu nombre: ");
        n = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Ingresa tu edad");
        edad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresa tu carrera: ");
        c = Convert.ToString(Console.ReadLine());


        Console.WriteLine("Tu nombre es: " + n);
        Console.WriteLine("Tu edad es: " + edad);
        Console.WriteLine("Tu carrera es: " + c);

    }
}