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
    public partial class Items : MetroFramework.Forms.MetroForm
    {
        public Items()
        {
            InitializeComponent();
        }

        private void ItemsBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
