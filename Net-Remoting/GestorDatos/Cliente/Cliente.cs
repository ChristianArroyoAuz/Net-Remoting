// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 29/06/2016.                                                                              *
// ******************************************************************************************


using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using System.Collections;
using GestorDatos;
using System.Linq;
using System.Text;
using System;

namespace Cliente
{
    public class Cliente
    {
        public Cliente(string nombre)
        {
            HttpChannel canal = new HttpChannel();
            ChannelServices.RegisterChannel(canal, false);
            InicializarObjetoRemoto();
            this.AgregarNombre(new GestorDatos.GestorDatos(), nombre);
        }

        // Metodo Factory
        private void InicializarObjetoRemoto()
        {
            RemotingConfiguration.RegisterWellKnownClientType(typeof(GestorDatos.GestorDatos), "http://localhost:30000/GestorDatos");
        }

        private void AgregarNombre(GestorDatos.GestorDatos objetoRemoto, String nombre)
        {
            objetoRemoto.AgregarDato(nombre);
            ArrayList nombres = objetoRemoto.ObtenerDatos();
            foreach (string elemento in nombres)
            {
                Console.WriteLine(elemento);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Agregando el nombre: " + args[0] + " a la lista...");
            new Cliente(args[0]);
            Console.WriteLine("Presione ENTER para concluir...");
            Console.ReadLine();
        }
    }
}