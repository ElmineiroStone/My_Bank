﻿using My_Bank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Bank.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        private double totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.getBonificacao();
        }

        public double getBonificacao()
        {
            return this.totalBonificacao;
        }
    }
}