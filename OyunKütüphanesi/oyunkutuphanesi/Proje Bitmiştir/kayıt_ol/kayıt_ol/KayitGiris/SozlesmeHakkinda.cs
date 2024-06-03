using System;
using System.Drawing;
using System.Windows.Forms;

namespace kayıt_ol
{
    public partial class SozlesmeHakkinda : Form
    {
        public Point mouseLocation;
        Form gelenForm;
        public SozlesmeHakkinda(Form form)
        {
            InitializeComponent();            
            gelenForm = form;            
        }
        public SozlesmeHakkinda()
        {
            InitializeComponent();
            this.MouseDown += sözlesme_hakkındaki_MouseDown;
            this.MouseMove += sözlesme_hakkındaki_MouseMove;
        }
        private void sözlesme_hakkındaki_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }      
        private void sözlesme_hakkındaki_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Hakkimizda donus = new Hakkimizda(gelenForm);
            donus.Show();
            this.Hide();
        }
    }
}
