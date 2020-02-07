﻿// ******************************************************************************************
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
        public Contenedor RetornaContenedor(Contenedor entrada)
        {
            Log.Imprimir("Se invoco RetornaContenedor(), se obtuvo {0}", entrada);
            return new Contenedor("abc", 123);
        }
    }
}