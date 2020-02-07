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
    public delegate void OnEventHandler(string mensaje);

    public class Componente : MarshalByRefObject
    {
        public event OnEventHandler ManipuladorEvento;

        public Componente()
        {
            Log.Imprimir("Se creo una instancia de Componente");
        }

        public string LlamadaUno()
        {
            PublicarEvento_PlanificarOtro("Evento desde Servidor: se invoco a LlamadaUno()");
            return "Componente.LlamadaUno()";
        }

        private void PublicarEvento(string mensaje)
        {
            Log.Imprimir("Publicando \"{0}\"...", mensaje);
            if (ManipuladorEvento != null)
            {
                ManipuladorEvento(mensaje);
            }
            else
            {
                Log.Imprimir("Hora de publicar un evento, pero no hay suscriptores");
            }
        }

        private void PublicarEvento_PlanificarOtro(string texto)
        {
            PublicarEvento(texto);
            Thread hilo = new Thread(new ThreadStart(PublicarEventoEnCincoSeg));
            hilo.Start();
        }

        private void PublicarEventoEnCincoSeg()
        {
            Thread.Sleep(5000);
            PublicarEvento("Han pasado 5 segundos desde una llamada a un método");
        }
    }
}