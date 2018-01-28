using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal1
{
    public partial class Cart : Form
    {

        private void cardWaitingSpinner1_Load(object sender, EventArgs e)
        {

        }

        public Cart()

        {
            InitializeComponent();
        }

        private void CartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            Modules.Pin pin = new Modules.Pin();
            pin.ShowDialog();
        }
    }
}
