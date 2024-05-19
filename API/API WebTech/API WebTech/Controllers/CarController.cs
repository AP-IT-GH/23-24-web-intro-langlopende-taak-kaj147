using API_WebTech.Interfaces.Car;
using API_WebTech.Service;
using Microsoft.AspNetCore.Mvc;

namespace API_WebTech.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController
    {
        [HttpGet("GetCar")]
        public List<CarChargeAccu> GetCar()
        {
            var database = new DatabaseService();
            var accu = database.GetAccu();
            return accu;
        }
    }
}
