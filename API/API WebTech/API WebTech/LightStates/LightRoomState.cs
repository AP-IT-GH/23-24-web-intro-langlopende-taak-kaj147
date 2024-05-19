using API_WebTech.Interfaces;
using API_WebTech.Interfaces.Light;

namespace API_WebTech.LightStates
{
    public class LightRoomState
    {
        Random random = new Random();
        public List<LightState> Light()
        {
            Rooms r = new Rooms();
            List<LightState> lights = new List<LightState>();

            string room;
            bool state;
            
            for (int x = 0; x < r.rooms.Count; x++)
            {
                room = r.rooms[x];
                state = Convert.ToBoolean(random.Next(0,2));

                lights.Add(new LightState
                {
                    room = room,
                    lightState = state
                });
            }
            return lights;
        }
    }
}
