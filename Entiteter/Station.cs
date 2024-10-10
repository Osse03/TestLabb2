namespace Entiteter
{
    public class Station
    {

        public string StationID { get; set; }
        public string Adress { get; set; }
        public int AnatalFodon { get; set; }
        public int AntalTillgänglig { get; set; }

        public List<Fordon> Fordon { get; set; }



    }
}
