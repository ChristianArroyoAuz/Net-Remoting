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
    [Serializable]
    public class Contenedor
    {
        private string cadena;
        private int numero;

        public string Cadena
        {
            get { return cadena; }
        }
        public int Numero
        {
            get { return numero; }
        }

        public Contenedor(string cadena, int numero)
        {
            this.cadena = cadena;
            this.numero = numero;
        }
        public override string ToString()
        {
            return string.Format("Contenedor[cadena=\"{0}\",numero={1}]", Cadena, Numero);
        }
    }
}