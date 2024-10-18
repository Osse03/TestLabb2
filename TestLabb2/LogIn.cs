using InMemoryDatabase;
using Entiteter;

namespace TestLabb2
{
    public partial class LogIn : Form
    {

        private LogicLayer logicLayer;
        private Anv�ndare inloggadAnv�ndare;

        public LogIn(LogicLayer logicLayer)
        {
            InitializeComponent();
            this.logicLayer = logicLayer;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var anv�ndareLista = logicLayer.H�mtaAllaAnv�ndare();
            var inloggadAnv�ndare = anv�ndareLista.FirstOrDefault(a => a.FullNamn == textNamn.Text && a.L�senord == textL�senord.Text);

            var systemAdminLista = logicLayer.InitieraSystemAdmins();

            var Nyanv�ndare = anv�ndareLista.FirstOrDefault(a => a.FullNamn == textNamn.Text && a.L�senord == textL�senord.Text);
            var systemAdmin = systemAdminLista.FirstOrDefault(a => a.FullNamn == textNamn.Text && a.L�senord == textL�senord.Text);

            if (Nyanv�ndare != null)
            {
                new UthyrningForm(logicLayer, inloggadAnv�ndare).Show();  // Skickar LogicLayer och inloggad anv�ndare
                this.Hide();
            }
            else if (systemAdmin != null)
            {
                new FordonHantering(logicLayer).Show();  // Skickar LogicLayer
                this.Hide();
                MessageBox.Show("1. Vid Uppdatering m�ste du fylla i alla f�lt och klicka p� FordonID." +
                                "\n 2. F�r att ta bort m�ste du klicka p� FordonID och fylla i FordonID-f�ltet.");
            }
            else
            {
                MessageBox.Show("Ditt fulla namn eller l�senord �r fel, f�rs�k igen");
                textNamn.Clear();
                textL�senord.Clear();
                textNamn.Focus();
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {
            new SkapaKonto(logicLayer).Show();
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
