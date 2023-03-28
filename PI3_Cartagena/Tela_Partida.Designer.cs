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
            this.button3 = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(30, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 325);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Partidas abertas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_partidas
            // 
            this.lb_partidas.FormattingEnabled = true;
            this.lb_partidas.ItemHeight = 16;
            this.lb_partidas.Location = new System.Drawing.Point(29, 48);
            this.lb_partidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_partidas.Name = "lb_partidas";
            this.lb_partidas.Size = new System.Drawing.Size(243, 260);
            this.lb_partidas.TabIndex = 0;
            this.lb_partidas.SelectedIndexChanged += new System.EventHandler(this.lb_partidas_SelectedIndexChanged);
            this.lb_partidas.SelectedValueChanged += new System.EventHandler(this.lb_partidas_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btn_form_criar_partida);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1157, 662);
            this.panel2.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(874, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 63);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(874, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 63);
            this.button2.TabIndex = 3;
            this.button2.Text = "Entrar na partida";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_form_criar_partida
            // 
            this.btn_form_criar_partida.Location = new System.Drawing.Point(874, 30);
            this.btn_form_criar_partida.Name = "btn_form_criar_partida";
            this.btn_form_criar_partida.Size = new System.Drawing.Size(183, 63);
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
            this.panel4.Location = new System.Drawing.Point(411, 30);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(315, 325);
            this.panel4.TabIndex = 1;
            // 
            // lbl_nomePartida
            // 
            this.lbl_nomePartida.AutoSize = true;
            this.lbl_nomePartida.Enabled = false;
            this.lbl_nomePartida.Location = new System.Drawing.Point(63, 17);
            this.lbl_nomePartida.Name = "lbl_nomePartida";
            this.lbl_nomePartida.Size = new System.Drawing.Size(28, 16);
            this.lbl_nomePartida.TabIndex = 1;
            this.lbl_nomePartida.Text = "       ";
            this.lbl_nomePartida.Visible = false;
            // 
            // lb_jogadoresNaPartida
            // 
            this.lb_jogadoresNaPartida.FormattingEnabled = true;
            this.lb_jogadoresNaPartida.ItemHeight = 16;
            this.lb_jogadoresNaPartida.Location = new System.Drawing.Point(21, 48);
            this.lb_jogadoresNaPartida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_jogadoresNaPartida.Name = "lb_jogadoresNaPartida";
            this.lb_jogadoresNaPartida.Size = new System.Drawing.Size(269, 260);
            this.lb_jogadoresNaPartida.TabIndex = 0;
            // 
            // Tela_Partida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 642);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tela_Partida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_Partida";
            this.Load += new System.EventHandler(this.Tela_Partida_Load);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_form_criar_partida;
    }
}