using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace kayıt_ol.kütüphane
{
    public partial class Kutuphane : Form
    {
        bool sidebarExpand;
        bool OboutCollapse;
        bool kayantext;
        private bool isTextBig = false;
        public Point mouseLocation;
        public Kutuphane()
        {
            InitializeComponent();
            this.MouseDown += Kütüphane_MouseDown;
            this.MouseMove += Kütüphane_MouseMove;
        }
        private void Kütüphane_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
        private void Kütüphane_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
        private void SideTimerDate_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                SideBar.Width -= 110;

                if (SideBar.Width == SideBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SideTimerDate.Stop();
                }
            }
            else
            {
                SideBar.Width += 190;
                if (SideBar.Width == SideBar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SideTimerDate.Stop();
                }
            }
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            KayarText.Start();
            SideTimerDate.Start();

            if (isTextBig)
            {
                KutuphaneText.Text = "Kutuphane";
                KutuphaneText.Font = new Font(KutuphaneText.Font.FontFamily, 48);
                isTextBig = false;
                KutuphaneText.Location = new Point(KutuphaneText.Location.X - 80, KutuphaneText.Location.Y);
                oyunPanel.Location = new Point(oyunPanel.Location.X-90, oyunPanel.Location.Y);
                //Thread.Sleep(200);

            }
            else
            {
                KutuphaneText.Text = "Kutuphane";
                KutuphaneText.Font = new Font(KutuphaneText.Font.FontFamily, 36);
                isTextBig = true;

                oyunPanel.Location=new Point(235, 128);

                KutuphaneText.Location = new Point(KutuphaneText.Location.X + 80, KutuphaneText.Location.Y);
                //Thread.Sleep(200);
            }
        }
        private void HakkimizdaTimer_Tick(object sender, EventArgs e)
        {
            if (OboutCollapse)
            {
                hakkimizdaContainer.Height += 10;
                if (hakkimizdaContainer.Height == hakkimizdaContainer.MaximumSize.Height)
                {
                    OboutCollapse = false;
                    HakkimizdaTimer.Stop();
                }
            }
            else
            {
                hakkimizdaContainer.Height -= 10;
                if (hakkimizdaContainer.Height == hakkimizdaContainer.MinimumSize.Height)
                {
                    OboutCollapse = true;
                    HakkimizdaTimer.Stop();
                }
            }
        }
        private void hakkimizdaButton_Click(object sender, EventArgs e)
        {
            HakkimizdaTimer.Start();
        }
        private void KayarText_Tick(object sender, EventArgs e)
        {
            if (kayantext)
            {
                

            }
            else
            {


            }

            if (kayantext)
            {
           

            }
            else
            {

            }

            if (kayantext)
            {
                

            }
            else
            {

               

            }

        }
        private void yardim_button_Click(object sender, EventArgs e)
        {
            Yardim yardim = new Yardim(this);
            yardim.Show();
            this.Hide();
        }
        private void yustol_button_Click(object sender, EventArgs e)
        {
            Yustol yustol = new Yustol(this);
            yustol.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Magaza magaza = new Magaza();
            magaza.Show();
            this.Hide();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Kutuphane_Load(object sender, EventArgs e)
        {
            yusstolEntities db = new yusstolEntities();
            Uyeler uye = db.Uyelers.Where(x => x.Id == GirisYap.KullaniciId).First();
            if (uye.OyunIndimi.HasValue)
            {
                oyunPanel.Visible=true;
            }
            else { oyunPanel.Visible=false; }
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\Sevinç\\OneDrive\\Masaüstü\\oyun\\oyunFinal.exe");
        }
    }
}
