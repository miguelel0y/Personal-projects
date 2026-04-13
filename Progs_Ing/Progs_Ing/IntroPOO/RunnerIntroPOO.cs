//using introduccionPOO.DirectorioPOO;

using Progs_Ing.IntroPOO.DirectorioPOO;

namespace Progs_Ing.IntroPOO{
    
    public class RunnerIntroPOO
    {
        public RunnerIntroPOO()
        {
         
            /*saludar saludador = new saludar();
            string nombre, carrera;
            int edad=0;
            Console.Write("Ingresa el nombre: ");
            nombre=Console.ReadLine();
            Console.Write("Ingresa la edad: ");
            edad=int.Parse(Console.ReadLine()); 
            Console.Write("Ingresa la carrera: ");
            carrera=Console.ReadLine();
            
            
            saludador.saludarA(nombre);
            saludador.requisarEdad(edad);
            saludador.licenciatura(carrera);
            */

    










            //saludar saludador= new saludar();
            //saludador.saludador();

            /*OperacionesBasicas operacionesBasicas = new OperacionesBasicas();

            int num1 = 30;
            int num2 = 4;
            int resultado = operacionesBasicas.Sumar(num1, num2);
           int mult = operacionesBasicas.Multi(num1, num2);
           int div= operacionesBasicas.division(num1, num2);


            Console.WriteLine(resultado);
            Console.WriteLine(mult);
            Console.WriteLine(div);
            */

            NumComplejo z1 = new NumComplejo(parte_real:2, parte_imaginaria:3);
            NumComplejo z2 = new NumComplejo(parte_real:7, parte_imaginaria:9);
            z1.suma(z2);
            

        }   
        
    }
    
}