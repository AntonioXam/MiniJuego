using System.Media;

namespace Vegajuego
{
    public partial class Level1 : Form
    {
        Link Player;
        public Level1()
        {
            InitializeComponent();
            IniciarPersonajes();
        }

        private void IniciarPersonajes()
        {

            // Lienzo, coodenadaX, coordenadaY,salud,escudo y arma
            Player = new Link(this, 0, 0, 30, 0, 0);

        }
    }
}
