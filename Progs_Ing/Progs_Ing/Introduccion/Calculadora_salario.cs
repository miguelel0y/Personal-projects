namespace Progs_Ing.Introduccion;

public class Calculadora_salario
{

    public Calculadora_salario()
    {
        double horastrabajadas, horasextra, salario, pagoextra;

        double tarifa_normal = 16;
        double tarifa_extra = 20;
        double horas_normales = 40;

        Console.WriteLine("Ingresa la cantidad de horas que trabajas: ");
        horastrabajadas = Convert.ToDouble(Console.ReadLine());

        if (horastrabajadas > horas_normales)
        {
            horasextra = horastrabajadas - horas_normales;
            pagoextra = horasextra * tarifa_extra;
            salario = (horas_normales * tarifa_normal) + pagoextra;

            Console.WriteLine("Tu salario es: " + salario);
        }
        else
        {
            salario = horastrabajadas * tarifa_normal;
            Console.WriteLine("Tu salario es: " + salario);
        }

    }
}