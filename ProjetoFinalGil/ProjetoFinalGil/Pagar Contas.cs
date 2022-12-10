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
    public partial class Pagar_Contas : Form
    {
        public Pagar_Contas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Digite a senha por favor!");
            }
            else if (radioButton2.Checked == true)
            {
                MessageBox.Show("Parcelar em quantas vez!");
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Pagar_Contas_Load(object sender, EventArgs e)
        {

        }
    }
}
