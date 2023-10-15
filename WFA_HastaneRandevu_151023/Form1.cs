namespace WFA_HastaneRandevu_151023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Hasta> hastalar = new List<Hasta>();

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();

            hasta.Ad = txtAdSoyad.Text;
            hasta.TCNo = mtxTC.Text;
            hasta.TelefonNo = mtxTelefon.Text;
            string cinsiyet = rbKadin.Checked ? "Kadýn" : "Erkek";
            hasta.Cinsiyet = cinsiyet;

            hasta.Poliklinik = cbPoliklinikler.SelectedItem.ToString();
            hasta.RandevuTarihi = dtpRandevu.Value.Date;
            hasta.RandevuSaati = rb1200.Checked ? "12:00" : rb1300.Checked ? "13:00" : rb1400.Checked ? "14:00" : "15:00";

            hastalar.Add(hasta);

            foreach (Hasta h in hastalar)
            {
                lstHastaListesi.Items.Add(h);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbPoliklinikler.SelectedIndex = 0;
        }

        private void lstHastaListesi_DoubleClick(object sender, EventArgs e)
        {
            if (lstHastaListesi.SelectedItem is Hasta selectedObject)
            {
                MessageBox.Show($"{selectedObject.ToDetailedString()}");
            }

        }
    }
}