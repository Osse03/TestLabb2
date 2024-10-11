using Entiteter;

namespace InMemoryDatabase
{
    public class Database
    {

        internal List<Fordon> Fordons = new List<Fordon> ();
        internal List<Station> Stations = new List<Station> ();
        internal List<Hyra> Hyras = new List<Hyra> ();
        internal List<Användare> Användares = new List<Användare> ();
        internal List<SystemAdmin> SystemAdmins = new List<SystemAdmin> ();
        internal List<Person> Persons = new List<Person> ();

        public List<Användare> HämtaAnvändare()
        {
            return Användares;
        }

        public void LäggTillAnvändare(Användare användare)
        {
            Användares.Add(användare);
        } 

        public void InitieraAnvändare()
        {
            if (Användares.Count == 0)
            {
                Användares.Add(new Användare
                {
                    AnvändareID = "0123",
                    FullNamn = "Osama Alhussain",
                    Lösenord = "12345",
                    Epost = "osamaalhussain@icloud.com",
                    BetalningsMetod = "Klarna"
                });

                Användares.Add(new Användare
                {
                    AnvändareID = "V123",
                    FullNamn = "Varto Kaka",
                    Lösenord = "123456",
                    Epost = "vartokaka@icloud.com",
                    BetalningsMetod = "MasterCard"
                });
            }
        }

        public List<Fordon> HämtaFordon()
        {
            List<Fordon> fordon = new List<Fordon>()
            {

            };

            return fordon;
        }






    }
}
