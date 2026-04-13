namespace Progs_Ing.Introduccion;

public class Arreglos_array
{
    public Arreglos_array()
    {
        int[] arreglo1d = new int[10];
        int i = 0;
       ///ciclo for
       
       Console.Write("arreglos con ciclo for\n");
        for (i = 0; i < arreglo1d.Length; i++)
        {
            arreglo1d[i] = i + 1;
        }

        for (i = 0; i < arreglo1d.Length; i++)
        {
            Console.WriteLine($"Iteracion {i}= {arreglo1d[i]}");
        }

        ///hacer el recorrido con el ciclo while
        i = 0;
        Console.Write("arreglos con while\n");
        while (i < arreglo1d.Length)
        {
            Console.WriteLine($"Iteracion {i}= {arreglo1d[i]}");
            i++;
        }
        
        
            ///ciclo do while
            i = 0;
            Console.Write("arreglos con do while\n");
        do
        {
            Console.WriteLine($"Iteracion {i}= {arreglo1d[i]}");
            i++;

        }while(i<arreglo1d.Length);
        
        
    }
    
    
    
    
}