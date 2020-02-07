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
using System.Drawing;
using ObjetoRemoto;
using System.Data;
using System.Linq;
using System.Text;
using System;

namespace ClienteGolpea
{
    public partial class ClienteGolpea : Form
    {
        private Cerebro cerebroJuego;
        private int golpes, fallos;

        public ClienteGolpea()
        {
            InitializeComponent();
            this.SetBounds((Screen.GetBounds(this).Width / 2) - (this.Width / 2),
                           (Screen.GetBounds(this).Height / 2) - (this.Height / 2),
                           this.Width,
                           this.Height,
                           BoundsSpecified.Location);
            HttpChannel canal = new HttpChannel();
            ChannelServices.RegisterChannel(canal, false);
            InicializarObjetoRemoto();
            cerebroJuego = new Cerebro();
        }

        private void InicializarObjetoRemoto()
        {
            RemotingConfiguration.RegisterWellKnownClientType(typeof(Cerebro), "http://localhost:30000/Cerebro");
        }

        private void pnlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = pnlPanel.CreateGraphics();
            g.DrawString("X", Font, new SolidBrush(Color.Blue), e.X, e.Y);
            cerebroJuego.AlmacenarPosicion(e.X, e.Y);
            if (cerebroJuego.GolpeoAlCuadro(e.X, e.Y))
            {
                g.DrawString("H", Font, new SolidBrush(Color.Red), e.X, e.Y); golpes++;
            }
            else
            {
                fallos++;
            }
            lblGolpes.Text = "Golpes: " + golpes.ToString();
            lblFallos.Text = "Fallos: " + fallos.ToString();
        }
    }
}