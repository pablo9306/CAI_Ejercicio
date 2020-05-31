using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpendedoraCapas.Entidades
{
    public class Expendedora
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

        public Expendedora()
        {
            this._lata = new List<Lata>();
        }


        public void AgregarLata(Lata lata)
        {
            this._lata.Add(lata);
        }

        public bool TieneCapacidad(string codigo)
        {
            return this.Lata.Where(lata => lata.Codigo == codigo).ToList().Count < 10;
        }

        public void AgregarLataNueva(string codigo, double precio, double volumen)
        {

            Lata latrucho = this.createLata(codigo);
            latrucho.Precio = precio;
            latrucho.Volumen = volumen;
            this.AgregarLata(latrucho);

        }

        public Lata createLata(string codigo)
        {
            //Lata latita = null;
            if (codigo == "CO1")
                return new Entidades.Lata("CO1", "Coca Cola", "Regular", 10, 1);
            if (codigo == "CO2")
                return new Entidades.Lata("CO2", "Coca Cola", "Zero", 11, 1);
            if (codigo == "SP1")
                return new Entidades.Lata("SP1", "Sprite", "Regular", 10, 1);
            if (codigo == "SP2")
                return new Entidades.Lata("SP2", "Sprite", "Zero", 11, 1);
            if (codigo == "FA1")
                return new Entidades.Lata("FA1", "Fanta", "Regular", 10, 1);
            if (codigo == "FA2")
                return new Entidades.Lata("FA2", "Fanta", "Zero", 11, 1);

            throw new CodigoInvalidoException("Codigo Invalid");
        }


    }
}
