using Microsoft.Extensions.DependencyInjection;
using RM.Data.Repositories;
using RM.Domain.Entities.Interfaces;
using RM.Domain.Entities.Services;

namespace RM.CrossCutting.IoC
{

    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {

            services.AddScoped<IClienteRepository, ClienteRepository>();
            
            services.AddScoped<IContaCorrenteRepository, ContaCorrenteRepository>();

            services.AddScoped<ITransacaoRepository, TransacaoRepository>();

            services.AddScoped<ITransacaoService, TransacaoService>();
        }
    }
}
