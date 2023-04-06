namespace PI3_Cartagena
{
    partial class Tela_Carta
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Listar = new System.Windows.Forms.Button();
            this.txt_SenhaUser = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_UserId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_cartas = new System.Windows.Forms.ListBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_mostraTab = new System.Windows.Forms.ListBox();
            this.btn_mostrarTabuleiro = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_pularVez = new System.Windows.Forms.Button();
            this.btn_voltarPirata = new System.Windows.Forms.Button();
            this.lbl_retornoJogar = new System.Windows.Forms.Label();
            this.btn_andar = new System.Windows.Forms.Button();
            this.lbl_casaSel = new System.Windows.Forms.Label();
            this.btn_casaSel = new System.Windows.Forms.Button();
            this.lbl_cartaSel = new System.Windows.Forms.Label();
            this.btn_selCarta = new System.Windows.Forms.Button();
            this.btnTabuleiro = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.btn_Listar);
            this.panel3.Controls.Add(this.txt_SenhaUser);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txt_UserId);
            this.panel3.Location = new System.Drawing.Point(11, 65);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 264);
            this.panel3.TabIndex = 2;
            // 
            // btn_Listar
            // 
            this.btn_Listar.Location = new System.Drawing.Point(51, 208);
            this.btn_Listar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(152, 19);
            this.btn_Listar.TabIndex = 5;
            this.btn_Listar.Text = "Listar Cartas";
            this.btn_Listar.UseVisualStyleBackColor = true;
            this.btn_Listar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_SenhaUser
            // 
            this.txt_SenhaUser.Location = new System.Drawing.Point(26, 159);
            this.txt_SenhaUser.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SenhaUser.Name = "txt_SenhaUser";
            this.txt_SenhaUser.Size = new System.Drawing.Size(196, 20);
            this.txt_SenhaUser.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 136);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Senha do Usuario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Id Usuario";
            // 
            // txt_UserId
            // 
            this.txt_UserId.Location = new System.Drawing.Point(23, 77);
            this.txt_UserId.Margin = new System.Windows.Forms.Padding(2);
            this.txt_UserId.Name = "txt_UserId";
            this.txt_UserId.Size = new System.Drawing.Size(198, 20);
            this.txt_UserId.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_cartas);
            this.panel1.Location = new System.Drawing.Point(265, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 264);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mão de Cartas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_cartas
            // 
            this.lb_cartas.FormattingEnabled = true;
            this.lb_cartas.Location = new System.Drawing.Point(26, 39);
            this.lb_cartas.Margin = new System.Windows.Forms.Padding(2);
            this.lb_cartas.Name = "lb_cartas";
            this.lb_cartas.Size = new System.Drawing.Size(183, 212);
            this.lb_cartas.TabIndex = 0;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(11, 7);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(50, 28);
            this.btn_voltar.TabIndex = 2;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.lb_mostraTab);
            this.panel2.Controls.Add(this.btn_mostrarTabuleiro);
            this.panel2.Location = new System.Drawing.Point(515, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 264);
            this.panel2.TabIndex = 4;
            // 
            // lb_mostraTab
            // 
            this.lb_mostraTab.FormattingEnabled = true;
            this.lb_mostraTab.Location = new System.Drawing.Point(19, 39);
            this.lb_mostraTab.Name = "lb_mostraTab";
            this.lb_mostraTab.Size = new System.Drawing.Size(154, 212);
            this.lb_mostraTab.TabIndex = 1;
            // 
            // btn_mostrarTabuleiro
            // 
            this.btn_mostrarTabuleiro.Location = new System.Drawing.Point(59, 14);
            this.btn_mostrarTabuleiro.Name = "btn_mostrarTabuleiro";
            this.btn_mostrarTabuleiro.Size = new System.Drawing.Size(75, 23);
            this.btn_mostrarTabuleiro.TabIndex = 0;
            this.btn_mostrarTabuleiro.Text = "Mostar Tabuleior";
            this.btn_mostrarTabuleiro.UseVisualStyleBackColor = true;
            this.btn_mostrarTabuleiro.Click += new System.EventHandler(this.btn_mostrarTabuleiro_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.btn_pularVez);
            this.panel4.Controls.Add(this.btn_voltarPirata);
            this.panel4.Controls.Add(this.lbl_retornoJogar);
            this.panel4.Controls.Add(this.btn_andar);
            this.panel4.Controls.Add(this.lbl_casaSel);
            this.panel4.Controls.Add(this.btn_casaSel);
            this.panel4.Controls.Add(this.lbl_cartaSel);
            this.panel4.Controls.Add(this.btn_selCarta);
            this.panel4.Location = new System.Drawing.Point(11, 338);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(704, 100);
            this.panel4.TabIndex = 5;
            // 
            // btn_pularVez
            // 
            this.btn_pularVez.Location = new System.Drawing.Point(255, 64);
            this.btn_pularVez.Name = "btn_pularVez";
            this.btn_pularVez.Size = new System.Drawing.Size(75, 23);
            this.btn_pularVez.TabIndex = 7;
            this.btn_pularVez.Text = "Pular ";
            this.btn_pularVez.UseVisualStyleBackColor = true;
            this.btn_pularVez.Click += new System.EventHandler(this.btn_pularVez_Click);
            // 
            // btn_voltarPirata
            // 
            this.btn_voltarPirata.Location = new System.Drawing.Point(255, 39);
            this.btn_voltarPirata.Name = "btn_voltarPirata";
            this.btn_voltarPirata.Size = new System.Drawing.Size(75, 23);
            this.btn_voltarPirata.TabIndex = 6;
            this.btn_voltarPirata.Text = "voltar";
            this.btn_voltarPirata.UseVisualStyleBackColor = true;
            this.btn_voltarPirata.Click += new System.EventHandler(this.btn_voltarPirata_Click);
            // 
            // lbl_retornoJogar
            // 
            this.lbl_retornoJogar.AutoSize = true;
            this.lbl_retornoJogar.Location = new System.Drawing.Point(336, 13);
            this.lbl_retornoJogar.Name = "lbl_retornoJogar";
            this.lbl_retornoJogar.Size = new System.Drawing.Size(83, 13);
            this.lbl_retornoJogar.TabIndex = 5;
            this.lbl_retornoJogar.Text = "Retorno Jogar...";
            // 
            // btn_andar
            // 
            this.btn_andar.Location = new System.Drawing.Point(255, 13);
            this.btn_andar.Name = "btn_andar";
            this.btn_andar.Size = new System.Drawing.Size(75, 23);
            this.btn_andar.TabIndex = 4;
            this.btn_andar.Text = "Andar";
            this.btn_andar.UseVisualStyleBackColor = true;
            this.btn_andar.Click += new System.EventHandler(this.btn_andar_Click);
            // 
            // lbl_casaSel
            // 
            this.lbl_casaSel.AutoSize = true;
            this.lbl_casaSel.Location = new System.Drawing.Point(131, 64);
            this.lbl_casaSel.Name = "lbl_casaSel";
            this.lbl_casaSel.Size = new System.Drawing.Size(102, 13);
            this.lbl_casaSel.TabIndex = 3;
            this.lbl_casaSel.Text = "Casa Selecionada...";
            // 
            // btn_casaSel
            // 
            this.btn_casaSel.Location = new System.Drawing.Point(23, 54);
            this.btn_casaSel.Name = "btn_casaSel";
            this.btn_casaSel.Size = new System.Drawing.Size(102, 23);
            this.btn_casaSel.TabIndex = 2;
            this.btn_casaSel.Text = "Selecionar Casa";
            this.btn_casaSel.UseVisualStyleBackColor = true;
            this.btn_casaSel.Click += new System.EventHandler(this.btn_casaSel_Click);
            // 
            // lbl_cartaSel
            // 
            this.lbl_cartaSel.AutoSize = true;
            this.lbl_cartaSel.Location = new System.Drawing.Point(130, 35);
            this.lbl_cartaSel.Name = "lbl_cartaSel";
            this.lbl_cartaSel.Size = new System.Drawing.Size(103, 13);
            this.lbl_cartaSel.TabIndex = 1;
            this.lbl_cartaSel.Text = "Carta Selecionada...";
            // 
            // btn_selCarta
            // 
            this.btn_selCarta.Location = new System.Drawing.Point(23, 25);
            this.btn_selCarta.Name = "btn_selCarta";
            this.btn_selCarta.Size = new System.Drawing.Size(102, 23);
            this.btn_selCarta.TabIndex = 0;
            this.btn_selCarta.Text = "Selecionar Carta";
            this.btn_selCarta.UseVisualStyleBackColor = true;
            this.btn_selCarta.Click += new System.EventHandler(this.btn_selCarta_Click);
            // 
            // btnTabuleiro
            // 
            this.btnTabuleiro.Location = new System.Drawing.Point(725, 399);
            this.btnTabuleiro.Margin = new System.Windows.Forms.Padding(2);
            this.btnTabuleiro.Name = "btnTabuleiro";
            this.btnTabuleiro.Size = new System.Drawing.Size(64, 28);
            this.btnTabuleiro.TabIndex = 6;
            this.btnTabuleiro.Text = "Tabuleiro";
            this.btnTabuleiro.UseVisualStyleBackColor = true;
            this.btnTabuleiro.Click += new System.EventHandler(this.btnTabuleiro_Click);
            // 
            // Tela_Carta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTabuleiro);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Tela_Carta";
            this.Text = "Partida";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Listar;
        private System.Windows.Forms.TextBox txt_SenhaUser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_UserId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_cartas;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lb_mostraTab;
        private System.Windows.Forms.Button btn_mostrarTabuleiro;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_andar;
        private System.Windows.Forms.Label lbl_casaSel;
        private System.Windows.Forms.Button btn_casaSel;
        private System.Windows.Forms.Label lbl_cartaSel;
        private System.Windows.Forms.Button btn_selCarta;
        private System.Windows.Forms.Label lbl_retornoJogar;
        private System.Windows.Forms.Button btn_pularVez;
        private System.Windows.Forms.Button btn_voltarPirata;
        private System.Windows.Forms.Button btnTabuleiro;
    }
}