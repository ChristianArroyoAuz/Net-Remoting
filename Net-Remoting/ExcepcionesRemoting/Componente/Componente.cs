// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 29/06/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;

namespace Componente
{
    public class Componente : MarshalByRefObject
    {
        public void LlamadaUno()
        {
            throw new ExcepcionRemota("Texto para excepción generica", "Texto Extra");
        }

        public void LlamadaDos()
        {
            throw new Exception("Texto para excepción estandar");
        }
    }
}