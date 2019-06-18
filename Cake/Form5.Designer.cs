namespace Cake
{
    partial class FrmClientes
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
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtCpfCliente = new System.Windows.Forms.TextBox();
            this.txtEnderecoCliente = new System.Windows.Forms.TextBox();
            this.txtRuaCliente = new System.Windows.Forms.TextBox();
            this.txtNumeroCliente = new System.Windows.Forms.TextBox();
            this.txtTelefoneCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPesquisarC = new System.Windows.Forms.Button();
            this.btnDeletarC = new System.Windows.Forms.Button();
            this.btnAlterarC = new System.Windows.Forms.Button();
            this.btnInserirC = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.dtGClientes = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmailClientes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(81, 34);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(288, 20);
            this.txtNomeCliente.TabIndex = 0;
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.Location = new System.Drawing.Point(439, 36);
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.Size = new System.Drawing.Size(136, 20);
            this.txtCpfCliente.TabIndex = 1;
            // 
            // txtEnderecoCliente
            // 
            this.txtEnderecoCliente.Location = new System.Drawing.Point(82, 64);
            this.txtEnderecoCliente.Name = "txtEnderecoCliente";
            this.txtEnderecoCliente.Size = new System.Drawing.Size(287, 20);
            this.txtEnderecoCliente.TabIndex = 2;
            this.txtEnderecoCliente.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtRuaCliente
            // 
            this.txtRuaCliente.Location = new System.Drawing.Point(82, 99);
            this.txtRuaCliente.Name = "txtRuaCliente";
            this.txtRuaCliente.Size = new System.Drawing.Size(287, 20);
            this.txtRuaCliente.TabIndex = 3;
            // 
            // txtNumeroCliente
            // 
            this.txtNumeroCliente.Location = new System.Drawing.Point(440, 66);
            this.txtNumeroCliente.Name = "txtNumeroCliente";
            this.txtNumeroCliente.Size = new System.Drawing.Size(60, 20);
            this.txtNumeroCliente.TabIndex = 4;
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Location = new System.Drawing.Point(440, 100);
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(138, 20);
            this.txtTelefoneCliente.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "CPF:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rua:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Número:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefone:";
            // 
            // btnPesquisarC
            // 
            this.btnPesquisarC.Location = new System.Drawing.Point(590, 34);
            this.btnPesquisarC.Name = "btnPesquisarC";
            this.btnPesquisarC.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarC.TabIndex = 15;
            this.btnPesquisarC.Text = "Pesquisar";
            this.btnPesquisarC.UseVisualStyleBackColor = true;
            this.btnPesquisarC.Click += new System.EventHandler(this.btnPesquisarC_Click);
            // 
            // btnDeletarC
            // 
            this.btnDeletarC.Location = new System.Drawing.Point(348, 346);
            this.btnDeletarC.Name = "btnDeletarC";
            this.btnDeletarC.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarC.TabIndex = 14;
            this.btnDeletarC.Text = "Deletar";
            this.btnDeletarC.UseVisualStyleBackColor = true;
            this.btnDeletarC.Click += new System.EventHandler(this.btnDeletarC_Click);
            // 
            // btnAlterarC
            // 
            this.btnAlterarC.Location = new System.Drawing.Point(267, 346);
            this.btnAlterarC.Name = "btnAlterarC";
            this.btnAlterarC.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarC.TabIndex = 13;
            this.btnAlterarC.Text = "Alterar";
            this.btnAlterarC.UseVisualStyleBackColor = true;
            this.btnAlterarC.Click += new System.EventHandler(this.btnAlterarC_Click);
            // 
            // btnInserirC
            // 
            this.btnInserirC.Location = new System.Drawing.Point(186, 346);
            this.btnInserirC.Name = "btnInserirC";
            this.btnInserirC.Size = new System.Drawing.Size(75, 23);
            this.btnInserirC.TabIndex = 12;
            this.btnInserirC.Text = "Inserir";
            this.btnInserirC.UseVisualStyleBackColor = true;
            this.btnInserirC.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(429, 346);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 16;
            this.btnApagar.Text = "Limpar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // dtGClientes
            // 
            this.dtGClientes.AllowUserToAddRows = false;
            this.dtGClientes.AllowUserToDeleteRows = false;
            this.dtGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGClientes.Location = new System.Drawing.Point(54, 177);
            this.dtGClientes.Name = "dtGClientes";
            this.dtGClientes.ReadOnly = true;
            this.dtGClientes.Size = new System.Drawing.Size(626, 150);
            this.dtGClientes.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "E-mail:";
            // 
            // txtEmailClientes
            // 
            this.txtEmailClientes.Location = new System.Drawing.Point(81, 129);
            this.txtEmailClientes.Name = "txtEmailClientes";
            this.txtEmailClientes.Size = new System.Drawing.Size(288, 20);
            this.txtEmailClientes.TabIndex = 19;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 402);
            this.Controls.Add(this.txtEmailClientes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtGClientes);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnPesquisarC);
            this.Controls.Add(this.btnDeletarC);
            this.Controls.Add(this.btnAlterarC);
            this.Controls.Add(this.btnInserirC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefoneCliente);
            this.Controls.Add(this.txtNumeroCliente);
            this.Controls.Add(this.txtRuaCliente);
            this.Controls.Add(this.txtEnderecoCliente);
            this.Controls.Add(this.txtCpfCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Clientes";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtCpfCliente;
        private System.Windows.Forms.TextBox txtEnderecoCliente;
        private System.Windows.Forms.TextBox txtRuaCliente;
        private System.Windows.Forms.TextBox txtNumeroCliente;
        private System.Windows.Forms.TextBox txtTelefoneCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPesquisarC;
        private System.Windows.Forms.Button btnDeletarC;
        private System.Windows.Forms.Button btnAlterarC;
        private System.Windows.Forms.Button btnInserirC;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.DataGridView dtGClientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmailClientes;
    }
}