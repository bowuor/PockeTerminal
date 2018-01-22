using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PockeTerminal.Modules;

namespace Terminal1
{
    public partial class CardWaitingForm : Form
    {
        public CardWaitingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CardWaitingForm_Load(object sender, EventArgs e)
        {
            ReadCard read = new ReadCard(1000);

            ReadCardListener readCardListener = new ReadCardListener();
            readCardListener.Listen(read);

            read.Begin();

        }
    }
}
