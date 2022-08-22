﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Bank.Funcionarios
{
    public class Funcionario
    {
        // 0 - Funcionario
        // 1 - Diretor
        // 2 - Design
        // n - ....


        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }
        

        public double getBonificacao()
        { 
            return Salario * 0.10;
        }
    }
}