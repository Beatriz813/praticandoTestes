using Banco.Core.Agregados;
using Banco.Core.Interfaces.UseCases;
using Banco.Core.ObjetosValor.RetornoInterno;

namespace Banco.Domain.UseCases.Deposito
{
    public class USCDeposito : IUSCDeposito
    {
        public BaseRetorno<string> Validar(TransacaoDeposito transacao)
        {
            throw new NotImplementedException();
        }
    }
}
