using System.Media;

namespace Vegajuego
{
    public partial class Level1 : Form
    {
        Link Player;
        Broncas Enemigo1;
        SoundPlayer musica;
        Boolean HaySonido = false;
        public Level1(CheckBox onOff)
        {
            InitializeComponent();
            IniciarPersonajes();
            IniciarOpcionesDelMapa(onOff);

        }
        private void IniciarOpcionesDelMapa(CheckBox onOff)
        {
            if (onOff.Checked == true)
            {
                musica = new SoundPlayer(global::Vegajuego.Properties.Resources.sonido);
                musica.PlayLooping();
                HaySonido |= true;
            }
            labelVida.Text = "Salud->" + Player.Salud;
            labelEscudo.Text = "Escudo->" + Player.Escudo;
            labelArma.Text = "Arma->" + Player.Arma;
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
            {
                labelVida.Text = "Salud->" + Player.Salud;
                labelEscudo.Text = "Escudo->" + Player.Escudo;
                labelArma.Text = "Arma->" + Player.Arma;

                if (Player.Caja.Bounds.IntersectsWith(Enemigo1.Caja.Bounds))
                {
                    Player.Salud = Player.Salud - 1;
                }
                Enemigo1.mover();

                if (Player.Salud <= 0)
                {
                    this.Hide();
                    if(HaySonido == true)
                    {
                        musica.Stop();
                    }
                    Final End = new Final();
                    MovEnemigos.Stop();
                    End.Show();
                }
            }
        }

        private void Leve1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
