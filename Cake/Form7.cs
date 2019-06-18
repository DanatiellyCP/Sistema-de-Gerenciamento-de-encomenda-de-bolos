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
    public partial class FrmAdministracao : Form
    {
        public FrmAdministracao()
        {
            InitializeComponent();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre janela com ajuda dos sistema
            MessageBox.Show("1 - Para cadastrar Bolos, Encomendas e Clientes, lembre-se: Sempre preencha todos os campos corretamente\n2 - Todos os Campos estão sempre com legendas.\nCakeSystem");
        }
    }
}
