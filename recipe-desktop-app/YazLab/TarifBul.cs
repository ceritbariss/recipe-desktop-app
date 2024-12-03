using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazLab
{
    public partial class TarifBul : Form
    {
        public TarifBul()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            TxtEldeMiktar.KeyPress += TxtEldeMiktar_KeyPress;
        }

        Tarifler tarifler = new Tarifler();
        Malzemeler malzemeler = new Malzemeler();

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-MAJ4LBL\SQLEXPRESS;Initial Catalog=Yazlab1;Integrated Security=True");

        private void TxtEldeMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string malzemeAdi = CmbTumMalzemeler.SelectedItem.ToString();
            malzemeler.MalzemeBirimGetir(TxtBirim, malzemeAdi);
        }

        private void TxtBirim_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TxtMiktar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Close();
        }

        private void TarifBul_Load(object sender, EventArgs e)
        {
            tarifler.TarifleriListele(dataGridView1);
            malzemeler.ButunMalzemeler(CmbTumMalzemeler);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string malzemeAdi = CmbTumMalzemeler.SelectedItem.ToString();
            int malzemeId = malzemeler.MalzemeIdBul(malzemeAdi);
            string toplamMiktar = TxtEldeMiktar.Text;

            malzemeler.ToplamMiktarGuncelle(malzemeId, toplamMiktar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["TarifAdi"].Value != null)
                {
                    int tarifId = tarifler.TarifIdBul(Convert.ToString(row.Cells["TarifAdi"].Value));
                    bool yeterliMalzemeVar = true;

                    SqlCommand command = new SqlCommand("SELECT MalzemeID, MalzemeMiktar FROM TarifMalzemeIliskisi WHERE TarifID = @TarifID", baglanti);
                    command.Parameters.AddWithValue("TarifID", tarifId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int malzemeID = reader.GetInt32(0);
                            float malzemeMiktar = Convert.ToSingle(reader["MalzemeMiktar"]);
                            float toplamMiktar = malzemeler.ToplamMiktarGetir(malzemeID);

                            if (toplamMiktar < malzemeMiktar) 
                            {
                                yeterliMalzemeVar = false;
                                break;
                            }
                        }
                    }

                    if (yeterliMalzemeVar)
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                    else 
                    {
                        row.DefaultCellStyle.BackColor= Color.Red;
                    }
                }
            }

            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Malzemeler SET ToplamMiktar = NULL", baglanti);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Bütün Malzemelerin Elinizdeki Miktarları Silindi.");
            button3.PerformClick();
        }
    }
}
