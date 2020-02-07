// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 29/06/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;

namespace Componente
{
    public class Componente : MarshalByRefObject
    {
        public string Llamada(string texto)
        {
            Log.Imprimir("Se invoco a Componente.Llamada(\"{0}\")", texto);
            return texto + DateTime.Now.ToString("HH:mm:ss.fff");
        }
    }
}