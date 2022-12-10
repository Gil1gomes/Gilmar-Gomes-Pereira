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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoFinalGil
{
    public partial class ListaCliente : Form
    {
        public ListaCliente()
        {
            InitializeComponent();
            AtualizarListView();
        }

        private void AtualizarListView()
        {
            ClientesListView.Items.Clear();
            UsuariosDAO usuariosDAO = new UsuariosDAO();

            List<Clientes> clientes = usuariosDAO.ListarTodosUsuarios();
            if(clientes.Count > 0 )
            {
                foreach (Clientes cliente in clientes)
                {
                    ListViewItem lista = new ListViewItem(cliente.Id.ToString());
                    lista.SubItems.Add(cliente.Nome);
                    lista.SubItems.Add(cliente.Email);
                    lista.SubItems.Add(cliente.Telefone);
                    lista.SubItems.Add(cliente.Endereco);
                    lista.SubItems.Add(cliente.CPF);
                    ClientesListView.Items.Add(lista);
                }
            }
        }

        private void ListaCliente_Load(object sender, EventArgs e)
        {

        }

        private void cadastrobutton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CadastrarCliente CadastrarCliente = new CadastrarCliente();
            CadastrarCliente.ShowDialog();
            this.Visible = true;
            AtualizarListView();
        }

        private void Atualizarbutton1_Click(object sender, EventArgs e)
        {
           // Atualizarbutton1.Visible = false;
         //   excluirbutton1.Visible = false;

            int index = ClientesListView.FocusedItem.Index;
            int ID = int.Parse(ClientesListView.Items[index].SubItems[0].Text);
            string NOME = ClientesListView.Items[index].SubItems[1].Text;
            string EMAIL = ClientesListView.Items[index].SubItems[2].Text;
            string TELEFONE = ClientesListView.Items[index].SubItems[3].Text;
            string ENDERECO = ClientesListView.Items[index].SubItems[4].Text;
            string CPF = ClientesListView.Items[index].SubItems[5].Text;

        }

        private void excluirbutton1_Click(object sender, EventArgs e)
        {
            int index = ClientesListView.FocusedItem.Index;
            int id = int.Parse(ClientesListView.Items[index].SubItems[0].Text);
            UsuariosDAO usuariosFxcluir = new UsuariosDAO();
            usuariosFxcluir.Excluir(id);
            AtualizarListView();
        }

        private void ClientesListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
