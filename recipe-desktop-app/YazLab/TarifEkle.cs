using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazLab
{
    public partial class TarifEkle : Form
    {
        public TarifEkle()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Activated += TarifEkle_Activated;

            TxtSure.KeyPress += TxtSure_KeyPress;
            TxtMiktar.KeyPress += TxtMiktar_KeyPress;
        }

        Malzemeler malzemeler = new Malzemeler();
        Tarifler tarifler = new Tarifler();

        private void TarifEkle_Activated(object sender, EventArgs e)
        {
            malzemeler.ButunMalzemeler(CmbMalzemeler);
        }
        private void TarifEkle_Load(object sender, EventArgs e)
        {
            malzemeler.ButunMalzemeler(CmbMalzemeler);
            CmbKategori.Items.Add("Tatlı");
            CmbKategori.Items.Add("Ana Yemek");
            CmbKategori.Items.Add("Meze");
            CmbKategori.Items.Add("Çorba");
            CmbKategori.Items.Add("İçecek");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MalzemeEkle malzemeEkle = new MalzemeEkle(this);
            malzemeEkle.Show();
            this.Hide();
        }

        private void CmbMalzemeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            malzemeler.MalzemeBirimGetir(TxtBirim, CmbMalzemeler.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tarifAdi = TxtTarifAdi.Text;
            int malzemeId = malzemeler.MalzemeIdBul(CmbMalzemeler.Text);
            int tarifId = tarifler.TarifIdBul(tarifAdi);
            malzemeler.TarifeMalzemeEkle(malzemeId, tarifId, TxtMiktar);
            MessageBox.Show("Tarife Malzeme Eklendi.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tarifler.TarifEkle(TxtTarifAdi, CmbKategori, TxtSure, TxtHazirlanis);
        }

        private void TxtSure_TextChanged(object sender, EventArgs e)
        {

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
    }
}
