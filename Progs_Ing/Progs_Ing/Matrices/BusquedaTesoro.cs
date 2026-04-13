namespace Progs_Ing.Matrices;

public class BusquedaTesoro
{
    public BusquedaTesoro()
    {
        int[,] mapa = new int[2, 5];
        int numero;

        Console.WriteLine("Que numero buscas como tesoro?:  (1-50)");
        numero = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        LLenadomapa(mapa);
        Imprimirmapa(mapa);

        if (Buscarnumero(mapa, numero))
        {
            Console.WriteLine("Numero encontrado, aparece en la lista");
        }
        else
        {
            Console.WriteLine("Numero no encontrado");
        }

        ///funcion void
        static void LLenadomapa(int[,] mat)
        {
            Random r = new Random();
            int i, j;

            for (i = 0; i < mat.GetLength(0); i++)
            {
                for (j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = r.Next(1, 51);
                }
            }
        }

        static void Imprimirmapa(int[,] mat)
        {
            int i,j;
            for (i = 0; i < mat.GetLength(0); i++)
            {
                for (j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static bool Buscarnumero(int[,] mat, int valor)
        {
            foreach (int n in mat)
            {
                if (n == valor)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}