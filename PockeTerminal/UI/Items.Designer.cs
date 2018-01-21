namespace Terminal1
{
    partial class Items
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.CartCancelButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.Price});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1141, 591);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.CartCancelButton);
            this.bunifuGradientPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(1141, 73);
            this.bunifuGradientPanel3.TabIndex = 14;
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
            this.CartCancelButton.ButtonText = "Back";
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
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1141, 591);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Items";
            this.ShowInTaskbar = false;
            this.Text = "Items";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Price;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private Bunifu.Framework.UI.BunifuThinButton2 CartCancelButton;
    }
}