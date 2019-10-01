namespace BBImageOverlay
{
    partial class FormDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDialog));
            this.mapTextBox = new System.Windows.Forms.TextBox();
            this.newmapLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mapTextBox
            // 
            this.mapTextBox.Location = new System.Drawing.Point(61, 19);
            this.mapTextBox.Name = "mapTextBox";
            this.mapTextBox.Size = new System.Drawing.Size(100, 20);
            this.mapTextBox.TabIndex = 0;
            this.mapTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MapTextBox_KeyDown);
            // 
            // newmapLabel
            // 
            this.newmapLabel.AutoSize = true;
            this.newmapLabel.BackColor = System.Drawing.Color.Transparent;
            this.newmapLabel.Location = new System.Drawing.Point(2, 22);
            this.newmapLabel.Name = "newmapLabel";
            this.newmapLabel.Size = new System.Drawing.Size(56, 13);
            this.newmapLabel.TabIndex = 1;
            this.newmapLabel.Text = "New Map:";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(5, 40);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(86, 40);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.BackColor = System.Drawing.Color.Maroon;
            this.errorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.errorLabel.Location = new System.Drawing.Point(5, 67);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(155, 15);
            this.errorLabel.TabIndex = 4;
            this.errorLabel.Text = "Error: Can\'t find map!";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.Visible = false;
            // 
            // FormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(165, 85);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.newmapLabel);
            this.Controls.Add(this.mapTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDialog";
            this.Text = "FormDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDialog_FormClosing);
            this.Load += new System.EventHandler(this.FormDialog_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDialog_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mapTextBox;
        private System.Windows.Forms.Label newmapLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label errorLabel;
    }
}