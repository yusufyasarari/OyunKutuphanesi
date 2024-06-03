using System;
using System.Drawing;
using System.Windows.Forms;
using kayıt_ol.kütüphane;
using System.Linq;

namespace kayıt_ol
{
    public partial class GirisYap : Form
    {
        public Point mouseLocation;
        public static int KullaniciId;
        public GirisYap()
        {
            InitializeComponent();
            this.MouseDown += giris_MouseDown;
            this.MouseMove += giris_MouseMove;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (kk.Text == "Kullanıcı Adı" || kk.Text == "" || sf.Text == "" || sf.Text == "Şifre")
            {
                MessageBox.Show("Lütfen bilgilerinizi doğru giriniz...");
                return;
            }
            using (yusstolEntities baglanti = new yusstolEntities())
            {
                if (baglanti.Uyelers.Any(x => x.KullaniciAdi == kk.Text && x.Sifre == sf.Text))
                {
                    KullaniciId = baglanti.Uyelers.Where(x => x.KullaniciAdi == kk.Text && x.Sifre == sf.Text).First().Id;
                    new Kutuphane().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Böyle Bir Hesap Bulunmamaktadır");
                }
            }
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
        private void label8_Click(object sender, EventArgs e)
        {
            Hakkimizda hakkımızda = new Hakkimizda(this);
            hakkımızda.Show();
            this.Hide();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Iletisim iletisim = new Iletisim(this);
            iletisim.Show();
            this.Hide();
        }
        private void giris_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
        private void giris_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (kk.Text == "Kullanıcı Adı")
            {
                kk.Text = "";
                kk.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (kk.Text == "")
            {
                kk.Text = "Kullanıcı Adı";
                kk.ForeColor = Color.Black;
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (sf.Text == "Şifre")
            {
                sf.Text = "";
                sf.ForeColor = Color.Black;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (sf.Text == "")
            {
                sf.Text = "Şifre";
                sf.ForeColor = Color.Black;
            }
        }
    }
}