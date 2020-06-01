using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpendedoraCapas.Entidades;

namespace ExpendedoraCapas.Negocio
{
    public class MostrarLatasAceptadas
    { 
    
        public static void MostrarLatas(Expendedora expendedora)
        {
            Console.Clear();
            var lataCreada = expendedora.Lata.Select(x => x.Codigo).Distinct();

            foreach (var item in lataCreada)
            {
                Lata l = expendedora.Lata.Find(x => x.Codigo == item);
                
                Console.WriteLine(l.Codigo + " " + l.Nombre + " " + l.Sabor);
            }

        }
    }
}
