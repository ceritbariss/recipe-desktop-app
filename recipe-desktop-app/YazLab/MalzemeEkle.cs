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
    public partial class MalzemeEkle : Form
    {
        private Form previousForm;
        public MalzemeEkle(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.StartPosition = FormStartPosition.CenterScreen;

            TxtBirimFiyat.KeyPress += TxtBirimFiyat_KeyPress;
        }

        Malzemeler malzemeler = new Malzemeler();

        private void TxtBirimFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            malzemeler.MalzemeEkle(TxtMalzemeAdi, CmbBirim, TxtBirimFiyat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (previousForm != null)  // Eğer önceki form varsa ona geri dön
            {
                previousForm.Show();
                this.Close();
            }
        }

        private void MalzemeEkle_Load(object sender, EventArgs e)
        {
            CmbBirim.Items.Add("Adet");
            CmbBirim.Items.Add("Gram");
            CmbBirim.Items.Add("Mililitre");
        }
    }
}
