using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParkingService.Module.Parking.Core.DTO;

namespace ParkingService.Module.Parking.Core.Services
{
    public class ParkingService : IParkingService
    {
        private readonly List<ParkingSpot> _parkingSpots;

        public ParkingService(List<ParkingSpot> parkingSpots)
        {
            _parkingSpots = parkingSpots;
        }


        public async Task<IReadOnlyList<AdminDto>> GetAdmins()
        {
            //This is just to avoid async warning. It just assumes task completed
            await Task.CompletedTask;
            return new List<AdminDto>()
            {
                new AdminDto()
                {
                    Id = Guid.NewGuid(),
                    Name = "Test Admin1"
                },
                new AdminDto()
                {
                    Id = Guid.NewGuid(),
                    Name = "Test Admin2"
                },
                new AdminDto()
                {
                    Id = Guid.NewGuid(),
                    Name = "Test Admin3"
                }
            };
        }

        public void AssignVehicleToSpot(ParkingSpot parkingSpot)
        {
            switch (parkingSpot.ParkingSpotType)
            {
                case ParkingSpotType.Bike: _parkingSpots.Add(ReserveParkingSpot(parkingSpot));
                    break;
                case ParkingSpotType.Car: _parkingSpots.Add(ReserveParkingSpot(parkingSpot));
                    break;
                case ParkingSpotType.Compact: _parkingSpots.Add(ReserveParkingSpot(parkingSpot));
                    break;
                case ParkingSpotType.Handicapped: _parkingSpots.Add(ReserveParkingSpot(parkingSpot));
                    break;
                case ParkingSpotType.Electric: _parkingSpots.Add(ReserveParkingSpot(parkingSpot));
                    break;
                case ParkingSpotType.Cycle: _parkingSpots.Add(ReserveParkingSpot(parkingSpot));
                    break;
            }
        }

        public void RemoveParkingSpot(ParkingSpot parkingSpot)
        {
            _parkingSpots.Remove(parkingSpot);
        }

        public string ShowDisplayBoard()
        {
            return "Showing Available Parking";
        }

        public async Task<List<ParkingSpot>> ShowEmptySpotNumber()
        {
            await Task.CompletedTask;
            //Show List of different available parkings
            return new List<ParkingSpot>().Where(t => t.IsFree) as List<ParkingSpot>;

        }

        public async Task<ParkingTicket> GetParkingTicket()
        {
            await Task.CompletedTask;
            return new ParkingTicket
            {
                Id = Guid.NewGuid(),
                ParkingTicketStatus = ParkingTicketStatus.Active
            };
        }
        
        private ParkingSpot ReserveParkingSpot(ParkingSpot parkingSpot)
        {
            //TODO calculate available parking spots and return
            switch (parkingSpot.ParkingSpotType)
            {
                case ParkingSpotType.Bike: return new ParkingSpot(ParkingSpotType.Bike);
                    break;
                case ParkingSpotType.Compact: return new ParkingSpot(ParkingSpotType.Compact);
                    break;
                case ParkingSpotType.Handicapped: return new ParkingSpot(ParkingSpotType.Handicapped);
                    break;
                case ParkingSpotType.Cycle: return new ParkingSpot(ParkingSpotType.Cycle);
                    break;
                case ParkingSpotType.Electric: return new ParkingSpot(ParkingSpotType.Electric);
                    break;
                case ParkingSpotType.Car: return new ParkingSpot(ParkingSpotType.Car);
                    break;
                
            };
            return null;
        }

        private List<ParkingSpot> ReturnFreeParkingSpots()
        {
            //TODO Check which spots are free and then return
            return new List<ParkingSpot>();
        }
    }
}