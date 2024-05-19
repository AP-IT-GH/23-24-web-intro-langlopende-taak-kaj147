using API_WebTech.Interfaces.Security;
using API_WebTech.Service;
using Microsoft.AspNetCore.Mvc;

namespace API_WebTech.Controllers
{
    [ApiController]
    [Route("controller")]
    public class SecurityController
    {
        [HttpGet("GetAllPresent")]
        public List<PplHouse> GetAllPresent()
        {
            var database = new DatabaseService();
            var present = database.GetPplHouse();
            return present;
        }
    }
}
