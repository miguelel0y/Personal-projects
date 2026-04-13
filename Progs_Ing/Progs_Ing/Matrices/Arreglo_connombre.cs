namespace Progs_Ing.Matrices;

public class Arreglo_connombre
{
    public Arreglo_connombre()
    {
        string[] nombres = new string[5];
        int i;

        for (i = 0; i < nombres.Length; i++)
        {
            Console.Write("Ingresa un nombre: ");
            nombres[i] = Console.ReadLine();
            
        }
        Console.Write("Acabo registro ");
        Console.Write("Recorrido foreach : ");
        foreach (var nombre in nombres)
        {
            Console.Write(nombre);
        }

    }
}