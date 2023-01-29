using Banco.Core.Agregados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Domain.Mapeadores
{
    public partial class Mapeador
    {
        public IClienteRepository _clienteRepository;
        public TransacaoDeposito EntradaParaDominio(IServiceProvider provider)
        {
            
            return new TransacaoDeposito ();
        }
    }
}
