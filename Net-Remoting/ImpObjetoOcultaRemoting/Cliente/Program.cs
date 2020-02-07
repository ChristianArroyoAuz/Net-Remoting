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
            Utilidades.MostrarTodosLosDatos();
            string resultado;
            Log.EsperarParaTerminar("1) Presiona ENTER para crear el objeto remoto...");
            Componente.IComponente miComponente = ObtenerComponente();
            Log.Imprimir("Se creo miComponenete. Es un proxy? {0}", (RemotingServices.IsTransparentProxy(miComponente) ? "SI" : "NO"));
            Log.EsperarParaTerminar("2) Presiona ENTER para probar el objeto remoto...");
            resultado = miComponente.LlamadaUno();
            Log.Imprimir("miComponente.LlamadaUno() retorno {0}", resultado);
            Log.EsperarParaTerminar("Presiona ENTER para terminar...");
        }

        private static IComponente ObtenerComponente()
        {
            return Activator.GetObject(typeof(Componente.IComponente), "tcp://localhost:33000/Componente") as IComponente;
        }
    }
}