using API_WebTech.Interfaces.Security;

namespace API_WebTech.Security
{
    public class PresentHouse
    {
        Random random = new Random();
        public List<PplHouse> PresentPplHouse()
        {
            PplList p = new PplList();
            List<PplHouse> pplPresent = new List<PplHouse> ();

            string person;
            string present = "";
            bool r;

            for (int x = 0; x < p.pplList.Count; x++)
            {
                person = p.pplList[x];
                r = Convert.ToBoolean(random.Next(0, 2));

                if(r)
                {
                    present = "Inside";
                }
                else if(!r)
                {
                    present = "Outside";
                }
                pplPresent.Add(new PplHouse
                {
                    ppl = person,
                    present = present
                });
            }

            return pplPresent;
        }
    }
}
