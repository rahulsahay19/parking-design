using Microsoft.AspNetCore.Mvc;

namespace ParkingService.Modules.Parking.Api.Controllers
{
    [Route(BasePath)]
    public class HomeController : BaseController
    {
        [HttpGet]
        public ActionResult<string> Get() => "Parking Module";
    }
}