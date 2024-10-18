using InMemoryDatabase;

namespace TestLabb2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Database db = new Database();
            db.InitieraAnv�ndare();

            LogicLayer logicLayer = new LogicLayer(db);

            Application.Run(new LogIn(logicLayer));  // Passera LogicLayer till formul�ren
        }
    }
}
