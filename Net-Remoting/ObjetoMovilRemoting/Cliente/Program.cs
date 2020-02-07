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
            Componente.Componente miComponente = new Componente.Componente();
            Log.Imprimir("Se creo miComponenete. Es un proxy? {0}", (RemotingServices.IsTransparentProxy(miComponente) ? "SI" : "NO"));
            Contenedor miContenedorUno = new Contenedor("Desde Cliente", 555);
            Contenedor miContenedorDos = miComponente.RetornaContenedor(miContenedorUno);
            Log.Imprimir("miComponenete.RetornaContenedor() retorno {0}", miContenedorDos);
            Log.EsperarParaTerminar("Presiona ENTER para terminar...");
        }
    }
}