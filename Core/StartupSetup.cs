using Core.Interfaces.Services;
using Core.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Core
{
    public static class StartupSetup
    {
        public static void AddCustomServices(this IServiceCollection service)
        {
            service.AddScoped<IUserService, UserService>();
        }
    }
}
