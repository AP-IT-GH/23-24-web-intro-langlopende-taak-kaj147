using API_WebTech.Interfaces.Light;
using API_WebTech.Interfaces;
using API_WebTech.Interfaces.Shutter;

namespace API_WebTech.Shutter
{
    public class Shutters
    {
        Random random = new Random();
        public List<ShutterState> Shutter()
        {
            Rooms r = new Rooms();
            List<ShutterState> lights = new List<ShutterState>();

            string room;
            bool state;

            for (int x = 0; x < r.rooms.Count; x++)
            {
                room = r.rooms[x];
                state = Convert.ToBoolean(random.Next(0, 2));

                lights.Add(new ShutterState
                {
                    room = room,
                    lightState = state
                });
            }
            return lights;
        }
    }
}
