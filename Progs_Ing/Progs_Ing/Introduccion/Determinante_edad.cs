namespace Progs_Ing.Introduccion;

public class Determinante_edad
{

    public Determinante_edad()
    {

        int edad;

        Console.WriteLine("Bienvenido al bar!!");
        Console.WriteLine("Ingresa tu edad: ");
        edad = Convert.ToInt32(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad, puedes pasar!!");

        }
        else
        {
            Console.WriteLine("No eres mayor de edad, no puedes pasar!!");
        }

    }
}