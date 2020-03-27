using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant Pablin = new Restaurant(5,"Av. Libertador 6123");
            Console.WriteLine("Bienvenido al Restaurant Pablin");
            Console.WriteLine("Ingresar la cantidad de mesas a pedir:");
            int mesaspedidas = -1;
            while (mesaspedidas < 0)
            {
                try 
                {
                    mesaspedidas = int.Parse(Console.ReadLine());                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Ingresar un valor positivo");
                }
            }
            int mesasDispDespReserva = 0;
            try
            {
                mesasDispDespReserva = Pablin.CupoMesas(mesaspedidas);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Se reservaron " + mesaspedidas +   " mesas. Quedan " + mesasDispDespReserva + " disponibles");
            Console.ReadLine();
        }
    }
}
