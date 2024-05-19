using API_WebTech.Car;
using API_WebTech.Heat;
using API_WebTech.LightStates;
using API_WebTech.Audio;
using API_WebTech.Security;
using API_WebTech.Interfaces.Car;
using API_WebTech.Interfaces.Heat;
using API_WebTech.Interfaces.Light;
using API_WebTech.Interfaces.Audio;
using API_WebTech.Interfaces.Security;
using API_WebTech.Interfaces.Shutter;
using API_WebTech.Shutter;

namespace API_WebTech.Service
{
    public class DatabaseService
    {
        //Heat
        public List<Heating> GetAllHeat()
        {
            var heat = new HeatRanGen();
            return heat.HeatRoomTempRanGen();
        }

        //Light
        public List<LightState> GetAllLightState()
        {
            var light = new LightRoomState();
            return light.Light();
        }

        //Shutter
        public List<ShutterState> GetAllShutterState()
        {
            var shutter = new Shutters();
            return shutter.Shutter();
            
        }

        //Audio
        public List<SoArAl> GetSongArtistAlbum()
        {
            var song = new CurrentAudio();
            return song.Current();
        }

        //Car
        public List<CarChargeAccu> GetAccu()
        {
            var car = new CarAccu();            
            return car.Car();
        }


        //Security
        public List<PplHouse> GetPplHouse()
        {
            var pplHouse = new PresentHouse();
            return pplHouse.PresentPplHouse();
        }
    }
}
