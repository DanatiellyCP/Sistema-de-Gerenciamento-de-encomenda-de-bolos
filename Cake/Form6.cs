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
    public partial class FrmEncomendas : Form
    {
        public FrmEncomendas()
        {
            InitializeComponent();
        }

       

        private void btnInserirE_Click(object sender, EventArgs e)
        {
            if (txtCodEncomenda.Text != "" && txtDataEncomenda.Text != "" && txtDataEntrega.Text!="" &&  CLStatus.Text!="" && txtKG.Text!="" && txtValorTot.Text!="" && txtCodBoloE.Text!= "" && txtCodClienteE.Text!= "")
            {
                // Chama método de inserir encomenda
                Class1 chamaCE = new Class1();
                int codigoEncomenda = Int32.Parse(txtCodEncomenda.Text);
                string dataEncomenda = txtDataEncomenda.Text;
                string dataEntrega = txtDataEntrega.Text;
                string status = CLStatus.Text;
                string descricao = txtDescricaoE.Text;
                float kg = float.Parse(txtKG.Text);
                float valorTotal = float.Parse(txtValorTot.Text);
                string codBolo = txtCodBoloE.Text;
                string codCliente = txtCodClienteE.Text;
                chamaCE.InserirEncomenda(codigoEncomenda, dataEncomenda, dataEntrega, status, descricao, kg, valorTotal, codBolo, codCliente);

                // Voltando a tabela greed ao normal
                //Class1 chamaCE = new Class1();
                dtgEncomendas.DataSource = chamaCE.CarregaTabelaEncomendas();
            }
            else
            {
                MessageBox.Show("Prencha todos os campos corretamente !");
            }
            


        }

        private void btnAlterarE_Click(object sender, EventArgs e)
        {
            if (txtCodEncomenda.Text != "" && txtDataEncomenda.Text != "" && txtDataEntrega.Text != "" && CLStatus.Text != "" && txtKG.Text != "" && txtValorTot.Text != "" && txtCodBoloE.Text != "" && txtCodClienteE.Text != "")
            {
                // Chama método de alterar encomenda
                Class1 chamaAE = new Class1();
                int codigoEncomenda = Int32.Parse(txtCodEncomenda.Text);
                string dataEncomenda = txtDataEncomenda.Text;
                string dataEntrega = txtDataEntrega.Text;
                string status = CLStatus.Text;
                string descricao = txtDescricaoE.Text;
                float kg = float.Parse(txtKG.Text);
                float valorTotal = float.Parse(txtValorTot.Text);
                string codBolo = txtCodBoloE.Text;
                string codCliente = txtCodClienteE.Text;
                chamaAE.alterarEncomenda(codigoEncomenda, dataEncomenda, dataEntrega, status, descricao, kg, valorTotal, codBolo, codCliente);

                // Voltando a tabela greed ao normal
                Class1 chamaCE = new Class1();
                dtgEncomendas.DataSource = chamaCE.CarregaTabelaEncomendas();
            }
            else
            {
                MessageBox.Show("Prencha todos os campos corretamente !");
            }
        }

        private void btnPesquisarE_Click(object sender, EventArgs e)
        {
            // chama método de pesquisar encomenda
            if (txtNomeClienteP.Text != "")
            {
                Class1 chamaPE = new Class1();
                string nomeClientePesquisa = txtNomeClienteP.Text;
                dtgEncomendas.DataSource = chamaPE.pesquisaEncomenda(nomeClientePesquisa);
            }
            else
            {
                MessageBox.Show("Preencha o campo com o nome do cliente para fazer a busca! !");
            }
        }

        private void FrmEncomendas_Load(object sender, EventArgs e)
        {
            // Chamar método de carregar tabela de encomendas 
            Class1 chamaCE = new Class1();
            dtgEncomendas.DataSource = chamaCE.CarregaTabelaEncomendas();
        }

        private void btnDeletarE_Click(object sender, EventArgs e)
        {
            // chama método para excluir Encomenda
            if (txtCodEncomenda.Text != "")
            {
                int idEncomenda = Int32.Parse(txtCodEncomenda.Text);
                Class1 chamaEE = new Class1();
                chamaEE.ExcluirEncomenda(idEncomenda);

                // Voltando a tabela greed ao normal
                Class1 chamaCE = new Class1();
                dtgEncomendas.DataSource = chamaCE.CarregaTabelaEncomendas();
            }
            else
            {
                MessageBox.Show("Informe o Código da encomenda que deseja excluir");
            }
        }

        private void btnLimparEncomendas_Click(object sender, EventArgs e)
        {
            txtCodEncomenda.Text = "";
            txtDataEncomenda.Text = "";
            txtDataEntrega.Text = "";
            CLStatus.Text = "";
            txtDescricaoE.Text = "";
            txtKG.Text = "";
            txtValorTot.Text = "";
            txtCodBoloE.Text = "";
            txtCodClienteE.Text = "";
            txtNomeClienteP.Text = "";
            // Voltando a tabela greed ao normal
            Class1 chamaCE = new Class1();
            dtgEncomendas.DataSource = chamaCE.CarregaTabelaEncomendas();
        }

        private void btnPesquisa2_Click(object sender, EventArgs e)
        {
            // Chama método de PESQUISA entre datas
            if(txtDe.Text=="" && txtDe.Text == "")
            {
                string de = txtDe.Text;
                string ate = txtAte.Text;

                Class1 chamaPED = new Class1();
                //chamaPED.pesquisaEncomendaDatas(de, ate);

                dtgEncomendas.DataSource = chamaPED.pesquisaEncomendaDatas(de, ate);
            }
            else
            {
                MessageBox.Show("Informe as datas de busca!");
            }
            

        }
    }
}
