using BilgiHotelDAL;
using Entity;
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
    public partial class FrmVardiyaEkle : Form
    {
        VardiyalarDAL vardiyalarDAL = new VardiyalarDAL();
        VardiyaEntity vardiyaEntity = new VardiyaEntity();
        Tools tool = new Tools();
        public string CustomFormat { get; set; }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dtpbaslangic.Format = DateTimePickerFormat.Custom;
            dtpbaslangic.CustomFormat = "hh':'mm tt";
            dtpbaslangic.Format = DateTimePickerFormat.Custom;
            dtpbaslangic.CustomFormat = "hh':'mm tt";
        }
        public FrmVardiyaEkle()
        {
            InitializeComponent();
        }

        private void FrmVardiyaEkle_Load(object sender, EventArgs e)
        {
            MylistviewDoldurma();
        }
        void formdaikileriEntityIleYazdır()
        {
            vardiyaEntity.VardiyaTipi = vardiyatipi.Text;
            vardiyaEntity.VardiyaBaslangicSaati = dtpbaslangic.Value;
            vardiyaEntity.VardiyaBitisSaati = dtpbitis.Value;
        }
        void MylistviewDoldurma()
        { tool.ListViewDoldur(lvvardiya, "sp_vardiyalarigetir", false, null); }
        private void btnvarekle_Click(object sender, EventArgs e)
        {
            try
            {
                formdaikileriEntityIleYazdır();

                vardiyaEntity.VardiyaId = (int)vardiyalarDAL.getInsertVardiya(vardiyaEntity);

                if (vardiyatipi.Text == "" )
                {
                    MessageBox.Show("Vardiya Tanimi GİRİNİZ");
                }
                else if (vardiyaEntity.VardiyaId == 0)
                {
                    MessageBox.Show("Girilen Tanımda Vardiya  var. Tekrar Deneyiniz");
                }
                else
                {
                    MessageBox.Show("VARDİYA BAŞARIYLA EKLENDİ");
                }
            }
            catch (Exception HATA)
            {
                MessageBox.Show("Vardiya Ekleme Basarisiz" + HATA.Message);
            }
            MylistviewDoldurma();
        }

        private void btnvargüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                formdaikileriEntityIleYazdır();

                int a = vardiyalarDAL.getUpdateVardiya(vardiyaEntity);

                if (vardiyatipi.Text == "")
                {
                    MessageBox.Show("Vardiya Tanimi GİRİNİZ");
                }
                else
                {
                    MessageBox.Show("VARDİYA BAŞARIYLA GÜNCELLENDİ" + a.ToString());
                }
            }
            catch (Exception HATA)
            {
                MessageBox.Show("Vardiya Güncelleme Basarisiz" + HATA.Message);
            }
            MylistviewDoldurma();
        }

        private void btnvargetir_Click(object sender, EventArgs e)
        {
            SqlParameter[] sp =
            {new SqlParameter
                {
                    ParameterName="vardiyatipi",
                    Value=vardiyatipi.Text
                }
            };

            tool.ListViewDoldur(lvvardiya, "sp_vardiyataniminagörevardiyalarigetir", true, sp);
        }

        private void btnvartemizle_Click(object sender, EventArgs e)
        {
            tool.FormTemizle(this);
        }

        private void lvvardiya_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tool.FormDoldur("select * from tbl_Vardiya where VardiyaId=" + lvvardiya.SelectedItems[0].SubItems[0].Text, null, this);
            vardiyatipi.Text = "";
            vardiyaEntity.VardiyaId = Convert.ToInt32(lvvardiya.SelectedItems[0].SubItems[0].Text);
        }

        private void btnvarhepsinigetir_Click(object sender, EventArgs e)
        {
            MylistviewDoldurma();
        }
    }
}
