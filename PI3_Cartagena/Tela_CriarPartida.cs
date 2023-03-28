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
    public partial class Tela_CriarPartida : Form
    {
        public Tela_CriarPartida()
        {
            InitializeComponent();
            btn_criarPartida.Enabled = false;
        }
        
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
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }

        private void btn_criarPartida_Click(object sender, EventArgs e)
        {
            string nomePartida = txt_nomePartida.Text;
            string senhaPartida = txt_senhaPartida.Text;

            string dadosPartidaNova = Jogo.CriarPartida(nomePartida, senhaPartida);

            MessageBox.Show(dadosPartidaNova);
            this.Close();
        }

        private void txt_senhaPartida_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }
    }
}
