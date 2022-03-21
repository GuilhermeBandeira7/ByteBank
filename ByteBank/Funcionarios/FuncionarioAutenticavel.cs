using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel // the class is abstract cause we don't want to implement Funcionario's methods here and we also have the Autenticavel contract interface implemented
    {
        public string Senha { get; set; }

        public FuncionarioAutenticavel(double salario, string cpf)
            : base(salario, cpf) // we need to implement Funcionario constructor 
        {

        }

        public bool Autenticar(string senha)
        {
            return Senha == senha; 
        }
    }
}
