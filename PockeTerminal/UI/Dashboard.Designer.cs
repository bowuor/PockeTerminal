namespace Terminal1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.balanceButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.itemsButton = new System.Windows.Forms.Button();
            this.HomePanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.headerPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MenuPanel.Controls.Add(this.bunifuGradientPanel2);
            this.MenuPanel.Controls.Add(this.balanceButton);
            this.MenuPanel.Controls.Add(this.buyButton);
            this.MenuPanel.Controls.Add(this.itemsButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(141, 531);
            this.MenuPanel.TabIndex = 0;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.logo);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(141, 100);
            this.bunifuGradientPanel2.TabIndex = 8;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.Image = global::PockeTerminal.Properties.Resources.pocke_logo;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(141, 100);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // balanceButton
            // 
            this.balanceButton.BackColor = System.Drawing.Color.Transparent;
            this.balanceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.balanceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.balanceButton.FlatAppearance.BorderSize = 0;
            this.balanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.balanceButton.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceButton.ForeColor = System.Drawing.Color.Green;
            this.balanceButton.Image = global::PockeTerminal.Properties.Resources.icons8_Wallet_64px_2;
            this.balanceButton.Location = new System.Drawing.Point(17, 400);
            this.balanceButton.Name = "balanceButton";
            this.balanceButton.Size = new System.Drawing.Size(107, 128);
            this.balanceButton.TabIndex = 7;
            this.balanceButton.Text = "Balance";
            this.balanceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.balanceButton.UseVisualStyleBackColor = false;
            this.balanceButton.Click += new System.EventHandler(this.balanceButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.Color.Transparent;
            this.buyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyButton.FlatAppearance.BorderSize = 0;
            this.buyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyButton.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyButton.ForeColor = System.Drawing.Color.Green;
            this.buyButton.Image = global::PockeTerminal.Properties.Resources.icons8_Shopping_Cart_64px;
            this.buyButton.Location = new System.Drawing.Point(17, 257);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(107, 128);
            this.buyButton.TabIndex = 6;
            this.buyButton.Text = "Buy";
            this.buyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // itemsButton
            // 
            this.itemsButton.BackColor = System.Drawing.Color.Transparent;
            this.itemsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.itemsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemsButton.FlatAppearance.BorderSize = 0;
            this.itemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemsButton.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsButton.ForeColor = System.Drawing.Color.Green;
            this.itemsButton.Image = global::PockeTerminal.Properties.Resources.icons8_List_48px;
            this.itemsButton.Location = new System.Drawing.Point(17, 116);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Size = new System.Drawing.Size(107, 128);
            this.itemsButton.TabIndex = 5;
            this.itemsButton.Text = "Items";
            this.itemsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.itemsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.itemsButton.UseVisualStyleBackColor = false;
            this.itemsButton.Click += new System.EventHandler(this.itemsButton_Click);
            // 
            // HomePanel
            // 
            this.HomePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomePanel.BackgroundImage")));
            this.HomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.GradientBottomLeft = System.Drawing.Color.White;
            this.HomePanel.GradientBottomRight = System.Drawing.Color.LightGreen;
            this.HomePanel.GradientTopLeft = System.Drawing.Color.White;
            this.HomePanel.GradientTopRight = System.Drawing.Color.White;
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Quality = 10;
            this.HomePanel.Size = new System.Drawing.Size(1000, 531);
            this.HomePanel.TabIndex = 1;
            this.HomePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HomePanel_Paint);
            // 
            // headerPanel
            // 
            this.headerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("headerPanel.BackgroundImage")));
            this.headerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.headerPanel.GradientBottomRight = System.Drawing.Color.LightGreen;
            this.headerPanel.GradientTopLeft = System.Drawing.Color.White;
            this.headerPanel.GradientTopRight = System.Drawing.Color.White;
            this.headerPanel.Location = new System.Drawing.Point(141, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Quality = 10;
            this.headerPanel.Size = new System.Drawing.Size(1000, 36);
            this.headerPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HomePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(141, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 531);
            this.panel1.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1141, 531);
            this.ControlBox = false;
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "POCKECARD";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuPanel.ResumeLayout(false);
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button balanceButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button itemsButton;
        private Bunifu.Framework.UI.BunifuGradientPanel headerPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel HomePanel;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Panel panel1;
    }
}

