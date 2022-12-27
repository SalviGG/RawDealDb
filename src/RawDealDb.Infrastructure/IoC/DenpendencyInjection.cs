using Microsoft.Extensions.DependencyInjection;
using RawDealDb.Core.Interfaces.DAL;
using RawDealDb.Core.Interfaces.Service;
using RawDealDb.Infrastructure.Files;
using RawDealDb.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Infrastructure.IoC
{
    public static class DenpendencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ISetsRepository, SetsRepository>();
            services.AddScoped<ICardRepository, CardRepository>();
            services.AddScoped<IInfrastructureFileService, InfrasctructureFileService>();

            return services;
        }
    }
}
