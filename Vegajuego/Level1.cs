using System.Media;

namespace Vegajuego
{
    public partial class Level1 : Form
    {
        Link Player;
        Broncas Enemigo1;
        public Level1()
        {
            InitializeComponent();
            IniciarPersonajes();
            IniciarOpcionesDelMapa();
        }
        private void IniciarOpcionesDelMapa()
        {
            labelVida.Text = "Salud->" + Player.Salud;
            labelEscudo.Text = "Escudo->" + Player.Escudo;
            labelArma.Text = "Arma->" + Player.Arma;
        }
        private void MovEnemigos_Tick(object sender, EventArgs e)
        {
            labelVida.Text = "Salud->" + Player.Salud;
            labelEscudo.Text = "Escudo->" + Player.Escudo;
            labelArma.Text = "Arma->" + Player.Arma;

            if (Player.Caja.Bounds.IntersectsWith(Enemigo1.Caja.Bounds))
            {
                Player.Salud = Player.Salud - 1;
            }
            Enemigo1.mover();
        }
        private void IniciarPersonajes()
        {

            // Lienzo, coodenadaX, coordenadaY,salud,escudo y arma
            Player = new Link(this, 0, 0, 30, 0, 0);
            Enemigo1 = new Broncas(this, 0, 300);

        }

        private void Level1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Player.mover(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Enemigo1.mover();
        }

        
    }
}
