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

namespace ObjetoRemoto
{
    public class Chat : MarshalByRefObject
    {
        private ArrayList clientes = new ArrayList();
        private string sesion = "";

        public void AgregarCliente(string nombre)
        {

            if (nombre != null)
            {
                lock (clientes)
                {
                    clientes.Add(nombre);
                }
            }
        }

        public void RemoverCliente(string nombre)
        {
            lock (clientes)
            {
                clientes.Remove(nombre);
            }
        }

        public void AgregarTexto(string texto)
        {
            if (texto != null)
            {
                lock (sesion)
                {
                    sesion += texto;
                }
            }
        }

        public ArrayList Clientes()
        {
            return clientes;
        }

        public string Sesion()
        {
            return sesion;
        }
    }
}