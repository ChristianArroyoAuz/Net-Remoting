// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 29/06/2016.                                                                              *
// ******************************************************************************************


using System.Runtime.Remoting.Messaging;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
using System.Text;
using Componente;
using System;

namespace Cliente
{
    delegate string ObtenerCadena(string arg);

    class Program
    {
        private const int NUMERO_DE_INVOCACIONES = 5;

        private static void OnLlamadaTermina(IAsyncResult res)
        {
            ObtenerCadena manipulador = ((AsyncResult)res).AsyncDelegate as ObtenerCadena;
            int indice = (int)res.AsyncState;
            string resultado = manipulador.EndInvoke(res);
            Log.Imprimir("miContenido.Llamada() #{0} concluyo. El resultado es \"{1}\"", indice, resultado);
        }

        [STAThread]
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("Cliente.exe.config");
            Componente.Componente miComponente = new Componente.Componente();
            Log.Imprimir("Se creo un objeto remoto. Es Proxy? {0}", (RemotingServices.IsTransparentProxy(miComponente) ? "SI" : "NO"));
            for (int i = 1; i <= NUMERO_DE_INVOCACIONES; ++i)
            {
                Log.Imprimir("Invocando a miComponente.Llamada() #{0}...", i);
                ObtenerCadena manipulador = new ObtenerCadena(miComponente.Llamada);
                manipulador.BeginInvoke("Desde Cliente", new AsyncCallback(OnLlamadaTermina), i);
            }
            Log.EsperarParaTerminar("Presione ENTER para salir...");
        }
    }
}