using API_WebTech.Interfaces.Audio;
using API_WebTech.Service;
using Microsoft.AspNetCore.Mvc;

namespace API_WebTech.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AudioController
    {
        [HttpGet("GetCurrentSong")]
        public List<SoArAl> GetCurrentSong()
        {
            var database = new DatabaseService();
            var song = database.GetSongArtistAlbum();
            return song;
        }
    }
}
