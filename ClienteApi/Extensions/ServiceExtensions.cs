using Mediador;
using Mediador.Filtrado;
using Mediador.ManejoCache;

namespace ClienteApi.Extensions
{
    public static class ServiceExtensions
    { 
        public static IServiceCollection RegistrarServicios(this IServiceCollection services)
        {
            services.AddScoped<IFachada, Fachada>();
            services.AddScoped<IFiltrarSolicitudes, FiltrarSolicitudes>();
            services.AddScoped<ICacheHandler, CacheHandler>();
            return services;
        }
        
    }
}
