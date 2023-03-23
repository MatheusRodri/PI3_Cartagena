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
    public partial class Tela_Jogadores : Form
    {
        
        private int idPartida;
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

            MessageBox.Show(dadosDaPartida);
        }

        private void partidaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void partidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            
            Carta partida = new Carta();
            partida.Show();
            this.Close();
        }

        private void btnPartida_Click(object sender, EventArgs e)
        {
            int idUsuario = Convert.ToInt32(txtUser.Text);
            string senhaUsuario = txtSenhaU.Text;
            string jogador = Jogo.IniciarPartida(idUsuario, senhaUsuario);

            MessageBox.Show($"Jogador: {jogador} iniciara a partida");
        }
    }
}