namespace Progs_Ing.Matrices;

public class TablasconMatriz
{
    public TablasconMatriz()
    {
        int i=0;
        int[] n = new int[10];
        
        Console.WriteLine("Tabla del 2");
       
        
        for (i = 0; i <n.Length; i++)
        {
            n[i] = (i + 1) * 2;
            Console.WriteLine(n[i]);
            
        }
        

    }
}