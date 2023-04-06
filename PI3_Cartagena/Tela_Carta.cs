using CartagenaServer;
using PI3_Cartagena.Classes;
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
    public partial class Tela_Carta : Form
    {

        string[] mao;
        string[] casasSeparadas;

        private int idPartida;
        private int idUsuario;
        private string senhaUsuario;

        string cartaParaJogar;
        int numCartaAjogar;

        
        string tipoCasaSel;
        int numCasaSel;
        public Tela_Carta(int idPartida,int idUsuario,string senhaUsuario)
        {
            InitializeComponent();
            this.idPartida = idPartida;
            this.idUsuario = idUsuario;
            this.senhaUsuario = senhaUsuario;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {               
            lb_cartas.Items.Clear();
            int id = Convert.ToInt32(txt_UserId.Text);
            string senha = txt_SenhaUser.Text;

            string cartas = Jogo.ConsultarMao(id, senha);

            cartas = cartas.Replace("\r", "");
            mao = cartas.Split('\n');
             
            
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
                                    Location = new Point(720, 60 * contador),
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
                                    Location = new Point(720, 60 * contador),
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
                                    Location = new Point(720, 60 * contador),
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
                                    Location = new Point(720, 60 * contador),
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
                                    Location = new Point(720, 60 * contador),
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
                                    Location = new Point(720, 60 * contador),
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
            catch (Exception)
            {

                MessageBox.Show("Partida Não Iniciada");
            }


        }

        private void partidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tela_Carta partida = new Tela_Carta(idPartida, idUsuario,senhaUsuario);
            partida.Show();
            this.Close();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Tela_Partida tela_Partida = new Tela_Partida();
            tela_Partida.Show();
            this.Close();
        }

        private void btn_mostrarTabuleiro_Click(object sender, EventArgs e)
        {
            //tebuleiro por completo (Casa,Tipo)
            string tabuleiro = Jogo.ExibirTabuleiro(idPartida);
            //imprime tabuleiro na list box (lb_tabuleiro)
            tabuleiro.Replace("\r", "");
            casasSeparadas = tabuleiro.Split('\n');
            for (int i = 0; i < casasSeparadas.Length; i++)
            {
                lb_mostraTab.Items.Add(casasSeparadas[i]);
            }
        }

        
        private void btn_selCarta_Click(object sender, EventArgs e)
        {
            //pega a informacao da cara selecionada na listbox da mao
            string cartaSel = lb_cartas.SelectedItem.ToString();

            //separa carta selecionada (Tipo,numCartas)
            string[] cartaSelecionada = cartaSel.Split(',');

            cartaParaJogar = Convert.ToString(cartaSelecionada[0]);

            numCartaAjogar = Convert.ToInt32(cartaSelecionada[1]);

            lbl_cartaSel.Text = cartaParaJogar + " " + Convert.ToString(numCartaAjogar);
        }

        private void btn_casaSel_Click(object sender, EventArgs e)
        {
            //pega informacao da casa selecionada

            string casas = lb_mostraTab.SelectedItem.ToString();
            string[] casasSele = casas.Split(',');
            //corta info em num e tipo casa

            //convert informacoes e as passa para as variaveis a ser tratada
            numCasaSel = Convert.ToInt32(casasSele[0]);
            tipoCasaSel = Convert.ToString(casasSele[1]);

            lbl_casaSel.Text = tipoCasaSel + " " + Convert.ToString(numCasaSel);
        }

        private void btn_andar_Click(object sender, EventArgs e)
        {
            lbl_retornoJogar.Text = Jogo.Jogar(idUsuario, senhaUsuario, numCasaSel, cartaParaJogar);
        }

        private void btn_voltarPirata_Click(object sender, EventArgs e)
        {
            lbl_retornoJogar.Text = Jogo.Jogar(idUsuario, senhaUsuario, numCasaSel);
        }

        private void btn_pularVez_Click(object sender, EventArgs e)
        {
            lbl_retornoJogar.Text = Jogo.Jogar(idUsuario, senhaUsuario);
        }

        private void btnTabuleiro_Click(object sender, EventArgs e)
        {
            Tela_Tabuleiro tela_Carta = new Tela_Tabuleiro(idPartida);
            tela_Carta.Show();
            this.Close();
        }
    }
}
