using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YazLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Activated += Form1_Activated;

            TxtSure.KeyPress += TxtSure_KeyPress;
            TxtMiktar.KeyPress += TxtMiktar_KeyPress;
        }

        private void TxtSure_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void TxtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            malzemeler.ButunMalzemeler(CmbMalzemeler);
        }

        // DATA : Data Source=DESKTOP-MAJ4LBL\SQLEXPRESS;Initial Catalog=Yazlab1;Integrated Security=True;Trust Server Certificate=True

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-MAJ4LBL\SQLEXPRESS;Initial Catalog=Yazlab1;Integrated Security=True");

        Tarifler tarifler = new Tarifler();
        Malzemeler malzemeler = new Malzemeler();


        public string tarifAdi;
        public int tarifID;

        private void Form1_Load(object sender, EventArgs e)
        {   
            tarifler.TarifleriListele(dataGridView1);
            CmbSirala.Items.Add("A - Z");
            CmbSirala.Items.Add("Z - A");
            CmbSirala.Items.Add("Tatlı");
            CmbSirala.Items.Add("Ana Yemek");
            CmbSirala.Items.Add("Meze");
            CmbSirala.Items.Add("Çorba");
            CmbSirala.Items.Add("İçecek");
            CmbSirala.Items.Add("Artan Maliyet");
            CmbSirala.Items.Add("Azalan Maliyet");
            CmbSirala.Items.Add("Artan Süre");
            CmbSirala.Items.Add("Azalan Süre");

            CmbKategori.Items.Add("Tatlı");
            CmbKategori.Items.Add("Ana Yemek");
            CmbKategori.Items.Add("Meze");
            CmbKategori.Items.Add("Çorba");
            CmbKategori.Items.Add("İçecek");

            malzemeler.ButunMalzemeler(CmbTumMalzemeler);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // TARİFİN ADINI KATEGORİSİNİ SÜRESİNİ GÖSTER
            TxtTarifAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            CmbKategori.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtSure.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            
            // TARİFİN MALZEMELERİNİ GÖSTER
            tarifAdi = TxtTarifAdi.Text;
            tarifID = tarifler.TarifIdBul(tarifAdi);

            malzemeler.MalzemeBul(tarifID, CmbMalzemeler);

            // HAZIRLANIŞI GÖSTER
            tarifler.Hazirlanis(tarifID, TxtHazirlanis);
        }


        // MALZEME BİRİM MİKTAR DEĞERİNİ GÖSTER
        private void CmbMalzemeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbMalzemeler.SelectedItem != null)
            {
                CmbTumMalzemeler.SelectedIndex = -1;
                string secilenMalzeme = CmbMalzemeler.SelectedItem.ToString();

                malzemeler.MalzemeBirimMiktar(tarifID, secilenMalzeme, TxtMiktar, TxtBirim);
            }
        }

        private void TxtMiktar_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tarifler.TarifSirala(dataGridView1, CmbSirala);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TarifEkle tarifEkle = new TarifEkle();
            tarifEkle.Visible = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tarifId = tarifler.TarifIdBul(TxtTarifAdi.Text);
            tarifler.TarifSil(tarifId);
            tarifler.TarifleriListele(dataGridView1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MalzemeEkle malzemeEkle = new MalzemeEkle(this);
            malzemeEkle.Visible=true;
            this.Hide();
        }

        private void CmbTumMalzemeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbTumMalzemeler.SelectedIndex != -1)
            {
                CmbMalzemeler.SelectedIndex = -1;
                string secilenMalzeme = CmbTumMalzemeler.SelectedItem.ToString();

                malzemeler.MalzemeBirimGetir(TxtBirim, secilenMalzeme);
            }
        }

        private void BtnTarifiGüncelle_Click(object sender, EventArgs e)
        {
            string tarifAdi = TxtTarifAdi.Text;
            string kategori = CmbKategori.Text;
            int sure = int.Parse(TxtSure.Text);
            string hazirlanis = TxtHazirlanis.Text;

            tarifler.TarifGuncelle(tarifID, tarifAdi, kategori, sure, hazirlanis);
            tarifler.TarifleriListele(dataGridView1);
        }

        private void BtnMalzemeGüncelle_Click(object sender, EventArgs e)
        {
            float miktar = float.Parse(TxtMiktar.Text);
            int malzemeId = malzemeler.MalzemeIdBul(CmbMalzemeler.Text);

            malzemeler.MalzemeGuncelle(tarifID, malzemeId, miktar);
            tarifler.TarifleriListele(dataGridView1);
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            int malzemeId = malzemeler.MalzemeIdBul(CmbTumMalzemeler.Text);
            malzemeler.TarifeMalzemeEkle(malzemeId, tarifID, TxtMiktar);
            MessageBox.Show("Malzeme Tarife Eklendi.");
            malzemeler.MalzemeBul(tarifID, CmbMalzemeler);
        }

        private void TxtArama_TextChanged(object sender, EventArgs e)
        {
            string text = TxtArama.Text;
            tarifler.TarifArama(dataGridView1,text);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int malzemeId = malzemeler.MalzemeIdBul(CmbMalzemeler.Text);
            malzemeler.TarifdenMalzemeSil(tarifID, malzemeId);
            MessageBox.Show("Malzeme Tarifden Silindi.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TarifBul tarifBul = new TarifBul();
            tarifBul.Visible = true;
            this.Hide();
        }
    }
}
