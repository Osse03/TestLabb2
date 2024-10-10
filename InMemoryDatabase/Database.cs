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
            List<Användare> användare = new List<Användare>()
            {
                new Användare
                {
                    AnvändareID = "O123",
                    FullNamn ="Osama Alhussain",
                    Lösenord = "12345",
                    Epost = "osamaalhussain@icolud.com",
                    BetalningsMetod ="Klarna",
                    HyresHistorik = new List<Hyra>
                    {
                        new Hyra
                        {
                            HyraID = "H000",
                            Kostnad = 55.95, StartTid =
                            DateTime.Now.AddMonths(-1),
                            SlutTid = DateTime.Now

                        }
                    }

                },
                 new Användare
                {
                    AnvändareID = "V123",
                    FullNamn ="Varto Kaka",
                    Lösenord = "123456",
                    Epost = "vartokaka@icolud.com",
                    BetalningsMetod ="MasterCard",
                    HyresHistorik = new List<Hyra>
                    {
                        new Hyra
                        {
                            HyraID = "H001",
                            Kostnad = 55.95, StartTid =
                            DateTime.Now.AddMonths(-1),
                            SlutTid = DateTime.Now

                        }
                    }

                }

            };

            return användare;
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
