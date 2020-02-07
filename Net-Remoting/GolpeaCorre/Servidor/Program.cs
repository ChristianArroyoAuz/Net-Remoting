// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 29/06/2016.                                                                              *
// ******************************************************************************************


using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using ObjetoRemoto;
using System.Linq;
using System.Text;
using System;

namespace Servidor
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            HttpChannel canal = new HttpChannel(30000);
            ChannelServices.RegisterChannel(canal, false);
            Console.WriteLine("Iniciando el servidor");
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Cerebro), "Cerebro", WellKnownObjectMode.Singleton);
            Console.WriteLine("Presione ENTER para concluir..."); Console.ReadLine();
        }
    }
}