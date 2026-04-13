namespace Progs_Ing.Funciones;

public class PrimerFuncion
{
    public PrimerFuncion()
    {
        double pagofinal;
        pagofinal = Procesarpago(2000,0.16,"descuento10");
        Console.WriteLine("Pagar con descuento: "+pagofinal);
        pagofinal = Procesarpago(200, 0.16, null);
        Console.WriteLine("Pagar sin descuento: "+pagofinal);
        

        static double Procesarpago(double subtotal, double impuesto, string cupon)
        {
            double total= subtotal + (subtotal*impuesto);
            double desc;
            if (cupon == "descuento10")
            {
                desc= total * 0.10;
                total -= desc;
                Console.WriteLine("Cupon aplicado");
            }
            else if (!string.IsNullOrEmpty(cupon))
            {
                Console.WriteLine("Cupon invalido");
            }
            
            return total;
        }
        
    }
}