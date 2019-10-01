namespace BBImageOverlay
{
    partial class bblineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bblineForm));
            this.mapnameLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.bblineLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mapnameLabel
            // 
            this.mapnameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mapnameLabel.Image = ((System.Drawing.Image)(resources.GetObject("mapnameLabel.Image")));
            this.mapnameLabel.Location = new System.Drawing.Point(0, 0);
            this.mapnameLabel.Name = "mapnameLabel";
            this.mapnameLabel.Size = new System.Drawing.Size(144, 16);
            this.mapnameLabel.TabIndex = 0;
            this.mapnameLabel.Text = "morocc";
            this.mapnameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapnameLabel_MouseDown);
            // 
            // exitLabel
            // 
            this.exitLabel.BackColor = System.Drawing.Color.Lime;
            this.exitLabel.Image = ((System.Drawing.Image)(resources.GetObject("exitLabel.Image")));
            this.exitLabel.Location = new System.Drawing.Point(132, 3);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(9, 9);
            this.exitLabel.TabIndex = 1;
            this.exitLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exitLabel_MouseDown);
            // 
            // bblineLabel
            // 
            this.bblineLabel.BackColor = System.Drawing.Color.Lime;
            this.bblineLabel.Location = new System.Drawing.Point(0, 16);
            this.bblineLabel.Name = "bblineLabel";
            this.bblineLabel.Size = new System.Drawing.Size(128, 129);
            this.bblineLabel.TabIndex = 2;
            // 
            // bblineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(144, 145);
            this.Controls.Add(this.bblineLabel);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.mapnameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "bblineForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bblineForm_FormClosing);
            this.Load += new System.EventHandler(this.bblineForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mapnameLabel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label bblineLabel;
    }
}

