using Banco.Core.Agregados;
using Banco.Core.ObjetosValor.RetornoInterno;

namespace Banco.Core.Interfaces.UseCases
{
    public interface IUSCDeposito
    {
        BaseRetorno<string> Validar(TransacaoDeposito transacao);
    }
}
