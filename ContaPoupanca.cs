using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaPoupanca : Conta
    {
        
        public ContaPoupanca(Data DataDeAbertura) : base(DataDeAbertura) { }

        public override bool Deposita(double valorDeposito)
        {
            if(base.Deposita(valorDeposito + (valorDeposito * 0.1))) return true;
            return false;
        }

    }
}
