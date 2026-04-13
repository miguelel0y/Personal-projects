namespace Progs_Ing.Introduccion;

public class Forp2
{
    public Forp2()
    {
        double n1, n2, increase, i, sum=0;
        Console.WriteLine("Ingresa numero de inicio: ");
        n1=(int)double.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa numero donde termina: ");
        n2=(int)double.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa numero de incremento: ");
        increase=(int)double.Parse(Console.ReadLine());

        for (i = n1; i <= n2; i+=increase)
        {
            sum += i;
            Console.WriteLine(i);
            
            Console.Write(" ");
            
        }

        
        Console.WriteLine("La suma es: " + sum);
    }
}