// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 29/06/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using ComponenteSAOST;
using System.Linq;
using System.Text;
using System;

namespace ClienteSOA
{
    class Program
    {
        //Indica que el modelo de subprocesos COM para la aplicación es el apartamento de un único subproceso.
        [STAThread]
        static void Main(string[] args)
        {
            //Lee el archivo de configuración y configura la infraestructura de comunicación remota.
            RemotingConfiguration.Configure("ClienteSAO.exe.config");
            //Llamado al metodo MostrarTodosLosDatos() de la clase Utilidades
            Utilidades.MostrarTodosLosDatos();
            string resultado;
            //Imprimiendo mensaje de espera de la clase Log
            Log.EsperarParaTerminar("1) Presione ENTER para crear el objeto remoto…");
            //Haciendo una nueva instancia de la libreria ComponenteSAOST
            ComponenteSAOST.ComponenteSAOST miComponente = new ComponenteSAOST.ComponenteSAOST();
            //Lamando a los metodos PrimeraLlamada() y SegundaLLamada() alternadamente despues del Enter
            //Se imprimra el estado del proxy correspondiente a cada llamada
            Log.Imprimir("miComponente ha sido creado. Es Proxy? {0}", (RemotingServices.IsTransparentProxy(miComponente) ? "SI" : "NO"));
            Log.EsperarParaTerminar("2) Presione ENTER para usar el primer metodo…");
            resultado = miComponente.PrimeraLlamada();
            Log.Imprimir("miComponente.PrimeraLlamada() retorno: {0}", resultado);
            Log.EsperarParaTerminar("3) Presione ENTER para usar el segundo metodo…");
            resultado = miComponente.SegundaLlamada();
            Log.Imprimir("miComponente.SegundaLlamada() retorno: {0}", resultado);
            Log.EsperarParaTerminar("4) Presione ENTER para crear un nuevo objeto remoto…");
            //Creacion de un nuevo ojeto remoto e impresion del estado del proxy del objeto
            ComponenteSAOST.ComponenteSAOST otroComponente = new ComponenteSAOST.ComponenteSAOST();
            Log.Imprimir("otroComponente ha sido creado. Es Proxy? {0}", (RemotingServices.IsTransparentProxy(otroComponente) ? "SI" : "NO"));
            Log.EsperarParaTerminar("5) Presione ENTER para usar el primer metodo…");
            //Lamando al metodo PrimeraLlamada()
            resultado = otroComponente.PrimeraLlamada();
            Log.Imprimir("otroComponente.PrimeraLlamada() retorno: {0}", resultado);
            Log.EsperarParaTerminar("Presione ENTER para salir...");
        }
    }
}