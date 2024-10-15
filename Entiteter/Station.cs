namespace Entiteter
{
    public class Station
    {

        public int StationID { get; set; }
        public string Adress { get; set; }
        public int AnatalFodon { get; set; }

        public List<Fordon> BefintligaFordon { get; set; }



    }
}
