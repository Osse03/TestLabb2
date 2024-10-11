using InMemoryDatabase;

namespace TestLabb2
{
    public partial class LogIn : Form
    {
        private Database database;
        public LogIn(Database db)
        {
            InitializeComponent();
            database = db;
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
            var användareLista = database.HämtaAnvändare();

            var användare = användareLista.FirstOrDefault(a => a.FullNamn == textNamn.Text);
            var användareLösen = användareLista.FirstOrDefault(a => a.Lösenord == textLösenord.Text);

            if (användare != null && användareLösen != null)
            {
                new Form3().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Din namn eller lösenord är fel, försök igen");
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

        private void label4_Click(object sender, EventArgs e)
        {
            textNamn.Clear();
            textLösenord.Clear();
            textNamn.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void VissaNyLösenord_CheckedChanged(object sender, EventArgs e)
        {

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
