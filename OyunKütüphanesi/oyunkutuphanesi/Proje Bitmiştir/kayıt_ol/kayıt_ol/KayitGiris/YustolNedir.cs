using System;
using System.Drawing;
using System.Windows.Forms;

namespace kayıt_ol
{
    public partial class YustolNedir : Form
    {
        public Point mouseLocation;
        Form gelenForm;
        public YustolNedir(Form gelenForm)
        {
            InitializeComponent();           
            this.gelenForm= gelenForm;
        }
        public YustolNedir()
        {
            InitializeComponent();
            this.MouseDown += yustol_nedir_MouseDown;
            this.MouseMove += yustol_nedir_MouseMove;
        }
        private void yustol_nedir_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
        private void yustol_nedir_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Hakkimizda hakkımızda = new Hakkimizda(gelenForm);
            hakkımızda.Show();
            this.Hide();
        }       
    }
}
