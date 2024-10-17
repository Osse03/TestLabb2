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

            // Töm listan och visa hyreshistoriken
            listHyreshistorik.Items.Clear();
            foreach (var hyra in inloggadAnvändare.HyresHistorik)
            {
                ListViewItem item = new ListViewItem(hyra.HyraID);
                item.SubItems.Add(hyra.StartTid.ToString());
                item.SubItems.Add(hyra.SlutTid.ToString());
                item.SubItems.Add(hyra.Kostnad.ToString("F2"));
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

                    foreach (var fordon in station.BefintligaFordon.Where(f => f.Status == "Tillgänglig"))
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

        private void Hyra_Click(object sender, EventArgs e)
        {
            // Kontrollera om användaren redan har en aktiv hyra
            var aktivHyra = inloggadAnvändare.HyresHistorik.FirstOrDefault(h => h.SlutTid == null);
            if (aktivHyra != null)
            {
                MessageBox.Show("Du har redan en aktiv hyra. Avsluta den innan du hyr ett nytt fordon.");
                return;
            }

            // Fortsätt med att hyra fordonet om ingen aktiv hyra finns
            if (listFordon.SelectedItems.Count > 0)
            {
                int selectedFordonID = int.Parse(listFordon.SelectedItems[0].SubItems[0].Text);
                int selectedStationID = int.Parse(listStationer.SelectedItems[0].SubItems[0].Text);

                var station = database.HämtaStation().FirstOrDefault(s => s.StationID == selectedStationID);
                var fordon = station.BefintligaFordon.FirstOrDefault(f => f.FordonID == selectedFordonID);

                if (fordon != null && fordon.Status == "Tillgänglig")
                {
                    // Skapa ny hyra
                    aktuellHyra = new Hyra
                    {
                        HyraID = Guid.NewGuid().ToString(),
                        StartTid = DateTime.Now,
                        Användare = inloggadAnvändare,
                        Fordon = fordon
                    };

                    // Uppdatera fordonets status
                    fordon.Status = "Upptaget";
                    MessageBox.Show("Du har hyrt fordonet!");

                    // Uppdatera listan med fordon
                    listFordon.Items.Remove(listFordon.SelectedItems[0]);
                }

            }
            else
            {
                MessageBox.Show("Välj ett fordon att hyra.");
            }
        }
        private void AvslutaHyra_Click(object sender, EventArgs e)
        {
            if (aktuellHyra != null)
            {
                // Ange sluttid och beräkna kostnad
                aktuellHyra.SlutTid = DateTime.Now;

                double timmar = (aktuellHyra.SlutTid - aktuellHyra.StartTid).TotalHours;

                aktuellHyra.Kostnad = timmar * 100;  // Exempelpris 100 kr per timme

                // Uppdatera fordonets status till "Tillgänglig"
                aktuellHyra.Fordon.Status = "Tillgänglig";

                // Lägga till hyra i användarens historik
                inloggadAnvändare.HyresHistorik.Add(aktuellHyra);

                // Fråga användaren vilken station fordonet ska lämnas vid
                var stationer = database.HämtaStation();
                string stationLista = string.Join("\n", stationer.Select(s => $"{s.StationID} - {s.Adress}").ToArray());
                string valdStationID = Microsoft.VisualBasic.Interaction.InputBox($"Välj station att lämna fordonet:\n{stationLista}", "Lämna Fordon", "1");

                if (int.TryParse(valdStationID, out int stationID))
                {
                    var valdStation = stationer.FirstOrDefault(s => s.StationID == stationID);
                    if (valdStation != null)
                    {
                        valdStation.BefintligaFordon.Add(aktuellHyra.Fordon);

                        // Visa meddelande med kostnad och var fordonet lämnades
                        MessageBox.Show($"Hyran är avslutad. Kostnad: {aktuellHyra.Kostnad} SEK.\nFordonet har lämnats vid {valdStation.Adress}.");

                        // Återställ hyresdata
                        aktuellHyra = null;
                    }
                    else
                    {
                        MessageBox.Show("Ogiltig station. Försök igen.");
                    }
                }
                else
                {
                    MessageBox.Show("Ogiltig inmatning. Försök igen.");
                }
            }
            else
            {
                MessageBox.Show("Du har ingen aktiv hyra att avsluta.");
            }
        }



















        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 
    }
}
