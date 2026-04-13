namespace Progs_Ing;

public class ExamenUnidad1_COMPLETO
{

    public ExamenUnidad1_COMPLETO()
    {

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

        Console.WriteLine(" ");
        Console.WriteLine("--- Pregunta 9: Evaluación de expresiones ---");
        Console.WriteLine("Dadas las variables A = -5, B = 15, C = 10");
        Console.WriteLine(" ");
        
        int A = -5;
        int B = 15;
        int C = 10;
        
    
        bool p1= A < 3;                  
        bool p2= A > C;                    
        bool p3 = A < C;                   
        bool p4 = B < C;                    
        bool p5 = B != C;                   
        bool p6 = A == 3;                   
        bool p7 = A * B == 15;               
        bool p8 = A * B == -30;               
        
        
        Console.WriteLine("EXPRESIÓN                     RESULTADO");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"A < 3                         {p1}");
        Console.WriteLine($"A > C                         {p2}");
        Console.WriteLine($"A < C                         {p3}");
        Console.WriteLine($"B < C                         {p4}");
        Console.WriteLine($"B != C                        {p5}");
        Console.WriteLine($"A == 3                        {p6}");
        Console.WriteLine($"A * B == 15                   {p7}");
        Console.WriteLine($"A * B == -30                  {p8}");
        Console.WriteLine("----------------------------------------");

        
        
    }
}