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
    public partial class CriarPartida : Form
    {
        public CriarPartida()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_criarPartida_Click(object sender, EventArgs e)
        {
            string nomePartida = txt_nomePartida.Text;
            string senhaPartida = txt_senhaPartida.Text;

            string dadosPartidaNova = Jogo.CriarPartida(nomePartida, senhaPartida);

            MessageBox.Show(dadosPartidaNova);
            this.Close();
        }
    }
}
