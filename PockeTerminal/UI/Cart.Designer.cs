namespace Terminal1
{
    partial class Cart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CheckoutButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CartCancelButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 25);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 560);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(755, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "QUICK ORDER";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(755, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SEARCH";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(331, 420);
            this.listBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ksh. 0.00";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 597);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(801, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 597);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 51);
            this.panel3.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Items selected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "0";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.CheckoutButton);
            this.panel4.Controls.Add(this.CartCancelButton);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 481);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(340, 116);
            this.panel4.TabIndex = 12;
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.ActiveBorderThickness = 1;
            this.CheckoutButton.ActiveCornerRadius = 20;
            this.CheckoutButton.ActiveFillColor = System.Drawing.Color.Lime;
            this.CheckoutButton.ActiveForecolor = System.Drawing.Color.White;
            this.CheckoutButton.ActiveLineColor = System.Drawing.Color.Lime;
            this.CheckoutButton.BackColor = System.Drawing.Color.White;
            this.CheckoutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckoutButton.BackgroundImage")));
            this.CheckoutButton.ButtonText = "checkout";
            this.CheckoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckoutButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutButton.ForeColor = System.Drawing.Color.White;
            this.CheckoutButton.IdleBorderThickness = 1;
            this.CheckoutButton.IdleCornerRadius = 20;
            this.CheckoutButton.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.CheckoutButton.IdleForecolor = System.Drawing.Color.White;
            this.CheckoutButton.IdleLineColor = System.Drawing.Color.LimeGreen;
            this.CheckoutButton.Location = new System.Drawing.Point(219, 47);
            this.CheckoutButton.Margin = new System.Windows.Forms.Padding(5);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(107, 58);
            this.CheckoutButton.TabIndex = 13;
            this.CheckoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click_1);
            // 
            // CartCancelButton
            // 
            this.CartCancelButton.ActiveBorderThickness = 1;
            this.CartCancelButton.ActiveCornerRadius = 20;
            this.CartCancelButton.ActiveFillColor = System.Drawing.Color.Lime;
            this.CartCancelButton.ActiveForecolor = System.Drawing.Color.White;
            this.CartCancelButton.ActiveLineColor = System.Drawing.Color.Lime;
            this.CartCancelButton.BackColor = System.Drawing.Color.White;
            this.CartCancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CartCancelButton.BackgroundImage")));
            this.CartCancelButton.ButtonText = "cancel";
            this.CartCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CartCancelButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartCancelButton.ForeColor = System.Drawing.Color.White;
            this.CartCancelButton.IdleBorderThickness = 1;
            this.CartCancelButton.IdleCornerRadius = 20;
            this.CartCancelButton.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.CartCancelButton.IdleForecolor = System.Drawing.Color.White;
            this.CartCancelButton.IdleLineColor = System.Drawing.Color.LimeGreen;
            this.CartCancelButton.Location = new System.Drawing.Point(49, 47);
            this.CartCancelButton.Margin = new System.Windows.Forms.Padding(5);
            this.CartCancelButton.Name = "CartCancelButton";
            this.CartCancelButton.Size = new System.Drawing.Size(103, 58);
            this.CartCancelButton.TabIndex = 12;
            this.CartCancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CartCancelButton.Click += new System.EventHandler(this.CartCancelButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "The amount below shall be deducted from your card";
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.listBox1);
            this.panel5.Location = new System.Drawing.Point(0, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(337, 547);
            this.panel5.TabIndex = 13;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1141, 597);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cart";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cart_Load);
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 CartCancelButton;
        private Bunifu.Framework.UI.BunifuThinButton2 CheckoutButton;
    }
}