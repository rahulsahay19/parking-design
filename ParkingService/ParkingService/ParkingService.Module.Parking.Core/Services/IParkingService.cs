using System.Collections.Generic;
using System.Threading.Tasks;
using ParkingService.Module.Parking.Core.DTO;

namespace ParkingService.Module.Parking.Core.Services
{
    public interface IParkingService
    {
        Task<IReadOnlyList<AdminDto>> GetAdmins();
        void AssignVehicleToSpot(ParkingSpot parkingSpot);
        void RemoveParkingSpot(ParkingSpot parkingSpot);
        string ShowDisplayBoard();
        Task<List<ParkingSpot>> ShowEmptySpotNumber();
        Task<ParkingTicket> GetParkingTicket();
    }
}