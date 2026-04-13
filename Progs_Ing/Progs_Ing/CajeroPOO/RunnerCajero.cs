namespace Progs_Ing.CajeroPOO;

public class RunnerCajero
{
    public RunnerCajero()
    {
        Ccuenta cuenta01 = new Ccuenta();
        cuenta01.asignarNombre("un nombre");
        cuenta01.asignarCuenta("Una cuenta");
        cuenta01.asignarTipodeInteres(2.5);

        cuenta01.ingreso(100000);
        cuenta01.reintegro(500000);
        
        Console.WriteLine(cuenta01.obtenerNombre());
        Console.WriteLine(cuenta01.obtenerCuenta());
        Console.WriteLine(cuenta01.estado());
        Console.WriteLine(cuenta01.obtenerTipodeInteres()); 
    }
}