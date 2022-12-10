using ProjetoGil;
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
    public partial class CadastrarProprietario : Form
    {
        public CadastrarProprietario()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1CADSTRAR_Click(object sender, EventArgs e)
        {
            Proprietario Pro = new Proprietario(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, comboBox1.Text);
            ProprietarioDao Prodao = new ProprietarioDao();
            Prodao.Inserir(Pro);
        }

        private void CadastrarProprietario_Load(object sender, EventArgs e)
        {

        }
    }
}
