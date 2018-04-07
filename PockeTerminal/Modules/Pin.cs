using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal1.Modules
{
    public partial class Pin : Form
    {
        public Pin()
        {
            InitializeComponent();

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void NumpadButton1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("1");
        }

        private void NumpadButton2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("2");
        }

        private void NumpadButton3_Click(object sender, EventArgs e)
        {
            SendKeys.Send("3");
        }

        private void NumpadButton4_Click(object sender, EventArgs e)
        {
            SendKeys.Send("4");
        }

        private void NumpadButton5_Click(object sender, EventArgs e)
        {
            SendKeys.Send("5");
        }

        private void NumpadButton6_Click(object sender, EventArgs e)
        {
            SendKeys.Send("6");
        }

        private void NumpadButton7_Click(object sender, EventArgs e)
        {
            SendKeys.Send("7");
        }

        private void NumpadButton8_Click(object sender, EventArgs e)
        {
            SendKeys.Send("8");
        }

        private void NumpadButton9_Click(object sender, EventArgs e)
        {
            SendKeys.Send("9");
        }

        private void NumpadButton0_Click(object sender, EventArgs e)
        {
            SendKeys.Send("0");
        }

        private void NumpadEnterButton_Click(object sender, EventArgs e)
        {
            
            
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int TxTindex = PasswordTextBox.SelectionStart; // save the index position

            if (TxTindex > 0 && TxTindex == PasswordTextBox.Text.Length) // check if there is text in texbox and check if index is at the end of text.

            {
                PasswordTextBox.Text = PasswordTextBox.Text.Remove(PasswordTextBox.Text.Length - 1, 1);
                PasswordTextBox.SelectionStart = PasswordTextBox.Text.Length;
            }

            else // is the index is in between the text?
            {
                if (TxTindex > 0) // check if there is text in texbox
                {
                    PasswordTextBox.Text = PasswordTextBox.Text.Remove(TxTindex - 1, 1);
                    PasswordTextBox.SelectionStart = TxTindex - 1; // to set the cursor position after the deleted number between the text.
                }
                else
                {
                    return;
                }

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Text = String.Empty;
            PasswordTextBox.Focus();
        }
    }
}
