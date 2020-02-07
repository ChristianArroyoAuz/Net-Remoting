// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 29/06/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;
using System.Text;
using System;

namespace GestorDatos
{
    [Serializable]
    public class AlmacenDatos
    {
        private ArrayList nombres = new ArrayList();

        public void AgregarNombre(string nombre)
        {
            nombres.Add(nombre);
        }

        public ArrayList ObtenerNombres()
        {
            return nombres;
        }
    }
}