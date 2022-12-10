using ProjetoGil;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalGil
{
    internal class FuncDao
    {

        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public FuncDao()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }
        public void Inserir(FUNCIONARIOS usuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO CLIENTES VALUES (@nome, @email, @telefone, @endereco, @cpf, @atividade)";

            Cmd.Parameters.AddWithValue("@nome_func", usuario.NOME_FUNC);
            Cmd.Parameters.AddWithValue("@sexo", usuario.SEXO);
            Cmd.Parameters.AddWithValue("@cpf", usuario.CPF);
            Cmd.Parameters.AddWithValue("@admissao", usuario.ADMISSAO);
            Cmd.Parameters.AddWithValue("@salario", usuario.SALARIO);
            Cmd.Parameters.AddWithValue("@cargo", usuario.CARGO);
            Cmd.Parameters.AddWithValue("@depto", usuario.DEPTO);


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
            Cmd.CommandText = @"Delete from FUNCIONARIOS where ID = @id";
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
        public void Alterar(FUNCIONARIOS usuarios)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Usuarios SET NOME_FUNC = @nome_func, SEXO = @sexo, CPF = @cpf, ADMISSAO = @admissao, SALARIO = @salario, CARGO = @cargo, DEPTO - @depto, WHERE ID = @id";
            Cmd.Parameters.AddWithValue("@id", usuarios.Id);
            Cmd.Parameters.AddWithValue("@nome_func", usuarios.NOME_FUNC);
            Cmd.Parameters.AddWithValue("@sexo", usuarios.SEXO);
            Cmd.Parameters.AddWithValue("@cpf", usuarios.CPF);
            Cmd.Parameters.AddWithValue("@admissao", usuarios.ADMISSAO);
            Cmd.Parameters.AddWithValue("@salario", usuarios.SALARIO);
            Cmd.Parameters.AddWithValue("@cargo", usuarios.CARGO);
            Cmd.Parameters.AddWithValue("@depto", usuarios.DEPTO); 

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


        public List<FUNCIONARIOS> ListarTodosUsuarios()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM FUNCIONARIOS";

            List<FUNCIONARIOS> listaDeUsuarios = new List<FUNCIONARIOS>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                while (rd.Read())
                {
                    FUNCIONARIOS usuario = new FUNCIONARIOS((int)rd["Id"], (string)rd["NOME_FUNC"],
                        (string)rd["SEXO"], (string)rd["CPF"], (DateTime)rd["ADMISSAO"], (double)rd["SALARIO"], (string)rd["CARGO"], (string)rd["DEPTO"]);
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
