namespace Progs_Ing.Introduccion;


public class Piramideinvertida
{
    
    public Piramideinvertida()
    {

        Console.WriteLine("Piramide invertida");

        int altura = 5;
        int i, j;
        
        for(i=1; i<=altura; i++)
        {
            for ( j = 1; j<= altura - i; j++)
            {
                Console.Write("*");
            }
            
            Console.WriteLine();
        }
        
    }
}