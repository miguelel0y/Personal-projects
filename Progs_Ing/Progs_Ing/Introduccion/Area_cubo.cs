namespace Progs_Ing.Introduccion;

public class Area_cubo
{
    public Area_cubo()
    {
        double a, b, c, area;
        Console.WriteLine("Digite o valor do lado do cubo:");
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Convert.ToDouble(Console.ReadLine());
        area = 2 * (a * b + a * c + b * c);
        Console.WriteLine("A area do cubo é: " + area);
    }
}