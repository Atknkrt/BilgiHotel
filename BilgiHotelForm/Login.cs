using BilgiHotelDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiHotelForm
{
    public partial class Login : Form
    {
        public static int yetkiId;
        public static int personelId;
        bool drmkontrol = false;
        public Login()
        {
            InitializeComponent();
        }
        //
        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlDataReader oku = SQL.SqlexecuteReader("select k.kullaniciAd,k.KullaniciParola,kp.PersonelId,kp.YetkiId from tbl_KullaniciPersonel as kp join tbl_Kullanici as k ON kp.KullaniciId=k.KullaniciId", null);
            while (oku.Read())
            {
                if (oku["kullaniciAd"].ToString() == txtKullanici.Text && oku["KullaniciParola"].ToString() == txtSifre.Text && oku["YetkiId"].ToString() == "1")
                {
                    drmkontrol = true;
                    yetkiId = Convert.ToInt32(oku[3].ToString());
                    personelId = Convert.ToInt32(oku[2].ToString());
                    FrmAnasayfa fa = new FrmAnasayfa();
                    fa.Show();
                    this.Hide();
                    break;
                }
                else if (oku["kullaniciAd"].ToString() == txtKullanici.Text && oku["KullaniciParola"].ToString() == txtSifre.Text && oku["YetkiId"].ToString() == "2")
                {
                    drmkontrol = true;
                    yetkiId = Convert.ToInt32(oku[3].ToString());
                    personelId = Convert.ToInt32(oku[2].ToString());
                    FrmAnasayfa fa = new FrmAnasayfa();
                    fa.Show();
                    this.Hide();
                    break;
                }
                else if (oku["kullaniciAd"].ToString() == txtKullanici.Text && oku["KullaniciParola"].ToString() == txtSifre.Text && oku["YetkiId"].ToString() == "3")
                {
                    drmkontrol = true;
                    yetkiId = Convert.ToInt32(oku[3].ToString());
                    personelId = Convert.ToInt32(oku[2].ToString());
                    FrmAnasayfa fa = new FrmAnasayfa();
                    fa.Show();
                    this.Hide();
                    break;
                }


            }
            if (txtKullanici.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı veya şifre giriniz");
            }
            else if (drmkontrol == false)
            {
                MessageBox.Show("Böyle bir kullanici bulunamamaktadır");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
