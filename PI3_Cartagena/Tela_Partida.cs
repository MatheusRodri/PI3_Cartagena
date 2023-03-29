﻿using CartagenaServer;
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
        public Tela_Partida()
        {
            InitializeComponent();
            exibirPartidas();

        }
         int idpartida;
        private void exibirPartidas()
        {
            lb_partidas.Items.Clear();
            string dados = Jogo.ListarPartidas("T");
            dados = dados.Replace("\r", "");
            string[] partidas = dados.Split('\n');  




            for (int i = 0; i < partidas.Length; i++)
            {
                lb_partidas.Items.Add(partidas[i]);
            }
        }

        private void jogadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dadosPartidas = lb_partidas.SelectedItem.ToString();
            string[] itens = dadosPartidas.Split(',');

            idpartida = Convert.ToInt32(itens[0]);
            

            Tela_Jogadores tela_Jogadores = new Tela_Jogadores(idpartida);
            tela_Jogadores.Show();
            this.Close();
        }

        private void inicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_Inicial tela_Inicial = new Tela_Inicial();
            tela_Inicial.Show();
            this.Close();
        }

        private void lb_partidas_SelectedValueChanged(object sender, EventArgs e)
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
        }

        private void cartaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_form_criar_partida_Click(object sender, EventArgs e)
        {
            Tela_CriarPartida partida = new Tela_CriarPartida();
            partida.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tela_Jogadores tela_Jogadores = new Tela_Jogadores(idpartida);
            tela_Jogadores.Show();
            this.Close();
        }
    }
}
