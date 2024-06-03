using System;
using System.Drawing;
using System.Windows.Forms;

namespace kayıt_ol
{
    public partial class Hakkimizda : Form
    {
        Form form;
        public Hakkimizda(Form form)
        {
            InitializeComponent();
            this.MouseDown += Hakkımızda_MouseDown;
            this.MouseMove += Hakkımızda_MouseMove;
            this.form = form;
        }
        public Hakkimizda()
        {
            InitializeComponent();
            this.MouseDown += Hakkımızda_MouseDown;
            this.MouseMove += Hakkımızda_MouseMove;
        }
        private void label4_Click(object sender, EventArgs e)
        {
            YustolNedir yustol_Nedirr = new YustolNedir(form);
            yustol_Nedirr.Show();
            this.Hide();
        }
        private bool isDragging = false;
        private int offsetX, offsetY;
        private void Hakkımızda_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offsetX = e.X;
                offsetY = e.Y;
            }
        }
        private void Hakkımızda_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left += e.X - offsetX;
                this.Top += e.Y - offsetY;
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }
        private void Hakkımızda_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
        private void label10_Click(object sender, EventArgs e)
        {
            Form customMessageBox = new Form();
            customMessageBox.Text = "Telif Hakkı İhlali Bildirimi";
            customMessageBox.Size = new Size(500, 200);
            customMessageBox.StartPosition = FormStartPosition.CenterScreen;
            customMessageBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            customMessageBox.BackColor = Color.Red;
            customMessageBox.MaximizeBox = false;
            customMessageBox.MinimizeBox = false;

            // Başlık etiketi oluşturma
            Label titleLabel = new Label();
            titleLabel.Text = "YusTol Telif Hakkı Bildirimi";
            titleLabel.ForeColor = Color.Black;
            titleLabel.Font = new Font("Arial", 14, FontStyle.Bold);
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLabel.Dock = DockStyle.Top;

            // Metin etiketi oluşturma
            Label messageLabel = new Label();
            messageLabel.Text = "Başkalarının fikri mülkiyet haklarına saygı duyar ve internet sitelerimizi ve hizmetlerimizi kullanan herkesin de aynısını yapmasını isteriz.\n\nÇalışmalarının internet sitelerimizden veya hizmetlerimizden birinde telif hakkı ihlali oluşturacak şekilde çoğaltıldığına inanan herkes YUSTOL@GMAİL.COM aracılığıyla YusTol'a bildirimde bulunabilir.";
            messageLabel.ForeColor = Color.White;
            messageLabel.Font = new Font("Arial", 12);
            messageLabel.TextAlign = ContentAlignment.MiddleLeft;
            messageLabel.Dock = DockStyle.Fill;
          

            // Kontrolleri forma ekleme
            customMessageBox.Controls.Add(titleLabel);
            customMessageBox.Controls.Add(messageLabel);
   

            // İletişim kutusunu gösterme
            customMessageBox.ShowDialog();
        }
        private void label2_Click_1(object sender, EventArgs e)
        {
            SozlesmeHakkinda sözlesme_Hakkındaki=new SozlesmeHakkinda(form);
            sözlesme_Hakkındaki.Show();
            this.Hide();
        }
    }
}