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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void bolosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chamar o form de bolos
            FrmBolos bolo = new FrmBolos();
            bolo.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chamar o form de login
            FrmLogin login = new FrmLogin();
            login.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chamar o form de clientes
            FrmClientes cliente = new FrmClientes();
            cliente.Show();
        }

        private void encomendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chamar o form de encomendas
            FrmEncomendas encomenda = new FrmEncomendas();
            encomenda.Show();
        }

        private void administraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chamar o form de administração
            FrmAdministracao adminstracao = new FrmAdministracao();
            adminstracao.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Faz o Logim no sistema
            if (txtUsuario.Text != "" && txtSenhaLogin.Text != "")
            {
                Class1 chamaLogin = new Class1();
                string usuario = txtUsuario.Text;
                string senha = txtSenhaLogin.Text;
                chamaLogin.FazerLogin(usuario, senha);
                menuStrip1.Visible = true;
                groupBox1.Visible = false;
            }
            else
            {
                MessageBox.Show("Informe a senha e o usuário !");
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSenhaLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
