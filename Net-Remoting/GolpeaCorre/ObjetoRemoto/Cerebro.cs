// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 29/06/2016.                                                                              *
// ******************************************************************************************


using System.Runtime.Remoting.Channels;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
using System.Text;
using System;

namespace ObjetoRemoto
{
    public class Cerebro : MarshalByRefObject
    {
        private int xPos, yPos;
        private int x, y;
        private Thread hilo;
        private Random aleatorio;
        private int dimensionCuadrado = 50;

        public Cerebro()
        {
            aleatorio = new Random();
            for (int i = 0; i < 500000; i++)
            {
                aleatorio.Next(100000);
            }
            hilo = new Thread(new ThreadStart(MoverPosicion));
            hilo.Start();
        }

        public int POSX
        {
            get { return xPos; }
        }

        public int POSY
        {
            get { return yPos; }
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public int Dimensiones
        {
            get { return dimensionCuadrado; }
        }

        public void AlmacenarPosicion(int x, int y)
        {
            this.x = x; this.y = y;
        }

        public bool GolpeoAlCuadro(int x, int y)
        {
            return (x >= POSX && x <= POSX + dimensionCuadrado) && (y >= POSY && y <= POSY + dimensionCuadrado);
        }

        public void MoverPosicion()
        {
            while (true)
            {
                Thread.Sleep(2000); xPos = aleatorio.Next(225);
                yPos = aleatorio.Next(150);
            }
        }
    }
}