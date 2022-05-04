using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBanco
{
    class ContaBancaria
    {
        public string Nome_Cliente;
        public int Idade_Cliente;
        public int Numero_Conta;
        public double Saldo_Conta;


        public void DepositoConta(double ValorDepositado)
        {
            this.Saldo_Conta = this.Saldo_Conta + ValorDepositado;
        }

        public void SacaConta(double valorSacar)
        {
            this.Saldo_Conta = this.Saldo_Conta - valorSacar;
        }

        public override string ToString()
        {
            return "Nome: " + Nome_Cliente + "  Sua Idade:  " + Idade_Cliente + "  N. da Conta:  " + Numero_Conta + "  N. da Conta:  " + Saldo_Conta ;
        }
    }
}
