using examenDAW.Repositories.EvenimentRepository;
using examenDAW.Repositories.ParticipantRepository;
using examenDAW.Services.EvenimentServices;
using examenDAW.Services.ParticipantServices;

namespace examenDAW.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IParticipantRepository, ParticipantRepository>();
            services.AddTransient<IEvenimentRepository, EvenimentRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IParticipantService, ParticipantService>();
            services.AddTransient<IEvenimentService, EvenimentService>();
            return services;
        }

    }
}
