using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_Expendedora
{
    class Expendedora
    {
        private List<Lata> _lata;
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendida;

        public List<Lata> Lata { get => _lata; set => _lata = value; }
        public string Proveedor { get => _proveedor; set => _proveedor = value; }
        public int Capacidad { get => _capacidad; set => _capacidad = value; }
        public double Dinero { get => _dinero; set => _dinero = value; }
        public bool Encendida { get => _encendida; set => _encendida = value; }

        public void AgregarLata(Lata lata)
        {
            Console.WriteLine("Escribir el código: ");
            string Codigo = Console.ReadLine();
            Lata latas = new Lata(Codigo);
            Lata.Add(latas);

        }

    }
}
