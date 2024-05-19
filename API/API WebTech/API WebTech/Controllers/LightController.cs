using API_WebTech.Interfaces.Light;
using API_WebTech.Service;
using Microsoft.AspNetCore.Mvc;

namespace API_WebTech.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LightController
    {
        [HttpGet("GetAllLightStates")]
        public List<LightState> GetAllLichtState()
        {
            var database = new DatabaseService();
            return database.GetAllLightState();
        }
    }
}
