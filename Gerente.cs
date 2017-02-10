using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Gerente : Pessoa, IAutenticacao
    {
        public bool Autenticacao
        {
            get
            {
                return true;
            }
        }
    }
}
