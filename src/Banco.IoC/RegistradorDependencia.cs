using Banco.Core.Interfaces.UseCases;
using Banco.Domain.UseCases.Deposito;
using Microsoft.Extensions.DependencyInjection;

namespace Banco.IoC
{
    public static partial class RegistradorDependencia
    {
        public static void RegistradorUseCase(this IServiceCollection services)
        {
            services.AddScoped<IUSCDeposito, USCDeposito>();
        }
    }
}