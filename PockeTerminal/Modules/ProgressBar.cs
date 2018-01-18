using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal1
{
    public partial class CardWaitingSpinner : UserControl
    {
        public CardWaitingSpinner()
        {
            InitializeComponent();
        }

        int dir = 1;
        private void stretch_Tick(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar1.Value == 100)
            {
                dir = -1; //reduce
            }
            else if (bunifuCircleProgressbar1.Value == 0)
            {
                dir = +1; //expand
            }
            bunifuCircleProgressbar1.Value += dir;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CardWaitingSpinner_Load(object sender, EventArgs e)
        {
            
        }

    }
}
