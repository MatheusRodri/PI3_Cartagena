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
            this.cmb_filtro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_partidas = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_entrarNaPartida = new System.Windows.Forms.Button();
            this.btn_formCriarPartida = new System.Windows.Forms.Button();
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
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.cmb_filtro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_partidas);
            this.panel1.Location = new System.Drawing.Point(22, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 264);
            this.panel1.TabIndex = 1;
            // 
            // cmb_filtro
            // 
            this.cmb_filtro.FormattingEnabled = true;
            this.cmb_filtro.Items.AddRange(new object[] {
            "Todas",
            "Abertas",
            "Jogando",
            "Encerradas"});
            this.cmb_filtro.Location = new System.Drawing.Point(72, 14);
            this.cmb_filtro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_filtro.Name = "cmb_filtro";
            this.cmb_filtro.Size = new System.Drawing.Size(133, 21);
            this.cmb_filtro.TabIndex = 2;
            this.cmb_filtro.SelectedIndexChanged += new System.EventHandler(this.cmb_filtro_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Partidas: ";
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
            this.lb_partidas.SelectedValueChanged += new System.EventHandler(this.lb_partidas_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BackgroundImage = global::PI3_Cartagena.Properties.Resources.Landscape_Wallpapers_landscape_island_beach_XVII_century_4k_hi_0;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btn_entrarNaPartida);
            this.panel2.Controls.Add(this.btn_formCriarPartida);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 411);
            this.panel2.TabIndex = 2;
            // 
            // btn_entrarNaPartida
            // 
            this.btn_entrarNaPartida.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_entrarNaPartida.Font = new System.Drawing.Font("Blackadder ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrarNaPartida.ForeColor = System.Drawing.Color.Gold;
            this.btn_entrarNaPartida.Image = global::PI3_Cartagena.Properties.Resources.Botao;
            this.btn_entrarNaPartida.Location = new System.Drawing.Point(594, 123);
            this.btn_entrarNaPartida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_entrarNaPartida.Name = "btn_entrarNaPartida";
            this.btn_entrarNaPartida.Size = new System.Drawing.Size(163, 51);
            this.btn_entrarNaPartida.TabIndex = 3;
            this.btn_entrarNaPartida.Text = "Entrar na partida";
            this.btn_entrarNaPartida.UseVisualStyleBackColor = false;
            this.btn_entrarNaPartida.Click += new System.EventHandler(this.btn_entrarNaPartida_Click);
            // 
            // btn_formCriarPartida
            // 
            this.btn_formCriarPartida.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_formCriarPartida.Font = new System.Drawing.Font("Blackadder ITC", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_formCriarPartida.ForeColor = System.Drawing.Color.Gold;
            this.btn_formCriarPartida.Image = global::PI3_Cartagena.Properties.Resources.Botao;
            this.btn_formCriarPartida.Location = new System.Drawing.Point(594, 24);
            this.btn_formCriarPartida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_formCriarPartida.Name = "btn_formCriarPartida";
            this.btn_formCriarPartida.Size = new System.Drawing.Size(163, 51);
            this.btn_formCriarPartida.TabIndex = 2;
            this.btn_formCriarPartida.Text = "Criar partida";
            this.btn_formCriarPartida.UseVisualStyleBackColor = false;
            this.btn_formCriarPartida.Click += new System.EventHandler(this.btn_formCriarPartida_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            // Tela_Partida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 411);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Tela_Partida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neiva";
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
        private System.Windows.Forms.Button btn_entrarNaPartida;
        private System.Windows.Forms.Button btn_formCriarPartida;
        private System.Windows.Forms.ComboBox cmb_filtro;
    }
}