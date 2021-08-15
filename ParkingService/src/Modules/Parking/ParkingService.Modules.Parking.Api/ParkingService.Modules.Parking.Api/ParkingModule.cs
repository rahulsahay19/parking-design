using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ParkingService.Modules.Parking.Api
{
    public static class ParkingModule
    {
        public static IServiceCollection AddParkingModule(this IServiceCollection services)
        {
            return services;
        }

        public static IApplicationBuilder UseParkingModule(this IApplicationBuilder app)
        {
            return app;
        }
    }
}