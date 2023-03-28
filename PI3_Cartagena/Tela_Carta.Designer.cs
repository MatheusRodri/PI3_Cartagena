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
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panel3.Location = new System.Drawing.Point(16, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 406);
            this.panel3.TabIndex = 2;
            // 
            // btn_Listar
            // 
            this.btn_Listar.Location = new System.Drawing.Point(76, 320);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(228, 29);
            this.btn_Listar.TabIndex = 5;
            this.btn_Listar.Text = "Listar Cartas";
            this.btn_Listar.UseVisualStyleBackColor = true;
            this.btn_Listar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_SenhaUser
            // 
            this.txt_SenhaUser.Location = new System.Drawing.Point(39, 245);
            this.txt_SenhaUser.Name = "txt_SenhaUser";
            this.txt_SenhaUser.Size = new System.Drawing.Size(292, 26);
            this.txt_SenhaUser.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Senha do Usuario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Id Usuario";
            // 
            // txt_UserId
            // 
            this.txt_UserId.Location = new System.Drawing.Point(34, 118);
            this.txt_UserId.Name = "txt_UserId";
            this.txt_UserId.Size = new System.Drawing.Size(295, 26);
            this.txt_UserId.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_cartas);
            this.panel1.Location = new System.Drawing.Point(428, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 406);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mão de Cartas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_cartas
            // 
            this.lb_cartas.FormattingEnabled = true;
            this.lb_cartas.ItemHeight = 20;
            this.lb_cartas.Location = new System.Drawing.Point(33, 60);
            this.lb_cartas.Name = "lb_cartas";
            this.lb_cartas.Size = new System.Drawing.Size(272, 324);
            this.lb_cartas.TabIndex = 0;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(16, 11);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 2;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // Tela_Carta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Tela_Carta";
            this.Text = "Partida";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}