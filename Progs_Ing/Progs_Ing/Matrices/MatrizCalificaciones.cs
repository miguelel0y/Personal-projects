namespace Progs_Ing.Matrices;

public class MatrizCalificaciones
{
    public MatrizCalificaciones()
    {
        string Alumnos;
        
        Console.Write("Ingrese el nombre de Alumnos: ");
        
        
        int nAlumnos;
        do
        {
            Console.WriteLine("Numero de Alumnos: ");
            nAlumnos = int.Parse(Console.ReadLine());

        } while (nAlumnos < 1);
        {
           float[]nota =new float[nAlumnos]; //crear la matriz
           int i = 0; //subíndice
           float suma = 0F;  //suma total de las notas medias

           
           //ingreso de las notas de los alumnos
           for (i = 0; i < nota.Length; i++)
           {
               Console.Write("Nota media del alumno: " +(i+1)  + ": ");
               nota[i] = float.Parse(Console.ReadLine());
           }
           ///suma de las notas y resultado del promedio grupal
           for (i = 0; i < nota.Length; i++)
           {
               suma += nota[i];
               Console.Write("Nota media del curso:" + suma /nAlumnos);
           }
           
           /*los dos ciclos for se pueden reducir a uno solo
           de tal manera que: 
            
            for (i=0; i<nota.length; i++){
            
            Console.WriteLine("Nota media del alumno " + (i+1) + ": ");
            nota[i]=float.parse((Console.ReadLine());
            }
            */
        }
        
        
        
    }
}