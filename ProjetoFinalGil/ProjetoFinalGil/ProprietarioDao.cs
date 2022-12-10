using ProjetoGil;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalGil
{
    class ProprietarioDao
    {

        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public ProprietarioDao()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }
        public void Inserir(Proprietario usuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO CLIENTES VALUES (@nome, @sexo, @cpf, @email, @telefone, @endereco)";

            Cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            Cmd.Parameters.AddWithValue("@email", usuario.SEXO);
            Cmd.Parameters.AddWithValue("@telefone", usuario.CPF);
            Cmd.Parameters.AddWithValue("@endereco", usuario.EMAIL);
            Cmd.Parameters.AddWithValue("@cpf", usuario.TELEFONE);
            Cmd.Parameters.AddWithValue("@atividade", usuario.ENDERECO);



            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir usuario no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        public void Excluir(int id)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"Delete from usuarios where id = @id";
            Cmd.Parameters.AddWithValue("@id", id);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao excluir usuário.");
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        public void Alterar(Proprietario usuarios)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Usuarios SET NOME = @nome, SEXO = @sexo, CPF = @cpf, EMAIL = @email, TELEFONE = @telefone, ENDERECO = @endereco WHERE ID = @id";
            Cmd.Parameters.AddWithValue("@id", usuarios.Id);
            Cmd.Parameters.AddWithValue("@nome", usuarios.Nome);
            Cmd.Parameters.AddWithValue("@sexo", usuarios.SEXO);
            Cmd.Parameters.AddWithValue("@cpf", usuarios.CPF);
            Cmd.Parameters.AddWithValue("@email", usuarios.EMAIL);
            Cmd.Parameters.AddWithValue("@telefone", usuarios.TELEFONE);
            Cmd.Parameters.AddWithValue("@endereço", usuarios.ENDERECO);

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


        public List<Proprietario> ListarTodosUsuarios()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM PROPRIETARIO";

            List<Proprietario> listaDeUsuarios = new List<Proprietario>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    Proprietario usuario = new Proprietario((int)rd["ID"], (string)rd["NOME"],
                        (string)rd["SEXO"], (string)rd["CPF"], (string)rd["EMAIL"], (string)rd["TELEFONE"], (string)rd["ENDERECO"]);
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
