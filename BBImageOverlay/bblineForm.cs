using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace BBImageOverlay
{
    public partial class bblineForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private Bitmap cursor;



        public bblineForm()
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("BBImageOverlay.zoom.png");
            cursor = new Bitmap(myStream);
            
            InitializeComponent();
            drawLines("morocc");
        }



        public void drawLines(string town)
        {
            if (Program.mapsData.ContainsKey(town))
            {
                mapnameLabel.Text = town;
                Point p = new Point();
                Program.mapsData.TryGetValue(town, out p);
                int linesX = p.X / 40;
                int linesY = p.Y / 40;

                float distanceX = 128f / (p.X / 40.0f);
                float distanceY = 128f / (p.Y / 40.0f);

                if (p.Y > p.X)
                {
                    linesX *= 2;
                    distanceX *= (float)p.X / (float)p.Y;
                }

                if (p.Y < p.X)
                {
                    linesY *= 2;
                    distanceY *= (float)p.Y / (float)p.X;
                }

                Bitmap buffer = new Bitmap(128, 129);
                Graphics g = Graphics.FromImage(buffer);
                g.Clear(Color.Lime);
                Pen pen = new Pen(Color.Red);
                for (int i = 1; i < linesX; i++)
                {
                    int round = (int)Math.Round(i * distanceX);
                    g.DrawLine(pen, 0, 128-(int)Math.Round(i * distanceX), 128, 128-(int)Math.Round(i * distanceX));
                    bblineLabel.Image = buffer;
                }

                for (int i = 1; i <= linesY; i++)
                {

                    g.DrawLine(pen, (int)Math.Round(i * distanceY), 0, (int)Math.Round(i * distanceY), 129);
                }
               
                Bitmap bmp = cursor;
                g.DrawImage(bmp, 116, 1, 10, 19);
                bblineLabel.Image = buffer;
            }
        }

        private void mapnameLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                Properties.Settings.Default.Location = Location;
            }
            if (e.Button == MouseButtons.Right)
            {
                Form formDialog = new FormDialog(this);
                formDialog.ShowDialog(this);
            }
        }

        private void exitLabel_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
            System.Environment.Exit(0);
        }

        private void bblineForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Location = Location;
        }

        private void bblineForm_Load(object sender, EventArgs e)
        {
            Location = Properties.Settings.Default.Location;
        }
    }
}
