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
    public partial class Tela_Inicial : Form
    {
        public Tela_Inicial()
        {
            InitializeComponent();
            inicialToolStripMenuItem.Visible = false;
        }

        int idPartida;

        private void btn_listarPartida_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_criarPartida_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txt_nomeUsuario.Text;
            string senhaPartida = txt_senha.Text;
            string dadosDaPartida = Jogo.EntrarPartida(idPartida, nomeUsuario, senhaPartida);

            MessageBox.Show(dadosDaPartida);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void partidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_Partida tela_Partida = new Tela_Partida();
            tela_Partida.ShowDialog();
            Hide();
        }

        private void Tela_Inicial_Load(object sender, EventArgs e)
        {

        }

        private void txt_nomeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void cartaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carta partida = new Carta();
            partida.Show();
            Hide();
        }

        private void inicialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
