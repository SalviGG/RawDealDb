using RawDealDb.UI.Interfaces;
using RawDealDb.UI.Services;

namespace RawDealDb.UI.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddUI(this IServiceCollection services)
        {
            services.AddScoped<ISetService, SetService>();
            services.AddScoped<ICardService, CardService>();
            services.AddScoped<IFileService, FileService>();
            return services;
        }
    }
}
