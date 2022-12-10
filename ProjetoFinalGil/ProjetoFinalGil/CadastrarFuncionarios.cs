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
    public partial class CadastrarFuncionarios : Form
    {
        public CadastrarFuncionarios()
        {
            InitializeComponent();

        }
        public CadastrarFuncionarios(string NOME_FUNC, string SEXO, string CPF,DateTime ADMISSAO, Double SALARIO, string CARGO, string DEPTO)
        {
            InitializeComponent();
            textBox2.Text = NOME_FUNC;
            textBox3.Text = SEXO;
            textBox4.Text = CPF;
            dateTimePicker1.Value = ADMISSAO;
            double salario = Convert.ToDouble(textBox7);
            textBox7.Text = CARGO;
            textBox8.Text = DEPTO;

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cadastrarbutton1_Click(object sender, EventArgs e)
        {
            FUNCIONARIOS FUNC = new FUNCIONARIOS(Convert.ToInt32( textBox2), textBox3.Text, textBox4.Text, textBox6.Text, dateTimePicker1.Value, Convert.ToDouble (textBox7), textBox8.Text,comboBox1.Text);
            FuncDao FuncDao = new FuncDao();
            FuncDao.Inserir(FUNC);
        }

        private void CadastrarFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
