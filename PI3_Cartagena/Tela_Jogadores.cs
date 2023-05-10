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
        
        private int idPartida;
        private int idUsuario;
        private string senhaUsuario;
        public Tela_Jogadores(int idPartida)
        {
            InitializeComponent();
            this.idPartida = idPartida;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_entrarPartida_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txt_nomeUsuario.Text;
            string senhaPartida = txt_senha.Text;
            string dadosDaPartida = Jogo.EntrarPartida(idPartida, nomeUsuario, senhaPartida);

            Console.WriteLine(dadosDaPartida);
            string[] dadosUser = dadosDaPartida.Split(',');
            
            txtUser.Text = dadosUser[0];
            txtSenhaU.Text = dadosUser[1];
        }

        private void partidaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void partidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Tela_Carta partida = new Tela_Carta(idPartida,idUsuario,senhaUsuario);
            partida.Show();
            this.Close();
        }

        private void btnPartida_Click(object sender, EventArgs e)
        {
            idUsuario = Convert.ToInt32(txtUser.Text);
            senhaUsuario = txtSenhaU.Text;
            string jogador = Jogo.IniciarPartida(idUsuario, senhaUsuario);
            
            MessageBox.Show($"Jogador: {jogador} iniciara");
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Tela_Partida partida = new Tela_Partida();
            partida.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tela_Carta tela_Carta = new Tela_Carta(idPartida, idUsuario, senhaUsuario);
            tela_Carta.Show();
            this.Close();
        }

        private void btn_jgn_Click(object sender, EventArgs e)
        {
            jogando jogando = new jogando(idPartida, idUsuario, senhaUsuario);
            jogando.Show();
            this.Close();
        }
    }
}
