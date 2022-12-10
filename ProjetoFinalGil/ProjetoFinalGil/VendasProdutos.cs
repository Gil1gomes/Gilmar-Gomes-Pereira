using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalGil
{
    public partial class VendasProdutos : Form
    {
        public VendasProdutos()
        {
            InitializeComponent();
        }

        private void VendasProdutos_Load(object sender, EventArgs e)
        {
            
        }
        public static void Produtos(ref TextBox txt)
        {
            string valor = string.Empty; 
            double v = 0;
            try
            {
                valor = txt.Text.Replace(",","").Replace(".","");
                if (valor.Equals(""))
                    valor = "";
                valor = valor.PadLeft(3, '0');
                if (valor.Length > 3 & valor.Substring(0, 1) == "0")
                    valor = valor.Substring(1, valor.Length - 1);
                v = Convert.ToDouble(valor) / 100;
                txt.Text = string.Format("{0:n}", v);
                txt.SelectionStart= txt.Text.Length;


            }
            catch(Exception)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Produtos(ref textBox1);
        }
    }
}
