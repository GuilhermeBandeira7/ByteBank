using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
            UsarSistema();

            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("856.248.521-87");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("856.624.874-65");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("15.684.254-89");
            igor.Nome = "Igor";

            Funcionario camilla = new GerenteDeConta("963.418.247-85");
            camilla.Nome = "Camilla";

            Funcionario guilherme = new Desenvolvedor("258.328.647-65");
            guilherme.Nome = "Guilherme";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camilla);
            gerenciador.Registrar(guilherme);

            Console.WriteLine("Total de bonificações do mês: " + gerenciador.GetTotalBonificacao());
        }

        public static void UsarSistema()
        {
            SistemaInterno sistema = new SistemaInterno();
            Diretor roberta = new Diretor("856.624.874-65"); // now we use Autenticavel to create an instance of the class
            roberta.Nome = "Roberta";
            roberta.Senha = "1234";

            GerenteDeConta camilla = new GerenteDeConta("963.418.247-85");
            camilla.Nome = "Camilla";
            camilla.Senha = "4321";

            ParceiroComercial parceiro = new ParceiroComercial(); // instance and authentication of a ParceiroComercial
            parceiro.Senha = "parca";



            sistema.Logar(roberta, "1234");
            sistema.Logar(camilla, "4321");
            sistema.Logar(parceiro, "parca");
        }
    }
}
