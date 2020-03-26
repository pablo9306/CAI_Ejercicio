using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    class Restaurant
    {
        private int _cantMesas;
        private string _direccion;
        private bool _estaAbierto;

        public int cantMesas
        {
            get
            {
                return this._cantMesas;
            }
            set
            {
                this._cantMesas = value;
            }
        }

        public string direccion
        {
            get
            {
                return this._direccion;
            }
            set
            {
                this._direccion = value;
            }
        }

        public Restaurant(int cantMesas, bool estaAbierto)
        {
            this._cantMesas = cantMesas;
            this._estaAbierto = estaAbierto;
        }

        public bool CupoMesas(int mesasreservar)
        {
            if (this._estaAbierto)
            {
                if (this._cantMesas <= mesasreservar)
                {
                    Console.WriteLine("Mesas a reservar excedido");
                    return false;
                }
                Console.WriteLine("Se reservaron " + mesasreservar + " mesas");
                this._cantMesas = (this._cantMesas - mesasreservar);
                return true;
            }
            Console.WriteLine("Restaurant cerrado");
            return false;
        }
     }
}