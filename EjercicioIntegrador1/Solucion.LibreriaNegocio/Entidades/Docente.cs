using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Docente : Empleado
    {
        

        public Docente(int cod, string nombre, string apellido, DateTime fechaIngreso) : base(cod,nombre,apellido,fechaIngreso)
        {
        }

        public override string GetNombreCompleto()
        {
            return "Docente " + this.Apellido;
        }

    }
}
