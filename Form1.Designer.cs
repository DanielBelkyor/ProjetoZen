namespace Projeto_Final
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxUserName = new System.Windows.Forms.TextBox();
            this.txtBxSenha = new System.Windows.Forms.TextBox();
            this.cmBxStats = new System.Windows.Forms.ComboBox();
            this.nmcNivel = new System.Windows.Forms.NumericUpDown();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmcNivel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nível";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(8, 133);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(50, 13);
            this.lblA.TabIndex = 5;
            this.lblA.Text = "A = Ativo";
            this.lblA.Visible = false;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(73, 133);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(77, 13);
            this.lblB.TabIndex = 6;
            this.lblB.Text = "B = Bloqueado";
            this.lblB.Visible = false;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(168, 133);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(73, 13);
            this.lblC.TabIndex = 7;
            this.lblC.Text = "C = Desligado";
            this.lblC.Visible = false;
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(11, 25);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(146, 20);
            this.txtBxName.TabIndex = 8;
            // 
            // txtBxUserName
            // 
            this.txtBxUserName.Location = new System.Drawing.Point(177, 25);
            this.txtBxUserName.Name = "txtBxUserName";
            this.txtBxUserName.Size = new System.Drawing.Size(100, 20);
            this.txtBxUserName.TabIndex = 9;
            // 
            // txtBxSenha
            // 
            this.txtBxSenha.Location = new System.Drawing.Point(297, 25);
            this.txtBxSenha.Name = "txtBxSenha";
            this.txtBxSenha.Size = new System.Drawing.Size(100, 20);
            this.txtBxSenha.TabIndex = 10;
            // 
            // cmBxStats
            // 
            this.cmBxStats.FormattingEnabled = true;
            this.cmBxStats.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmBxStats.Location = new System.Drawing.Point(11, 87);
            this.cmBxStats.Name = "cmBxStats";
            this.cmBxStats.Size = new System.Drawing.Size(121, 21);
            this.cmBxStats.TabIndex = 11;
            this.cmBxStats.SelectedIndexChanged += new System.EventHandler(this.cmBxStats_SelectedIndexChanged);
            // 
            // nmcNivel
            // 
            this.nmcNivel.Location = new System.Drawing.Point(177, 87);
            this.nmcNivel.Name = "nmcNivel";
            this.nmcNivel.Size = new System.Drawing.Size(84, 20);
            this.nmcNivel.TabIndex = 12;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(15, 183);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(62, 23);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(83, 183);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(348, 183);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 16;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Visualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 218);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.nmcNivel);
            this.Controls.Add(this.cmBxStats);
            this.Controls.Add(this.txtBxSenha);
            this.Controls.Add(this.txtBxUserName);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmcNivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxUserName;
        private System.Windows.Forms.TextBox txtBxSenha;
        private System.Windows.Forms.ComboBox cmBxStats;
        private System.Windows.Forms.NumericUpDown nmcNivel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button button1;
    }
}

