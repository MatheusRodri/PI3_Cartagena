using CartagenaServer;
using PI3_Cartagena.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
            mapa();

           



  


        }
        public void mover(int boneco ,string pctbox,string  pctBox0,int  posq, Jogador item, int k, int atual)
        {
            for (int j = 0; j < boneco; j++)
            {
                
                
                pctbox = item.piratas[k].nome;
                PictureBox pictureBox = this.Controls.Find(pctbox, true).FirstOrDefault() as PictureBox;
                pctBox0 = pctBox0 + ((posq).ToString());
                PictureBox pictureBoxC = this.Controls.Find(pctBox0, true).FirstOrDefault() as PictureBox;


                if (atual != 0)
                {
                    pictureBox.Location = new Point(pictureBoxC.Location.X, pictureBoxC.Location.Y + 11 * (j + 1) * atual);
                }
                else if (posq == 37)
                {
                    switch (pictureBox.Name) {
                        case"Vermleho":
                            if (j == 3)
                            {
                                int l = j - 3;
                                pictureBox.Location = new Point(651, 20 + 11 * (l + 1) * atual);
                            }
                            else
                            {
                                pictureBox.Location = new Point(638, 20 + 11 * (j + 1) * atual);
                            }
                            break;
                        case "Verde":
                            if (j == 3)
                            {
                                int l = j - 3;
                                pictureBox.Location = new Point(691, 20 + 11 * (l + 1) * atual);
                            }
                            else
                            {
                                pictureBox.Location = new Point(678, 20 + 11 * (j + 1) * atual);
                            }
                            break;
                        case "Amarelo":
                            if (j == 3)
                            {
                                int l = j - 3;
                                pictureBox.Location = new Point(731, 20 + 11 * (l + 1) * atual);
                            }
                            else
                            {
                                pictureBox.Location = new Point(718, 20 + 11 * (j + 1) * atual);
                            }
                            break;
                        case "Azul":
                            if (j == 3)
                            {
                                int l = j - 3;
                                pictureBox.Location = new Point(771, 20 + 11 * (l + 1) * atual);
                            }
                            else
                            {
                                pictureBox.Location = new Point(758, 20 + 11 * (j + 1) * atual);
                            }
                            break;

                    }
                        
                 

                }
                else { pictureBox.Location = new Point(pictureBoxC.Location.X, pictureBoxC.Location.Y + 11 * (j)); } 

                pctBox0 = "pctBox";    
                item.piratas[k].posicao = posq;
                k++;

            }
        }

        public void mapa()
        {
            
            string tabuleiro = Jogo.ExibirTabuleiro(idPartida);
            tabuleiro = tabuleiro.Replace("\r", "");
            string[] posicao = tabuleiro.Split('\n');

            List<int> pos = new List<int>();
            List<string> icone = new List<string>();
            List<PictureBox> img = new List<PictureBox>();

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && !char.IsLetter(control.Name[6]))
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
                else if (posicao[i].Length == 4)
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

            //Mostrar Jogadores


            List<string> lugar = new List<string>();
            string situacao = Jogo.VerificarVez(idPartida);
            situacao = situacao.Replace("\r", "");
            string[] eu = situacao.Split('\n');
            lugar = eu.ToList();
            string jogadorvez = lugar[0];
            List<string> posi = new List<string>();
            List<string> boneco = new List<string>();
            List<string> bonecojogador = new List<string>();


            string vez = lugar[0];
            int posicaoInicial = vez.IndexOf(',');
            int posicaoFinal = vez.LastIndexOf(',');
            foreach (var item in lugar)
            {
                posicaoInicial = item.IndexOf(',');
                posicaoFinal = item.LastIndexOf(',');

                if (lugar.IndexOf(item) == 0 || item == "")
                {
                    continue;
                }
                else if (item == "")
                {
                    continue;
                }
                posi.Add(item.Substring(0, item.IndexOf(',')));
                boneco.Add(item.Substring(item.LastIndexOf(',') + 1));
                bonecojogador.Add(item.Substring(posicaoInicial + 1, posicaoFinal - posicaoInicial - 1));


            }

            posicaoInicial = vez.IndexOf(',');
            posicaoFinal = vez.LastIndexOf(',');

            //Erro: Não pode ser menor que zero
            vez = vez.Substring(posicaoInicial + 1, posicaoFinal - posicaoInicial - 1);
            string contjogadores = Jogo.ListarJogadores(idPartida);
            contjogadores = contjogadores.Replace("\r", "");
            string[] players = contjogadores.Split('\n');

            List<Jogador> jogadoresLista = new List<Jogador>();

            for (int i = 0; i < players.Length - 1; i++)
            {
                int posvirgula1 = players[i].IndexOf(',');
                int posvirgula2 = players[i].LastIndexOf(',');
                int id = Convert.ToInt32(players[i].Substring(0, posvirgula1));
                string nome = players[i].Substring(posvirgula1 + 1, posvirgula2 - posvirgula1 - 1);
                string cor = players[i].Substring(posvirgula2 + 1);
                Jogador jogador = new Jogador(id, cor, nome);

                jogadoresLista.Add(jogador);

            }

            string pctBox0 = "pctBox";
            string pctbox = "pctBoxVm";

            for (int i = 0; i < players.Length - 1; i++)
            {

                switch (players[i].Substring(players[i].LastIndexOf(',') + 1))
                {
                    case "Vermelho":
                        pctbox = "pctBoxVm";

                        break;
                    case "Verde":
                        pctbox = "pctBoxVd";

                        break;
                    case "Amarelo":
                        pctbox = "pctBoxAm";

                        break;
                    case "Azul":
                        pctbox = "pctBoxAz";

                        break;
                }
                for (int j = 1; j <= 6; j++)
                {
                    string pctboxaux = pctbox + j.ToString();
                    PictureBox pictureBox = this.Controls.Find(pctboxaux, true).FirstOrDefault() as PictureBox;
                    pictureBox.Visible = true;

                }
            }
            int aux = 0;

            for (int i = 0; i < posi.Count; i++)
            {
                pctBox0 = "pctBox";
                int posq = Convert.ToInt32(posi[i]);

                if (posq == 0)
                {
                    continue;
                }

                else

                {

                    int atual = 0;
                    if (posi[i] == posi[i - 1] && posi[i] != "0")
                    {
                        int a = Convert.ToInt32(boneco[i]);
                        int b = Convert.ToInt32(boneco[i - 1]);
                        atual = (a + b)-1;
                        
                    }

                    foreach (var item in jogadoresLista)
                    {
                        bool t = true;
                        if (Convert.ToInt32(bonecojogador[i]) == item.id)
                        {
                            switch (item.cor)
                            {
                                case "Vermelho":
                                    int k = 0;
                                    while (t == true)
                                    {

                                        if (item.piratas[k].posicao == 0)
                                        {
                                            aux += 1;

                                            mover(Convert.ToInt32(boneco[i]), pctbox, pctBox0, posq, item, k, atual);
                                            t = false;
                                        }
                                        else k++;
                                    }
                                    break;
                                case "Verde":

                                    k = 0;
                                    while (t == true)
                                    {

                                        if (item.piratas[k].posicao == 0)
                                        {
                                            aux += 1;

                                            mover(Convert.ToInt32(boneco[i]), pctbox, pctBox0, posq, item, k, atual);
                                            t = false;
                                        }
                                        else k++;
                                    }
                                    break;
                                case "Amarelo":
                                    k = 0;
                                    while (t == true)
                                    {

                                        if (item.piratas[k].posicao == 0)
                                        {
                                            aux += 1;
                                           
                                            mover(Convert.ToInt32(boneco[i]), pctbox, pctBox0, posq, item, k, atual);
                                            t = false;
                                        }
                                        else k++;
                                    }
                                    break;
                                case "Azul":
                                    k = 0;
                                    while (t == true)
                                    {

                                        if (item.piratas[k].posicao == 0)
                                        {
                                            aux += 1;
                                           
                                            mover(Convert.ToInt32(boneco[i]), pctbox, pctBox0, posq, item, k, atual);
                                            t = false;
                                        }
                                        else k++;
                                    }
                                    break;
                            }
                        }

                    }


                }

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Tela_Partida tela_Partida = new Tela_Partida();
            tela_Partida.Show();
            Hide();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {

        }
    }
}
