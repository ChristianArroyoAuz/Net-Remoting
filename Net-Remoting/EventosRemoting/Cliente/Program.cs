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
    class Cliente : IDisposable
    {
        private Componente.Componente miComponente;
        private SumideroEvento sumidero;

        public Cliente()
        {
            Log.Imprimir("Cliente()");
            // Creo el proxy para el objeto remoto 
            miComponente = new Componente.Componente();
            // creo el sumidero de eventos             
            sumidero = new SumideroEvento(new OnEventHandler(ManipuladorEventoCallback));
            // registro el manipulador de evento con el sumidero         
            sumidero.Registrar(miComponente);
        }

        ~Cliente()
        {
            (this as IDisposable).Dispose();
        }

        public void ManipuladorEventoCallback(string texto)
        {
            Log.Imprimir("Obtuve texto mediante un callback! {0}", texto);
        }

        public void Prueba()
        {
            Log.Imprimir("miComponente.LlamadaUno() retorno {0}", miComponente.LlamadaUno());
        }

        void IDisposable.Dispose()
        {
            // se deregistra el manipulador del objeto remoto      
            sumidero.Deregistrar(miComponente);
            GC.SuppressFinalize(this);
            Log.Imprimir("Cliente.Dispose()");
        }

        [STAThread]
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("Cliente.exe.config");
            Utilidades.MostrarTodosLosDatos();

            using (Cliente c = new Cliente())
            {
                c.Prueba();
                Log.EsperarParaTerminar("Presiona ENTER para terminar...");
                GC.KeepAlive(c);
            }
        }
    }
}