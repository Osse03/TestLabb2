using InMemoryDatabase;

namespace TestLabb2
{
    public partial class LogIn : Form
    {
       
        private Database database = new Database();
        public LogIn(Database db)
        {
            InitializeComponent();
           this.database = db;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var NyAnv�ndareLista = database.H�mtaAnv�ndare();
            var SystemAdminLista = database.InitieraSystemAdmin();
          

            var Nyanv�ndare = NyAnv�ndareLista.FirstOrDefault(a => a.FullNamn == textNamn.Text && a.L�senord == textL�senord.Text);
            var systemAdmin = SystemAdminLista.FirstOrDefault(a => a.FullNamn == textNamn.Text && a.L�senord == textL�senord.Text);


            if (Nyanv�ndare != null)
            {
                //new ().Show();
                //this.Hide();

            }
            else if (systemAdmin != null)
            {

                new SystemAdminMeny().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Din namn eller l�senord �r fel, f�rs�k igen");
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

        private void label4_Click(object sender, EventArgs e)
        {
            textNamn.Clear();
            textL�senord.Clear();
            textNamn.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void VissaNyL�senord_CheckedChanged(object sender, EventArgs e)
        {

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
