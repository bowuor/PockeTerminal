﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using uFCoderMulti;
using System.IO;

namespace Terminal1
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }
        
        private void buyButton_Click(object sender, EventArgs e)
        {
            CardWaitingForm modal = new CardWaitingForm();
            
            DialogResult dialogresult = modal.ShowDialog();

            if (dialogresult == DialogResult.OK)

            {
                Console.WriteLine("You clicked OK");
                Cart sale = new Cart();
                sale.Show();
            }
            else if (dialogresult == DialogResult.Cancel)
            {
               Console.WriteLine("No card detected");
            }

            modal.Dispose();
        }
        
        private void balanceButton_Click(object sender, EventArgs e)
        {
            CardWaitingForm tap = new CardWaitingForm();

            DialogResult dialogresult = tap.ShowDialog();

            if (dialogresult == DialogResult.OK)

            {
                Console.WriteLine("You clicked OK");
                Balance bal = new Balance();
                bal.Show();
            }
            else if (dialogresult == DialogResult.Cancel)
            {
                Console.WriteLine("No card detected");
            }

            tap.Dispose();
        }

        private void itemsButton_Click(object sender, EventArgs e)
        {
            Items itemList = new Items();
            itemList.Show();
        }

        private void HomePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
