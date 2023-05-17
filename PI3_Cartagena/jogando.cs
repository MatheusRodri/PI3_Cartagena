using CartagenaServer;
using PI3_Cartagena.Classes;
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
    public partial class jogando : Form
    {

        private int idPartida;
        private int idUsuario;
        private string senhaUsuario;


        string cartaParaJogar;
        int numCartaAjogar;


        string tipoCasaSel;
        int numCasaSel;

        string[] mao;
        string[] casasSeparadas;

        public jogando(int idPartida, int idUsuario, string senhaUsuario)
        {
                     
            InitializeComponent();
            this.idPartida = idPartida;
            this.idUsuario = idUsuario;
            this.senhaUsuario = senhaUsuario;


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
            /*
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
            }*/

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


           
            //Erro aqui
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
                    if (posi[i] == posi[i - 1])
                    {
                        atual++;
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
                                            pctbox = item.piratas[k].nome;
                                            item.piratas[k].posicao = posq;
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
                                            pctbox = item.piratas[k].nome;
                                            item.piratas[k].posicao = posq;
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



        public void mover(int boneco, string pctbox, string pctBox0, int posq, Jogador item, int k, int atual)
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
                pictureBox.Location = new Point(pictureBoxC.Location.X, pictureBoxC.Location.Y + 11 * (j));
                pctBox0 = "pctBox";

                item.piratas[k].posicao = posq;
                k++;

            }
        }


        /////////////////////////////////////////////////////////////////////////////////////////
        ///botoes e funcoes deles 

        private void btnPartida_Click(object sender, EventArgs e)
        {
            idUsuario = Convert.ToInt32(txtUser.Text);
            senhaUsuario = txtSenhaU.Text;
            string jogador = Jogo.IniciarPartida(idUsuario, senhaUsuario);

            MessageBox.Show($"Jogador: {jogador} iniciara");
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

        private void btn_mostratab_Click(object sender, EventArgs e)
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

        private void btn_Listar_Click(object sender, EventArgs e)
        {

            try
            {
                lb_cartas.Items.Clear();

                int id = Convert.ToInt32(txtUser.Text);
                string senha = txtSenhaU.Text;

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

        private void tmrVerificarVez_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Verificar vez");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
