namespace Progs_Ing.Introduccion;

public class ProyectoUnidad1
{

    public ProyectoUnidad1()
    {

        double peso, altura, imc;

        Console.WriteLine("Calculadora de IMC");
        Console.WriteLine("Ingresa tu peso: ");
        peso = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresa tu altura: ");
        altura = Convert.ToDouble(Console.ReadLine());

        imc = peso / (altura * altura);

        Console.WriteLine("Tu IMC es de: " + imc);

        if (imc < 18.5)
        {
            Console.WriteLine("Tu imc es bajo!!");
        }
        else if (imc >= 18.5 && imc < 24.9)
        {
            Console.WriteLine("Tu IMC es normal");
        }
        else if (imc >= 25 && imc <= 29.9)
        {
            Console.WriteLine("Tu IMC es sobrepeso");
        }
        else if (imc >= 30)
        {
            Console.WriteLine("Tu IMC es obesidad");
        }

    }
}