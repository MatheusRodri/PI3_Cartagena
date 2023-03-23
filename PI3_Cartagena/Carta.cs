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
    public partial class Carta : Form
    {
        public Carta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_cartas.Items.Clear();
            int id = Convert.ToInt32(txt_UserId.Text);
            string senha = txt_SenhaUser.Text;



            string cartas = Jogo.ConsultarMao(id, senha);

            cartas = cartas.Replace("\r", "");
            string[] mao = cartas.Split('\n');


            


            for (int i = 0; i < mao.Length; i++)
            {
                lb_cartas.Items.Add(mao[i]);
            }
        }

        private void partidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Carta partida = new Carta();
            partida.Show();
            this.Close();
        }
    }
}
