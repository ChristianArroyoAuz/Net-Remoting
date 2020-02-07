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
            try
            {
                miComponente.LlamadaUno();
            }
            catch (ExcepcionRemota ex)
            {
                Log.Imprimir("Se capturo una ExcepcionRemota: mensaje=\"{0}\", msg.extra=\"{1}\"", ex.Message, ex.MensajeAdicional);
            }

            try
            {
                miComponente.LlamadaDos();
            }
            catch (Exception ex)
            {
                Log.Imprimir("Se capture una Exception: mensaje=\"{0}\"", ex.Message);
            }
            Log.EsperarParaTerminar("Presiona ENTER para terminar...");
        }
    }
}