using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_Expendedora
{
    class ConsolaHelp
    {
        public static bool EsOpcionValida(string input, string opcionesValidas)
        {
            // manejamos expciones
            try
            {
                // validamos algo
                if (string.IsNullOrEmpty(input)  // es nulo o vacío
                    || input.Length > 1          // tiene más de un caracter       
                    || !opcionesValidas.ToUpper().Contains(input.ToUpper())) // no está dentro de las opciones válidas
                {
                    return false;
                }

                return true;
            }
            // podemos capturar más exceptions asi mostramos errpores más personalizados
            // en este caso no nos importa arrojar una ex porque decidimos que el método devuelva T o F
            catch
            {
                // podemos mostrar un error

                return false;
            }
        }
    }
}
