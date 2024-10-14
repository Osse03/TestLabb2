using Entiteter;
using InMemoryDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLabb2
{
    public partial class SkapaKonto : Form
    {

        private Database database;
        public SkapaKonto(Database db)
        {
            InitializeComponent();

            database = db;
        }


        private void label8_Click(object sender, EventArgs e)
        {
            new LogIn(database).Show();
            this.Hide();
        }

        private void REGISTERA_Click(object sender, EventArgs e)
        {
            string fullNamn = textNewUserName.Text;
            string epost = textEpost.Text;
            string användareID = textNewUserName.Text;
            string betalningsMetod = textBetalningsMetod.Text;
            string lösenOrd = textNyttLösenord.Text;
            string rättLösen = textRättLösenord.Text;

            if (lösenOrd != rättLösen)
            {
                MessageBox.Show("Lösenorden matchar inte. Försök igen");
                return;
            }

            if (textNewUserName.Text == "" && textEpost.Text == "" && textBetalningsMetod.Text == "" && textBetalningsMetod.Text == "" && textNyttLösenord.Text == "")
            {
                MessageBox.Show("Vissa fält är tomt. Fyll på alla information");
            }

            Användare nyAnvändare = new Användare
            {
                FullNamn = fullNamn,
                Epost = epost,
                AnvändareID = användareID,
                BetalningsMetod = betalningsMetod,
                Lösenord = lösenOrd
            };

            database.LäggTillAnvändare(nyAnvändare);

            MessageBox.Show("Ny användare är registrerad!");
            textNewUserName.Clear();
            textEpost.Clear();
            textBetalningsMetod.Clear();
            textAnvändareID.Clear();
            textNyttLösenord.Clear();
            textRättLösenord.Clear();
            textNewUserName.Focus();



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textNewUserName.Clear();
            textEpost.Clear();
            textBetalningsMetod.Clear();
            textNyttLösenord.Clear();
            textRättLösenord.Clear();

            textNewUserName.Focus();
        }

        private void VissaNyLösenord_CheckedChanged(object sender, EventArgs e)
        {
            if (VissaNyLösenord.Checked)
            { 
                textNyttLösenord.PasswordChar = '\0';
                textRättLösenord.PasswordChar = '\0';
            }
            else
            {
                textNyttLösenord.PasswordChar = '*';
                textRättLösenord.PasswordChar = '*';
            }

        }
    }
}
