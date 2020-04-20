using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_Expendedora
{
    public class Lata
    {
        private string _codigo, _nombre, _sabor;
        private double _precio, _volumen;
        
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Sabor { get => _sabor; set => _sabor = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public double Volumen { get => _volumen; set => _volumen = value; }

        public Lata(string Codigo)
        {
            this._codigo = Codigo;
        }
        public double GetPrecioPorLitro()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
