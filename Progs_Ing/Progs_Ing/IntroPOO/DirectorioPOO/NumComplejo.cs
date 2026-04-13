namespace Progs_Ing.IntroPOO.DirectorioPOO;

public class NumComplejo
{
    //atributos de clase
    //...descriptores de objetos
    //Por convencion los atributos deben ser privados
    private double parte_real;
    private double parte_imaginaria;
    
    //constructor

    public NumComplejo(double parte_real, double parte_imaginaria)
    {
        this.parte_real = parte_real;  
        this.parte_imaginaria = parte_imaginaria;
    }

    public void suma(NumComplejo num)
    {
        double resultReal, resultImaginaria;
        resultReal = this.parte_real + num.parte_real;
        resultImaginaria = this.parte_imaginaria + num.parte_imaginaria;
        Console.WriteLine(resultReal +"+" + resultImaginaria +"i");
    }
}