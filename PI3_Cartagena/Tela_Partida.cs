using CartagenaServer;
using PI3_Cartagena.Classes;
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
    public partial class Tela_Partida : Form
    {
        private int idpartida;
        public Tela_Partida()
        {
            InitializeComponent();
            exibirPartidas("T");
            btn_entrarNaPartida.Enabled = false;
            cmb_filtro.SelectedIndex = 0;
        }
        public void exibirPartidas(string tipoPartida)
        {
            try
            {
            lb_partidas.Items.Clear();
            string dados = Jogo.ListarPartidas(tipoPartida);
            dados = dados.Replace("\r", "");
            string[] partidas = dados.Split('\n');  


            for (int i = 0; i < partidas.Length; i++)
            {
                lb_partidas.Items.Add(partidas[i]);
            }

            }catch(Exception ex)
            {
                MessageBox.Show("Houve um erro, verifique o servidor ou DLL");
            }
        }

        private void lb_partidas_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string[] dadosPartidas = lb_partidas.SelectedItem.ToString().Split(',');

                idpartida = Convert.ToInt32(dadosPartidas[0]);
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
                btn_entrarNaPartida.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Houve um erro ao selecionar a partida, por favor selecione outra");
            }
        }

        private void btn_formCriarPartida_Click(object sender, EventArgs e)
        {
            Tela_CriarPartida partida = new Tela_CriarPartida();
            partida.Show();
            this.Close();
        }

        private void btn_entrarNaPartida_Click(object sender, EventArgs e)
        {
            Tela_Jogadores tela_Jogadores = new Tela_Jogadores(idpartida);
            tela_Jogadores.Show();
            this.Close();
        }

        private void cmb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            // (T)Todas, (A)Abertas, (J)Jogando, (E)Encerradas

            string filtro = cmb_filtro.SelectedItem.ToString();
            switch (filtro)
            {
                case "Todas":
                    exibirPartidas("T");
                    break;
                case "Abertas":
                    exibirPartidas("A");
                    break;
                case "Encerradas":
                  exibirPartidas("E");
                    break;
                case "Jogando":
                    exibirPartidas("J");
                    break;
                default:
                    exibirPartidas("T");
                    break;
            }

            
        }

    }
}
