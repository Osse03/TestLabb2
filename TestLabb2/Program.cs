using InMemoryDatabase;

namespace TestLabb2
{
    internal static class Program
    {


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Skapa en instans av Database
            Database db = new Database();
            // Anropar befintliga användare
            db.InitieraAnvändare();

            // Passera denna instans till LogIn-konstruktorn
            Application.Run(new LogIn(db));

        }
    }
}