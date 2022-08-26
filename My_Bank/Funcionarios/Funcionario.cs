using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Bank.Funcionarios
{
    public class Funcionario
    {

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public virtual double getBonificacao()
        {
            return Salario * 0.10;
        }

        public static int totaDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            this.CPF = cpf;
            this.Salario = salario;

            Console.WriteLine("Criando um Funcionario.");
            totaDeFuncionarios++;
        }
        
        public virtual void AumentarSalario()
        {
            this.Salario *= 1.1;
        }
    }
}
