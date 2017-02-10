using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Relatorio
    {
        public List<Conta> Contas = new List<Conta>();

        public int TotalDeContas
        {
            get
            {
                return Contas.Count();
            }
        }

        public double MaiorSaldo
        {
            get
            {
                return Contas.Max(c => c.Saldo);
            }
        }

        public double MenorSaldo
        {
            get
            {
                return Contas.Min(c => c.Saldo);
            }
        }

        public double MediaDosSaldos
        {
            get
            {
                return Contas.Average(c => c.Saldo);
            }
        }

        public double SomaDosSaldos
        {
            get
            {
                return Contas.Sum(c => c.Saldo);
            }
        }

    }
}
