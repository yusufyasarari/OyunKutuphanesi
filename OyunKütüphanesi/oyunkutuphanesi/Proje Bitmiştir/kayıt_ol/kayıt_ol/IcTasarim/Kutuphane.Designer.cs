namespace kayıt_ol.kütüphane
{
    partial class Kutuphane
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.KutuphaneText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SideTimerDate = new System.Windows.Forms.Timer(this.components);
            this.HakkimizdaTimer = new System.Windows.Forms.Timer(this.components);
            this.KayarText = new System.Windows.Forms.Timer(this.components);
            this.oyunPanel = new System.Windows.Forms.Panel();
            this.btnOyna = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SideBar = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.hakkimizdaButton = new System.Windows.Forms.Button();
            this.hakkimizdaContainer = new System.Windows.Forms.Panel();
            this.yardim_button = new System.Windows.Forms.Button();
            this.yustol_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.oyunPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SideBar.SuspendLayout();
            this.panel8.SuspendLayout();
            this.hakkimizdaContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // KutuphaneText
            // 
            this.KutuphaneText.AutoSize = true;
            this.KutuphaneText.BackColor = System.Drawing.Color.Transparent;
            this.KutuphaneText.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KutuphaneText.ForeColor = System.Drawing.Color.Transparent;
            this.KutuphaneText.Location = new System.Drawing.Point(304, -2);
            this.KutuphaneText.MaximumSize = new System.Drawing.Size(344, 86);
            this.KutuphaneText.MinimumSize = new System.Drawing.Size(257, 65);
            this.KutuphaneText.Name = "KutuphaneText";
            this.KutuphaneText.Size = new System.Drawing.Size(344, 86);
            this.KutuphaneText.TabIndex = 0;
            this.KutuphaneText.Text = "Kutuphane";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(855, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SideTimerDate
            // 
            this.SideTimerDate.Interval = 10;
            this.SideTimerDate.Tick += new System.EventHandler(this.SideTimerDate_Tick);
            // 
            // HakkimizdaTimer
            // 
            this.HakkimizdaTimer.Interval = 10;
            this.HakkimizdaTimer.Tick += new System.EventHandler(this.HakkimizdaTimer_Tick);
            // 
            // KayarText
            // 
            this.KayarText.Interval = 10;
            this.KayarText.Tick += new System.EventHandler(this.KayarText_Tick);
            // 
            // oyunPanel
            // 
            this.oyunPanel.Controls.Add(this.btnOyna);
            this.oyunPanel.Controls.Add(this.pictureBox1);
            this.oyunPanel.Controls.Add(this.label8);
            this.oyunPanel.Controls.Add(this.label7);
            this.oyunPanel.Controls.Add(this.label6);
            this.oyunPanel.Controls.Add(this.label5);
            this.oyunPanel.Controls.Add(this.label2);
            this.oyunPanel.Controls.Add(this.label1);
            this.oyunPanel.Location = new System.Drawing.Point(235, 128);
            this.oyunPanel.Name = "oyunPanel";
            this.oyunPanel.Size = new System.Drawing.Size(516, 214);
            this.oyunPanel.TabIndex = 35;
            this.oyunPanel.Visible = false;
            // 
            // btnOyna
            // 
            this.btnOyna.Location = new System.Drawing.Point(188, 173);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(75, 23);
            this.btnOyna.TabIndex = 7;
            this.btnOyna.Text = "Oyna";
            this.btnOyna.UseVisualStyleBackColor = true;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kayıt_ol.Properties.Resources.arabaYaris;
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(385, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "İndirildi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(385, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Eğlence";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(385, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Araba Yarışı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(183, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "İndirme Durumu: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(183, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(183, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oyun İsmi: ";
            // 
            // SideBar
            // 
            this.SideBar.BackgroundImage = global::kayıt_ol.Properties.Resources.red_arka_plan;
            this.SideBar.Controls.Add(this.panel8);
            this.SideBar.Controls.Add(this.hakkimizdaContainer);
            this.SideBar.Controls.Add(this.panel3);
            this.SideBar.Controls.Add(this.panel7);
            this.SideBar.Controls.Add(this.panel5);
            this.SideBar.Location = new System.Drawing.Point(0, -2);
            this.SideBar.MaximumSize = new System.Drawing.Size(227, 655);
            this.SideBar.MinimumSize = new System.Drawing.Size(61, 655);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(61, 655);
            this.SideBar.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.hakkimizdaButton);
            this.panel8.Location = new System.Drawing.Point(-17, 253);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(269, 66);
            this.panel8.TabIndex = 36;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Location = new System.Drawing.Point(4, 64);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(253, 67);
            this.panel9.TabIndex = 33;
            // 
            // hakkimizdaButton
            // 
            this.hakkimizdaButton.BackColor = System.Drawing.Color.Transparent;
            this.hakkimizdaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hakkimizdaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hakkimizdaButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hakkimizdaButton.ForeColor = System.Drawing.Color.Transparent;
            this.hakkimizdaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hakkimizdaButton.Location = new System.Drawing.Point(13, 1);
            this.hakkimizdaButton.MinimumSize = new System.Drawing.Size(233, 65);
            this.hakkimizdaButton.Name = "hakkimizdaButton";
            this.hakkimizdaButton.Size = new System.Drawing.Size(254, 65);
            this.hakkimizdaButton.TabIndex = 34;
            this.hakkimizdaButton.Text = "     ❓      Hakkimizda";
            this.hakkimizdaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hakkimizdaButton.UseVisualStyleBackColor = false;
            this.hakkimizdaButton.Click += new System.EventHandler(this.hakkimizdaButton_Click);
            // 
            // hakkimizdaContainer
            // 
            this.hakkimizdaContainer.BackColor = System.Drawing.Color.Transparent;
            this.hakkimizdaContainer.Controls.Add(this.yardim_button);
            this.hakkimizdaContainer.Controls.Add(this.yustol_button);
            this.hakkimizdaContainer.Location = new System.Drawing.Point(-7, 255);
            this.hakkimizdaContainer.MaximumSize = new System.Drawing.Size(256, 156);
            this.hakkimizdaContainer.MinimumSize = new System.Drawing.Size(236, 64);
            this.hakkimizdaContainer.Name = "hakkimizdaContainer";
            this.hakkimizdaContainer.Size = new System.Drawing.Size(256, 64);
            this.hakkimizdaContainer.TabIndex = 35;
            // 
            // yardim_button
            // 
            this.yardim_button.BackColor = System.Drawing.Color.Transparent;
            this.yardim_button.Cursor = System.Windows.Forms.Cursors.Help;
            this.yardim_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yardim_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yardim_button.ForeColor = System.Drawing.Color.Transparent;
            this.yardim_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yardim_button.Location = new System.Drawing.Point(55, 107);
            this.yardim_button.Name = "yardim_button";
            this.yardim_button.Size = new System.Drawing.Size(197, 44);
            this.yardim_button.TabIndex = 36;
            this.yardim_button.Text = "    •     yardim";
            this.yardim_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yardim_button.UseVisualStyleBackColor = false;
            this.yardim_button.Click += new System.EventHandler(this.yardim_button_Click);
            // 
            // yustol_button
            // 
            this.yustol_button.BackColor = System.Drawing.Color.Transparent;
            this.yustol_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yustol_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yustol_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yustol_button.ForeColor = System.Drawing.Color.Transparent;
            this.yustol_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yustol_button.Location = new System.Drawing.Point(55, 63);
            this.yustol_button.Name = "yustol_button";
            this.yustol_button.Size = new System.Drawing.Size(197, 44);
            this.yustol_button.TabIndex = 35;
            this.yustol_button.Text = "    •     YusTol";
            this.yustol_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yustol_button.UseVisualStyleBackColor = false;
            this.yustol_button.Click += new System.EventHandler(this.yustol_button_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(-17, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 72);
            this.panel3.TabIndex = 32;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(13, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 65);
            this.button2.TabIndex = 29;
            this.button2.Text = "    🛒     Magaza";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(4, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(253, 67);
            this.panel4.TabIndex = 33;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.menuButton);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(229, 109);
            this.panel7.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(71, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.AutoSize = true;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Location = new System.Drawing.Point(12, 32);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(44, 42);
            this.menuButton.TabIndex = 0;
            this.menuButton.Text = "☰";
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(-7, 127);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(252, 65);
            this.panel5.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-1, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 65);
            this.button1.TabIndex = 29;
            this.button1.Text = "     🎮     Kütüphane";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Kutuphane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(903, 594);
            this.Controls.Add(this.oyunPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KutuphaneText);
            this.Controls.Add(this.SideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kutuphane";
            this.Text = "Kütüphane";
            this.Load += new System.EventHandler(this.Kutuphane_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Kütüphane_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Kütüphane_MouseMove);
            this.oyunPanel.ResumeLayout(false);
            this.oyunPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SideBar.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.hakkimizdaContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label KutuphaneText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer SideTimerDate;
        private System.Windows.Forms.Timer HakkimizdaTimer;
        private System.Windows.Forms.Timer KayarText;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label menuButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel hakkimizdaContainer;
        private System.Windows.Forms.Button yardim_button;
        private System.Windows.Forms.Button yustol_button;
        private System.Windows.Forms.Button hakkimizdaButton;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel oyunPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOyna;
    }
}