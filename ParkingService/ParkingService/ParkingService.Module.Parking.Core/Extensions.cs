using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using ParkingService.Module.Parking.Core.DTO;
using ParkingService.Module.Parking.Core.Services;

namespace ParkingService.Module.Parking.Core
{
    public static class Extensions
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services.AddScoped<List<ParkingSpot>>();
            services.AddScoped<IParkingService, Services.ParkingService>();
            return services;
        }
    }
}