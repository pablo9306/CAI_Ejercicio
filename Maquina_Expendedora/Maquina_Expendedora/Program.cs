﻿using System;
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

            Expendedora maquina = IniciarListaLatas();
            //MostrarStock(maquina);

            Console.WriteLine("Máquina expendedora, seleccione una opción");
            string menu = "1) Listado de latas aceptadas \n2) Ingresar lata \n3) Seleccionar lata por código " +
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
                                MostrarLatasAceptadas(maquina);
                                break;
                            case "2":
                                IngresarLata(maquina);
                                break;
                            case "3":
                                mostratTotaaaaaaaaaal(maquina);
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

        private static Expendedora IniciarListaLatas()
        {
            Expendedora expendedora = new Expendedora();
            expendedora.AgregarLata(expendedora.createLata("CO1"));
            expendedora.AgregarLata(expendedora.createLata("CO2"));
            expendedora.AgregarLata(expendedora.createLata("SP1"));
            expendedora.AgregarLata(expendedora.createLata("SP2"));
            expendedora.AgregarLata(expendedora.createLata("FA1"));
            expendedora.AgregarLata(expendedora.createLata("FA2"));

            return expendedora;
        }
            
        private static void IngresarLata(Expendedora expendedora)
        {
            Console.WriteLine("Escribir el código: ");
            string c = Console.ReadLine();
            Console.WriteLine("Escribir el precio: ");
            double p = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribir el volumen: ");
            double v = int.Parse(Console.ReadLine());
            
            expendedora.AgregarLataNueva(c, p, v);
            Console.WriteLine("Lata Agregada");
        }


        private static void MostrarLatasAceptadas(Expendedora expendedora)
        {

            var trucho = expendedora.Lata.Select(x => x.Codigo).Distinct();
            
            foreach (var item in trucho)
            {
                Lata l = expendedora.Lata.Find(x => x.Codigo == item);

                Console.WriteLine(l.Codigo + " " + l.Nombre + " " + l.Sabor);
            }

        }


        private static void mostratTotaaaaaaaaaal(Expendedora expendedora)
        {

            var trucho = expendedora.Lata.Select(x => x.Codigo).Distinct();

            foreach (var item in trucho)
            {
                Lata l = expendedora.Lata.Find(x => x.Codigo == item);
                var cantidadIguales = 0;
                foreach (Lata latita in expendedora.Lata)
                {
                    if (item == latita.Codigo)
                    {
                        cantidadIguales++;

                    }
                }
                   Console.WriteLine("Cantidad " + cantidadIguales + " " + l.Codigo + " " + l.Nombre + " " + l.Sabor);

            }
        }
    }
}
