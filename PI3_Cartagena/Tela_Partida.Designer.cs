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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_partidas = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTabuleiro = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_form_criar_partida = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_nomePartida = new System.Windows.Forms.Label();
            this.lb_jogadoresNaPartida = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_partidas);
            this.panel1.Location = new System.Drawing.Point(22, 24);
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
            this.panel2.Controls.Add(this.btnTabuleiro);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btn_form_criar_partida);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 538);
            this.panel2.TabIndex = 2;
            // 
            // btnTabuleiro
            // 
            this.btnTabuleiro.Location = new System.Drawing.Point(656, 237);
            this.btnTabuleiro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTabuleiro.Name = "btnTabuleiro";
            this.btnTabuleiro.Size = new System.Drawing.Size(137, 51);
            this.btnTabuleiro.TabIndex = 4;
            this.btnTabuleiro.Text = "Tabuleiro";
            this.btnTabuleiro.UseVisualStyleBackColor = true;
            this.btnTabuleiro.Click += new System.EventHandler(this.btnTabuleiro_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 132);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Entrar na partida";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_form_criar_partida
            // 
            this.btn_form_criar_partida.Location = new System.Drawing.Point(656, 24);
            this.btn_form_criar_partida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_form_criar_partida.Name = "btn_form_criar_partida";
            this.btn_form_criar_partida.Size = new System.Drawing.Size(137, 51);
            this.btn_form_criar_partida.TabIndex = 2;
            this.btn_form_criar_partida.Text = "Criar partida";
            this.btn_form_criar_partida.UseVisualStyleBackColor = true;
            this.btn_form_criar_partida.Click += new System.EventHandler(this.btn_form_criar_partida_Click);
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
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
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
            this.lb_jogadoresNaPartida.SelectedIndexChanged += new System.EventHandler(this.lb_jogadoresNaPartida_SelectedIndexChanged);
            // 
            // Tela_Partida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 522);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Tela_Partida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neiva";
            this.EnabledChanged += new System.EventHandler(this.Tela_Partida_EnabledChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_partidas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_nomePartida;
        private System.Windows.Forms.ListBox lb_jogadoresNaPartida;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_form_criar_partida;
        private System.Windows.Forms.Button btnTabuleiro;
    }
}