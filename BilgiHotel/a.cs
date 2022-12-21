using BilgiHotelDAL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiHotel
{
    public partial class a : Form
    {
        public a()
        {
            InitializeComponent();
        }

        

        private void btnKamEkle_Click(object sender, EventArgs e)
        {
           VardiyaEntity var = new VardiyaEntity();
           VardiyalarDAL mydal = new VardiyalarDAL();
            var.VardiyaTipi = vartxttanim.Text;
            var.VardiyaBaslangicSaati = vardtpbaslangic.Value;
            var.VardiyaBitisSaati= vardtpbitis.Value;
            mydal.getInsertVardiya(var);
        }
    }
}
