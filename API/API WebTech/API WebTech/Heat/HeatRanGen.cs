using API_WebTech.Interfaces;
using API_WebTech.Interfaces.Heat;

namespace API_WebTech.Heat
{
    public class HeatRanGen
    {
        public List<Heating> HeatRoomTempRanGen() 
        {
            Rooms r = new Rooms();
            List<Heating> heat = new List<Heating>();
                        
            string room;
            int temp;

            Random random = new Random();

            for (int x = 0;x < r.rooms.Count;x++) 
            {
                room = r.rooms[x];
                temp = random.Next(16,24);

                heat.Add(new Heating
                {
                    room = room,
                    temp = temp
                });
            }
            return heat;
        }
    }
}
