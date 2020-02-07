// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 29/06/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using Componente;
using System;

namespace Servidor
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("Servidor.exe.config");
            Utilidades.MostrarTodosLosDatos();
            Log.EsperarParaTerminar("Presione ENTER para detener al servidor...");
        }
    }
}