using CartagenaServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI3_Cartagena
{
    public partial class Tela_Tabuleiro : Form
    {
        private int idPartida;
        public Tela_Tabuleiro(int idPartida)
        {

            InitializeComponent();
            this.idPartida = idPartida;
            string tabuleiro = Jogo.ExibirTabuleiro(idPartida);
            tabuleiro = tabuleiro.Replace("\r", "");
            string[] posicao = tabuleiro.Split('\n');

            List<int> pos = new List<int>();
            List<string> icone = new List<string>();
            List<PictureBox> img = new List<PictureBox>();

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    img.Add((PictureBox)control);
                }
            }

            img.Reverse();

            pos.Add(0);
            icone.Add("B");
            for (int i = 1; i < posicao.Length; i++)
            {

                if (posicao[i].Length == 3)
                {
                    pos.Add(Convert.ToInt32(posicao[i].Substring(0, posicao[i].Length - 2)));
                    icone.Add(posicao[i].Substring(2));
                }
                else if(posicao[i].Length == 4)
                {
                    pos.Add(Convert.ToInt32(posicao[i].Substring(0, posicao[i].Length - 2)));
                    icone.Add(posicao[i].Substring(3));
                }
            }
            for (int i = 1; i < icone.Count - 1; i++)
            {
                switch (icone[i])
                {
                    case "C":
                        img[i].Image = Image.FromFile("Icones/Chave.png");

                        break;
                    case "E":
                        img[i].Image = Image.FromFile("Icones/Esqueleto.jpg");

                        break;
                    case "T":
                        img[i].Image = Image.FromFile("Icones/Tricornio.jpg");

                        break;
                    case "F":
                        img[i].Image = Image.FromFile("Icones/Faca.jpg");

                        break;
                    case "G":
                        img[i].Image = Image.FromFile("Icones/Garrafa.jpg");

                        break;
                    case "P":
                        img[i].Image = Image.FromFile("Icones/Pistola.jpg");

                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tela_Partida tela_Partida = new Tela_Partida();
            tela_Partida.Show();
            Hide();
        }
    }
}
