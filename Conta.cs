using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public abstract class Conta
    {

        private static int _numeroDaConta = 1;

        public Conta(Data DataDeAbertura)
        {
            Numero = _numeroDaConta;
            this.DataDeAbertura = DataDeAbertura;
            _numeroDaConta++;
        }

        public int Numero { get; private set; }
        public double Saldo { get; protected set; }
        public Correntista Titular { get; set; }
        public Data DataDeAbertura { get; private set; }

        public virtual bool Deposita(double valorDeposito)
        {
            if (valorDeposito > 0)
            {
                Saldo += valorDeposito;
                return true;
            }
            return false;
        }
        public virtual bool Saca(double valorSaque)
        {
            if (ConfereSaque(valorSaque))
            {
                Saldo -= valorSaque;
                return true;
            }
            return false;
        }
        public virtual bool TransferePara(Conta contaDestino, double valor)
        {
            if (ConfereSaque(valor))
            {
                contaDestino.Saldo += valor;
                Saldo -= valor;
                return true;
            }
            return false;
        }

        private bool ConfereSaque(double valor)
        {
            if (valor > 0 && valor <= Saldo) return true;
            return false;
        }
    }
}
