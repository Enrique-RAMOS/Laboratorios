using Lab1_Notas.Models;
namespace Lab1_Notas.Bussines
{
    public class Operaciones
    {
        public double index(Acciones acciones)
        {



            Double promedio1 = acciones.lab1 * 0.4 + acciones.par1 * 0.6;
            Double promedio2 = acciones.lap2 * 0.4 + acciones.par2 * 0.6;
            Double promedio3 = acciones.lap3 * 0.4 + acciones.par3 * 0.6;

            Double calculo = promedio1 * 0.333333 + promedio2 * 0.333333 + promedio3 * 0.333333;

            string nombres = acciones.nombre;

            return calculo;
           
        }
      

    }
}
