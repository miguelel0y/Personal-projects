namespace Progs_Ing.Matrices;

public class ArreglosCaracteres
{
    public ArreglosCaracteres()
    {
        char[] cadena = new char[40];
        int i = 0, car;
        
        Console.Write("Introducir un texto: ");
        while((car = int.Parse(Console.ReadLine())) !='\r' && i < cadena.Length);
        {
            cadena[i] = (char)car;
            i++;
        }
        Console.WriteLine("Texto introducido: ");
        Console.Write(cadena);
        Console.WriteLine("Longitud del texto: "+i);
        Console.WriteLine("Dimension de la matriz: "+ cadena.Length);
        
    }
}