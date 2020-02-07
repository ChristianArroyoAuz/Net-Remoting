// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 29/06/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using Componente;
using System;

namespace Componente
{
    public class SumideroEvento : MarshalByRefObject
    {
        private OnEventHandler manipulador;

        public SumideroEvento(OnEventHandler manipulador)
        {
            this.manipulador = manipulador;
        }

        [System.Runtime.Remoting.Messaging.OneWay]
        public void ManipuladorEventoCallback(string texto)
        {
            if (manipulador != null)
            {
                manipulador(texto);
            }
        }

        public void Registrar(Componente miComponente)
        {
            miComponente.ManipuladorEvento += new OnEventHandler(ManipuladorEventoCallback);
        }

        public void Deregistrar(Componente miComponente)
        {
            miComponente.ManipuladorEvento -= new OnEventHandler(ManipuladorEventoCallback);
        }
    }
}