namespace Progs_Ing;

public class ExamenUnidad1
{

    public ExamenUnidad1()
    {

        Console.WriteLine("Universidad Autonoma de Tamaulipas");
        Console.WriteLine(" ");
        Console.WriteLine("\nFacultad de ingeniería");
        Console.WriteLine(" ");
        Console.WriteLine("Ingeniería en Ciencias de Datos e Inteligencia Artificial");
        Console.WriteLine(" ");
        Console.WriteLine("Semestre Enero-Junio");
        Console.WriteLine("\nExamen Parcial 1");

        String nombre, p1, p2, p3, p4, p5, p6, p7, p8;
        int a, b, c, d, e, f, g, h;
        Double nota = 0;
        Char semestre;

        Console.WriteLine("Ingresa tu nombre completo: ");
        nombre = Convert.ToString(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("Ingresa tu semestre actual (A,B,C,D,E): ");
        semestre = Convert.ToChar(Console.ReadLine());
        Console.WriteLine(" ");

        Console.WriteLine("Lee cuidadosamente las instrucciones y responde correctamente");
        Console.WriteLine(" ");
        Console.WriteLine("1) ¿Qué es la programacion?: ");
        p1 = Convert.ToString(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("2) ¿Qué es un algoritmo?: ");
        p2 = Convert.ToString(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("3) Explica el ciclo de vida de un programa: ");
        p3 = Convert.ToString(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("4) ¿Qué es una variable?: ");
        p4 = Convert.ToString(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("5) ¿Qué es un tipo de dato?: ");
        p5 = Convert.ToString(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("6) Menciona al menos 5 tipos de datos: ");
        p6 = Convert.ToString(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("7) ¿Cuáles son los tipos de operadores aritmeticos?: ");
        p7 = Convert.ToString(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("8) Menciona los operadores relacionales, al menos 5: ");
        p8 = Convert.ToString(Console.ReadLine());
        Console.WriteLine(" ");



        double n1, n2, rest, sum, mult, div, bas, area, altura, dia, meses;

        Console.WriteLine("Examen unidad 1");
        Console.WriteLine(" ");
        Console.WriteLine("ingresa el numero: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        if (n1 % 2 == 0)
        {
            Console.WriteLine("Par");
        }
        else
        {
            Console.WriteLine("Impar");
        }

        Console.WriteLine(" ");
        Console.WriteLine("diversas operaciones");
        Console.WriteLine("Ingresa n1: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresa n2: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        sum = n1 + n2;
        rest = n1 - n2;
        mult = n1 * n2;
        div = n1 / n2;

        Console.WriteLine("Suma es: " + sum);
        Console.WriteLine("Resta es: " + rest);
        Console.WriteLine("multiplicacion es: " + mult);
        Console.WriteLine("Division es: " + div);

        Console.WriteLine(" ");
        Console.WriteLine("Numero mayor");
        Console.WriteLine("Ingresa n1: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresa n2: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        if (n1 > n2)
        {
            Console.WriteLine(n1 + " es mayor que " + n2);
        }
        else
        {
            Console.WriteLine(n2 + " es mayor que " + n1);
        }

        Console.WriteLine(" ");
        Console.WriteLine("area de un rectangulo");
        Console.WriteLine("Ingresa la base: ");
        bas = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresa la altura: ");
        altura = Convert.ToDouble(Console.ReadLine());

        area = bas * altura;

        Console.WriteLine("El area del rectangulo es de: " + area);

        Console.WriteLine(" ");
        Console.WriteLine("Dias de la semana");
        Console.WriteLine("Ingresa el dia que quieres saber(en numero): ");
        dia = Convert.ToDouble(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("lunes");
                break;

            case 2:
                Console.WriteLine("Martes");
                break;

            case 3:
                Console.WriteLine("Miercoles");
                break;

            case 4:
                Console.WriteLine("Jueves");
                break;

            case 5:
                Console.WriteLine("Viernes");
                break;

            case 6:
                Console.WriteLine("Sabado");
                break;

            case 7:
                Console.WriteLine("Domingo");
                break;

            default:
                Console.WriteLine("Opcion no valida!!");
                break;
        }

        Console.WriteLine(" ");
        Console.WriteLine("Meses del año");
        Console.WriteLine("Ingresa el mes a conocer(en numero): ");
        meses = Convert.ToDouble(Console.ReadLine());

        switch (meses)
        {
            case 1:
                Console.WriteLine("Enero");
                break;

            case 2:
                Console.WriteLine("Febrero");
                break;

            case 3:
                Console.WriteLine("Marzo");
                break;

            case 4:
                Console.WriteLine("Abril");
                break;

            case 5:
                Console.WriteLine("Mayo");
                break;

            case 6:
                Console.WriteLine("Junio");
                break;

            case 7:
                Console.WriteLine("Julio");
                break;
            case 8:
                Console.WriteLine("Agosto");
                break;
            case 9:
                Console.WriteLine("Septiembre");
                break;
            case 10:
                Console.WriteLine("Octubre");
                break;
            case 11:
                Console.WriteLine("Noviembre");
                break;
            case 12:
                Console.WriteLine("Diciembre");
                break;

            default:
                Console.WriteLine("Opcion no valida!!");
                break;
        }

    }
}


