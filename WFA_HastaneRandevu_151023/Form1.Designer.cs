namespace WFA_HastaneRandevu_151023
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnRandevuOlustur = new Button();
            groupBox2 = new GroupBox();
            rb1500 = new RadioButton();
            rb1400 = new RadioButton();
            rb1300 = new RadioButton();
            rb1200 = new RadioButton();
            dtpRandevu = new DateTimePicker();
            cbPoliklinikler = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            rbErkek = new RadioButton();
            rbKadin = new RadioButton();
            txtAdSoyad = new TextBox();
            mtxTelefon = new MaskedTextBox();
            mtxTC = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            lstHastaListesi = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(376, 617);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRandevuOlustur);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(368, 589);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Randevu Oluştur";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRandevuOlustur
            // 
            btnRandevuOlustur.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRandevuOlustur.Location = new Point(63, 522);
            btnRandevuOlustur.Name = "btnRandevuOlustur";
            btnRandevuOlustur.Size = new Size(238, 51);
            btnRandevuOlustur.TabIndex = 1;
            btnRandevuOlustur.Text = "Randevu Oluştur";
            btnRandevuOlustur.UseVisualStyleBackColor = true;
            btnRandevuOlustur.Click += btnRandevuOlustur_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rb1500);
            groupBox2.Controls.Add(rb1400);
            groupBox2.Controls.Add(rb1300);
            groupBox2.Controls.Add(rb1200);
            groupBox2.Controls.Add(dtpRandevu);
            groupBox2.Controls.Add(cbPoliklinikler);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(3, 265);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(354, 251);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Bilgileri";
            // 
            // rb1500
            // 
            rb1500.AutoSize = true;
            rb1500.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rb1500.Location = new Point(180, 190);
            rb1500.Name = "rb1500";
            rb1500.Size = new Size(62, 24);
            rb1500.TabIndex = 13;
            rb1500.TabStop = true;
            rb1500.Text = "15:00";
            rb1500.UseVisualStyleBackColor = true;
            // 
            // rb1400
            // 
            rb1400.AutoSize = true;
            rb1400.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rb1400.Location = new Point(84, 190);
            rb1400.Name = "rb1400";
            rb1400.Size = new Size(62, 24);
            rb1400.TabIndex = 12;
            rb1400.TabStop = true;
            rb1400.Text = "14:00";
            rb1400.UseVisualStyleBackColor = true;
            // 
            // rb1300
            // 
            rb1300.AutoSize = true;
            rb1300.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rb1300.Location = new Point(180, 150);
            rb1300.Name = "rb1300";
            rb1300.Size = new Size(62, 24);
            rb1300.TabIndex = 11;
            rb1300.TabStop = true;
            rb1300.Text = "13:00";
            rb1300.UseVisualStyleBackColor = true;
            // 
            // rb1200
            // 
            rb1200.AutoSize = true;
            rb1200.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rb1200.Location = new Point(84, 150);
            rb1200.Name = "rb1200";
            rb1200.Size = new Size(62, 24);
            rb1200.TabIndex = 2;
            rb1200.TabStop = true;
            rb1200.Text = "12:00";
            rb1200.UseVisualStyleBackColor = true;
            // 
            // dtpRandevu
            // 
            dtpRandevu.Location = new Point(124, 96);
            dtpRandevu.Name = "dtpRandevu";
            dtpRandevu.Size = new Size(200, 23);
            dtpRandevu.TabIndex = 10;
            // 
            // cbPoliklinikler
            // 
            cbPoliklinikler.FormattingEnabled = true;
            cbPoliklinikler.Items.AddRange(new object[] { "Göz", "Ortopedi", "İç Hastalıklar", "Kardiyoloji" });
            cbPoliklinikler.Location = new Point(124, 36);
            cbPoliklinikler.Name = "cbPoliklinikler";
            cbPoliklinikler.Size = new Size(200, 23);
            cbPoliklinikler.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(52, 98);
            label5.Name = "label5";
            label5.Size = new Size(43, 21);
            label5.TabIndex = 8;
            label5.Text = "Tarih";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(28, 38);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 7;
            label4.Text = "Poliklinik";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(mtxTelefon);
            groupBox1.Controls.Add(mtxTC);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(8, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 253);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hasta Bilgileri";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbErkek);
            groupBox3.Controls.Add(rbKadin);
            groupBox3.Location = new Point(6, 145);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(332, 87);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cinsiyet";
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.Location = new Point(142, 38);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(66, 25);
            rbErkek.TabIndex = 1;
            rbErkek.TabStop = true;
            rbErkek.Text = "Erkek";
            rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadin
            // 
            rbKadin.AutoSize = true;
            rbKadin.Location = new Point(17, 38);
            rbKadin.Name = "rbKadin";
            rbKadin.Size = new Size(67, 25);
            rbKadin.TabIndex = 0;
            rbKadin.TabStop = true;
            rbKadin.Text = "Kadın";
            rbKadin.UseVisualStyleBackColor = true;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(103, 59);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(150, 29);
            txtAdSoyad.TabIndex = 5;
            // 
            // mtxTelefon
            // 
            mtxTelefon.Location = new Point(103, 100);
            mtxTelefon.Mask = "(999) 000-0000";
            mtxTelefon.Name = "mtxTelefon";
            mtxTelefon.Size = new Size(150, 29);
            mtxTelefon.TabIndex = 4;
            // 
            // mtxTC
            // 
            mtxTC.Location = new Point(103, 19);
            mtxTC.Mask = "00000000000";
            mtxTC.Name = "mtxTC";
            mtxTC.Size = new Size(150, 29);
            mtxTC.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 102);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 2;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 61);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 19);
            label1.Name = "label1";
            label1.Size = new Size(27, 21);
            label1.TabIndex = 0;
            label1.Text = "TC";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lstHastaListesi);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(368, 589);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Randevular";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstHastaListesi
            // 
            lstHastaListesi.FormattingEnabled = true;
            lstHastaListesi.ItemHeight = 15;
            lstHastaListesi.Location = new Point(6, 6);
            lstHastaListesi.Name = "lstHastaListesi";
            lstHastaListesi.Size = new Size(356, 574);
            lstHastaListesi.TabIndex = 0;
            lstHastaListesi.DoubleClick += lstHastaListesi_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 619);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Main Menu";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TabPage tabPage2;
        private MaskedTextBox mtxTelefon;
        private MaskedTextBox mtxTC;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtAdSoyad;
        private GroupBox groupBox3;
        private RadioButton rbErkek;
        private RadioButton rbKadin;
        private DateTimePicker dtpRandevu;
        private ComboBox cbPoliklinikler;
        private Label label5;
        private Label label4;
        private RadioButton rb1200;
        private RadioButton rb1300;
        private RadioButton rb1500;
        private RadioButton rb1400;
        private Button btnRandevuOlustur;
        private ListBox lstHastaListesi;
    }
}