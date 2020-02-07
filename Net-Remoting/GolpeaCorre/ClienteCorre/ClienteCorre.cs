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

namespace ClienteCorre
{
    public partial class ClienteCorre : Form
    {
        private Cerebro cerebroJuego;
        private Thread hilo;

        public ClienteCorre()
        {
            InitializeComponent();
            this.SetBounds(0, 0, this.Width, this.Height);
            HttpChannel canal = new HttpChannel();
            ChannelServices.RegisterChannel(canal, false);
            InicializarObjetoRemoto();
            cerebroJuego = new Cerebro();
            hilo = new Thread(new ThreadStart(Pulso));
            hilo.Start();
        }

        private void InicializarObjetoRemoto()
        {
            RemotingConfiguration.RegisterWellKnownClientType(typeof(Cerebro), "http://localhost:30000/Cerebro");
        }

        private void Pulso()
        {
            while (true)
            {
                Thread.Sleep(500);
                pnlPanel.Invalidate();
            }
        }

        private void pnlPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(new Pen(new SolidBrush(Color.Blue)),
                            cerebroJuego.POSX,
                            cerebroJuego.POSY,
                            cerebroJuego.Dimensiones,
                            cerebroJuego.Dimensiones);
            if (cerebroJuego.X != 0 && cerebroJuego.Y != 0)
            {
                g.DrawString("X", Font, new SolidBrush(Color.Red), cerebroJuego.X, cerebroJuego.Y);
            }
        }
    }
}