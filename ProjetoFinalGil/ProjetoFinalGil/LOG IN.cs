using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoFinalGil
{
    public partial class SistemaGestao : Form
    {
        public SistemaGestao()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtProprietário.Text.Equals("GILMAR")&& txtSenha.Text.Equals("123"))
                {
                    var menu = new CadastrarCliente();
                    menu.ShowDialog();

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show( "Proprietário ou Sennha incorreta", "Dsculpe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProprietário.Focus();
                    txtSenha.Text = "";
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Dsculpe", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }    
}
