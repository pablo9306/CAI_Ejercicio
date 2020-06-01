using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpendedoraCapas.Negocio
{
    public class CodigoInvalidoException : Exception
    {
        public CodigoInvalidoException(string message)
        {
            //this.Message = message;
        }
    }
}
