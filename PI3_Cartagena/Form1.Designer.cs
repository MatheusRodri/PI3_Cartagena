namespace PI3_Cartagena
{
    partial class Form1
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
            this.btn_listarPartida = new System.Windows.Forms.Button();
            this.lb_partidas = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_partidaSelecionada = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_criarPartida = new System.Windows.Forms.Button();
            this.txt_senhaPartida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nomePartida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_nomeUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_listarPartida
            // 
            this.btn_listarPartida.Location = new System.Drawing.Point(68, 35);
            this.btn_listarPartida.Name = "btn_listarPartida";
            this.btn_listarPartida.Size = new System.Drawing.Size(118, 23);
            this.btn_listarPartida.TabIndex = 0;
            this.btn_listarPartida.Text = "Listar partidas";
            this.btn_listarPartida.UseVisualStyleBackColor = true;
            this.btn_listarPartida.Click += new System.EventHandler(this.btn_listarPartida_Click);
            // 
            // lb_partidas
            // 
            this.lb_partidas.FormattingEnabled = true;
            this.lb_partidas.ItemHeight = 16;
            this.lb_partidas.Location = new System.Drawing.Point(44, 78);
            this.lb_partidas.Name = "lb_partidas";
            this.lb_partidas.Size = new System.Drawing.Size(172, 180);
            this.lb_partidas.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Selecionar partida";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_partidaSelecionada
            // 
            this.lbl_partidaSelecionada.AutoSize = true;
            this.lbl_partidaSelecionada.Location = new System.Drawing.Point(335, 78);
            this.lbl_partidaSelecionada.Name = "lbl_partidaSelecionada";
            this.lbl_partidaSelecionada.Size = new System.Drawing.Size(0, 16);
            this.lbl_partidaSelecionada.TabIndex = 3;
            this.lbl_partidaSelecionada.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_criarPartida);
            this.panel1.Controls.Add(this.txt_senhaPartida);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_nomePartida);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(556, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 200);
            this.panel1.TabIndex = 4;
            // 
            // btn_criarPartida
            // 
            this.btn_criarPartida.Location = new System.Drawing.Point(25, 151);
            this.btn_criarPartida.Name = "btn_criarPartida";
            this.btn_criarPartida.Size = new System.Drawing.Size(168, 23);
            this.btn_criarPartida.TabIndex = 4;
            this.btn_criarPartida.Text = "Criar partida";
            this.btn_criarPartida.UseVisualStyleBackColor = true;
            this.btn_criarPartida.Click += new System.EventHandler(this.btn_criarPartida_Click);
            // 
            // txt_senhaPartida
            // 
            this.txt_senhaPartida.Location = new System.Drawing.Point(25, 102);
            this.txt_senhaPartida.Name = "txt_senhaPartida";
            this.txt_senhaPartida.Size = new System.Drawing.Size(168, 22);
            this.txt_senhaPartida.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // txt_nomePartida
            // 
            this.txt_nomePartida.Location = new System.Drawing.Point(25, 36);
            this.txt_nomePartida.Name = "txt_nomePartida";
            this.txt_nomePartida.Size = new System.Drawing.Size(168, 22);
            this.txt_nomePartida.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da partida";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txt_senha);
            this.panel2.Controls.Add(this.txt_nomeUsuario);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(272, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 181);
            this.panel2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Entrar na partida";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(24, 108);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(196, 22);
            this.txt_senha.TabIndex = 3;
            // 
            // txt_nomeUsuario
            // 
            this.txt_nomeUsuario.Location = new System.Drawing.Point(24, 41);
            this.txt_nomeUsuario.Name = "txt_nomeUsuario";
            this.txt_nomeUsuario.Size = new System.Drawing.Size(196, 22);
            this.txt_nomeUsuario.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Senha da partida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Seu nome";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.lbl_partidaSelecionada);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.lb_partidas);
            this.panel3.Controls.Add(this.btn_listarPartida);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 452);
            this.panel3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_listarPartida;
        private System.Windows.Forms.ListBox lb_partidas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_partidaSelecionada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_criarPartida;
        private System.Windows.Forms.TextBox txt_senhaPartida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nomePartida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_nomeUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
    }
}

