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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int idPartida;

        private void btn_listarPartida_Click(object sender, EventArgs e)
        {
            string dados = Jogo.ListarPartidas("T");
            dados = dados.Replace("\r","");
            string[] partidas = dados.Split('\n');

           

            for(int i = 0; i < partidas.Length; i++)
            {
                lb_partidas.Items.Add(partidas[i]);
            }    
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string partida = lb_partidas.SelectedItem.ToString();
            string[] itens = partida.Split(',');

            idPartida = Convert.ToInt32(itens[0]);
            string nomePartida = itens[1];
            string dataPartida = itens[2];
            string statusPartida = itens[3];

            lbl_partidaSelecionada.Text = $"ID: {idPartida} \nNome da partida: {nomePartida} \nData da partida: {dataPartida} \nStatus da partida {statusPartida}";
            lbl_partidaSelecionada.Visible = true;
        }

        private void btn_criarPartida_Click(object sender, EventArgs e)
        {
            string nomePartida = txt_nomePartida.Text;
            string senhaPartida = txt_senhaPartida.Text;

            string dadosPartidaNova = Jogo.CriarPartida(nomePartida, senhaPartida);

            MessageBox.Show(dadosPartidaNova);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txt_nomeUsuario.Text;
            string senhaPartida = txt_senha.Text;
            string dadosDaPartida = Jogo.EntrarPartida(idPartida, nomeUsuario, senhaPartida);

            MessageBox.Show(dadosDaPartida);
        }
    }
}
