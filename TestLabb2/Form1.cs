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
            var anv�ndareLista = Database.H�mtaAnv�ndare();

            var anv�ndare = anv�ndareLista.FirstOrDefault(a => a.FullNamn == textNamn.Text);


            if (anv�ndare != null)
            {

                new Form2().Show();
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
    }
}
