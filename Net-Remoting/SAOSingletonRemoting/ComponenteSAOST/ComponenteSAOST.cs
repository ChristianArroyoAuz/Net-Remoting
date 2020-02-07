// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 29/06/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Text;

namespace ComponenteSAOST
{
    //Me permite el acceso a objetos a través de los límites del dominio de aplicación 
    //en las aplicaciones que trabajan con comunicaciónes remotas
    public class ComponenteSAOST : MarshalByRefObject
    {
        private static int ID = 0;
        private int id;

        public ComponenteSAOST()
        {
            //Dandole valor al id local
            id = System.Threading.Interlocked.Increment(ref ID);
            //Llamado del metodo Imprimir de la Clase Log, me permitara imprimir el identficador
            Log.Imprimir("Se creo una instancia del Objeto Remoto ComponenteSAOST, id={0}", id);
        }

        //Metodo de la primera llamada de la clase Log que no acepta argumentos y me 
        //retorna un string y no acepta argumentos
        public string PrimeraLlamada()
        {
            Log.Imprimir("Se invoco a PrimeraLlamada()");
            return string.Format("ComponenteSAOST.id={0}", id);
        }

        //Metodo de la segunda llamada de la clase Log que no acepta argumentos y me 
        //retorna un string y no acepta argumentos
        public string SegundaLlamada()
        {
            Log.Imprimir("Se invoco a SegundaLlamada()");
            return string.Format("ComponenteSAOST.id={0}", id);
        }
    }
}