using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetoFinalGil
{
    internal class FUNCIONARIOS
    {
        private int _ID;
        private string _NOME_FUNC;
        private string _SEXO;
        private string _CPF;
        private DateTime _ADMISSAO;
        private Double _SALARIO;
        private string _CARGO;
        private string _DEPTO;


        public FUNCIONARIOS(string nome_func, string sexo, string cpf, DateTime admissao, Double salario, string cargo, string depto)
        {

            NOME_FUNC = nome_func;
            SEXO = sexo;
            CPF = cpf;
            ADMISSAO = admissao;
            SALARIO = salario;
            DEPTO = depto;






        }
        public FUNCIONARIOS(int id, string nome_func, string sexo, string cpf, DateTime admissao, Double salario, string cargo,string depto)
        {
            _ID = id;
            NOME_FUNC = nome_func;
            SEXO = sexo;
            CPF = cpf;
            ADMISSAO = admissao;
            SALARIO = salario;
            DEPTO = depto;

        }

        public int Id
        {
            get { return _ID; }

        }
        public string NOME_FUNC
        {
            get { return _NOME_FUNC; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("o nome informado não é um texto valido");
                _NOME_FUNC = value;
            }
        }


        public string SEXO
        {
            get { return _SEXO; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("o email informado não é um texto valido");
                _SEXO = value;
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

        public DateTime ADMISSAO
        {
            get { return _ADMISSAO; }
            set
            {
                //if (DateTime.IsNullOrEmpty(value =null))
                  //  throw new Exception("o endereço informado não é um texto valido--- O texto vem daqui");
                _ADMISSAO = value;
            }
        }

        public Double SALARIO
        {
            get { return _SALARIO; }
            set
            {
                //if (Double.IsNullOrEmpty(value))
                //    throw new Exception("o cpf informado é invalido");
                _SALARIO = value;
            }
        }

        public string CARGO
        {
            get { return _CARGO; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A atividade informado é invalido");
                _CARGO = value;
            }
        }
        public string DEPTO
        {
            get { return _DEPTO; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A atividade informado é invalido");
                _DEPTO = value;
            }
        }
    }
}