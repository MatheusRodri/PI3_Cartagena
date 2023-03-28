using CartagenaServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI3_Cartagena
{
    public partial class Carta : Form
    {
        public Carta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_cartas.Items.Clear();
            int id = Convert.ToInt32(txt_UserId.Text);
            string senha = txt_SenhaUser.Text;

            string cartas = Jogo.ConsultarMao(id, senha);

            cartas = cartas.Replace("\r", "");
            string[] mao = cartas.Split('\n');
            List<int> qtd = new List<int>();
            List<string> icone = new List<string>();

            for (int i = 0; i < mao.Length; i++)
            {
                lb_cartas.Items.Add(mao[i]);
            }
            for (int i = 0; i < mao.Length; i++)
            {
                if (mao[i].Length >= 3)
                {
                    qtd.Add(Convert.ToInt32(mao[i].Substring(2)));
                    icone.Add(mao[i].Substring(0, mao[i].Length - 2));
                }
            }
            int contador = 1;
            int posQtd = 0;
            // "C", "T", "E", "F", "G", "P"
            foreach (var item in icone)
            {
                switch (item)
                {
                    case "C":
                        for (int j = 0; j < qtd[posQtd]; j++)
                        {
                            var picture = new PictureBox
                            {
                                Name = "pictureBox",
                                Size = new Size(40, 50),
                                Location = new Point(550, 60 * contador),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Image = Image.FromFile("Icones/Chave.png"),
                            };
                            this.Controls.Add(picture);                          
                            contador++;

                        }
                        posQtd++;
                        break;
                    case "T":
                        for (int j = 0; j < qtd[posQtd]; j++)
                        {
                            var picture = new PictureBox
                            {
                                Name = "pictureBox",
                                Size = new Size(40, 50),
                                Location = new Point(550, 60 * contador),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Image = Image.FromFile("Icones/Tricornio.jpg"),
                            };
                            this.Controls.Add(picture);
                            contador++;

                        }
                        posQtd++;
                        break;

                    case "E":
                        for (int j = 0; j < qtd[posQtd]; j++)
                        {
                            var picture = new PictureBox
                            {
                                Name = "pictureBox",
                                Size = new Size(40, 50),
                                Location = new Point(550, 60 * contador),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Image = Image.FromFile("Icones/Esqueleto.jpg"),
                            };
                            this.Controls.Add(picture);
                            contador++;

                        }
                        posQtd++;
                        break;
                    case "F":
                        for (int j = 0; j < qtd[posQtd]; j++)
                        {
                            var picture = new PictureBox
                            {
                                Name = "pictureBox",
                                Size = new Size(40, 50),
                                Location = new Point(550, 60 * contador),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Image = Image.FromFile("Icones/Faca.jpg"),
                            };
                            this.Controls.Add(picture);
                            contador++;

                        }
                        posQtd++;
                        break;
                    case "G":
                        for (int j = 0; j < qtd[posQtd]; j++)
                        {
                            var picture = new PictureBox
                            {
                                Name = "pictureBox",
                                Size = new Size(40, 50),
                                Location = new Point(550, 60 * contador),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Image = Image.FromFile("Icones/Garrafa.jpg"),

                            };
                            this.Controls.Add(picture);
                            contador++;

                        }
                        posQtd++;
                        break;
                    case "P":
                        for (int j = 0; j < qtd[posQtd]; j++)
                        {
                            var picture = new PictureBox
                            {
                                Name = "pictureBox",
                                Size = new Size(40, 50),
                                Location = new Point(550, 60 * contador),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Image = Image.FromFile("Icones/Pistola.jpg"),
                            };
                            this.Controls.Add(picture);
                            contador++;
                        }
                        posQtd++;
                        break;
                }
            }

        }

        private void partidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Carta partida = new Carta();
            partida.Show();
            this.Close();
        }
    }
}
