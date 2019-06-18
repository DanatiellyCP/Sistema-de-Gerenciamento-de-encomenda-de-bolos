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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // teste inserir adm
            Class1 chama = new Class1();
            string codigo = txtCodigo.Text;
            string senha = txtSenha.Text;
            string nome = txtNome.Text;
            chama.cadastrarAdm(codigo, nome, senha);

        }
    }
}
