using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    class FuncionarioN3: Funcionario
    {
        public override double ParticipacaoLucro()
        {
            return base.ParticipacaoLucro() * 0.03;
        }
    }
}
