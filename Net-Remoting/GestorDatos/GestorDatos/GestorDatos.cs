// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 29/06/2016.                                                                              *
// ******************************************************************************************


using System.Runtime.Remoting.Channels;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;
using System.Text;
using System;

namespace GestorDatos
{
    public class GestorDatos : MarshalByRefObject
    {
        private AlmacenDatos almacen;

        public GestorDatos()
        {
            almacen = new AlmacenDatos();
        }

        public void AgregarDato(string nombre)
        {
            almacen.AgregarNombre(nombre);
        }

        public ArrayList ObtenerDatos()
        {
            return almacen.ObtenerNombres();
        }
    }
}