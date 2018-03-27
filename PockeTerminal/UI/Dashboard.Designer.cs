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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.MenuPanel.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.MenuPanel.Controls.Add(this.bunifuGradientPanel2);
            this.MenuPanel.Controls.Add(this.balanceButton);
            this.MenuPanel.Controls.Add(this.buyButton);
            this.MenuPanel.Controls.Add(this.itemsButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(157, 555);
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
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(157, 115);
            this.bunifuGradientPanel2.TabIndex = 8;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.Image = global::PockeTerminal.Properties.Resources.pocke_logo___Copy;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(157, 115);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // balanceButton
            // 
            this.balanceButton.BackColor = System.Drawing.Color.Transparent;
            this.balanceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.balanceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.balanceButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.balanceButton.FlatAppearance.BorderSize = 0;
            this.balanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.balanceButton.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceButton.ForeColor = System.Drawing.Color.Green;
            this.balanceButton.Image = global::PockeTerminal.Properties.Resources.icons8_Wallet_64px_2;
            this.balanceButton.Location = new System.Drawing.Point(17, 386);
            this.balanceButton.Name = "balanceButton";
            this.balanceButton.Size = new System.Drawing.Size(120, 110);
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
            this.buyButton.Location = new System.Drawing.Point(17, 255);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(120, 110);
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
            this.itemsButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.itemsButton.FlatAppearance.BorderSize = 0;
            this.itemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemsButton.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsButton.ForeColor = System.Drawing.Color.Green;
            this.itemsButton.Image = global::PockeTerminal.Properties.Resources.icons8_List_48px;
            this.itemsButton.Location = new System.Drawing.Point(17, 124);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Size = new System.Drawing.Size(120, 110);
            this.itemsButton.TabIndex = 5;
            this.itemsButton.Text = "Items";
            this.itemsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.itemsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.itemsButton.UseVisualStyleBackColor = false;
            this.itemsButton.Click += new System.EventHandler(this.itemsButton_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.MenuPanel);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 35);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(157, 555);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackgroundImage = global::PockeTerminal.Properties.Resources.pocke_logo___Copy;
            this.metroPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(180, 35);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(875, 555);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1078, 613);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.ForestGreen;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(23, 35, 23, 23);
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "POCKECARD";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.MenuPanel.ResumeLayout(false);
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button balanceButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button itemsButton;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
    }
}

