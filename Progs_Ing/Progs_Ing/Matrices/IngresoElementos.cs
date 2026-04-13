namespace Progs_Ing.Matrices;

public class IngresoElementos
{
    public IngresoElementos()
    {
        //---creacion de una matriz unidimensional---//
       
        //se define nElementos
        int nElementos;
       
        Console.WriteLine("Numero de elementos de la matriz: ");
        nElementos=int.Parse(Console.ReadLine());
        int[] m=new int[nElementos]; //crear la matriz m
        int i = 0; //subíndice

        Console.Write("Introducir los valores de la matriz: ");
        for (i = 0; i < nElementos; i++)
        {
            Console.Write("m[" + i +"]=");
            m[i]=int.Parse(Console.ReadLine());
        }

        //Visualizar los elementos de la matriz
        Console.WriteLine();
        for (i = 0; i < nElementos; i++)
        {
            Console.Write(m[i]+" ");
        }
        
    }
}