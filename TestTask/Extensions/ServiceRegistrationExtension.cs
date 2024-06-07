using TestTask.Services.Implementations;
using TestTask.Services.Interfaces;

namespace TestTask.Extensions
{
    public static class ServiceRegistrationExtension
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IUserService, UserService>();

        }
    }
}
