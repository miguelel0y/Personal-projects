namespace Progs_Ing.CajeroPOO;

public class Ccuenta
{
    //atributos
    private string nombre;
    private string cuenta;
    private double saldo;
    private double tipodeInteres;
   
    //metodos
    public void asignarNombre(string nom)
    {
        if (nom.Length == 0)
        {
            Console.WriteLine("Error, cadena vacia!!");
            return;
        }

        nombre = nom;
    }

    public string obtenerNombre()
    {
        return nombre;
    }

    public void asignarCuenta(string cue)
    {
        if (cue.Length == 0)
        {
            Console.WriteLine("Error, cuenta vacia!!");
            return;
        }

        cuenta = cue;
    }

    public string obtenerCuenta()
    {
        return cuenta;
    }

    public double estado()
    {
        return saldo;
    }

    public void ingreso(double cantidad)
    {
        if (cantidad < 0)
        {
            Console.WriteLine("Error, cantidad negativa!!");
        }
        saldo= saldo+cantidad;
    }

    public void reintegro(double cantidad)
    {
        if (saldo - cantidad < 0)
        {
            Console.WriteLine("Error, no dispone de saldo!!");
            return;
        }
        saldo -= cantidad;
    }
   
    public void asignarTipodeInteres(double tipo)
    {
        if (tipo < 0)
        {
            Console.WriteLine("Error, tipo no válido!!");
            return;
        }
        tipodeInteres = tipo;
    }
    public double obtenerTipodeInteres()
    {
        return tipodeInteres;
      
    }
   
}