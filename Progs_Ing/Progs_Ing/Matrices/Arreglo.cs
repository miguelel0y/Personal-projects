namespace Progs_Ing.Matrices;

public class Arreglo
{
    public Arreglo()
    {
        int[] arr = new int[5];
        int i, mayor, menor;
        
        
        for (i = 0; i < 5; i++)
        {
            Console.WriteLine("ingresa un numero: ");
            arr[i]=int.Parse(Console.ReadLine());
        }
        mayor=arr[0];
        menor=arr[0];
        for (i = 0; i < 5; i++)
        {
            if (arr[i] > mayor)
            {
                mayor = arr[i];
            }
            else if (arr[i]< menor)
            {
                menor = arr[i];
            }
        }
        Console.WriteLine("%mayor"[mayor]);
        Console.WriteLine("%menor"[menor]);
        
        
        
        
        
    }

    
}