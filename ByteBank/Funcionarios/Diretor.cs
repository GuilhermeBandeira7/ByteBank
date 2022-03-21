using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel // inhering autenticavel makes diretor and gerentedeconta the only authenticated
    {
        

        public Diretor( string cpf) : base(5000, cpf) // execute the constructor of the base class first
        {
           

        }

        public bool IAutenticar(string senha) // interface implementation
        {
            return true;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.15; // override with plus 15%
        }
        public override double GetBonificacao()
        {
            return Salario + 0.25;
        }

        
    }
}
