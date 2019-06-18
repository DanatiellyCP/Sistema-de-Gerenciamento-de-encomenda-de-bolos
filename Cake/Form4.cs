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
    public partial class FrmBolos : Form
    {
       
        public FrmBolos()
        {
            InitializeComponent();
             
        }
        

       
        

        private void button1_Click(object sender, EventArgs e)
        {
            // chamar a função de cadastro de bolo
            // teste inserir adm
            if (txtCodigoBolo.Text != "" && txtNomeBolo.Text != "" && txtPrecoBolo.Text != "" && txtDescricaoBolo.Text != "")
            {
                Class1 chamaCB = new Class1();
                string codigoBolo = txtCodigoBolo.Text;
                string nomeBolo = txtNomeBolo.Text;
                float precoBolo = float.Parse(txtPrecoBolo.Text);
                string descricaoBolo = txtDescricaoBolo.Text;
                chamaCB.cadastrarBolo(codigoBolo, nomeBolo, descricaoBolo, precoBolo);
            }
            else
                MessageBox.Show("Preencha todos os campos corretamente");
            
            /*dtGBolos.Refresh();
            txtCodigoBolo.Text = "";
            txtNomeBolo.Text = "";
            txtPrecoBolo.Text = "";
            txtDescricaoBolo.Text = "";*/

        }

        private void FrmBolos_Load(object sender, EventArgs e)
        {
            //Carrregar tabela de bolos
            Class1 chamaCTB = new Class1();
            dtGBolos.DataSource = chamaCTB.CarregaTabelaBolo();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Chamar a função para alterar dados de Bolos
            if (txtCodigoBolo.Text != "" && txtNomeBolo.Text != "" && txtPrecoBolo.Text != "" && txtDescricaoBolo.Text != "")
            {
                Class1 chamaAB = new Class1();
                string codigoBolo = txtCodigoBolo.Text;
                string nomeBolo = txtNomeBolo.Text;
                float precoBolo = float.Parse(txtPrecoBolo.Text);
                string descricaoBolo = txtDescricaoBolo.Text;

                chamaAB.alterarBolo(codigoBolo, nomeBolo, descricaoBolo, precoBolo);
            }
            else
            {
                MessageBox.Show("Prencha todos os campos para fazer a alteração!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Chamar função para pesquisar bolo
            if (txtCodigoBolo.Text != "")
            {
                Class1 chamaPB = new Class1();
                string codigoBolo = txtCodigoBolo.Text;
                richTextBox1.Text = chamaPB.pesquisaBolo(codigoBolo);
            }
            else
                MessageBox.Show("Informe o código do bolo.");
            
           
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // chma  a função que exclui bolo
            if (txtNomeBolo.Text != "")
            {
                Class1 chamaEB = new Class1();
                string nomeBolo = txtNomeBolo.Text;
                chamaEB.ExcluirBolo(nomeBolo);
            }
            else
            {
                MessageBox.Show("Informe o nome do bolo que deseja excluir!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDescricaoBolo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // chama função que carrega a tabela
            Class1 chamaCTB = new Class1();

           dtGBolos.DataSource = chamaCTB.CarregaTabelaBolo();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            txtCodigoBolo.Text = "";
            txtNomeBolo.Text = "";
            txtPrecoBolo.Text = "";
            txtDescricaoBolo.Text = "";
            richTextBox1.Text = "";
        }

        private void txtPrecoBolo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoBolo_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeBolo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        
    }
}
