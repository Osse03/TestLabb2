using InMemoryDatabase;
using Entiteter;

namespace TestLabb2
{
    public partial class LogIn : Form
    {
       
        private Database database = new Database();
        private Användare inloggadAnvändare;

        public LogIn(Database db)
        {
            InitializeComponent();
           this.database = db;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            var användareLista = database.HämtaAnvändare();

            var inloggadAnvändare = användareLista.FirstOrDefault(a => a.FullNamn == textNamn.Text && a.Lösenord == textLösenord.Text); //  hämtar den inloggade användare för hyrningsprocess 

            var systemAdminLista = database.InitieraSystemAdmin();
          

            var Nyanvändare = användareLista.FirstOrDefault(a => a.FullNamn == textNamn.Text && a.Lösenord == textLösenord.Text);
            var systemAdmin = systemAdminLista.FirstOrDefault(a => a.FullNamn == textNamn.Text && a.Lösenord == textLösenord.Text);


            if (Nyanvändare != null)
            {
                new UthyrningForm(database, inloggadAnvändare).Show();
                this.Hide();

            }
            else if (systemAdmin != null)
            {

                new FordonHantering().Show();
                this.Hide();
                MessageBox.Show("1. Vid Uppdatering måste du fylla i alla fält och klicka på FordonID. " +
                    "\n 2. För att ta bort måste du klicka på ForodonID och fylla i ForodonID fältet.");
            }
            else
            {
                MessageBox.Show("Din full namn eller lösenord är fel, försök igen");
                textNamn.Clear();
                textLösenord.Clear();
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

        private void RänsaFält_Click(object sender, EventArgs e)
        {
            textNamn.Clear();
            textLösenord.Clear();
            textNamn.Focus();
        }

        private void VisaLösenord_CheckedChanged(object sender, EventArgs e)
        {
            if (textVisaLösenord.Checked)
            {
                textLösenord.PasswordChar = '\0';
            }
            else
            {
                textLösenord.PasswordChar = '*';            
            }
        }
    }
}
