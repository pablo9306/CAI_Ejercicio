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

        public Restaurant(int cantMesas, string direccion)
        {
            this._cantMesas = cantMesas;
            this._estaAbierto = true;
            this._direccion = direccion;
        }

        
        public int CupoMesas(int mesasreservar)
        {            
            if (this._estaAbierto)
            {
                if (this._cantMesas < mesasreservar)
                {
                   throw new Exception("Mesas a reservar excedido, sólo tenemos " + (this._cantMesas - mesasreservar) + " disponbiles");
                }
                //Console.WriteLine("Se reservaron " + mesasreservar + " mesas. Quedan " + (this._cantMesas - mesasreservar) + " disponibles");
                return (this._cantMesas - mesasreservar);
            }
            throw new Exception("Restaurant cerrado");
        }
        public void estaAbierto()
        {
            this._estaAbierto = true;
        }
    }
}