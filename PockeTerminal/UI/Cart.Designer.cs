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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckoutButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CartCancelButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSearchBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.bunifuGradientPanel3.SuspendLayout();
            this.bunifuGradientPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 524);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(645, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "QUICK ORDER";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.bunifuGradientPanel2);
            this.tabPage2.Controls.Add(this.bunifuGradientPanel1);
            this.tabPage2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(781, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SEARCH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ksh. 0.00";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuGradientPanel4);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 524);
            this.panel1.TabIndex = 11;
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
            this.CheckoutButton.Location = new System.Drawing.Point(1020, 5);
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
            this.CartCancelButton.Location = new System.Drawing.Point(19, 5);
            this.CartCancelButton.Margin = new System.Windows.Forms.Padding(5);
            this.CartCancelButton.Name = "CartCancelButton";
            this.CartCancelButton.Size = new System.Drawing.Size(103, 58);
            this.CartCancelButton.TabIndex = 12;
            this.CartCancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CartCancelButton.Click += new System.EventHandler(this.CartCancelButton_Click);
            // 
            // bunifuSearchBox
            // 
            this.bunifuSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuSearchBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuSearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSearchBox.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuSearchBox.HintText = "Search Item";
            this.bunifuSearchBox.isPassword = false;
            this.bunifuSearchBox.LineFocusedColor = System.Drawing.Color.Green;
            this.bunifuSearchBox.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuSearchBox.LineMouseHoverColor = System.Drawing.Color.Green;
            this.bunifuSearchBox.LineThickness = 2;
            this.bunifuSearchBox.Location = new System.Drawing.Point(43, 14);
            this.bunifuSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSearchBox.Name = "bunifuSearchBox";
            this.bunifuSearchBox.Size = new System.Drawing.Size(379, 33);
            this.bunifuSearchBox.TabIndex = 2;
            this.bunifuSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuSearchBox);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(775, 58);
            this.bunifuGradientPanel1.TabIndex = 4;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.listBox2);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(3, 61);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(775, 436);
            this.bunifuGradientPanel2.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.MultiColumn = true;
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(775, 436);
            this.listBox2.TabIndex = 0;
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.CheckoutButton);
            this.bunifuGradientPanel3.Controls.Add(this.CartCancelButton);
            this.bunifuGradientPanel3.Controls.Add(this.label3);
            this.bunifuGradientPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(1141, 73);
            this.bunifuGradientPanel3.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(759, 0);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(382, 524);
            this.listBox1.TabIndex = 1;
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.Controls.Add(this.bunifuTileButton1);
            this.bunifuGradientPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(653, 0);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(106, 524);
            this.bunifuGradientPanel4.TabIndex = 2;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "Tile 1";
            this.bunifuTileButton1.Location = new System.Drawing.Point(9, 173);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(88, 79);
            this.bunifuTileButton1.TabIndex = 0;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1141, 597);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel3);
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
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 CartCancelButton;
        private Bunifu.Framework.UI.BunifuThinButton2 CheckoutButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuSearchBox;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.ListBox listBox2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private System.Windows.Forms.ListBox listBox1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
    }
}