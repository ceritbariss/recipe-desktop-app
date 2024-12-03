using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace YazLab
{
    public class Tarifler
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-MAJ4LBL\SQLEXPRESS;Initial Catalog=Yazlab1;Integrated Security=True");
        
        public void TarifleriListele(DataGridView dataGridView)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TarifAdi, Kategori, HazirlanmaSuresi FROM Tarifler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
        }

        public int TarifIdBul(string tarifAdi)
        {
            int tarifID = -1;
            SqlCommand command = new SqlCommand("SELECT TarifID FROM Tarifler WHERE TarifAdi = @TarifAdi", baglanti);
            command.Parameters.AddWithValue("@TarifAdi", tarifAdi);
            baglanti.Open();
            object result = command.ExecuteScalar();
            tarifID = Convert.ToInt32(result);
            baglanti.Close();
            return tarifID;
        }

        public void Hazirlanis(int tarifID, System.Windows.Forms.TextBox textBox)
        {
            SqlCommand command = new SqlCommand("SELECT Talimatlar FROM Tarifler WHERE TarifID = @TarifID", baglanti);
            command.Parameters.AddWithValue("@TarifID", tarifID);
            baglanti.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string hazirlanis = reader["Talimatlar"].ToString();
            textBox.Text = hazirlanis;
            reader.Close();
            baglanti.Close();
        }


        public void TarifSirala(DataGridView dataGridView, System.Windows.Forms.ComboBox comboBox)
        {
            string sorgu = "SELECT TarifAdi, Kategori, HazirlanmaSuresi FROM Tarifler";
            string where = "";
            string orderBy = "";

            string secim = comboBox.SelectedItem.ToString();

            if (secim == "Tatlı" || secim == "Ana Yemek" || secim == "Meze" || secim == "Çorba" || secim == "İçecek")
            {
                where = $" WHERE Kategori = '{secim}'";
            }

            else if (secim == "A - Z")
            {
                orderBy = " ORDER BY TarifAdi ASC";
            }
            else if (secim == "Z - A")
            {
                orderBy = " ORDER BY TarifAdi DESC";
            }
            else if (secim == "Artan Süre")
            {
                orderBy = " ORDER BY HazirlanmaSuresi ASC";
            }
            else if (secim == "Azalan Süre")
            {
                orderBy = " ORDER BY HazirlanmaSuresi DESC";
            }

            sorgu += where + orderBy;

            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView.DataSource = dt;
        }

        public void TarifEkle(System.Windows.Forms.TextBox TxtTarifAdi, System.Windows.Forms.ComboBox CmbKategori, System.Windows.Forms.TextBox TxtSure, System.Windows.Forms.TextBox TxtHazirlanis) 
        {
            int sure = int.Parse(TxtSure.Text);
            string tarifAdi = TxtTarifAdi.Text.Trim();

            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Tarifler WHERE TarifAdi COLLATE Latin1_General_CI_AI = @TarifAdi", baglanti);
            checkCmd.Parameters.AddWithValue("@TarifAdi", tarifAdi);

            baglanti.Open();
            int count = (int)checkCmd.ExecuteScalar();
            baglanti.Close();

            if(count > 0)
            {
                MessageBox.Show("Bu tarif zaten mevcut.");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Tarifler (TarifAdi, Kategori, HazirlanmaSuresi, Talimatlar) VALUES (@TarifAdi, @Kategori, @HazirlanmaSuresi, @Talimatlar)", baglanti);
                cmd.Parameters.AddWithValue("@TarifAdi", TxtTarifAdi.Text);
                cmd.Parameters.AddWithValue("@Kategori", CmbKategori.Text);
                cmd.Parameters.AddWithValue("@HazirlanmaSuresi", sure);
                cmd.Parameters.AddWithValue("@Talimatlar", TxtHazirlanis.Text);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Tarif Eklendi! Şimdi Tarifin Malzemelerini Ekleyiniz.");
            }
        }

        public void TarifSil(int tarifId) 
        {
            baglanti.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM TarifMalzemeIliskisi WHERE TarifID = @TarifID", baglanti);
            cmd.Parameters.AddWithValue("@TarifID", tarifId);
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("DELETE FROM Tarifler WHERE TarifID = @TarifID", baglanti);
            cmd2.Parameters.AddWithValue("@TarifID", tarifId);
            cmd2.ExecuteNonQuery();

            MessageBox.Show("Tarif başarıyla silindi.");
            baglanti.Close();
        }


        public void TarifGuncelle(int tarifId, string tarifAdi, string kategori, int sure, string hazirlanis) 
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Tarifler SET TarifAdi = @TarifAdi, Kategori = @Kategori, HazirlanmaSuresi = @HazirlanmaSuresi, Talimatlar = @Talimatlar WHERE TarifID = @TarifID", baglanti);
            
            cmd.Parameters.AddWithValue("@TarifAdi", tarifAdi);
            cmd.Parameters.AddWithValue("@Kategori", kategori);
            cmd.Parameters.AddWithValue("@HazirlanmaSuresi", sure);
            cmd.Parameters.AddWithValue("@Talimatlar", hazirlanis);
            cmd.Parameters.AddWithValue("@TarifID", tarifId);
            cmd.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Tarif Başarıyla Güncellendi.");
        }


        public void TarifArama(DataGridView dataGridView, string text) 
        {
            baglanti.Open();

            SqlCommand cmd = new SqlCommand("SELECT TarifAdi, Kategori, HazirlanmaSuresi FROM Tarifler WHERE TarifAdi COLLATE SQL_Latin1_General_CP1_CI_AS LIKE '%" + text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;

            baglanti.Close();
        }
    }
}
