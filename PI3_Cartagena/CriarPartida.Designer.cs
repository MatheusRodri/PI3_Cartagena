namespace PI3_Cartagena
{
    partial class CriarPartida
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
            this.label3.Location = new System.Drawing.Point(165, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // txt_senhaPartida
            // 
            this.txt_senhaPartida.Location = new System.Drawing.Point(31, 231);
            this.txt_senhaPartida.Name = "txt_senhaPartida";
            this.txt_senhaPartida.Size = new System.Drawing.Size(311, 22);
            this.txt_senhaPartida.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // btn_criarPartida
            // 
            this.btn_criarPartida.Location = new System.Drawing.Point(31, 271);
            this.btn_criarPartida.Name = "btn_criarPartida";
            this.btn_criarPartida.Size = new System.Drawing.Size(311, 23);
            this.btn_criarPartida.TabIndex = 2;
            this.btn_criarPartida.Text = "button1";
            this.btn_criarPartida.UseVisualStyleBackColor = true;
            this.btn_criarPartida.Click += new System.EventHandler(this.btn_criarPartida_Click);
            // 
            // txt_nomePartida
            // 
            this.txt_nomePartida.Location = new System.Drawing.Point(31, 152);
            this.txt_nomePartida.Name = "txt_nomePartida";
            this.txt_nomePartida.Size = new System.Drawing.Size(311, 22);
            this.txt_nomePartida.TabIndex = 1;
            this.txt_nomePartida.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CriarPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 402);
            this.Controls.Add(this.panel1);
            this.Name = "CriarPartida";
            this.Text = "CriarPartida";
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