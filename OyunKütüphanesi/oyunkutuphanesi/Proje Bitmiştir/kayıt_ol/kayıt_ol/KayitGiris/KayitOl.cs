using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace kayıt_ol
{
    public partial class KayitOl : Form
    {
        public Point mouseLocation;
        public KayitOl()
        {
            InitializeComponent();
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
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
            GirisYap giris = new GirisYap();
            giris.Show();
            this.Hide();
        }
        private void abonelik_Click(object sender, EventArgs e)
        {
            Sozlesme soz = new Sozlesme();
            soz.Show();
            this.Hide();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_kad.Text == "" || txt_kad.Text == "Kullanıcı Adı" || sifre.Text == "Şifre" || sifre.Text == "" || pos.Text == "E-posta" || pos.Text == "")
                {
                    MessageBox.Show("Lütfen boş alan bırakmayınız...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (trh.Checked == false)
                {
                    MessageBox.Show("Lütfen bir tarih seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (radioButton1.Checked == false)
                {
                    MessageBox.Show("Lütfen Buttonu işaretleyiniz...");
                    return;
                }
                if (txt_kad.Text.Length < 8)
                {
                    MessageBox.Show("Kullanıcı Adı 8 karakterden büyük olmalıdır");
                    return;
                }
                if (sifre.Text.Length < 8)
                {
                    MessageBox.Show("Şifre 8 karakterden büyük olmalıdır");
                    return;
                }

                using (yusstolEntities baglanti = new yusstolEntities())
                {
                    if (baglanti.Uyelers.Any(x => x.Eposta == pos.Text))
                    {
                        MessageBox.Show("Bu e posta kullanılıyor");
                        return;
                    }
                    TimeSpan yass = DateTime.Now - trh.Value;
                    double yas = yass.TotalDays / 365;
                    if (!(yas >= 13))
                    {
                        MessageBox.Show("13 yaşından büyük değil");
                        return;
                    }
                    if (pos.Text.Contains("@") && pos.Text.Contains("."))
                    {
                        Uyeler uye = new Uyeler();
                        uye.KullaniciAdi = txt_kad.Text;
                        uye.Eposta = pos.Text;
                        uye.Sifre = sifre.Text;
                        uye.Yas = Convert.ToInt32(yas);
                        baglanti.Uyelers.Add(uye);
                        baglanti.SaveChanges();                        
                        new GirisYap().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Mail Geçersiz");
                    }
                }
            }
            catch (Exception error) { MessageBox.Show("Şuanda kayıt işlemi gerçekleştirilimeiyor");}
        }
        private void label8_Click(object sender, EventArgs e)
        {
            Iletisim iletisim = new Iletisim(this);
            iletisim.Show();
            this.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime yasAltıTarih = new DateTime(2010, 1, 1);
            trh.Value = yasAltıTarih;

            // DateTimePicker'ın formatını özelleştirin
            trh.Format = DateTimePickerFormat.Custom;
            trh.CustomFormat = "dd.MM.yyyy";
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txt_kad.Text == "Kullanıcı Adı")
            {
                txt_kad.Text = "";
                txt_kad.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txt_kad.Text == "")
            {
                txt_kad.Text = "Kullanıcı Adı";
                txt_kad.ForeColor = Color.Black;
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (sifre.Text == "Şifre")
            {
                sifre.Text = "";
                sifre.ForeColor = Color.Black;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (sifre.Text == "")
            {
                sifre.Text = "Şifre";
                sifre.ForeColor = Color.Black;
            }
        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (pos.Text == "E-posta")
            {
                pos.Text = "";
                pos.ForeColor = Color.Black;
            }
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (pos.Text == "")
            {
                pos.Text = "E-posta";
                pos.ForeColor = Color.Black;
            }
        }
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime secilenTarih = trh.Value;

            DateTime bugun = DateTime.Today;

            int yas = bugun.Year - secilenTarih.Year;

            if (secilenTarih > bugun.AddYears(-yas))
            {
                yas--;
            }

            if (yas < 13)
            {
                MessageBox.Show("Kişi 13 yaşından küçük. Uyarı: Çocuk içeriği olabilir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            sifre.UseSystemPasswordChar = false;
        }
        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            sifre.UseSystemPasswordChar = true;
        }
        private void label10_Click(object sender, EventArgs e)
        {
            Hakkimizda hakkımızda = new Hakkimizda(this);
            hakkımızda.Show();
            this.Hide();
        }
    }
}

