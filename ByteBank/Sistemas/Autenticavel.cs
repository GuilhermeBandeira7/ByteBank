using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public abstract class Autenticavel : Funcionario // Autenticavel has to be abstract because it inherited Funcionario and we don't need funcionarios' abstract implementations
    {
        public string Senha { get; set; }

        protected Autenticavel(double salario, string cpf) // we need this constructor because of the Funcionario class
            : base (salario, cpf) //base calls the constructor of funcionario (master class)
        {            
        }

        public bool Autenticar(string senha)
        {
            if (Senha == senha)
            {
                return true;
            }
            else
            {
                return false;
            }

            // return Senha == senha; That's a simplified way to do what we did above.
        }
    }
}
