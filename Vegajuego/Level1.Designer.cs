namespace Vegajuego
{
    partial class Level1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            MovEnemigos = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            labelVida = new Label();
            pictureBox2 = new PictureBox();
            labelEscudo = new Label();
            labelArma = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // MovEnemigos
            // 
            MovEnemigos.Enabled = true;
            MovEnemigos.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.salud;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(596, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 39);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelVida
            // 
            labelVida.AutoSize = true;
            labelVida.BackColor = Color.Transparent;
            labelVida.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelVida.ForeColor = Color.Gold;
            labelVida.Location = new Point(645, 145);
            labelVida.Name = "labelVida";
            labelVida.Size = new Size(46, 23);
            labelVida.TabIndex = 1;
            labelVida.Text = "Vida";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.escudo;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(596, 170);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 39);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // labelEscudo
            // 
            labelEscudo.AutoSize = true;
            labelEscudo.BackColor = Color.Transparent;
            labelEscudo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelEscudo.ForeColor = Color.Gold;
            labelEscudo.Location = new Point(645, 190);
            labelEscudo.Name = "labelEscudo";
            labelEscudo.Size = new Size(65, 23);
            labelEscudo.TabIndex = 3;
            labelEscudo.Text = "Escudo";
            // 
            // labelArma
            // 
            labelArma.AutoSize = true;
            labelArma.BackColor = Color.Transparent;
            labelArma.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelArma.ForeColor = Color.Gold;
            labelArma.Location = new Point(645, 231);
            labelArma.Name = "labelArma";
            labelArma.Size = new Size(54, 23);
            labelArma.TabIndex = 4;
            labelArma.Text = "Arma";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.Arma;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(596, 215);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 39);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // Level1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.FondoFinal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(804, 459);
            Controls.Add(pictureBox3);
            Controls.Add(labelArma);
            Controls.Add(labelEscudo);
            Controls.Add(pictureBox2);
            Controls.Add(labelVida);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Level1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VegaZelda";
            FormClosed += Leve1_FormClosed;
            KeyPress += Level1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer MovEnemigos;
        private PictureBox pictureBox1;
        private Label labelVida;
        private PictureBox pictureBox2;
        private Label labelEscudo;
        private Label labelArma;
        private PictureBox pictureBox3;
    }
}
