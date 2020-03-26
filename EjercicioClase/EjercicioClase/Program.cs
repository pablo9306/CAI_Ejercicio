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
            Restaurant Pablin = new Restaurant(5, true);
            Console.WriteLine("Ingresar la cantidad de mesas a pedir:");
            int mesaspedidas = int.Parse(Console.ReadLine());
            Pablin.CupoMesas(mesaspedidas);
            Console.ReadLine();
        }
    }
}
