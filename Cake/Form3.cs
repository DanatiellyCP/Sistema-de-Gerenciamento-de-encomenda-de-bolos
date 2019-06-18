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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Faz o Logim no sistema
            Class1 chamaLogin = new Class1();
            string usuario = txtUsuario.Text;
            string senha = txtSenhaLogin.Text;
            chamaLogin.FazerLogin(usuario, senha);
            this.Close();
            

        }
    }
}
