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

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            Tela_Partida tela_Partida = new Tela_Partida();
            tela_Partida.Show();
            Hide();
        }
    }
}
