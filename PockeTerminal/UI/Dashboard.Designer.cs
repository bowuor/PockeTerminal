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
            this.balanceButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.itemsButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.statInfo = new System.Windows.Forms.StatusStrip();
            this.statusReader = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.statInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MenuPanel.Controls.Add(this.balanceButton);
            this.MenuPanel.Controls.Add(this.buyButton);
            this.MenuPanel.Controls.Add(this.itemsButton);
            this.MenuPanel.Controls.Add(this.panel4);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(141, 531);
            this.MenuPanel.TabIndex = 0;
            // 
            // balanceButton
            // 
            this.balanceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.balanceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.balanceButton.FlatAppearance.BorderSize = 0;
            this.balanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.balanceButton.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.balanceButton.Image = ((System.Drawing.Image)(resources.GetObject("balanceButton.Image")));
            this.balanceButton.Location = new System.Drawing.Point(17, 419);
            this.balanceButton.Name = "balanceButton";
            this.balanceButton.Size = new System.Drawing.Size(107, 100);
            this.balanceButton.TabIndex = 7;
            this.balanceButton.Text = "Balance";
            this.balanceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.balanceButton.UseVisualStyleBackColor = false;
            this.balanceButton.Click += new System.EventHandler(this.balanceButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyButton.FlatAppearance.BorderSize = 0;
            this.buyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyButton.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buyButton.Image = ((System.Drawing.Image)(resources.GetObject("buyButton.Image")));
            this.buyButton.Location = new System.Drawing.Point(17, 289);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(107, 100);
            this.buyButton.TabIndex = 6;
            this.buyButton.Text = "Buy";
            this.buyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // itemsButton
            // 
            this.itemsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.itemsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemsButton.FlatAppearance.BorderSize = 0;
            this.itemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemsButton.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.itemsButton.Image = ((System.Drawing.Image)(resources.GetObject("itemsButton.Image")));
            this.itemsButton.Location = new System.Drawing.Point(17, 159);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Size = new System.Drawing.Size(107, 100);
            this.itemsButton.TabIndex = 5;
            this.itemsButton.Text = "Items";
            this.itemsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.itemsButton.UseVisualStyleBackColor = false;
            this.itemsButton.Click += new System.EventHandler(this.itemsButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(141, 100);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.LimeGreen;
            this.HeaderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HeaderPanel.Controls.Add(this.panel3);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(141, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1000, 10);
            this.HeaderPanel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LimeGreen;
            this.panel3.Location = new System.Drawing.Point(53, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 100);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Controls.Add(this.statInfo);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel6.Location = new System.Drawing.Point(141, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1000, 521);
            this.panel6.TabIndex = 2;
            // 
            // statInfo
            // 
            this.statInfo.AutoSize = false;
            this.statInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusReader,
            this.statusResult});
            this.statInfo.Location = new System.Drawing.Point(0, 496);
            this.statInfo.Name = "statInfo";
            this.statInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statInfo.Size = new System.Drawing.Size(1000, 25);
            this.statInfo.TabIndex = 3;
            this.statInfo.Text = "statusStrip1";
            // 
            // statusReader
            // 
            this.statusReader.AutoSize = false;
            this.statusReader.ForeColor = System.Drawing.Color.Black;
            this.statusReader.Name = "statusReader";
            this.statusReader.Size = new System.Drawing.Size(150, 20);
            this.statusReader.Text = "statusReader";
            // 
            // statusResult
            // 
            this.statusResult.AutoSize = false;
            this.statusResult.ForeColor = System.Drawing.Color.Black;
            this.statusResult.Name = "statusResult";
            this.statusResult.Size = new System.Drawing.Size(225, 20);
            this.statusResult.Text = "statusResult";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1141, 531);
            this.ControlBox = false;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.HeaderPanel);
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
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.statInfo.ResumeLayout(false);
            this.statInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button balanceButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button itemsButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.StatusStrip statInfo;
        private System.Windows.Forms.ToolStripStatusLabel statusReader;
        private System.Windows.Forms.ToolStripStatusLabel statusResult;
    }
}

