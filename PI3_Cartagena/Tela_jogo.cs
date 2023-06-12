using CartagenaServer;
using PI3_Cartagena.Classes;
using System;
using System.Collections;
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
        private int posicaoInicial { get; set; }
        private int posicaoFinal { get; set; }



        public Tela_jogo(int idPartida, int idUsuario, string senhaUsuario)
        {
            InitializeComponent();
            this.idPartida = idPartida;
            this.idUsuario = idUsuario;
            this.senhaUsuario = senhaUsuario;

            lbl_idJogador.Text = $"ID do jogador: {idUsuario.ToString()}";
            mostrarTabuleiro();
            MostrarCartas();
            mapa();
        }

        public void mapa()
        {
            try
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
                    string pozi = "";
                    pctBox0 = "pctBox";
                    int posq = Convert.ToInt32(posi[i]);

                    if (posq == 0)
                    {
                        continue;
                    }
                    else
                    {
                        if (i != 0)
                        {
                            pozi = posi[i - 1];
                        }

                        int atual = 0;
                        if (posi[i] == pozi && posi[i] != "0")
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
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o mapa, reinice a partidas");
            }

        }


        public void mover(int boneco, string pctbox, string pctBox0, int posq, Jogador item, int k, int atual)
        {
            try
            {
                for (int j = 0; j < boneco; j++)
                {
                    pctbox = item.piratas[k].nome;
                    PictureBox pictureBox = this.Controls.Find(pctbox, true).FirstOrDefault() as PictureBox;

                    pctBox0 = pctBox0 + ((posq).ToString());
                    PictureBox pictureBoxC = this.Controls.Find(pctBox0, true).FirstOrDefault() as PictureBox;

                    if (posq == 37)
                    {
                        switch (item.cor)
                        {
                            case "Vermelho":
                                if (j == 3)
                                {
                                    int l = j - 3;
                                    pictureBox.Location = new Point(1059, 35 + 11 * (l + 1));
                                }
                                else
                                {
                                    pictureBox.Location = new Point(1046, 35 + 11 * (j + 1));
                                }
                                break;
                            case "Verde":
                                if (j == 3)
                                {
                                    int l = j - 3;
                                    pictureBox.Location = new Point(1099, 35 + 11 * (l + 1));
                                }
                                else
                                {
                                    pictureBox.Location = new Point(1086, 35 + 11 * (j + 1));
                                }
                                break;
                            case "Amarelo":
                                if (j == 3)
                                {
                                    int l = j - 3;
                                    pictureBox.Location = new Point(1139, 35 + 11 * (l + 1));
                                }
                                else
                                {
                                    pictureBox.Location = new Point(1126, 35 + 11 * (j + 1));
                                }
                                break;
                            case "Azul":
                                if (j == 3)
                                {
                                    int l = j - 3;
                                    pictureBox.Location = new Point(1179, 35 + 11 * (l + 1));
                                }
                                else
                                {
                                    pictureBox.Location = new Point(1166, 35 + 11 * (j + 1));
                                }
                                break;

                        }
                    }
                    else if (atual != 0 && posq != 37)
                    {
                        pictureBox.Location = new Point(pictureBoxC.Location.X, pictureBoxC.Location.Y + 11 * (j + 1) * atual);
                    }

                    else { pictureBox.Location = new Point(pictureBoxC.Location.X, pictureBoxC.Location.Y + 11 * (j)); }
                    pictureBox.BringToFront();
                    pctBox0 = "pctBox";
                    item.piratas[k].posicao = posq;
                    k++;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro");
            }

        }

        //////////////////////////////////////////////////////botoes e funcoes deles



        private void mostrarTabuleiro()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao mostrar o tabuleiro");
            }

        }

        private void MostrarCartas()
        {
            idUsuario = Convert.ToInt32(idUsuario);
            senhaUsuario = senhaUsuario;

            pnlCartas.Controls.Clear();

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
                int contador = 0;
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
                                    Size = new Size(46, 77),
                                    Location = new Point(15 + (50 * contador), 2),
                                    SizeMode = PictureBoxSizeMode.StretchImage,
                                    Image = Image.FromFile("Icones/Chave.png"),
                                };
                                pnlCartas.Controls.Add(picture);

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
                                    Size = new Size(46, 77),
                                    Location = new Point(15 + (50 * contador), 2),

                                    SizeMode = PictureBoxSizeMode.StretchImage,
                                    Image = Image.FromFile("Icones/Tricornio.jpg"),
                                };
                                pnlCartas.Controls.Add(picture);


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

                                    Size = new Size(46, 77),
                                    Location = new Point(15 + (50 * contador), 2),
                                    SizeMode = PictureBoxSizeMode.StretchImage,
                                    Image = Image.FromFile("Icones/Esqueleto.jpg"),
                                };
                                pnlCartas.Controls.Add(picture);

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

                                    Size = new Size(46, 77),
                                    Location = new Point(15 + (50 * contador), 2),

                                    SizeMode = PictureBoxSizeMode.StretchImage,
                                    Image = Image.FromFile("Icones/Faca.jpg"),
                                };
                                pnlCartas.Controls.Add(picture);

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
                                    Size = new Size(46, 77),
                                    Location = new Point(15 + (50 * contador), 2),

                                    SizeMode = PictureBoxSizeMode.StretchImage,
                                    Image = Image.FromFile("Icones/Garrafa.jpg"),

                                };
                                pnlCartas.Controls.Add(picture);

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
                                    Size = new Size(46, 77),
                                    Location = new Point(15 + (50 * contador), 2 ),

                                    SizeMode = PictureBoxSizeMode.StretchImage,
                                    Image = Image.FromFile("Icones/Pistola.jpg"),
                                };
                                pnlCartas.Controls.Add(picture);

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
            try
            {
                Estrategia estrategia = new Estrategia();
                estrategia.AtribuirInfos(idPartida, idUsuario, senhaUsuario);


                //separação basica
                string retornando = Jogo.VerificarVez(idPartida);
                retornando = retornando.Replace("\r", "");
                string[] arrayRetornando = retornando.Split('\n');

                //dados de quem joga
                string[] jogandoAgora = arrayRetornando[0].Split(',');

                List<string> jogadas = new List<string>();

                //tabuleiro
                List<InfoTabuleiro> infoTabuleiro = new List<InfoTabuleiro>();


                //dados da partida geral
                for (int i = 1; i <= arrayRetornando.Length - 1; i++)
                {
                    jogadas.Add(arrayRetornando[i]);
                }


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
                    for (int i = 1; i < arrayRetornando.Length - 1; i++)
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
                    //Estrategia para volta


                    if (qtd < 4)
                    {
                        int pos = VerificaVolta(estrategia, minhaPos);

                        if (qtd <= 2 && pos == 1)
                        {
                            //Jogo.Jogar(idUsuario, senhaUsuario, minhaPos.Max());

                            //gera aleatotio pra não tentar voltar pirata na base


                //Verifica quantos tem entree a casa 30 e 37
               

                if (minhaPos.Count(x => x > 30 && x < 37) <= qtd)
                {
                    Jogo.Jogar(idUsuario, senhaUsuario, minhaPos.FirstOrDefault(x=> x> 30 && x <37), maoo[0]);
                }
                if (minhaPos.Count(x => x > 30 && x < 37) > 0 && qtd != 0)
                {
                    Jogo.Jogar(idUsuario, senhaUsuario, minhaPos.FirstOrDefault(x => x > 30 && x <  37), maoo[0]);
                }

                if (qtd < 4)
                {
                    VerificaVolta(estrategia, minhaPos, qtd, maoo);                                      
                                                                                              
                }               

                else
                {
                    mapa();
                    MostrarCartas();
                    return;
                }
                mapa();
                MostrarCartas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro");
            }

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

        private int VerificaVolta(Estrategia estrategia, List<int> minhaPos)
        {
            try
            {
                minhaPos.Reverse();
                int qtdNoFinal = 0;
                //Verifica onde esta os piratas do jogador e ve se na lista de info tem alguma casa menor que possua qtd de pirtas
                //diferente de 0 e menor q 3
                foreach (int item in minhaPos)
                {
                    if (item == 37)
                    {
                        qtdNoFinal++;
                    }

                    // Where para filtrar os itens da lista com nCasa menor que a minhaPos e nPiratas < 3.FirstOrDefault para obter o primeiro item dessa lista filtrada.
                    //To criando essa classe pq o retorno do where é uma classe
                    InfoTabuleiro primeiroMenorQuantidade = estrategia.infoTabuleiros.Where(posicao => posicao.nCasa < item && (posicao.nPiratas > 0 && posicao.nPiratas < 3)).LastOrDefault();

                    if (primeiroMenorQuantidade != null)
                    {

                        if (primeiroMenorQuantidade.nPiratas == 2)
                        {
                            Jogo.Jogar(idUsuario, senhaUsuario, item);
                            return 0;

                        }
                        //posicaoVolta = primeiroMenorQuantidade.nPiratas;                   

                        //Jogo.Jogar(idUsuario, senhaUsuario, primeiroMenorQuantidade.nCasa);
                    }

                }

        private void VerificaVolta(Estrategia estrategia, List<int> minhaPos, int qtd, string[] maoo)
        {
            minhaPos.Reverse();
            int qtdNoFinal = 0;
            
            //Verifica onde esta os piratas do jogador e ve se na lista de info tem alguma casa menor que possua qtd de pirtas
            //diferente de 0 e menor q 3
            foreach (int item in minhaPos)
            {
                if (item == 37)
                {
                    return -1;
                }

                // Where para filtrar os itens da lista com nCasa menor que a minhaPos e nPiratas < 3.FirstOrDefault para obter o primeiro item dessa lista filtrada.
                //To criando essa classe pq o retorno do where é uma classe
                InfoTabuleiro primeiroMenorQuantidade = estrategia.infoTabuleiros.Where(posicao => posicao.nCasa < item && posicao.nCasa > 0 &&(posicao.nPiratas > 0 && posicao.nPiratas < 3)).LastOrDefault();       

                if (primeiroMenorQuantidade != null)
                {
                    return 1;
                }
            }
            if (qtd < 2)

            {
                MessageBox.Show("Houve um erro");
            }
            else
            {
                verificaCasaAFrente(estrategia, minhaPos, maoo, qtd);
            }


        }

        private void verificaCasaAFrente(Estrategia estrategia, List<int> minhaPos, string[] mao,int qtd)
        {           
            foreach (int pos in minhaPos)

            {
                foreach (int pos in minhaPos)
                {
                    string carta =mao[i].Substring(0, 1);
                    int qtdcarta = Convert.ToInt32(mao[i].Substring(2));
                   

                    InfoTabuleiro verificaAvanco = estrategia.infoTabuleiros.FirstOrDefault(info => info.nCasa > pos && info.simbolo == Convert.ToChar(carta) && info.nPiratas > 0);

                    if(verificaAvanco != null)
                    {

                        if (verificaAvanco.nPiratas > 0)
                        {
                            Jogo.Jogar(idUsuario, senhaUsuario, pos, carta);
                            return;
                        }
                        else if(qtdcarta > 1)
                        {
                            Jogo.Jogar(idUsuario, senhaUsuario, pos, carta);
                        }
                        
                    }

                    
                       

                 
                }

                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar a casa");
            }
            Random random = new Random();
            int indiceAleatorio = random.Next(minhaPos.Count);
            int valorAleatorio = minhaPos[indiceAleatorio];
            indiceAleatorio = random.Next(mao.Length - 1);

            Jogo.Jogar(idUsuario, senhaUsuario, minhaPos.Min(), mao[indiceAleatorio].Substring(0, 1));
            return;

            
        }

        private void Mostra_Historico(int partidaAtual)
        {
            try
            {
                string retornoHistorico = Jogo.ExibirHistorico(partidaAtual);
                retornoHistorico = retornoHistorico.Replace("\r", "");
                string[] historico = retornoHistorico.Split('\n');
                for (int i = 0; i < historico.Length; i++)
                {
                    lbx_historico.Items.Add(historico[i]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao mostrar historico");
            }
        }

        private void pctBox11_Click(object sender, EventArgs e)
        {

        }
    }
}