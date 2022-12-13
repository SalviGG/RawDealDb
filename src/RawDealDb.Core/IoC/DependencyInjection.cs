using Microsoft.Extensions.DependencyInjection;
using RawDealDb.Core.Interfaces.Service;
using RawDealDb.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Core.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<ISetServiceCore, SetServiceCore>();
            services.AddScoped<ICardServiceCore, CardServiceCore>();

            return services;
        }
    }
}
