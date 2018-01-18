namespace Terminal1
{
    partial class CardWaitingSpinner
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardWaitingSpinner));
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.stretch = new System.Windows.Forms.Timer(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCircleProgressbar1.animated = true;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 5;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.LimeGreen;
            this.bunifuCircleProgressbar1.LabelVisible = false;
            this.bunifuCircleProgressbar1.LineProgressThickness = 5;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(5, 6);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(200, 200);
            this.bunifuCircleProgressbar1.TabIndex = 0;
            this.bunifuCircleProgressbar1.Value = 30;
            // 
            // stretch
            // 
            this.stretch.Enabled = true;
            this.stretch.Tick += new System.EventHandler(this.stretch_Tick);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.LimeGreen;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(48, 90);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(113, 29);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Tap card";
            // 
            // CardWaitingSpinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "CardWaitingSpinner";
            this.Size = new System.Drawing.Size(216, 212);
            this.Load += new System.EventHandler(this.CardWaitingSpinner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private System.Windows.Forms.Timer stretch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}
