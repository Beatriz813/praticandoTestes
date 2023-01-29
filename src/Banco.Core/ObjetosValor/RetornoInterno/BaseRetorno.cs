using Banco.Core.Enums;

namespace Banco.Core.ObjetosValor.RetornoInterno
{
    public class BaseRetorno<T>
    {
        public EnumStatus Status { get; set; }
        public T Retorno { get; set; }
    }
}
