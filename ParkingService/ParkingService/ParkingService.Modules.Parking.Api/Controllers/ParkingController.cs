using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParkingService.Module.Parking.Core.DTO;
using ParkingService.Module.Parking.Core.Services;

namespace ParkingService.Modules.Parking.Api.Controllers
{
    [Route(BasePath+"/[controller]")]
    public class ParkingController : BaseController
    {
        private readonly IParkingService _parkingService;

        public ParkingController(IParkingService parkingService)
        {
            _parkingService = parkingService;
        }

        [HttpGet("getparkingspots")]
        public ActionResult<Task<ParkingSpot>> GetFreeParkingSpots()
        {
            return Ok(_parkingService.ShowEmptySpotNumber());
        }
        
        [HttpGet("getparkingticket")]
        public ActionResult<Task<ParkingTicket>> GetParkingTicket()
        {
            return Ok(_parkingService.GetParkingTicket());
        } 
    }
}