using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Bank.Funcionarios
{
    public class Diretor: Funcionario
    {
        public override double getBonificacao()
        {
            return Salario + base.getBonificacao();
        }

        public Diretor()
        {
            Console.WriteLine("Criando um Diretor.");
        }
    }
}
