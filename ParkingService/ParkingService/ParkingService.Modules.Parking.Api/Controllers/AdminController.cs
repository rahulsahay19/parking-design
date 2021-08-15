using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParkingService.Module.Parking.Core.DTO;
using ParkingService.Module.Parking.Core.Services;

namespace ParkingService.Modules.Parking.Api.Controllers
{
    [Route(BasePath+"/[controller]")]
    public class AdminController : BaseController
    {
        private readonly IParkingService _parkingService;

        public AdminController(IParkingService parkingService)
        {
            _parkingService = parkingService;
        }
        
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<AdminDto>>> GetAdmins()
        {
            return Ok(await _parkingService.GetAdmins());
        }
    }
}