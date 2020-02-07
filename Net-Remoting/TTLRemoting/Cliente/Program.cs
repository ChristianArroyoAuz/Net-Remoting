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
        [STAThread]
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("Cliente.exe.config");
            Utilidades.MostrarTodosLosDatos();
            string resultado;
            Log.EsperarParaTerminar("1) Presione ENTER para crear un nuevo objeto remoto…");
            Componente.Componente miComponente = new Componente.Componente();
            Log.Imprimir("miComponente ha sido creado. Es Proxy? {0}", (RemotingServices.IsTransparentProxy(miComponente) ? "SI" : "NO"));
            Log.EsperarParaTerminar("2) Presione ENTER para usar el primer metodo…");
            resultado = miComponente.LlamadaUno();
            Log.Imprimir("miComponente.LlamadaUno() retorno: {0}", resultado);
            Log.EsperarParaTerminar("3) Presione ENTER para usar el segundo metodo…");
            resultado = miComponente.LlamadaDos();
            Log.Imprimir("miComponente.LlamadaDos() retorno: {0}", resultado);
            Log.EsperarParaTerminar("4) Presione ENTER para crear un nuevo objeto remoto…");
            Componente.Componente otroComponente = new Componente.Componente();
            Log.Imprimir("otroComponente ha sido creado. Es Proxy? {0}", (RemotingServices.IsTransparentProxy(otroComponente) ? "SI" : "NO"));
            Log.EsperarParaTerminar("5) Presione ENTER para usar el primer metodo…");
            resultado = otroComponente.LlamadaUno();
            Log.Imprimir("otroComponente.LlamadaUno() retorno: {0}", resultado);
            Log.EsperarParaTerminar("Presione ENTER para salir...");
        }
    }
}