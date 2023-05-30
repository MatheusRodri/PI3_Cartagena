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
    public partial class Tela_Jogadores : Form
    {

        private int idPartida {get;set;}
        private int idUsuario { get;set;}
        private string senhaUsuario { get;set;}
        private string senhaPartida { get;set;}
        private string nomeUsuario { get;set;}

        private string dadosPartida { get;set;}
        private string idJogadorInicial { get;set;}
        public Tela_Jogadores(int idPartida, string senhaPartida)
        {
            InitializeComponent();
            this.idPartida = idPartida;
            txt_senhaPartida.Text = senhaPartida;
            btn_entrarPartida.Enabled = false;
            //txt_idUser.Enabled = false;
            //txt_senhaUsuario.Enabled = false;
            //btn_iniciarPartida.Enabled = false;
            btn_telaJogo.Enabled = false;
        }
        public Tela_Jogadores(int idPartida)
        {
            InitializeComponent();
            this.idPartida = idPartida;
            //txt_idUser.Enabled = false;
            //txt_senhaUsuario.Enabled = false;
            //btn_iniciarPartida.Enabled = false;
            btn_telaJogo.Enabled = false;
        }

        private void validaCampos()
        {
            if (txt_nomeUsuario.Text.Length > 0 && txt_senhaPartida.Text.Length > 0)
            {
                btn_entrarPartida.Enabled = true;
                btn_telaJogo.Enabled = true;
            }
            else
            {
                btn_entrarPartida.Enabled = false;
                btn_telaJogo.Enabled = false;
            }
        }


        private void btn_entrarPartida_Click(object sender, EventArgs e)
        {
            nomeUsuario = txt_nomeUsuario.Text;
            senhaPartida = txt_senhaPartida.Text;
            dadosPartida = Jogo.EntrarPartida(idPartida, nomeUsuario, senhaPartida);

            Console.WriteLine(dadosPartida);
            string[] dadosUser = dadosPartida.Split(',');
            
            txt_idUser.Text = dadosUser[0];
            txt_senhaUsuario.Text = dadosUser[1];

            btn_iniciarPartida.Enabled = true;
        }

        private void btn_iniciarPartida_Click(object sender, EventArgs e)
        {
            idUsuario = Convert.ToInt32(txt_idUser.Text);
            senhaUsuario = txt_senhaUsuario.Text;
            idJogadorInicial = Jogo.IniciarPartida(idUsuario, senhaUsuario);
            
            MessageBox.Show($"Jogador: {idJogadorInicial} iniciara");

            Tela_jogo tela = new Tela_jogo(idPartida, idUsuario, senhaUsuario);
            tela.Show();
            this.Close();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Tela_Partida partida = new Tela_Partida();
            partida.Show();
            this.Close();
        }

        private void btn_telaJogo_Click(object sender, EventArgs e)
        {
            Tela_jogo jogando = new Tela_jogo(idPartida, idUsuario, senhaUsuario);
            jogando.Show();
            this.Close();
        }

        private void txt_nomeUsuario_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }

        private void txt_senhaPartida_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }

        private void btn_telaJogo_Click_1(object sender, EventArgs e)
        {
            Tela_jogo jogando = new Tela_jogo(idPartida, idUsuario, senhaUsuario);
            jogando.Show();
            this.Close();
        }
    }
}
