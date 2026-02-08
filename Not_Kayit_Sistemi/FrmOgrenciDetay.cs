using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Not_Kayit_Sistemi
{
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void LblNumara_Click(object sender, EventArgs e)
        {

        }
        public string numara;

        //veritabanı bağlantısını yaptık.
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JKNOO9P\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True;Encrypt=False");
        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            LblNumara.Text = numara;

            baglanti.Open();
            SqlCommand komut = new SqlCommand(
                "SELECT * FROM dbo.TBLDERS WHERE OGRNUMARA = @p1",
                baglanti
            );
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                LblSınav1.Text = dr[4].ToString();
                LblSınav2.Text = dr[5].ToString();
                LblSınav3.Text = dr[6].ToString();
                LblOrtalama.Text = dr[7].ToString();
                bool durum = Convert.ToBoolean(dr[8]);

                if (durum)
                {
                    LblDurum.Text = "GEÇTİ";
                }
                else
                {
                    LblDurum.Text = "KALDI";
                }
            }
            baglanti.Close();
        }
    }
}
