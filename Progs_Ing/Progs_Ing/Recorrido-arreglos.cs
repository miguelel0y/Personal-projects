namespace Progs_Ing.Introduccion;

public class Recorrido_arreglos
{
    public Recorrido_arreglos()
    {
         int[] arreglo1d = new int[10];
        int i=0;

        for(i=0; i<arreglo1d.Length; i++)
        {
            arreglo1d[i] = i + 1;
        }

        for (i = 0; i < arreglo1d.Length; i++)
        {
            Console.WriteLine($"Iteración {i} = {arreglo1d[i]}");
        }
        
       
       
       //usando ciclo while

       /*i = 0; 
       while(i < arreglo1d.Length)
       {
           Console.WriteLine($"  Iteración {i} = {arreglo1d[i]}");
           i++; 
       }

       Console.WriteLine("");
       
       
       Console.WriteLine("3. Recorrido con do while:");
       i = 0; 
       do
       {
           Console.WriteLine($"  Iteración {i} = {arreglo1d[i]}");
           i++; 
       } while(i < arreglo1d.Length);*/
    }
}