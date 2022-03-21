using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; } // protect access modifier grants access only to the father e daughter classess. Whereas private grants access only inside the father class
       
        public Funcionario(double salario, string cpf) 
        {
            Console.WriteLine("Criando funcionario");
            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario(); // an abstract method cannot have a body. the body is defined inside the derived classes like Designer, Auxiliar and etc.


        public abstract double GetBonificacao();

       

    }
}
