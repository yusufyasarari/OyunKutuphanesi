using System;
using System.Drawing;
using System.Windows.Forms;

namespace kayıt_ol
{
    public partial class Iletisim : Form
    {
        public Point mouseLocation;
        Form form;
        public Iletisim(Form form)
        {
            InitializeComponent();
            this.MouseDown += iletisim_MouseDown;
            this.MouseMove += iletisim_MouseMove;
            this.form = form;
        }
        public Iletisim()
        {
        }
        private void iletisim_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
        private void iletisim_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }
        private void label4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
