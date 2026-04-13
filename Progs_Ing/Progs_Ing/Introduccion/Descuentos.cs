namespace Progs_Ing.Introduccion;

public class Descuentos
{

    public Descuentos()
    {

        double precio, descuento, cantidad, final;

        Console.WriteLine("Bienvenido al almacen");
        Console.WriteLine("Ingresa la cantidad de tu compra: ");
        cantidad = Convert.ToDouble(Console.ReadLine());

        if (cantidad >= 1000)
        {
            descuento = 0.20 * cantidad;
            final = cantidad - descuento;

            Console.WriteLine("El precio era: " + cantidad);
            Console.WriteLine("El precio final despues de tu descuento es: " + final);
        }
        else
        {

            Console.WriteLine("Tu compra no cumple con el minimo para el descuento!!");
        }

    }
}