namespace PI3_Cartagena
{
    partial class Tela_Partida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_partidas = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_nomePartida = new System.Windows.Forms.Label();
            this.lb_jogadoresNaPartida = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_criarPartida = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_senhaPartida = new System.Windows.Forms.TextBox();
            this.txt_nomePartida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cartaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicialToolStripMenuItem,
            this.partidaToolStripMenuItem,
            this.jogadoresToolStripMenuItem,
            this.cartaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicialToolStripMenuItem
            // 
            this.inicialToolStripMenuItem.Name = "inicialToolStripMenuItem";
            this.inicialToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.inicialToolStripMenuItem.Text = "Inicial";
            this.inicialToolStripMenuItem.Click += new System.EventHandler(this.inicialToolStripMenuItem_Click);
            // 
            // partidaToolStripMenuItem
            // 
            this.partidaToolStripMenuItem.Name = "partidaToolStripMenuItem";
            this.partidaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.partidaToolStripMenuItem.Text = "Partida";
            // 
            // jogadoresToolStripMenuItem
            // 
            this.jogadoresToolStripMenuItem.Name = "jogadoresToolStripMenuItem";
            this.jogadoresToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.jogadoresToolStripMenuItem.Text = "Jogadores";
            this.jogadoresToolStripMenuItem.Click += new System.EventHandler(this.jogadoresToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_partidas);
            this.panel1.Location = new System.Drawing.Point(22, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 264);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Partidas abertas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_partidas
            // 
            this.lb_partidas.FormattingEnabled = true;
            this.lb_partidas.Location = new System.Drawing.Point(22, 39);
            this.lb_partidas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_partidas.Name = "lb_partidas";
            this.lb_partidas.Size = new System.Drawing.Size(183, 212);
            this.lb_partidas.TabIndex = 0;
            this.lb_partidas.SelectedIndexChanged += new System.EventHandler(this.lb_partidas_SelectedIndexChanged);
            this.lb_partidas.SelectedValueChanged += new System.EventHandler(this.lb_partidas_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 513);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Controls.Add(this.lbl_nomePartida);
            this.panel4.Controls.Add(this.lb_jogadoresNaPartida);
            this.panel4.Location = new System.Drawing.Point(308, 24);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 264);
            this.panel4.TabIndex = 1;
            // 
            // lbl_nomePartida
            // 
            this.lbl_nomePartida.AutoSize = true;
            this.lbl_nomePartida.Enabled = false;
            this.lbl_nomePartida.Location = new System.Drawing.Point(47, 14);
            this.lbl_nomePartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nomePartida.Name = "lbl_nomePartida";
            this.lbl_nomePartida.Size = new System.Drawing.Size(28, 13);
            this.lbl_nomePartida.TabIndex = 1;
            this.lbl_nomePartida.Text = "       ";
            this.lbl_nomePartida.Visible = false;
            // 
            // lb_jogadoresNaPartida
            // 
            this.lb_jogadoresNaPartida.FormattingEnabled = true;
            this.lb_jogadoresNaPartida.Location = new System.Drawing.Point(16, 39);
            this.lb_jogadoresNaPartida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_jogadoresNaPartida.Name = "lb_jogadoresNaPartida";
            this.lb_jogadoresNaPartida.Size = new System.Drawing.Size(203, 212);
            this.lb_jogadoresNaPartida.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.btn_criarPartida);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_senhaPartida);
            this.panel3.Controls.Add(this.txt_nomePartida);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(579, 24);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 264);
            this.panel3.TabIndex = 0;
            // 
            // btn_criarPartida
            // 
            this.btn_criarPartida.Location = new System.Drawing.Point(82, 232);
            this.btn_criarPartida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_criarPartida.Name = "btn_criarPartida";
            this.btn_criarPartida.Size = new System.Drawing.Size(88, 19);
            this.btn_criarPartida.TabIndex = 5;
            this.btn_criarPartida.Text = "Criar partida";
            this.btn_criarPartida.UseVisualStyleBackColor = true;
            this.btn_criarPartida.Click += new System.EventHandler(this.btn_criarPartida_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Senha da partida";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_senhaPartida
            // 
            this.txt_senhaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senhaPartida.Location = new System.Drawing.Point(31, 167);
            this.txt_senhaPartida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_senhaPartida.Name = "txt_senhaPartida";
            this.txt_senhaPartida.Size = new System.Drawing.Size(187, 24);
            this.txt_senhaPartida.TabIndex = 3;
            // 
            // txt_nomePartida
            // 
            this.txt_nomePartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomePartida.Location = new System.Drawing.Point(31, 93);
            this.txt_nomePartida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_nomePartida.Name = "txt_nomePartida";
            this.txt_nomePartida.Size = new System.Drawing.Size(187, 24);
            this.txt_nomePartida.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome da partida";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Criar partida";
            // 
            // cartaToolStripMenuItem
            // 
            this.cartaToolStripMenuItem.Name = "cartaToolStripMenuItem";
            this.cartaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.cartaToolStripMenuItem.Text = "Carta";
            this.cartaToolStripMenuItem.Click += new System.EventHandler(this.cartaToolStripMenuItem_Click);
            // 
            // Tela_Partida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Tela_Partida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_Partida";
            this.Load += new System.EventHandler(this.Tela_Partida_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem partidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicialToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_partidas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_senhaPartida;
        private System.Windows.Forms.TextBox txt_nomePartida;
        private System.Windows.Forms.Button btn_criarPartida;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_nomePartida;
        private System.Windows.Forms.ListBox lb_jogadoresNaPartida;
        private System.Windows.Forms.ToolStripMenuItem cartaToolStripMenuItem;
    }
}