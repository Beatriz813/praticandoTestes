using Banco.Domain.Modelos;

namespace Banco.Core.Agregados
{
    public class TransacaoDeposito
    {
        public Conta Recebedor { get; set; }
        public decimal Valor { get; set; }
    }
}
