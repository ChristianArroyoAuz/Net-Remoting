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
    public class ComponenteA : MarshalByRefObject
    {
        public ComponenteA()
        {
            Log.Imprimir("Se creo una instancia del Objeto Remoto ComponenteA");
        }

        public string Llamada()
        {
            Log.Imprimir("Se invoco a Llamada()");
            return "ComponenteA.Llamada()";
        }
    }
}