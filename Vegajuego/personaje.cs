using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegajuego
{
    internal class Personaje
    {
        private int coordX;
        private int coordY;
        private Level1 lienzo;
        private PictureBox caja = new PictureBox();
        private String direccion;

        public Personaje(Level1 VegaZelda, int x,int y) 
        {
            coordX = x;
            coordY = y;
            lienzo = VegaZelda;
            direccion = "Derecha";
            caja.Location = new System.Drawing.Point(coordX,coordY);
            caja.BackColor = System.Drawing.Color.Transparent; ;
            caja.Size = new System.Drawing.Size(110, 110);
            caja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            caja.BackgroundImage = global::Vegajuego.Properties.Resources.derecha;

            VegaZelda.Controls.Add(caja); caja.Visible = true;
        }
        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public int Coordy
        {
            get { return coordY; }
            set { coordY = value; }
        }
        public int CoordX
        {
            get { return coordX; }
            set { coordX = value; }
        }
        public Level1 Lienzo
        {
            get { return lienzo; }
            set {  Lienzo =value; }
        }
        public PictureBox Caja
        {
            get { return caja; }
            set { caja = value; }
        }
        public void mover()
        {

        }


    }
}
