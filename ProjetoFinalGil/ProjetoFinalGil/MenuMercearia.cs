using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalGil
{
    public partial class MenuMercearia : Form
    {
        public MenuMercearia()
        {
            InitializeComponent();
        }

        private void cadastrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastrar= new CadastrarCliente();
            cadastrar.ShowDialog();
        }
    }
}
