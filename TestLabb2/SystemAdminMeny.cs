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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EfterLogIN_Click(object sender, EventArgs e)
        {
            new LäggTillFordon().Show();
            this.Hide();
        }
    }
}
