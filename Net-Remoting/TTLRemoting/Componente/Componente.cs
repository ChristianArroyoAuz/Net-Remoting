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
        private static int ID = 0;
        private int id;

        public Componente()
        {
            id = System.Threading.Interlocked.Increment(ref ID);
            Log.Imprimir("Se creo una instancia del Objeto Remoto Componente, Componente.id={0}", id);
        }

        ~Componente()
        {
            Log.Imprimir("Se destruyo una instancia del Objeto Remoto Componente2");
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