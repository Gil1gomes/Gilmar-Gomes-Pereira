using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace ProjetoFinalGil
{
    internal class Proprietario
    {
        private int _id;
        private string _Nome;
        private string _Sexo;
        private string _CPF;
        private string _EMAIL;
        private string _TELEFONE;
        private string _ENDERECO;
       


        public Proprietario(string nome, string sexo, string cpf, string email, string telefone, string endereco)
        {

            Nome = nome;
            SEXO = sexo;
            CPF = cpf;
            EMAIL = email;
            TELEFONE = telefone;
            ENDERECO = endereco;
            






        }
        public Proprietario(int id, string nome, string sexo, string cpf, string email, string telefone, string endereco)
        {
            _id = id;
            Nome = nome;
            _Sexo = sexo;
            CPF = cpf;
            _EMAIL = email;
            _TELEFONE = telefone;
            _ENDERECO = endereco;

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


        public string SEXO
        {
            get { return _Sexo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("o email informado não é um texto valido");
                _Sexo = value;
            }
        }

        public string CPF
        {
            get { return _CPF; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("o telefone informado não é um texto valido");
                _CPF = value;
            }



        }

        public string EMAIL
        {
            get { return _EMAIL; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("o endereço informado não é um texto valido--- O texto vem daqui");
                _EMAIL = value;
            }
        }

        public string TELEFONE
        {
            get { return _TELEFONE; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("o cpf informado é invalido");
                _TELEFONE = value;
            }
        }

        public string ENDERECO
        {
            get { return _ENDERECO; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A atividade informado é invalido");
                _ENDERECO = value;
            }
        }
    }
}