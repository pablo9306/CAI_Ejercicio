using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_Expendedora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuarActivo = true;
            Console.WriteLine("Presione ENTER para encender el equipo");
            string noEnter = Console.ReadLine();
            while (noEnter != "")
            {
                Console.Write("Presione ENTER, por favor.");
                noEnter = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Máquina expendedora, seleccione una opción");
            string menu = "1) Listado de latas disponibles \n2) Ingresar lata \n3) Seleccionar lata por código " +
               "\n4) Balance de la máquina \n5) Balance extra \n6) Apagar máquina";
            do
            {
                Console.WriteLine(menu);

                try
                {
                    string opcionSeleccionada = Console.ReadLine();

                    if (ConsolaHelp.EsOpcionValida(opcionSeleccionada, "123456"))
                    {
                        if (opcionSeleccionada.ToUpper() == "6")
                        {
                            continuarActivo = false;
                            continue;
                        }

                        switch (opcionSeleccionada)
                        {
                            case "1":
                                
                                break;
                            case "2":
                                
                                break;
                            case "3":
                                
                                break;
                            case "4":
                                
                                break;
                            case "5":
                                break;
                            //etc... si tenemos más opciones...
                            default:
                                Console.WriteLine("Opción inválida.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error durante la ejecución del comando. Por favor intente nuevamente. Mensaje: " + ex.Message);
                }
                Console.WriteLine("Ingrese una tecla para continuar.");

                Console.ReadKey();
                Console.Clear();
            }
            while (continuarActivo);

            Console.WriteLine("Gracias por usar la app.");
            Console.ReadKey();
        }
    }
}
