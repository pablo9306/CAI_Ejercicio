using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_Expendedora
{
    class CodigoInvalidoException : Exception
    {
        public CodigoInvalidoException(string message)
        {
            //this.Message = message;
        }
    }
}
