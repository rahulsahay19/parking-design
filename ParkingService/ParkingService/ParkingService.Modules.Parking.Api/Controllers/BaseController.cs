using Microsoft.AspNetCore.Mvc;

namespace ParkingService.Modules.Parking.Api.Controllers
{
    [ApiController]
    [Route(BasePath+"/[controller]")]
    public class BaseController : ControllerBase
    {
        protected const string BasePath = "parking";
    }
}