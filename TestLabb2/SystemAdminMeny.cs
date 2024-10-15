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
    public partial class SystemAdminMeny : Form
    {
        public SystemAdminMeny()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new HanteraStation().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EfterLogIN_Click(object sender, EventArgs e)
        {
            new FordonHantering().Show();
            this.Hide();
            MessageBox.Show("1. Vid Uppdatering måste du fylla i alla fält och klicka på FordonID. " +
                "\n 2. För att ta bort måste du klicka på ForodonID och fylla i ForodonID fältet.");
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
