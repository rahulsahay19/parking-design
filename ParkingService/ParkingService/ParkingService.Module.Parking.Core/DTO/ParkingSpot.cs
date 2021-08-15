namespace ParkingService.Module.Parking.Core.DTO
{
    public class ParkingSpot
    {
        public ParkingSpot(ParkingSpotType parkingSpotType)
        {
            ParkingSpotType = parkingSpotType;
        }

        public string Number { get; set; }
        public bool IsFree { get; set; }
        public VehicleType VehicleType { get; set; }
        public ParkingSpotType ParkingSpotType { get;}
        //TODO: Move these in config file Fixed 
        public int TotalBikeSpots { get; set; } = 200;
        public int TotalCarSpots { get; set; } = 200;
        public int TotalElectricSpots { get; set; } = 200;
        public int TotalHandicappedSpots { get; set; } = 200;
        public int TotalCompactSpots { get; set; } = 200;
        public int TotalCycleSpots { get; set; } = 200;
    }
}