using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cake
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //Carrregar tabela de clientes
            Class1 chamaCTC = new Class1();
            dtGClientes.DataSource = chamaCTC.CarregaTabelaCliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // chamar a função de cadastro de clientes
            // teste inserir adm
            if (txtNomeCliente.Text != "" && txtCpfCliente.Text != "" && txtEnderecoCliente.Text != "" && txtRuaCliente.Text != "" && txtNumeroCliente.Text != "" && txtTelefoneCliente.Text != "" )
            {
                Class1 chamaCC = new Class1();
                string NomeCliente = txtNomeCliente.Text;
                string cpfCliente = txtCpfCliente.Text;
                string enderecoCliente = txtEnderecoCliente.Text;
                string ruaCliente = txtRuaCliente.Text;
                int numeroCliente = Int32.Parse(txtNumeroCliente.Text);
                string telefoneCliente = txtTelefoneCliente.Text;
                string emailCliente = txtEmailClientes.Text;

                chamaCC.cadastrarClientes(NomeCliente, cpfCliente, enderecoCliente, ruaCliente, telefoneCliente, emailCliente, numeroCliente);

                txtNomeCliente.Text = "";
                txtCpfCliente.Text = "";
                txtEnderecoCliente.Text = "";
                txtRuaCliente.Text = "";
                txtNumeroCliente.Text = "";
                txtTelefoneCliente.Text = "";

            }
            else
                MessageBox.Show("Preencha todos os campos corretamente");
        }

       

        private void btnAlterarC_Click(object sender, EventArgs e)
        {
            // Evento de alteração da tabela clientes
            if (txtNomeCliente.Text != "" && txtCpfCliente.Text != "" && txtEnderecoCliente.Text != "" && txtRuaCliente.Text != "" && txtNumeroCliente.Text != "" && txtTelefoneCliente.Text != "")
            {
                Class1 chamaAC = new Class1();
                string NomeCliente = txtNomeCliente.Text;
                string cpfCliente = txtCpfCliente.Text;
                string enderecoCliente = txtEnderecoCliente.Text;
                string ruaCliente = txtRuaCliente.Text;
                int numeroCliente = Int32.Parse(txtNumeroCliente.Text);
                string telefoneCliente = txtTelefoneCliente.Text;

                chamaAC.alterarClientes(NomeCliente, cpfCliente, enderecoCliente, ruaCliente, numeroCliente, telefoneCliente);
            }
            else
            {
                MessageBox.Show("Informe todos os campos para fazer a alteração");
            }
        }

        private void btnPesquisarC_Click(object sender, EventArgs e)
        {
            // Chma metod de pesquisa de cliente
            // Chamar função para pesquisar bolo
            if (txtNomeCliente.Text != "")
            {
                Class1 chamaPC = new Class1();
                string nomeCliente = txtNomeCliente.Text;
                //richTextBox1.Text = chamaPB.pesquisaBolo(codigoBolo);
                dtGClientes.DataSource = chamaPC.pesquisaCliente(nomeCliente);
                
                
            }
            else
                MessageBox.Show("Informe o nome do cliente !");
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text = "";
            txtCpfCliente.Text = "";
            txtEnderecoCliente.Text = "";
            txtRuaCliente.Text = "";
            txtNumeroCliente.Text = "";
            txtTelefoneCliente.Text = "";

            // Voltando a tabela greed ao normal
            Class1 chamaCC = new Class1();
            dtGClientes.DataSource = chamaCC.CarregaTabelaCliente();


        }

        private void btnDeletarC_Click(object sender, EventArgs e)
        {
            // Chama metodo de exclusão de cliente
            Class1 chamaEC = new Class1();
            string nomeCliente = txtNomeCliente.Text;
            chamaEC.ExcluirCliente(nomeCliente);
        }
    }
}
