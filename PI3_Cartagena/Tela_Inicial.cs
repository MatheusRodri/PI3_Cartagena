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
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Tela_Partida tela_Partida = new Tela_Partida();
            tela_Partida.Show();
            Hide();
        }

        private void btn_tela_de_criacao_Click(object sender, EventArgs e)
        {
            Tela_Criacao_Inicio tela_criacao_inicio = new Tela_Criacao_Inicio();
            tela_criacao_inicio.Show();
            this.Hide();
        }
    }
}
