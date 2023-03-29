using DAWM_Backend_API.Core.Services;
using DAWM_Backend_API.DataLayer.Repositories;

namespace DAWM_Backend_API.Settings
{
    public class Dependencies
    {
        public static void Inject(WebApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Services.AddControllers();
            applicationBuilder.Services.AddSwaggerGen();

            AddRepositories(applicationBuilder.Services);
            AddServices(applicationBuilder.Services);
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<UserService>();
            services.AddScoped<CarService>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<UserRepo>();
            services.AddScoped<CarRepo>();
        }
    }
}
