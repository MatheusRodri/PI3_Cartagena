using CartagenaServer;
using PI3_Cartagena.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI3_Cartagena
{
    public partial class Tela_jogo : Form
    {
        private int idPartida { get; set; }
        private int idUsuario { get; set; }
        private string senhaUsuario { get; set; }
        private string cartaParaJogar { get; set; }
        private int numCartaAjogar { get; set; }
        private string tipoCasaSel { get; set; }
        private int numCasaSel { get; set; }
        private string[] mao { get; set; }
        private string[] casasSeparadas { get; set; }
        private string tabuleiro { get; set; }
        private string[] posicao { get; set; }
        private int posicaoInicial {get; set; }
        private int posicaoFinal { get; set; }

        public Tela_jogo(int idPartida, int idUsuario, string senhaUsuario)
        {
            InitializeComponent();
            this.idPartida = idPartida;
            this.idUsuario = idUsuario;
            this.senhaUsuario = senhaUsuario;

            lbl_idJogador.Text =  $"ID do jogador: {idUsuario.ToString()}";
            //lbl_senhaJogador.Text = $"Senha do jogador: {Esconde(senhaUsuario)}"  ;
            mostrarTabuleiro();
            MostrarCartas();
            mapa();
        }

        //private string Esconde(string senha)
        //{
        //    char[] chars = senha.ToCharArray();

        //    for (int i = 0; i < chars.Length; i++)
        //    {
        //        if (Char.IsLetterOrDigit(chars[i]))
        //        {
        //            chars[i] = '*';
        //        }
        //    }

        //    return new string(chars);
        //}
        public void mapa()
        {
            tabuleiro = Jogo.ExibirTabuleiro(idPartida);
            tabuleiro = tabuleiro.Replace("\r", "");
            posicao = tabuleiro.Split('\n');

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
                    return;
                }

                else

                {

                    int atual = 0;
                    if (posi[i] == posi[i - 1] && posi[i] != "0")
                    {
                        int a = Convert.ToInt32(boneco[i]);
                        int b = Convert.ToInt32(boneco[i - 1]);
                        atual = (a + b) - 1;

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
                else if (posq == 37)
                {
                    switch (pictureBox.Name)
                    {
                        case "Vermleho":
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


        /////////////////////////////////////////////////////////////////////////////////////////
        ///botoes e funcoes deles 



        private void btn_selCarta_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_casaSel_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_andar_Click(object sender, EventArgs e)
        {
            lbl_retornoJogar.Text = Jogo.Jogar(idUsuario, senhaUsuario, numCasaSel, cartaParaJogar);
            mapa();
        }

        private void btn_voltarPirata_Click(object sender, EventArgs e)
        {
            lbl_retornoJogar.Text = Jogo.Jogar(idUsuario, senhaUsuario, numCasaSel);
        }

        private void btn_pularVez_Click(object sender, EventArgs e)
        {
            lbl_retornoJogar.Text = Jogo.Jogar(idUsuario, senhaUsuario);
        }

        

        private void mostrarTabuleiro()
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

        private void MostrarCartas()
        {
            idUsuario = Convert.ToInt32(idUsuario);
            senhaUsuario = senhaUsuario;

            mapa();
            try
            {
                lb_cartas.Items.Clear();

                string cartas = Jogo.ConsultarMao(idUsuario, senhaUsuario);

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
                MessageBox.Show("Erro ao gerar as cartas");
            }
        }

        private void btn_Listar_Click(object sender, EventArgs e)
        {
            MostrarCartas();
        }

        private void tmrVerificarVez_Tick(object sender, EventArgs e)
        {
            

            
            //separação basica
            string retornando = Jogo.VerificarVez(idPartida);
            retornando = retornando.Replace("\r", "");
            string[] arrayRetornando = retornando.Split('\n');

            //dados de quem joga
            string[] jogandoAgora = arrayRetornando[0].Split(',');

            string[] jogadas = { };



            //dados da partida geral
            //for (int i = 1; i < arrayRetornando.Length - 1; i++)
            //{
            //    jogadas[i - 1] = arrayRetornando[i];
            //}


            if (jogandoAgora[1] == idUsuario.ToString())
            {
                string cartasNaMao = Jogo.ConsultarMao(idUsuario, senhaUsuario);
                cartasNaMao = cartasNaMao.Replace("\r", "");
                string[] maoo = cartasNaMao.Split('\n');
                int qtd = 0;
                //string[] cartaQuero = maoo.Split();


                //CODIGO RANDOM AQUI EM BAIXO

                //Lista de posição dos piratas
                List<int> minhaPos = new List<int>();
                Random random = new Random();


                //Alimenta uma lista de onde estão os piratas do jogador
                for (int i = 1; i < arrayRetornando.Length-1; i++)
                {
                    
                    int posicaoInicial = arrayRetornando[i].IndexOf(',');
                    int posicaoFinal = arrayRetornando[i].LastIndexOf(',');


                    if (arrayRetornando[i].Substring(posicaoInicial + 1, posicaoFinal - posicaoInicial - 1) == idUsuario.ToString())
                    {
                        minhaPos.Add(Convert.ToInt32(arrayRetornando[i].Substring(0, posicaoInicial)));
                    }
                }


                for (int i = 0; i < maoo.Length - 1; i++)
                {

                    qtd += (Convert.ToInt32(maoo[i].Substring(2)));

                }

                if (qtd < 3)
                {
                    int valorAleatorio = 0;
                    //gera aleatotio pra não tentar voltar pirata na base
                    while (valorAleatorio == 0)
                    {
                        int indiceAleatorio = random.Next(minhaPos.Count);
                        valorAleatorio = minhaPos[indiceAleatorio];

                        //verifica se a posição anterior ao numero que gerou não é a base se for faz o while denovo
                        if(minhaPos[indiceAleatorio ] == 0 || minhaPos[indiceAleatorio -1] <= 0)
                        {
                            valorAleatorio = 0;
                        }
                    }

                    Jogo.Jogar(idUsuario,senhaUsuario, valorAleatorio);
                }
               
                //JOGA UM pirata aleatorio e uma cart aleatoria
                else
                {
                    int indiceAleatorio = random.Next(minhaPos.Count);
                    int valorAleatorio = minhaPos[indiceAleatorio];
                    indiceAleatorio = random.Next(maoo.Length -1);
                    
                    Jogo.Jogar(idUsuario, senhaUsuario, valorAleatorio, maoo[indiceAleatorio].Substring(0, 1));
                }
            }
            else
            {
                mapa();
                return;
            }
            mapa();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Tela_Jogadores jogadores = new Tela_Jogadores(idPartida);
            jogadores.Show();
            this.Close();
        }

        private void btn_Verificas_Click(object sender, EventArgs e)
        {
            lbl_Jogadas.Text = Jogo.VerificarVez(idPartida);
            Mostra_Historico(idPartida);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tmrVerificarVez.Enabled = true;
        }

        private void lbl_cartaSel_Click(object sender, EventArgs e)
        {

        }

        private void lb_cartas_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
        private void lb_cartas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pega a informacao da cara selecionada na listbox da mao
            string cartaSel = lb_cartas.SelectedItem.ToString();

            //separa carta selecionada (Tipo,numCartas)
            string[] cartaSelecionada = cartaSel.Split(',');

            cartaParaJogar = Convert.ToString(cartaSelecionada[0]);

            numCartaAjogar = Convert.ToInt32(cartaSelecionada[1]);

            lbl_cartaSel.Text = $"Carta selecionada {cartaParaJogar + " " + Convert.ToString(numCartaAjogar)}";
        }

        private void lb_mostraTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pega informacao da casa selecionada

            string casas = lb_mostraTab.SelectedItem.ToString();
            string[] casasSele = casas.Split(',');
            //corta info em num e tipo casa

            //convert informacoes e as passa para as variaveis a ser tratada
            numCasaSel = Convert.ToInt32(casasSele[0]);
            tipoCasaSel = Convert.ToString(casasSele[1]);

            lbl_casaSel.Text = $"Casa selecionada: {tipoCasaSel + " " + Convert.ToString(numCasaSel)}";
        }

        private void Tela_jogo_Load(object sender, EventArgs e)
        {

        }

        private void Mostra_Historico(int partidaAtual)
        {
            string retornoHistorico = Jogo.ExibirHistorico(partidaAtual);
            retornoHistorico = retornoHistorico.Replace("\r", "");
            string[] historico = retornoHistorico.Split('\n');
            for(int i = 0; i < historico.Length; i++)
            {
                lbx_historico.Items.Add(historico[i]);
            }
            

        }
    }
}
