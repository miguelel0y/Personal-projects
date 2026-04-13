namespace Progs_Ing.Introduccion;

public class PositivoNegativo
{

    public PositivoNegativo()
    {

        double n1, n2, resultado;
        double suma, resta, mult, div;
        int i;

        Console.WriteLine("Menu de prueba");
        Console.WriteLine("1 positivo negativo");
        Console.WriteLine("2 numero par o impar");
        Console.WriteLine("3 diversas operaciones");
        Console.WriteLine("4 Conversor de dolares");
        Console.WriteLine("Ingrese una opcion");
        int opcion = Convert.ToInt32(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Opcion A");


                for (i = 5; i >= -5; i--)
                {
                    if (i > 0)
                    {
                        Console.WriteLine(i + "positivo");
                    }
                    else if (i < 0)
                    {
                        Console.WriteLine(i + "negativo");
                    }
                    else
                    {
                        Console.WriteLine(i + "cero");
                    }
                }

                break;
            case 2:
                Console.WriteLine("Opcion B");
                Console.WriteLine("Ingrese un numero");
                n1 = Convert.ToInt32(Console.ReadLine());
                if (n1 % 2 == 0)
                {
                    Console.WriteLine("El numero es par");

                }
                else
                {
                    Console.WriteLine("El numero es impar");
                }

                break;
            case 3:
                Console.WriteLine("Diversas variables");

                Console.WriteLine("Ingrese el primer numero: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero: ");
                n2 = Convert.ToDouble(Console.ReadLine());

                suma = n1 + n2;
                resta = n1 - n2;
                div = n1 / n2;
                mult = n1 * n2;

                Console.WriteLine("suma es igual a: " + suma);
                Console.WriteLine("resta es igual a: " + resta);
                Console.WriteLine("multiplicacion es igual a: " + mult);
                Console.WriteLine("division es igual a: " + div);

                break;

            case 4:

                break;

            default:
                Console.WriteLine("Opcion no valida");
                break;
        }

    }
}
