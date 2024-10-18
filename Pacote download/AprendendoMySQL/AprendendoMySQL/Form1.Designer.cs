namespace AprendendoMySQL
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxNome = new System.Windows.Forms.TextBox();
            this.tBoxTelefone = new System.Windows.Forms.TextBox();
            this.tBoxEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listContatos = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxBuscar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            // 
            // tBoxNome
            // 
            this.tBoxNome.Location = new System.Drawing.Point(15, 34);
            this.tBoxNome.Name = "tBoxNome";
            this.tBoxNome.Size = new System.Drawing.Size(208, 20);
            this.tBoxNome.TabIndex = 3;
            // 
            // tBoxTelefone
            // 
            this.tBoxTelefone.Location = new System.Drawing.Point(15, 83);
            this.tBoxTelefone.Name = "tBoxTelefone";
            this.tBoxTelefone.Size = new System.Drawing.Size(208, 20);
            this.tBoxTelefone.TabIndex = 4;
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.Location = new System.Drawing.Point(15, 136);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(208, 20);
            this.tBoxEmail.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listContatos
            // 
            this.listContatos.HideSelection = false;
            this.listContatos.Location = new System.Drawing.Point(251, 67);
            this.listContatos.Name = "listContatos";
            this.listContatos.Size = new System.Drawing.Size(372, 253);
            this.listContatos.TabIndex = 7;
            this.listContatos.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Buscar Contato:";
            // 
            // tBoxBuscar
            // 
            this.tBoxBuscar.Location = new System.Drawing.Point(251, 34);
            this.tBoxBuscar.Name = "tBoxBuscar";
            this.tBoxBuscar.Size = new System.Drawing.Size(291, 20);
            this.tBoxBuscar.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(548, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 325);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tBoxBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listContatos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBoxEmail);
            this.Controls.Add(this.tBoxTelefone);
            this.Controls.Add(this.tBoxNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Agenda de contatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxNome;
        private System.Windows.Forms.TextBox tBoxTelefone;
        private System.Windows.Forms.TextBox tBoxEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listContatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxBuscar;
        private System.Windows.Forms.Button button2;
    }
}

