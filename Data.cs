using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Data
    {

        public Data(int dia, int mes, int ano)
        {
            _dia = dia;
            _mes = mes;
            _ano = ano;
        }

        private int _dia;
        private int _mes;
        private int _ano;

        public string DataFormatada
        {
            get
            {
                return _dia + "/" + _mes + "/" + _ano;
            }

        }

    }
}
