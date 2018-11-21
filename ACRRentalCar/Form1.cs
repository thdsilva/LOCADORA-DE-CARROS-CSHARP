using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACRRentalCar
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria um novo formulário
            Form frm = new fmrCadastroCliente();
            // Define quem é o pai dessa janela
            frm.MdiParent = this;
            // Exibe o formulário
            frm.Show();
        }
    }
}
