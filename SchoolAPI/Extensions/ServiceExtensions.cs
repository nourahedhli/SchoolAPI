using Contracts;
using LoggerManager;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace SchoolAPI.Extensions
{
    public static class ServiceExtensions
    {

        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddScoped<ILoggerManager, LoggerService>();
        }
    }
}
