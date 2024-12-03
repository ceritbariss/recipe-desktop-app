using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Collections;

namespace YazLab
{
    public class Malzemeler
    {
        private string data = @"Data Source=DESKTOP-MAJ4LBL\SQLEXPRESS;Initial Catalog=Yazlab1;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-MAJ4LBL\SQLEXPRESS;Initial Catalog=Yazlab1;Integrated Security=True");

        public void MalzemeBul(int tarifID, System.Windows.Forms.ComboBox comboBox)
        {
            string sorgu = "SELECT m.MalzemeAdi " +
                           "FROM TarifMalzemeIliskisi t " +
                           "JOIN Malzemeler m ON t.MalzemeID = m.MalzemeID " +
                           "WHERE t.TarifID = @TarifID";

            using (SqlConnection baglanti = new SqlConnection(data))
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                da.SelectCommand.Parameters.AddWithValue("@TarifID", tarifID);
                DataTable dataTable = new DataTable();

                baglanti.Open();
                da.Fill(dataTable);
                comboBox.Items.Clear();

                foreach (DataRow row in dataTable.Rows)
                {
                    comboBox.Items.Add(row["MalzemeAdi"].ToString());
                }

                if (comboBox.Items.Count > 0)
                {
                    comboBox.SelectedIndex = 0;
                }
            }
        }
        


        public void MalzemeBirimMiktar(int tarifID, string malzemeAdi, System.Windows.Forms.TextBox TxtMiktar, System.Windows.Forms.TextBox TxtBirim)
        {
            string sorgu = "SELECT t.MalzemeMiktar, m.MalzemeBirim " +
                           "FROM TarifMalzemeIliskisi t " +
                           "JOIN Malzemeler m ON t.MalzemeID = m.MalzemeID " +
                           "WHERE t.TarifID = @TarifID AND m.MalzemeAdi = @MalzemeAdi";

            using (SqlConnection baglanti = new SqlConnection(data))
            {
                SqlCommand command = new SqlCommand(sorgu, baglanti);
                command.Parameters.AddWithValue("@TarifID", tarifID);
                command.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);

                baglanti.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TxtMiktar.Text = reader["MalzemeMiktar"].ToString();
                    TxtBirim.Text = reader["MalzemeBirim"].ToString();
                }
                reader.Close();
            }
        }


        public void MalzemeEkle(System.Windows.Forms.TextBox TxtMalzemeAdi, System.Windows.Forms.ComboBox CmbBirim, System.Windows.Forms.TextBox TxtBirimFiyat) 
        {
            string malzemeAdi = TxtMalzemeAdi.Text.Trim();

            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Malzemeler WHERE MalzemeAdi COLLATE Latin1_General_CI_AI = @MalzemeAdi", baglanti);
            checkCmd.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);

            baglanti.Open();
            int count = (int)checkCmd.ExecuteScalar();
            baglanti.Close();

            if (count > 0)
            {
                MessageBox.Show("Bu malzeme zaten mevcut.");
            }
            else
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Malzemeler (MalzemeAdi, MalzemeBirim, BirimFiyat) " +
                                   "VALUES (@MalzemeAdi, @MalzemeBirim, @BirimFiyat)", baglanti);
                cmd.Parameters.AddWithValue("@MalzemeAdi", TxtMalzemeAdi.Text);
                cmd.Parameters.AddWithValue("@MalzemeBirim", CmbBirim.Text);
                cmd.Parameters.AddWithValue("@BirimFiyat", int.Parse(TxtBirimFiyat.Text));
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Malzeme Eklendi.");
            }
        }


        public void ButunMalzemeler(System.Windows.Forms.ComboBox CmbMalzemeler) 
        {
            SqlCommand cmd = new SqlCommand("SELECT MalzemeAdi FROM Malzemeler", baglanti);
            baglanti.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            CmbMalzemeler.Items.Clear();
            while (reader.Read())
            {
                string malzemeAdi = reader["MalzemeAdi"].ToString();
                CmbMalzemeler.Items.Add(malzemeAdi);
            }
            baglanti.Close();
        }

        public void MalzemeBirimGetir(System.Windows.Forms.TextBox TxtBirim, String MalzemeAdi) 
        {
            SqlCommand cmd = new SqlCommand("SELECT MalzemeBirim FROM Malzemeler WHERE MalzemeAdi = @MalzemeAdi", baglanti);
            baglanti.Open();
            cmd.Parameters.AddWithValue("@MalzemeAdi", MalzemeAdi);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            TxtBirim.Text = reader["MalzemeBirim"].ToString();
            baglanti.Close();
        }

        
        public int MalzemeIdBul(String malzemeAdi) 
        {
            int malzemeID = -1;
            SqlCommand cmd = new SqlCommand("SELECT MalzemeID FROM Malzemeler WHERE MalzemeAdi = @MalzemeAdi", baglanti);
            cmd.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);
            baglanti.Open();
            malzemeID = Convert.ToInt32(cmd.ExecuteScalar());
            baglanti.Close();
            return malzemeID;
        }

        public void TarifeMalzemeEkle(int malzemeId, int tarifId, System.Windows.Forms.TextBox TxtMiktar) 
        {
            float miktar = float.Parse(TxtMiktar.Text);

            SqlCommand cmd = new SqlCommand("INSERT INTO TarifMalzemeIliskisi (TarifID, MalzemeID, MalzemeMiktar) VALUES (@TarifID, @MalzemeID, @MalzemeMiktar)", baglanti);
            cmd.Parameters.AddWithValue("@TarifID", tarifId);
            cmd.Parameters.AddWithValue("@MalzemeID", malzemeId);
            cmd.Parameters.AddWithValue("@MalzemeMiktar", miktar);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        public void TarifdenMalzemeSil(int tarifId, int malzemeId) 
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM TarifMalzemeIliskisi WHERE TarifID = @TarifID AND MalzemeID = @MalzemeID", baglanti);
            cmd.Parameters.AddWithValue("@TarifID", tarifId);
            cmd.Parameters.AddWithValue("@MalzemeID", malzemeId);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        public void MalzemeGuncelle(int tarifId, int malzemeId, float miktar) 
        {
            baglanti.Open();

            SqlCommand cmd = new SqlCommand("UPDATE TarifMalzemeIliskisi SET MalzemeMiktar = @MalzemeMiktar WHERE TarifID = @TarifID AND MalzemeID = @MalzemeID", baglanti);

            cmd.Parameters.AddWithValue("@MalzemeMiktar", miktar);
            cmd.Parameters.AddWithValue("@TarifID", tarifId);
            cmd.Parameters.AddWithValue("@MalzemeID", malzemeId);
            cmd.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Malzeme Başarıyla Güncellendi.");
        }


        public void ToplamMiktarGuncelle(int malzemeId, string toplamMiktar) 
        {
            SqlCommand cmd = new SqlCommand("UPDATE Malzemeler SET ToplamMiktar = @ToplamMiktar WHERE MalzemeID = @MalzemeID", baglanti);
            cmd.Parameters.AddWithValue("@ToplamMiktar", toplamMiktar);
            cmd.Parameters.AddWithValue("@MalzemeID", malzemeId);

            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Elinizdeki Malzeme Miktarı Eklendi.");
        }

        public float ToplamMiktarGetir(int malzemeId) 
        {
            SqlCommand cmd = new SqlCommand("SELECT ToplamMiktar FROM Malzemeler WHERE MalzemeID = @MalzemeID", baglanti);
            cmd.Parameters.AddWithValue("@MalzemeID", malzemeId);
            baglanti.Open();

            object result = cmd.ExecuteScalar();
            float toplamMiktar = (result != null && result != DBNull.Value) ? Convert.ToSingle(result) : 0f;

            baglanti.Close();

            return toplamMiktar;
        }
    }
}
