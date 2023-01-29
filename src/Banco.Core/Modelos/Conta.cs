using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Domain.Modelos
{
    public class Conta
    {
        public long NumeroConta { get; set; }
        public int Agencia { get; set; }
        public long CPFCNPJ { get; set; }
        public byte TipoConta { get; set; }
    }
}
