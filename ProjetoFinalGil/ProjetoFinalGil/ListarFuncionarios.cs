using ProjetoGil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalGil
{
    public partial class ListarFuncionarios : Form
    {
        public ListarFuncionarios()
        {
            InitializeComponent();
            AtualizarListView();
            Excluirbutton3.Visible = false;
        }

        private void AtualizarListView()
        {
            listView1.Items.Clear();
            FuncDao FuncionarioDao = new FuncDao();

            List<FUNCIONARIOS> funcionarios = FuncionarioDao.ListarTodosUsuarios();
            if (funcionarios.Count > 0)
            {
                foreach (FUNCIONARIOS FUNCIONARIO in funcionarios)
                {
                    ListViewItem lista = new ListViewItem(FUNCIONARIO.Id.ToString());
                    lista.SubItems.Add(FUNCIONARIO.NOME_FUNC);
                    lista.SubItems.Add(FUNCIONARIO.SEXO);
                    lista.SubItems.Add(FUNCIONARIO.CPF);
                    lista.SubItems.Add(FUNCIONARIO.ADMISSAO.ToString("dd/MM/yyyy"));
                    lista.SubItems.Add(FUNCIONARIO.SALARIO.ToString());
                    lista.SubItems.Add(FUNCIONARIO.CARGO);
                    lista.SubItems.Add(FUNCIONARIO.DEPTO);
                    listView1.Items.Add(lista);
                }
            }
        }

        private void ListaFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void Cadastrobutton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CadastrarFuncionarios cadastrarFuncionarios = new CadastrarFuncionarios();
            cadastrarFuncionarios.ShowDialog();
            this.Visible = true;
            AtualizarListView();
        }

        private void Atualizarbutton2_Click(object sender, EventArgs e)
        {
            Atualizarbutton2.Visible = false;
            Excluirbutton3.Visible = false;
        }

        private void Excluirbutton3_Click(object sender, EventArgs e)
        {
            int index = listView1.FocusedItem.Index;
            int id = int.Parse(listView1.Items[index].SubItems[0].Text);
            FuncDao usuariosFxcluir = new FuncDao();
            usuariosFxcluir.Excluir(id);
            AtualizarListView();
        }

        private void FuncionariosListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListarFuncionarios_Load(object sender, EventArgs e)
        {
            Excluirbutton3.Visible = true;
        }

        private void Excluirbutton3_Click_1(object sender, EventArgs e)
        {
            int index = listView1.FocusedItem.Index;
            FuncDao extra = new FuncDao();
            extra.Excluir(index);
        }

        private void Atualizarbutton2_Click_1(object sender, EventArgs e)
        {
            int index = listView1.FocusedItem.Index;
            int ID = int.Parse(listView1.Items[index].SubItems[0].Text);
            string NOME_FUNC = listView1.Items[index].SubItems[1].Text;
            string SEXO = listView1.Items[index].SubItems[2].Text;
            string CPF = listView1.Items[index].SubItems[3].Text;
            DateTime ADMISSAO = Convert.ToDateTime(listView1.Items[index].SubItems[4].Text);
            Double SALARIO = Convert.ToDouble(listView1.Items[index].SubItems[5].Text);
            string CARGO = listView1.Items[index].SubItems[6].Text;
            string DEPTO = listView1.Items[index].SubItems[7].Text;
            
            

        }

        private void Cadastrobutton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}