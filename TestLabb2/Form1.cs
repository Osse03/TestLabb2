using InMemoryDatabase;

namespace TestLabb2
{
    public partial class Form1 : Form
    {
        private Database Database = new Database();
        public Form1()
        {
            InitializeComponent();
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
            var användareLista = Database.HämtaAnvändare();

            var användare = användareLista.FirstOrDefault(a => a.FullNamn == textNamn.Text);


            if (användare != null)
            {

                new Form2().Show();
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
    }
}
