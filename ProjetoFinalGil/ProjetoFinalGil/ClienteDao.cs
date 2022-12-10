using ProjetoFinalGil;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoGil

{
    internal class UsuariosDAO
    {

        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public UsuariosDAO()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }
        public void Inserir(Clientes usuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO CLIENTES VALUES (@nome, @email, @telefone, @endereco, @cpf, @atividade)";

            Cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            Cmd.Parameters.AddWithValue("@email", usuario.Email);
            Cmd.Parameters.AddWithValue("@telefone", usuario.Telefone);
            Cmd.Parameters.AddWithValue("@endereco", usuario.Endereco);
            Cmd.Parameters.AddWithValue("@cpf", usuario.CPF);
            Cmd.Parameters.AddWithValue("@atividade", usuario.ATIVIDADE);



            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir clientes no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
 
        public void Excluir(int ID)
        {
 
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"Delete from Cliente where ID = @id";
            Cmd.Parameters.AddWithValue("@id", ID);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao excluir Cliente no banco.\n");
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        public void Alterar(Clientes usuarios)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE clientes SET NOME = @nome, EMAIL = @email, TELEFONE = @telefone, ENDERECO = @endereco, CPF = @cpf, ATIVIDAE = @atividae, WHERE ID = @id";
            Cmd.Parameters.AddWithValue("@id", usuarios.Id);
            Cmd.Parameters.AddWithValue("@nome", usuarios.Nome);
            Cmd.Parameters.AddWithValue("@email", usuarios.Email);
            Cmd.Parameters.AddWithValue("@telefone", usuarios.Telefone);
            Cmd.Parameters.AddWithValue("@endereco", usuarios.Endereco);
            Cmd.Parameters.AddWithValue("@cpf", usuarios.CPF);
            Cmd.Parameters.AddWithValue("@atividade", usuarios.ATIVIDADE);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("\"Erro: Problemas ao alterar usuario no banco.\\n\" + err.Message");


            }
            finally
            {
                Con.CloseConnection();
            }
        }


        public List<Clientes> ListarTodosUsuarios()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM CLIENTES";

            List<Clientes> listaDeUsuarios = new List<Clientes>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    Clientes usuario = new Clientes((int)rd["ID"], (string)rd["Nome"],
                        (string)rd["Email"], (string)rd["Telefone"], (string)rd["Endereco"], (string)rd["CPF"], (string)rd["ATIVIDADE"]);
                    listaDeUsuarios.Add(usuario);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

            return listaDeUsuarios;
        }


    }
}


