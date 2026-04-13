namespace Progs_Ing.Matrices;

public class ContadorPares
{
    public ContadorPares()
    {
        int[] numeros ={6,35,22,29,70,44,13,15,24,67};
        int[] pares = new int[10];
        int[] impares =new int[10];
        int i, contp = 0, contimp = 0;

        for (i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                pares[contp] = numeros[i];
                contp++;
            }
            else
            {
                impares[contp] = numeros[i];
                contimp++;
                
            }
        }
        Console.WriteLine("pares");
        for (i = 0; i < contp; i++)
        {
            Console.WriteLine(pares[i]+", ");
        }
        Console.WriteLine("impares");
        for (i = 0; i < contimp; i++)
        {
            Console.WriteLine(impares[i]+", ");
        }


    }
}