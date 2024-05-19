using API_WebTech.Interfaces.Car;

namespace API_WebTech.Car
{
    public class CarAccu
    {
        Random random = new Random();

        public List<CarChargeAccu> Car() 
        {
            string accu = $"{random.Next(0, 101) + random.NextDouble():#0.00}%";      
            bool charging = Convert.ToBoolean(random.Next(0, 2));
            string temp = $"{random.Next(15, 31) + random.NextDouble():#0.00}°C";

            List<CarChargeAccu> list = new List<CarChargeAccu> ();
            list.Add(new CarChargeAccu
            {
                accu = accu,
                charging = charging,
                temp = temp
            });
            return list;
        }
    }
}
