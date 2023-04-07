namespace PI3_Cartagena
{
    partial class Tela_CriarPartida
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_senhaPartida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_criarPartida = new System.Windows.Forms.Button();
            this.txt_nomePartida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_senhaPartida);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_criarPartida);
            this.panel1.Controls.Add(this.txt_nomePartida);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 508);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 54);
            this.label3.TabIndex = 5;
            this.label3.Text = "Criar Partida";
            // 
            // txt_senhaPartida
            // 
            this.txt_senhaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senhaPartida.Location = new System.Drawing.Point(32, 208);
            this.txt_senhaPartida.Name = "txt_senhaPartida";
            this.txt_senhaPartida.Size = new System.Drawing.Size(311, 38);
            this.txt_senhaPartida.TabIndex = 4;
            this.txt_senhaPartida.TextChanged += new System.EventHandler(this.txt_senhaPartida_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha da partida";
            // 
            // btn_criarPartida
            // 
            this.btn_criarPartida.Location = new System.Drawing.Point(31, 266);
            this.btn_criarPartida.Name = "btn_criarPartida";
            this.btn_criarPartida.Size = new System.Drawing.Size(311, 38);
            this.btn_criarPartida.TabIndex = 2;
            this.btn_criarPartida.Text = "Criar Partida";
            this.btn_criarPartida.UseVisualStyleBackColor = true;
            this.btn_criarPartida.Click += new System.EventHandler(this.btn_criarPartida_Click);
            // 
            // txt_nomePartida
            // 
            this.txt_nomePartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomePartida.Location = new System.Drawing.Point(32, 125);
            this.txt_nomePartida.Name = "txt_nomePartida";
            this.txt_nomePartida.Size = new System.Drawing.Size(311, 34);
            this.txt_nomePartida.TabIndex = 1;
            this.txt_nomePartida.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da partida";
            // 
            // Tela_CriarPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 402);
            this.Controls.Add(this.panel1);
            this.Name = "Tela_CriarPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neiva";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tela_CriarPartida_FormClosed);
            this.Load += new System.EventHandler(this.Tela_CriarPartida_Load);
            this.VisibleChanged += new System.EventHandler(this.Tela_CriarPartida_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_nomePartida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_criarPartida;
        private System.Windows.Forms.TextBox txt_senhaPartida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}