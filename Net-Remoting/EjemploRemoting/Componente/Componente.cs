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
    //Me permite el acceso a objetos a través de los límites del dominio de aplicación 
    //en las aplicaciones que trabajan con comunicaciónes remotas
    public class Componente : MarshalByRefObject
    {
        public Componente()
        {
            //Llamado del metodo Imprimir de la Clase Log
            Log.Imprimir("Se creo una instancia del Objeto Remoto Componente");
        }

        public string LlamadaDePrueba()
        {
            //Llamado del metodo Imprimir de la Clase Log retornando como resultado "Componente.LlamadaDePrueba()"
            Log.Imprimir("Se invoco a LlamadaDePrueba()");
            return "Componente.LlamadaDePrueba()";
        }
    }
}