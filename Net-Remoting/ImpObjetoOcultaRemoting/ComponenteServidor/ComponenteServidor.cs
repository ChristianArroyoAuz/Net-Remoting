// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 29/06/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using Componente;
using System;

namespace ComponenteServidor
{
    public class ComponenteServidor : MarshalByRefObject, IComponente
    {
        private static int ID = 0;
        private int id;

        public ComponenteServidor()
        {
            id = System.Threading.Interlocked.Increment(ref ID);
            Log.Imprimir("Se creo una instancia del Objeto Remoto Componente, Componente.id={0}", id);
        }

        public string LlamadaUno()
        {
            Log.Imprimir("Se invoco a LlamadaUno(), Componente.id={0}", id);
            return string.Format("Componente.id={0}", id);
        }

        public string LlamadaDos()
        {
            Log.Imprimir("Se invoco a LlamadaDos(), Componente.id={0}", id);
            return string.Format("Componente.id={0}", id);
        }
    }
}