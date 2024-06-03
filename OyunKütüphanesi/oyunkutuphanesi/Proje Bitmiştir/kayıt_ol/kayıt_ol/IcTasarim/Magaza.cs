using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace kayıt_ol.kütüphane
{

    public partial class Magaza : Form
    {
        private Point mouseLocation;
        bool sidebarExpand;
        bool OboutCollapse;
        private bool isTextBig = false;
        public Magaza()
        {
            InitializeComponent();
        }
        private void magaza_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
        private void magaza_MouseMove(object sender, MouseEventArgs e)
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
        private void menuButton_Click(object sender, EventArgs e)
        {
            SideTimerDate.Start();
            if (isTextBig)
            {
                magazatxt.Text = "Mağaza";
                isTextBig = false;
                magazatxt.Location = new Point(magazatxt.Location.X - 90, magazatxt.Location.Y);
                magazapan.Location = new Point(magazapan.Location.X - 102, magazapan.Location.Y);
                oyunPanel.Location = new Point(oyunPanel.Location.X+90, oyunPanel.Location.Y);

            }
            else
            {
                magazatxt.Text = "Mağaza";
                isTextBig = true;
                magazatxt.Location = new Point(magazatxt.Location.X + 90, magazatxt.Location.Y);
                magazapan.Location = new Point(magazapan.Location.X + 102, magazapan.Location.Y);
                oyunPanel.Location = new Point(236, 108);

            }


        }
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Kutuphane kutuphane = new Kutuphane();
            kutuphane.Show();
            this.Hide();
        }
        private void hakkimizdaButton_Click(object sender, EventArgs e)
        {
            HakkimizdaTimer.Start();
        }
        private void yustol_button_Click(object sender, EventArgs e)
        {
            Yustol yustol = new Yustol(this);
            yustol.Show();
            this.Hide();
        }
        private void yardim_button_Click(object sender, EventArgs e)
        {
            Yardim yardim = new Yardim(this);
            yardim.Show();
            this.Hide();
        }


        private void btnOyunİndir_Click(object sender, EventArgs e)
        {
            // Kaynak dosyanın yolu
            string kaynakDosyaYolu = @"INDIR:\oyunn\OyunFinal.exe";

            // Hedef dosyanın yolu
            string hedefDosyaYolu = @"C:\INCEK\OyunFinal.exe";

            // Dosyayı kopyala
            DosyaKopyala(kaynakDosyaYolu, hedefDosyaYolu);

            MessageBox.Show("Dosya indirildi!");


            yusstolEntities db = new yusstolEntities();
            Uyeler uye = db.Uyelers.Where(x => x.Id == GirisYap.KullaniciId).First();
            uye.OyunIndimi = true;
            db.SaveChanges();


            btnOyunİndir.Enabled = false;
            lblOyunDurum.Text = "İndirildi";
            lblOyunDurum.ForeColor = Color.Green;

        }
        private void DosyaKopyala(string kaynak, string hedef)
        {
            try
            {
                // Dosyayı kopyala
                File.Copy(kaynak, hedef, true);
            }
            catch (Exception ex)
            {
                // Hata durumunda ekrana yazdır
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void Magaza_Load(object sender, EventArgs e)
        {
            yusstolEntities db = new yusstolEntities();
            Uyeler uye = db.Uyelers.Where(x => x.Id == GirisYap.KullaniciId).First();
            if (uye.OyunIndimi.HasValue)
            {
                btnOyunİndir.Enabled = false;
                lblOyunDurum.Text = "İndirildi";
                lblOyunDurum.ForeColor = Color.Green;
            }
            else
            {
                btnOyunİndir.Enabled = true;
                lblOyunDurum.Text = "İndirilmedi";
                lblOyunDurum.ForeColor = Color.Red;
            }
        }
    }
}

