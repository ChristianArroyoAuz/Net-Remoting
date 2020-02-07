// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 29/06/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using ComponenteCAO;
using System.Linq;
using System.Text;
using System;

namespace ServidorCAO
{
    class Program
    {
        //Indica que el modelo de subprocesos COM para la aplicación es el apartamento de un único subproceso
        [STAThread]
        static void Main(string[] args)
        {
            //Lee el archivo de configuración y configura la infraestructura de comunicación remota.
            RemotingConfiguration.Configure("ServidorCAO.exe.config");
            //Llamado al metodo MostrarTodosLosDatos() de la  Clase Utilidades
            Utilidades.MostrarTodosLosDatos();
            //Llamado al metodo EsperarParaTerminar() de la Clase Log
            Log.EsperarParaTerminar("Presione ENTER para detener al servidor...");
        }
    }
}