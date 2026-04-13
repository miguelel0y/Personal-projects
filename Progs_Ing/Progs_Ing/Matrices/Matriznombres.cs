namespace Progs_Ing.Matrices;

public class Matriznombres
{
    public Matriznombres()
    {
        string[] nombres = new string[5];
        int i;

        for (i = 0; i < nombres.Length; i++)
        {
            Console.Write("Ingrese el nombre de Alumnos: ");
            nombres[i] = Console.ReadLine();
            
        }
        Console.Write("Acabo registro\n");
        Console.WriteLine("recorrido for each: \n");
       

        foreach (var nombre in nombres)
        {
            Console.WriteLine(nombre);
        }
        
    }
}