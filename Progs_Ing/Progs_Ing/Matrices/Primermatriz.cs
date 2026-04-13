namespace Progs_Ing.Matrices;

public class Primermatriz
{
    public Primermatriz()
    {
       /*
        //ejemplos declaracion de matrices
        //   int[] m;
        float[] temperatura;
        // COrdenador[] ordenador;
        
        //ejemplos declarados
        //   m = new int[10];
        temperatura = new float[31];
        // ordenador = new COrdenador[25];

        int nElementos;
        System.Console.Write("Numero de elementos de la matriz: ");
        nElementos = Convert.ToInt32(Console.ReadLine());
        int[] m =new int[nElementos];
        
        
        
        se intenta acceder a un elemento con subindice menor que cero o mayor que num
        de elementos de la matriz menos uno.
        */
        //int n = m.Length; (numero de elementos de la matriz m
       /* int[] m = new int[100];
        int k = 0, a = 0;

        k = 99;
        m[k + 1] = m[k];



        //equivalencia de matrices
        
        int[] m1= {10,20,30,40,50};
        int[] m2= (int[])m1.Clone();//m2 es una copia de m1

        if (m1.Equals(m2))// equivale a if(m1==m2)
        {
            System.Console.WriteLine("m1 y m2 se refieren a la misma matriz");
        }
        else
        {
            System.Console.WriteLine("m1 y m2 se refieren a matrices diferentes");
        }
        
        */
       
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