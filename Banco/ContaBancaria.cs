using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
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

        public void VisualizarSaldo()
        {
            Console.Write("\n\nCliente:" + this.Nome_Cliente);
            Console.Write("\n\nIdade:" + this.Idade_Cliente);
            Console.Write("\n\nNumero da Conta:" + this.Numero_Conta);
            Console.Write("\n\nSaldo Atual:" + this.Saldo_Conta);
        }
    }
}
