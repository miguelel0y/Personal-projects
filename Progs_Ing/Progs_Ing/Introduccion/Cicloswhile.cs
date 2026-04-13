namespace Progs_Ing.Introduccion;

public class Cicloswhile
{

    public Cicloswhile()
    {

        int i, suma = 0, contador = 0, num;
        String pass;

/*Console.WriteLine("Analisis de numero par, ingresa: ");
//num = Convert.ToInt32(Console.ReadLine());

while ((num= int.Parse(Console.ReadLine()))>0)
{
    if (num % 2 == 0)
    {
       suma+=num;
    }

}//llave while
Console.WriteLine("Suma es igual a: "+suma);
//Console.ReadKey();



for (i = 1; i <=100; i++)
{
    contador += i;

}
Console.WriteLine(contador);

decimal monto = 0, capital = 1000;
Double tasa = 0.05;


Console.WriteLine("{0}{1,20}","Año","monto depositado");

for (int anio = 1; anio <= 10; anio++)
{
    monto=capital*
          (decimal) Math.Pow(1.0+tasa,anio);

    Console.WriteLine("{0,4}{1,20:C}",anio ,monto);
}

*/

        int stock = 6;

        Console.WriteLine("Cantidad de stock: ");
        stock = int.Parse(Console.ReadLine());
        Console.WriteLine("Tienes: " + stock + "de stock");
        while (stock > 0)
        {
            stock -= 1;
            Console.WriteLine("Ahora tienes: " + stock + "de stock");
        }

        Console.WriteLine("Piramides con ciclos for");

        int altura = 5, j;

        for (i = 1; i <= altura; i++)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

    }
}
