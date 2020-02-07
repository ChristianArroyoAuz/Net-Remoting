// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 29/06/2016.                                                                              *
// ******************************************************************************************


using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;

namespace Componente
{
    [Serializable]
    public class ExcepcionRemota : ApplicationException
    {
        private string mensajeAdicional;

        public ExcepcionRemota(string mensaje, string mensajeExtra) : base(mensaje)
        {
            mensajeAdicional = mensajeExtra;
        }

        public ExcepcionRemota(SerializationInfo info, StreamingContext contexto) : base(info, contexto)
        {
            mensajeAdicional = info.GetString("mensajeAdicional");
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext contexto)
        {
            base.GetObjectData(info, contexto);
            info.AddValue("mensajeAdicional", mensajeAdicional);
        }

        public string MensajeAdicional
        {
            get { return mensajeAdicional; }
        }
    }
}