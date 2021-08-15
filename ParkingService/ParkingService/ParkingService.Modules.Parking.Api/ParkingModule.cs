using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ParkingService.Module.Parking.Core;

namespace ParkingService.Modules.Parking.Api
{
    public static class ParkingModule 
    {
        public static IServiceCollection AddParkingModule(this IServiceCollection services)
        {
            services.AddCore();
            return services;
        }

        public static IApplicationBuilder UseParkingModule(this IApplicationBuilder app)
        {
            return app;
        }
    }
}