using System;
using System.Windows.Forms;

namespace kayıt_ol.kütüphane
{
    public partial class Yustol : Form
    {
        Form form;
        public Yustol(Form form)
        {
            InitializeComponent();
            this.form = form;
        }
        public Yustol()
        {
            InitializeComponent();
            this.MouseDown += yustol_MouseDown;
            this.MouseMove += yustol_MouseMove;
        }
        private bool isDragging = false;
        private int offsetX, offsetY;
        private void label6_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }
        private void yustol_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offsetX = e.X;
                offsetY = e.Y;
            }
        }
        private void yustol_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left += e.X - offsetX;
                this.Top += e.Y - offsetY;
            }
        }
        private void yustol_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
