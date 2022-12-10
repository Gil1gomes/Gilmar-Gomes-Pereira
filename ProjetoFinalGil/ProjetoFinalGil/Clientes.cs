using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetoFinalGil
{
    internal class Clientes
    {
        private int _id;
        private string _Nome;
        private string _Email;
        private string _Telefone;
        private string _Endereco;
        private string _CPF;
        private string _atividade;


        public Clientes(string nome, string email, string telefone, string endereco, string cpf, string atividade)
        {

            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            CPF = cpf;
            ATIVIDADE = atividade;






        }
        public Clientes(int id, string nome, string email, string telefone, string endereco, string cpf, string atividade)
        {
            _id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            CPF = cpf;
            ATIVIDADE = atividade;

        }

        public int Id
        {
            get { return _id; }

        }
        public string Nome
        {
            get { return _Nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("o nome informado não é um texto valido");
                _Nome = value;
            }
        }


        public string Email
        {
            get { return _Email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("o email informado não é um texto valido");
                _Email = value;
            }
        }

        public string Telefone
        {
            get { return _Telefone; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("o telefone informado não é um texto valido");
                _Telefone = value;
            }



        }

        public string Endereco
        {
            get { return _Endereco; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("o endereço informado não é um texto valido--- O texto vem daqui");
                _Endereco = value;
            }
        }

        public string CPF
        {
            get { return _CPF; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("o cpf informado é invalido");
                _CPF = value;
            }
        }

        public string ATIVIDADE
        {
            get { return _atividade; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A atividade informado é invalido");
                _atividade = value;
            }
        }
    }
}