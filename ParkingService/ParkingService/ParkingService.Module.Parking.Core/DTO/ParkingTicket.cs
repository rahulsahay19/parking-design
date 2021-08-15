using System;

namespace ParkingService.Module.Parking.Core.DTO
{
    public class ParkingTicket
    {
        public Guid Id { get; set; }
        public ParkingTicketStatus ParkingTicketStatus { get; set; }
    }
}