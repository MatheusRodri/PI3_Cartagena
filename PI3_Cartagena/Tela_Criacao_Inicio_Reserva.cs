using PI3_Cartagena.Classes;
using PI3_Cartagena;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace PI3_Cartagena
{
    public partial class Tela_Criacao_Inicio_Reserva : Form
    {
        public Tela_Criacao_Inicio_Reserva()
        {
            InitializeComponent();
            
            //btn_criarPartida.Enabled = true;

            exibirPartidas("T");
        }

        //Validação para criação de partidas e criação de partida
        //Validacao n esta funcionando

        /*
        private void validaCampos()
        {
            if (txt_nomePartida.Text.Length > 0 && txt_senhaPartida.Text.Length > 0)
            {
                btn_criarPartida.Enabled = true;
            }
            else
            {
                btn_criarPartida.Enabled = false;
            }
        }
        
        
        private void txt_nomePartida_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }
        
        */


        private void btn_criarPartida_Click(object sender, EventArgs e)
        {
            Partida partida = new Partida();

            string nomePartida = txt_nomePartida.Text;
            string senhaPartida = txt_senhaPartida.Text;


            string dadosPartidaNova = partida.CriarPartida(nomePartida, senhaPartida);
            MessageBox.Show(dadosPartidaNova);
            

            //att lista de partidas
            exibirPartidas("T");


        }


        /////////////////////////////////////////////////////////////////////////////////
        //exibição de partidas

        public void exibirPartidas(string tipoPartida)
        {
            lb_partidas.Items.Clear();
            string dados = Jogo.ListarPartidas(tipoPartida);
            dados = dados.Replace("\r", "");
            string[] partidas = dados.Split('\n');


            for (int i = 0; i < partidas.Length; i++)
            {
                lb_partidas.Items.Add(partidas[i]);
            }
        }

        private void cmb_filtros_SelectedIndexChanged(object sender, EventArgs e)
        {
            exibirPartidas(cmb_filtros.SelectedItem.ToString());
        }
        //////////////////////////////////////////////////////////////////////////////
        ///
        //Exibir jogadores 

        //funcao que retorna id da partida sel
        int partidaSelecionado()
        {
            int idpartida = 0;
            string dadosPartidas = lb_partidas.SelectedItem.ToString();
            string[] itens = dadosPartidas.Split(',');

            idpartida = Convert.ToInt32(itens[0]);
            return idpartida;
        }

        private void mostrarJogadores()
        {
            int idPartida = partidaSelecionado();
            lb_jogadoresNaPartida.Items.Clear();
            string dados = Jogo.ListarJogadores(idPartida);
            dados = dados.Replace("\r", "");

            string[] jogadores = dados.Split('\n');




            for (int i = 0; i < jogadores.Length; i++)
            {
                lb_jogadoresNaPartida.Items.Add(jogadores[i]);
            }
        }

        
        private void lb_partidas_SelectedValueChanged(object sender, EventArgs e)
        {
           
            try
            {
                string[] dadosPartidas = lb_partidas.SelectedItem.ToString().Split(',');

                int idpartida = Convert.ToInt32(dadosPartidas[0]);
                string nomePartida = dadosPartidas[1];
                lbl_nomePartida.Text = $"Partida selecionada foi {nomePartida}";
                lbl_nomePartida.Visible = true;


                lb_jogadoresNaPartida.Items.Clear();
                string dados = Jogo.ListarJogadores(idpartida);
                dados = dados.Replace("\r", "");

                string[] jogadores = dados.Split('\n');




                for (int i = 0; i < jogadores.Length; i++)
                {
                    lb_jogadoresNaPartida.Items.Add(jogadores[i]);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Houve um erro ao selecionar a partida, por favor selecione outra");
            }
        }

        //Entrar com jogadores na partida (Podem ser mais que um)
        private void btn_entrarPartida_Click(object sender, EventArgs e)
        {
            int idPartida = partidaSelecionado();
            string nomeUsuario = txt_nomeUsuario.Text;
            string senhaPartida = txt_senha.Text;
        
            string dadosDaPartida = Jogo.EntrarPartida(idPartida, nomeUsuario, senhaPartida);

            MessageBox.Show(dadosDaPartida);
            /*
            Console.WriteLine(dadosDaPartida);            
            string[] dadosUser = dadosDaPartida.Split(',');
            
            txtUser.Text = dadosUser[0];
            txtSenhaU.Text = dadosUser[1];
            */

            //att lista de jogadores

            lb_jogadoresNaPartida.Items.Clear();
            string dados = Jogo.ListarJogadores(idPartida);
            dados = dados.Replace("\r", "");

            string[] jogadores = dados.Split('\n');




            for (int i = 0; i < jogadores.Length; i++)
            {
                lb_jogadoresNaPartida.Items.Add(jogadores[i]);
            }

        }



        //iniciar Partida

        private void btnPartida_Click(object sender, EventArgs e)
        {
            int idPartida = partidaSelecionado();
            int idUsuario = Convert.ToInt32(txtUser.Text);
            string senhaUsuario = txtSenhaU.Text;
            string jogador = Jogo.IniciarPartida(idUsuario, senhaUsuario);

            MessageBox.Show($"Jogador: {jogador} iniciara");

            jogando jogando = new jogando(idPartida, idUsuario, senhaUsuario);
            jogando.Show();
            this.Hide();
        }

       
    }
}







