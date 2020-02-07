// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 29/06/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using Componente;
using System;

namespace Cliente
{
    class Program
    {
        //Indica que el modelo de subprocesos COM para la aplicación es el apartamento de un único subproceso.
        [STAThread]
        static void Main(string[] args)
        {
            //Lee el archivo de configuración y configura la infraestructura de comunicación remota.
            RemotingConfiguration.Configure("Cliente.exe.config");
            //Llamado al metodo MostrarTodosLosDatos() de la clase Utilidades
            Utilidades.MostrarTodosLosDatos();
            //Haciendo una nueva instancia de la libreria Componente
            Componente.Componente miComponente = new Componente.Componente();
            //Llamado a los metoddos Imprimir y EsperarParaTerminar de la Clase Log
            Log.Imprimir("miComponente.LlamadaDePrueba() retorno {0}", miComponente.LlamadaDePrueba());
            Log.EsperarParaTerminar("Presione ENTER para salir...");
        }
    }
}