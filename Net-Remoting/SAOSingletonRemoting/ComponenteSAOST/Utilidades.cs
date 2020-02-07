// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 29/06/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;

namespace ComponenteSAOST
{
    public class Utilidades
    {
        //Metodo estatico para mostrar el tipo de datos de un Arreglo de datos
        private static void MostrarTipoDeDatos(Array arregloDatos)
        {
            //Recorriendo los objetos del arreglo para la impresion
            foreach (object obj in arregloDatos)
            {
                //Lamado al metodo imprimir de la clase Log
                Log.Imprimir("  {0}: {1}", obj.GetType().Name, obj);
            }
        }

        //Metodo de impresion de datos
        public static void MostrarTodosLosDatos()
        {
            Log.Imprimir("TIPOS DE DATOS REGISTRADOS EN REMOTING -(INICIO)- --------");
            //Recupera una matriz de tipos de objetos registrados en el extremo de servicios
            //que puede activarse a petición de un cliente.
            MostrarTipoDeDatos(RemotingConfiguration.GetRegisteredActivatedClientTypes());
            MostrarTipoDeDatos(RemotingConfiguration.GetRegisteredActivatedServiceTypes());
            //Recupera una matriz de tipos de objetos registrados en el cliente final como tipos conocidos.
            MostrarTipoDeDatos(RemotingConfiguration.GetRegisteredWellKnownClientTypes());
            MostrarTipoDeDatos(RemotingConfiguration.GetRegisteredWellKnownServiceTypes());
            Log.Imprimir("TIPOS DE DATOS REGISTRADOS EN REMOTING -(FIN)- ---------");
        }
    }
}