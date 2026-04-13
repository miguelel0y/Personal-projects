using System.Security.AccessControl;

namespace Progs_Ing.Introduccion;

public class Metodo_sumar
{
    public static double Sumar(double a, double b)
    {
        double resultado = 0;
        resultado = a + b;
        return resultado;
    }//(funciona como un void)

    public static void Sumar(string[] args)
    {
        double a = 10, b = 20, r = 0;
        r = Sumar(a, b);
        Console.WriteLine("Resultado: "+r);
    }//metodo main
}