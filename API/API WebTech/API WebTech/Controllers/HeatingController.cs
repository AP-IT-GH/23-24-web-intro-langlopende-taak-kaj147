using API_WebTech.Interfaces.Heat;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_WebTech.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeatingController
    {
        [HttpGet("GetAllHeats")]
        public List<Heating> GetAllHeats()
        {
            var database = new Service.DatabaseService();
            var heat = database.GetAllHeat();
            return heat;
        }
    }
}
