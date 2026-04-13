namespace Progs_Ing;

public class Arreglos2D
{
    public Arreglos2D()
    {
        
        int[,] tablero = new int[3,3];
        int contador = 1,sum=0;

        int[] suma = new int[3];
        
        for (int f = 0; f < 3; f++) {
            
            suma[f] = 0;
           
            for (int c = 0; c < 3; c++) {
                tablero[f, c] = contador++;
                Console.Write(tablero[f, c] + " ");
                suma[f]+= tablero[f, c];
            }
            
            //Console.WriteLine($" La suma de la fila es: {sum}"); 
            Console.WriteLine();
        }

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($" La suma de la fila {i} es: {suma[i]}");
        }
        
    }
    
}