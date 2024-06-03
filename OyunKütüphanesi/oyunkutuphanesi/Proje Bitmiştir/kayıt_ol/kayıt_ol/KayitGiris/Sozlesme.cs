using System;
using System.Drawing;
using System.Windows.Forms;

namespace kayıt_ol
{
    public partial class Sozlesme : Form
    {
        public Point mouseLocation;
        public Sozlesme()
        {
            InitializeComponent();
            this.MouseDown += sozlesme_MouseDown;
            this.MouseMove += sozlesme_MouseMove;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            KayitOl kayıt = new KayitOl();
            kayıt.Show();
            this.Hide();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void sozlesme_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
        private void sozlesme_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }            
    }
}
