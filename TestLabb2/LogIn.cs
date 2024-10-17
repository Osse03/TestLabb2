using InMemoryDatabase;
using Entiteter;

namespace TestLabb2
{
    public partial class LogIn : Form
    {
       
        private Database database = new Database();
        private Anv�ndare inloggadAnv�ndare;

        public LogIn(Database db)
        {
            InitializeComponent();
           this.database = db;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            var anv�ndareLista = database.H�mtaAnv�ndare();

            var inloggadAnv�ndare = anv�ndareLista.FirstOrDefault(a => a.FullNamn == textNamn.Text && a.L�senord == textL�senord.Text); //  h�mtar den inloggade anv�ndare f�r hyrningsprocess 

            var systemAdminLista = database.InitieraSystemAdmin();
          

            var Nyanv�ndare = anv�ndareLista.FirstOrDefault(a => a.FullNamn == textNamn.Text && a.L�senord == textL�senord.Text);
            var systemAdmin = systemAdminLista.FirstOrDefault(a => a.FullNamn == textNamn.Text && a.L�senord == textL�senord.Text);


            if (Nyanv�ndare != null)
            {
                new UthyrningForm(database, inloggadAnv�ndare).Show();
                this.Hide();

            }
            else if (systemAdmin != null)
            {

                new FordonHantering().Show();
                this.Hide();
                MessageBox.Show("1. Vid Uppdatering m�ste du fylla i alla f�lt och klicka p� FordonID. " +
                    "\n 2. F�r att ta bort m�ste du klicka p� ForodonID och fylla i ForodonID f�ltet.");
            }
            else
            {
                MessageBox.Show("Din full namn eller l�senord �r fel, f�rs�k igen");
                textNamn.Clear();
                textL�senord.Clear();
                textNamn.Focus();
            }


        }
        
        private void label2_Click(object sender, EventArgs e)
        {
            new SkapaKonto(database).Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void R�nsaF�lt_Click(object sender, EventArgs e)
        {
            textNamn.Clear();
            textL�senord.Clear();
            textNamn.Focus();
        }

        private void VisaL�senord_CheckedChanged(object sender, EventArgs e)
        {
            if (textVisaL�senord.Checked)
            {
                textL�senord.PasswordChar = '\0';
            }
            else
            {
                textL�senord.PasswordChar = '*';            
            }
        }
    }
}
