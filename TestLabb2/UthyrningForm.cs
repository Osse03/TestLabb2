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
    public partial class UthyrningForm : Form
    {
        private Database database;
        private Användare inloggadAnvändare;
        private Hyra aktuellHyra;

        public UthyrningForm(Database db, Användare användare)
        {
            InitializeComponent();
            this.database = db;
            this.inloggadAnvändare = användare;
            // Ladda stationer och fordon
            LaddaStationer();

        }
        private void UthyrningForm_Load(object sender, EventArgs e)
        {
            if (inloggadAnvändare == null)
            {
                MessageBox.Show("Ingen användare är inloggad. Vänligen logga in igen.");
                this.Close();  // Stäng formuläret om ingen användare är inloggad
                return;
            }
            // Visa användarens uppgifter
            lblFullNamn.Text = $"Namn: {inloggadAnvändare.FullNamn}";
            lblEpost.Text = $"E-post: {inloggadAnvändare.Epost}";


            listHyreshistorik.Columns.Add("HyraID", 100);
            listHyreshistorik.Columns.Add("Starttid", 150);
            listHyreshistorik.Columns.Add("Sluttid", 150);
            listHyreshistorik.Columns.Add("Kostnad", 100);

            // Töm listan och visa hyreshistoriken
            listHyreshistorik.Items.Clear();
            foreach (var hyra in inloggadAnvändare.HyresHistorik)
            {
                ListViewItem item = new ListViewItem(hyra.HyraID.ToString()); // Konvertera int till string
                item.SubItems.Add(hyra.StartTid.ToString());
                item.SubItems.Add(hyra.SlutTid.ToString());
                item.SubItems.Add(hyra.Kostnad.ToString("F2")); // Konvertera decimal till string med 2 decimaler
                listHyreshistorik.Items.Add(item);
            }
        }
        private void LaddaStationer()
        {
            listStationer.Columns.Add("StationID", 100);
            listStationer.Columns.Add("Adress", 100);
            listStationer.Columns.Add("AntalFordon", 100);

            listFordon.Columns.Add("FordonID", 100);
            listFordon.Columns.Add("Typ", 100);
            listFordon.Columns.Add("BatteriNivå", 100);
            listFordon.Columns.Add("Status", 100);

            var stationer = database.HämtaStation();
            listStationer.Items.Clear();

            foreach (var station in stationer)
            {
                ListViewItem item = new ListViewItem(station.StationID.ToString());
                item.SubItems.Add(station.Adress);
                item.SubItems.Add(station.BefintligaFordon.Count.ToString());
                listStationer.Items.Add(item);
            }
        }


        private void listStationer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listStationer.SelectedItems.Count > 0)
            {
                int selectedStationID = int.Parse(listStationer.SelectedItems[0].SubItems[0].Text);
                var station = database.HämtaStation().FirstOrDefault(s => s.StationID == selectedStationID);

                if (station != null)
                {
                    listFordon.Items.Clear();

                    foreach (var fordon in station.BefintligaFordon)
                    {
                        ListViewItem fordonItem = new ListViewItem(fordon.FordonID.ToString());
                        fordonItem.SubItems.Add(fordon.Typ);
                        fordonItem.SubItems.Add(fordon.BatteriNivå.ToString());
                        fordonItem.SubItems.Add(fordon.Status);
                        listFordon.Items.Add(fordonItem);
                    }
                }
            }

        }

        private void UppdateraFordon(Station valdStation)
        {
            listFordon.Items.Clear();

            foreach (var fordon in valdStation.BefintligaFordon)
            {
                ListViewItem item = new ListViewItem(fordon.FordonID.ToString());
                item.SubItems.Add(fordon.Typ);
                item.SubItems.Add(fordon.BatteriNivå.ToString());
                item.SubItems.Add(fordon.Status);
                listFordon.Items.Add(item);
            }
        }

        // Metod för att uppdatera hyreshistorik
        private void UppdateraHyreshistorik()
        {
            listHyreshistorik.Items.Clear();

            foreach (var hyra in inloggadAnvändare.HyresHistorik)
            {
                ListViewItem item = new ListViewItem(hyra.HyraID.ToString());
                item.SubItems.Add(hyra.StartTid.ToString());
                item.SubItems.Add(hyra.SlutTid.ToString());
                item.SubItems.Add(hyra.Kostnad.ToString("F2"));  
                listHyreshistorik.Items.Add(item);
            }
        }

        // Metod för att uppdatera stationens lista
        private void UppdateraStationer()
        {
            listStationer.Items.Clear();

            var stationer = database.HämtaStation();
            foreach (var station in stationer)
            {
                ListViewItem item = new ListViewItem(station.StationID.ToString());
                item.SubItems.Add(station.Adress);
                item.SubItems.Add(station.BefintligaFordon.Count.ToString());  // Dynamisk fordonsräkning
                listStationer.Items.Add(item);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHyra_Click_1(object sender, EventArgs e)
        {  
            
            // Kontrollera att både en station och ett fordon har valts
            if (listStationer.SelectedItems.Count > 0 && listFordon.SelectedItems.Count > 0)
            {
                // Hämta det valda station-ID och fordon-ID från listorna
                int selectedStationID = int.Parse(listStationer.SelectedItems[0].SubItems[0].Text);
                int selectedFordonID = int.Parse(listFordon.SelectedItems[0].SubItems[0].Text);

                // Hämta vald station baserat på stationID
                var stationer = database.HämtaStation();
                var valdStation = stationer.FirstOrDefault(s => s.StationID == selectedStationID);

                if (valdStation != null)
                {
                    // Hämta valt fordon från stationens fordonslista
                    var valtFordon = valdStation.BefintligaFordon.FirstOrDefault(f => f.FordonID == selectedFordonID);

                    if (valtFordon != null)
                    {
                        // Skapa en ny hyra och koppla fordonet till användaren
                        aktuellHyra = new Hyra
                        {
                            HyraID = Database.GenereraNyHyraID(),  // Genererar ett unikt HyraID
                            StartTid = DateTime.Now,
                            Fordon = valtFordon
                        };

                        // Ta bort fordonet från stationens tillgängliga fordon
                        valdStation.BefintligaFordon.Remove(valtFordon);

                        // Uppdatera listorna
                        UppdateraStationer();
                        UppdateraFordon(valdStation);

                        MessageBox.Show($"Du har hyrt {valtFordon.Typ}.", "Hyra lyckades");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vänligen välj både en station och ett fordon.", "Fel");
            }


        }

        private void btnAvslutaHyra_Click_1(object sender, EventArgs e)
        {
            if (aktuellHyra == null)
            {
                MessageBox.Show("Du har ingen aktiv hyra att avsluta.", "Fel");
                return;
            }

            // Sätt sluttiden och beräkna kostnaden
            aktuellHyra.SlutTid = DateTime.Now;
            double timmar = (aktuellHyra.SlutTid - aktuellHyra.StartTid).TotalHours;
            aktuellHyra.Kostnad = timmar * 100; // Exempelpris 100 kr per timme

            // Lägg till hyran till användarens hyreshistorik
            inloggadAnvändare.HyresHistorik.Add(aktuellHyra);

            // Uppdatera hyreshistoriken i gränssnittet
            UppdateraHyreshistorik();

            // Återställ hyresdata och uppdatera stationens fordonslista
            aktuellHyra.Fordon.Status = "Tillgänglig";
            var stationer = database.HämtaStation();
            string stationLista = string.Join("\n", stationer.Select(s => $"{s.StationID} - {s.Adress}").ToArray());
            string valdStationID = Microsoft.VisualBasic.Interaction.InputBox($"Välj station att lämna fordonet:\n{stationLista}", "Lämna Fordon", "1");

            if (int.TryParse(valdStationID, out int stationID))
            {
                var valdStation = stationer.FirstOrDefault(s => s.StationID == stationID);
                if (valdStation != null)
                {
                    // Lägg till fordonet till vald station
                    valdStation.BefintligaFordon.Add(aktuellHyra.Fordon);

                    // Uppdatera stationens lista och fordon
                    UppdateraStationer();
                    UppdateraFordon(valdStation);

                    MessageBox.Show($"Hyran är avslutad. Kostnad: {aktuellHyra.Kostnad} SEK.", "Hyra avslutad");
                }
            }

            // Återställ hyresdata
            aktuellHyra = null;
        }
    }
}
