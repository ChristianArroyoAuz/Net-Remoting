// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 29/06/2016.                                                                              *
// ******************************************************************************************


using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using System.Drawing;
using ObjetoRemoto;
using System.Data;
using System.Linq;
using System.Text;
using System;

namespace Cliente
{
    public partial class Chat : Form
    {
        private ObjetoRemoto.Chat objetoRemoto;
        private string nombre;
        private Thread hilo;

        public Chat()
        {
            InitializeComponent();
        }

        private void InicializarObjetoRemoto()
        {
            RemotingConfiguration.RegisterWellKnownClientType(typeof(ObjetoRemoto.Chat), "http://localhost:30000/Chat");
        }

        private void Poleo()
        {
            while (true)
            {
                Thread.Sleep(1000);
                ArrayList clientes = objetoRemoto.Clientes();
                lstMiembros.Invoke(new Action(() => lstMiembros.Items.Clear()));
                foreach (string nombreCliente in clientes)
                {
                    lstMiembros.Invoke(new Action(() => lstMiembros.Items.Add(nombreCliente)));
                }
                String texto = objetoRemoto.Sesion();
                rtxHistorial.Invoke(new Action(() => rtxHistorial.Clear()));
                rtxHistorial.Invoke(new Action(() => rtxHistorial.Text = texto));




                listBox1.Invoke(new Action(() => listBox1.Items.Clear()));

                listBox1.Invoke(new Action(() => listBox1.Items.Add(texto)));
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                this.nombre = login.nombreUsuario;
                HttpChannel canal = new HttpChannel();
                ChannelServices.RegisterChannel(canal, false);
                InicializarObjetoRemoto();
                objetoRemoto = new ObjetoRemoto.Chat();
                objetoRemoto.AgregarCliente(this.nombre);
                hilo = new Thread(new ThreadStart(Poleo));
                hilo.Start();
            }
            else
            {
                MessageBox.Show("Si no proporciona un nombre de usuario no puede continuar");
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (objetoRemoto != null)
            {
                objetoRemoto.RemoverCliente(this.nombre);
                lstMiembros.Items.Clear();
                lstMiembros.Items.Add("No se encuentra conectado...");
                hilo.Abort();
                rtxHistorial.Clear();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEnviar.Clear();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (objetoRemoto != null)
            {
                string texto = nombre + ": \n"; objetoRemoto.AgregarTexto(texto + txtEnviar.Text + "\n\n");
            }
        }
    }
}