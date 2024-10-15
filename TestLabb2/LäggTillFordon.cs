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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestLabb2
{
    public partial class LäggTillFordon : Form
    {

        private Database database = new Database();
        public LäggTillFordon()
        {
            InitializeComponent();
            listStationer.SelectedIndexChanged += new EventHandler(listStationer_SelectedIndexChanged);

        }

        private void LäggTillFordon_Load(object sender, EventArgs e)
        {
            listStationer.Columns.Add("StationID", 100);
            listStationer.Columns.Add("Adress", 100);
            listStationer.Columns.Add("AntalFordon", 100);

            listFordon.Columns.Add("FordonID", 100);
            listFordon.Columns.Add("Typ", 100);
            listFordon.Columns.Add("BatteriNivå", 100);
            listFordon.Columns.Add("Status", 100);

            // Hämta stationerna från databasen
            var stationer = database.HämtaStation();

            // Rensa listan för att förhindra duplicering
            listStationer.Items.Clear();

            // Loopar igenom varje station
            foreach (var station in stationer)
            {
                // Skapar en ny ListViewItem för varje station
                ListViewItem item = new ListViewItem(station.StationID.ToString());
                item.SubItems.Add(station.Adress);
                item.SubItems.Add(station.BefintligaFordon.Count.ToString()); // Lägg till antal fordon
                listStationer.Items.Add(item);
            }

        }

        private void listFordon_SelectedIndexChanged(object sender, EventArgs e)
        {



        }
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listStationer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kontrollera att en station har valts
            if (listStationer.SelectedItems.Count > 0)
            {
                // Hämta den valda stationens ID
                int selectedStationID = int.Parse(listStationer.SelectedItems[0].SubItems[0].Text);

                var stationer = database.HämtaStation();

                // Hitta den valda stationen baserat på StationID
                var valdStation = stationer.FirstOrDefault(station => station.StationID == selectedStationID);

                // Om en station hittas, visa dess fordon
                if (valdStation != null)
                {
                    // Rensa fordonlistan
                    listFordon.Items.Clear();

                    // Loopa igenom varje fordon i den valda stationen
                    foreach (var fordon in valdStation.BefintligaFordon)
                    {
                        // Skapa ett ListViewItem för varje fordon
                        ListViewItem fordonItem = new ListViewItem(fordon.FordonID.ToString());
                        fordonItem.SubItems.Add(fordon.Typ);
                        fordonItem.SubItems.Add(fordon.BatteriNivå.ToString());
                        fordonItem.SubItems.Add(fordon.Status);
                        listFordon.Items.Add(fordonItem);
                    }

                    // Uppdatera antalet fordon för den valda stationen i listStationer
                    listStationer.SelectedItems[0].SubItems[2].Text = valdStation.BefintligaFordon.Count.ToString();
                }
            }

        }

        private void Uppdatera_Click(object sender, EventArgs e)
        {
            // Kontrollera att ett fordon är valt
            if (listFordon.SelectedItems.Count > 0 && listStationer.SelectedItems.Count > 0)
            {
                // Hämta den valda stationens ID
                int selectedStationID = int.Parse(listStationer.SelectedItems[0].SubItems[0].Text);
                var stationer = database.HämtaStation();
                var valdStation = stationer.FirstOrDefault(station => station.StationID == selectedStationID);

                // Hämta det valda fordonets ID från listFordon
                int selectedFordonID = int.Parse(listFordon.SelectedItems[0].SubItems[0].Text);
                var valtFordon = valdStation.BefintligaFordon.FirstOrDefault(fordon => fordon.FordonID == selectedFordonID);

                if (valtFordon != null)
                {
                    // Uppdatera fordonets information baserat på användarens inmatning från textfälten
                    valtFordon.Typ = txtTyp.Text;
                    valtFordon.BatteriNivå = int.Parse(txtBatteriNivå.Text);
                    valtFordon.Status = txtStatus.Text;

                    // Uppdatera listan över fordon för att visa de uppdaterade värdena
                    UppdateraFordonLista(valdStation);
                }
            }

        }

        private void LäggTillFordn_Click(object sender, EventArgs e)
        {
            // Kontrollera att en station är vald
            if (listStationer.SelectedItems.Count > 0)
            {
                // Hämta den valda stationens ID
                int selectedStationID = int.Parse(listStationer.SelectedItems[0].SubItems[0].Text);

                // Hämta alla stationer och hitta den valda stationen
                var stationer = database.HämtaStation();
                var valdStation = stationer.FirstOrDefault(station => station.StationID == selectedStationID);

                // Skapa ett nytt fordon baserat på användarens inmatning
                var nyttFordon = new Fordon
                {
                    FordonID = int.Parse(txtFordonID.Text),
                    Typ = txtTyp.Text,
                    BatteriNivå = int.Parse(txtBatteriNivå.Text),
                    Status = txtStatus.Text
                };

                // Lägg till det nya fordonet i den valda stationens fordon-lista
                valdStation.BefintligaFordon.Add(nyttFordon);

                // Uppdatera listan över fordon och stationens fordonräknare
                UppdateraFordonLista(valdStation);
                listStationer.SelectedItems[0].SubItems[2].Text = valdStation.BefintligaFordon.Count.ToString(); // Uppdatera antal fordon
            }
            else
            {
                MessageBox.Show("Välj en station innan du lägger till ett fordon.");
            }

            txtFordonID.Clear();
            txtBatteriNivå.Clear();
            txtStatus.Clear();
            txtTyp.Clear();
            txtFordonID.Focus();
        }

        private void textEpost_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabortFordon_Click(object sender, EventArgs e)
        {
            Kontrollera att en station och ett fordon är valt
            if (listFordon.SelectedItems.Count > 0 && listStationer.SelectedItems.Count > 0)
            {
                // Hämta den valda stationens ID
                int selectedStationID = int.Parse(listStationer.SelectedItems[0].SubItems[0].Text);

                // Hämta alla stationer och hitta den valda stationen
                var stationer = database.HämtaStation();
                var valdStation = stationer.FirstOrDefault(station => station.StationID == selectedStationID);

                if (valdStation != null)
                {
                    // Hämta det valda fordonets ID från textrutan
                    int selectedFordonID = int.Parse(txtFordonID.Text);

                    // Hitta det valda fordonet i den valda stationens fordon-lista
                    var valtFordon = valdStation.BefintligaFordon.FirstOrDefault(fordon => fordon.FordonID == selectedFordonID);

                    // Om fordonet hittas, ta bort det från listan
                    if (valtFordon != null)
                    {
                        valdStation.BefintligaFordon.Remove(valtFordon);

                        // Uppdatera listan över fordon och stationens fordonräknare
                        UppdateraFordonLista(valdStation);
                        listStationer.SelectedItems[0].SubItems[2].Text = valdStation.BefintligaFordon.Count.ToString(); // Uppdatera antal fordon

                        // Rensa FordonID-fältet
                        txtFordonID.Clear();
                        txtTyp.Clear();
                        txtBatteriNivå.Clear();
                        txtStatus.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Fordonet hittades inte.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Välj både en station och ett fordon innan du tar bort.");
            }
        }
        private void UppdateraFordonLista(Station valdStation)
        {
            // Rensa listan för fordon
            listFordon.Items.Clear();

            // Lägg till varje fordon från den valda stationen till listan
            foreach (var fordon in valdStation.BefintligaFordon)
            {
                ListViewItem item = new ListViewItem(fordon.FordonID.ToString());
                item.SubItems.Add(fordon.Typ);
                item.SubItems.Add(fordon.BatteriNivå.ToString());
                item.SubItems.Add(fordon.Status);
                listFordon.Items.Add(item);
            }
        }

        private void listFordon_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listFordon.SelectedItems.Count > 0)
            {
                // Hämta valt fordon
                int selectedFordonID = int.Parse(listFordon.SelectedItems[0].SubItems[0].Text);

                // Hämta den valda stationens ID
                int selectedStationID = int.Parse(listStationer.SelectedItems[0].SubItems[0].Text);
                var stationer = database.HämtaStation();
                var valdStation = stationer.FirstOrDefault(station => station.StationID == selectedStationID);

                // Hämta det valda fordonet
                var valtFordon = valdStation.BefintligaFordon.FirstOrDefault(fordon => fordon.FordonID == selectedFordonID);

                // Fyll i textrutorna med fordonets aktuella data
                if (valtFordon != null)
                {
                    txtFordonID.Text = valtFordon.FordonID.ToString();
                    txtTyp.Text = valtFordon.Typ;
                    txtBatteriNivå.Text = valtFordon.BatteriNivå.ToString();
                    txtStatus.Text = valtFordon.Status;
                }
            }
        }
    }
}
