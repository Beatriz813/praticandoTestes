using Banco.Core.Agregados;
using Banco.Core.Enums;
using Banco.Core.Interfaces.UseCases;
using Banco.Core.ObjetosValor.RetornoInterno;
using Banco.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Banco.TestesUnitarios.Deposito
{
    public class DepositoUseCase
    {
        private readonly IUSCDeposito _useCase;
        public DepositoUseCase()
        {
            var services = new ServiceCollection();
            services.RegistradorUseCase();
            var serviceProvider = services.BuildServiceProvider();
            _useCase = serviceProvider.GetRequiredService<IUSCDeposito>();
        }

        [Fact]
        public void ContaInexistente()
        {
            var transacao = new TransacaoDeposito()
            {
                Valor = 10
            };

            BaseRetorno<string> retorno = _useCase.Validar(transacao);

            Assert.True(retorno.Status == EnumStatus.NEGOCIO);
        }
    }
}
