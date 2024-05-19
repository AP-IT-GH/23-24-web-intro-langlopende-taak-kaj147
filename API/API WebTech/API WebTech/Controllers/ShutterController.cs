using API_WebTech.Interfaces.Shutter;
using API_WebTech.Service;
using Microsoft.AspNetCore.Mvc;

namespace API_WebTech.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShutterController
    {
        [HttpGet("GetAllShutter")]
        public List<ShutterState> GetAllShutterStates()
        {
            var database = new DatabaseService();
            var shutter = database.GetAllShutterState();
            return shutter;
        }
    }
}
