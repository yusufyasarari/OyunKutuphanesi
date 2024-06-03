using System;
using System.Windows.Forms;

namespace kayıt_ol.kütüphane
{
    public partial class Yardim : Form
    {
        Form form;
        public Yardim(Form  form)
        {
            InitializeComponent();         
            this.form = form;
        }
        public Yardim()
        {
            InitializeComponent();
            this.MouseDown += Yardim_MouseDown;
            this.MouseMove += Yardim_MouseMove;            
        }
        private bool isDragging = false;
        private int offsetX, offsetY;
        private void Yardim_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left += e.X - offsetX;
                this.Top += e.Y - offsetY;
            }
        }
        private void Yardim_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offsetX = e.X;
                offsetY = e.Y;
            }
        }
        private void Yardim_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }    
    }
}

