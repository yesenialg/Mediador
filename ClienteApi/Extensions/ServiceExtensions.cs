using Mediador;
using Mediador.Contracts;

namespace ClienteApi.Extensions
{
    public static class ServiceExtensions
    { 
        public static IServiceCollection RegistrarServicios(this IServiceCollection services)
        {
            services.AddScoped<IFachada, Fachada>();
            return services;
        }
        
    }
}
