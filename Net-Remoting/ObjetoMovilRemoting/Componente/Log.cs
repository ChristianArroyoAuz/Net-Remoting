// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 29/06/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
using System.Text;
using System;

namespace Componente
{
    public class Log
    {
        //Creacion de un constructor vacio "Sin Parametros"
        private Log()
        {
        }

        //Metodo Imprimir que retorno un objeto tipo texto a imprimir
        public static void Imprimir(string texto, params object[] args)
        {
            RealizarLog("", texto, args);
        }

        //Metodo para imprimir un mensaje de informacion
        public static void Informacion(string texto, params object[] args)
        {
            RealizarLog("INFO: ", texto, args);
        }

        //Metodo para imprimir un mensaje de advertencia
        public static void Advertencia(string texto, params object[] args)
        {
            RealizarLog("ADVERTENCIA: ", texto, args);
        }

        //Metodo para imprimir un mensaje de error
        public static void Error(string texto, params object[] args)
        {
            RealizarLog("!!!ERROR!!! ", texto, args);
        }

        ////Metodo para imprimir un mensaje antes de salir de la aplicacion 
        public static void EsperarParaTerminar()
        {
            EsperarParaTerminar("Presione ENTER para terminar...");
        }

        public static void EsperarParaTerminar(string mensaje)
        {
            Console.WriteLine();
            Console.WriteLine();
            RealizarLog("", mensaje);
            Console.ReadLine();
        }

        //Metodo para imprimir los mensajes de informacion de tiempo transcurrido entre los diferentes eventos
        // El ID del hilo que se esta ejecutando con su respectivo tiempo de ejecucion
        private static void RealizarLog(string prefijo, string texto, params object[] args)
        {
            int idHilo = Thread.CurrentThread.ManagedThreadId;
            Console.Write("[{0:D4}] [{1}] ", idHilo, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));
            Console.Write(prefijo);
            Console.WriteLine(texto, args);
        }
    }
}