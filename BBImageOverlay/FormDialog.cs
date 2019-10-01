using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBImageOverlay
{
    public partial class FormDialog : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private bblineForm parentForm;
        public FormDialog(bblineForm frm)
        {
            parentForm = frm;
            InitializeComponent();
        }

        private void FormDialog_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void FormDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.DialogLocation = Location;
        }

        private void FormDialog_Load(object sender, EventArgs e)
        {
            Location = Properties.Settings.Default.DialogLocation;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (Program.mapsData.ContainsKey(mapTextBox.Text))
            {
                this.Close();
                parentForm.drawLines(mapTextBox.Text);
            }
            errorLabel.Visible = true;
        }

        private void MapTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (Program.mapsData.ContainsKey(mapTextBox.Text))
                {
                    this.Close();
                    parentForm.drawLines(mapTextBox.Text);
                }
                else
                    errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;
            }
        }
    }
}
