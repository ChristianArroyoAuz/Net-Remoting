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
    public class ComponenteB : MarshalByRefObject
    {
        public ComponenteB()
        {
            Log.Imprimir("Se creo una instancia del Objeto Remoto ComponenteB");
        }

        public string Llamada()
        {
            Log.Imprimir("Se invoco a Llamada()");
            return "ComponenteB.Llamada()";
        }
    }
}