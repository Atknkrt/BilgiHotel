using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace BilgiHotelDAL
{
    public class Tools
    {
        public void ComboBoxDoldur(System.Windows.Forms.ComboBox cmb,string sp,bool spdurum)
        {
            List<KeyValuePair<object, string>> c = new List<KeyValuePair<object, string>>();
            SqlDataReader oku = SQL.SqlexecuteReaderSp(sp, false, null);
            while (oku.Read())
            {
                c.Add(new KeyValuePair<object, string>((object)oku[0], (string)oku[1]));
            }
            cmb.DataSource = c.ToList();
            cmb.ValueMember = "key";
            cmb.DisplayMember = "value";
            oku.Close();
        }
        public void ListViewDoldur(ListView lv,string sp,bool spdurum, SqlParameter[] kmtprmtr)
        {
            lv.Items.Clear();
            lv.Columns.Clear();
            lv.GridLines= true;
            lv.FullRowSelect= true;
            ListViewItem SECİLEN = lv.FocusedItem;
            lv.View =View.Details;
            SqlDataReader oku = SQL.SqlexecuteReaderSp(sp, spdurum, kmtprmtr);
            for (int i = 0; i < oku.FieldCount; i++)
            {
                lv.Columns.Add(oku.GetName(i), 100);
            }
            while (oku.Read())
            {
                ListViewItem ekle= new ListViewItem(oku[0].ToString());
                for (int i = 1; i < oku.FieldCount; i++)
                {
                    ekle.SubItems.Add(oku[i].ToString());
                }
                lv.Items.Add(ekle);
            }
            oku.Close();
        }
        public void FormTemizle(Form frm)
        {
            foreach (Control item in frm.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }
                else if (item is CheckBox)
                {
                    (item as CheckBox).Checked = false;
                }
                else if (item is ListView)
                {
                    (item as ListView).Items.Clear();
                    
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex=-1;
                }
                else if(item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
                else if(item is DateTimePicker)
                {
                    (item as DateTimePicker).Value= DateTime.Today;
                }
                else if (item is Panel)
                {
                    panelTemizle((Panel)item);
                }
            }
        }
        public void FormDoldur(string cmdtext, SqlParameter[] kmtprmt,Form pnl)
        {
            SqlDataReader dr = SQL.SqlexecuteReaderSp(cmdtext, false, null);
            dr.Read();
            foreach(Control item in pnl.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = dr[(item as TextBox).TabIndex].ToString();
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex =Convert.ToInt32(dr[(item as ComboBox).TabIndex])-1;
                }
                else if (item is CheckBox)
                {
                    (item as CheckBox).Checked = Convert.ToBoolean(dr[(item as CheckBox).TabIndex]);
                }
                else if (item is DateTimePicker)
                {
                    (item as DateTimePicker).Value = Convert.ToDateTime(dr[(item as DateTimePicker).TabIndex]);
                }
                else if (item is TableLayoutPanel)
                {
                    asd(cmdtext, kmtprmt, (TableLayoutPanel)item);
                }
            }
        }
        public void asd (string cmdtext, SqlParameter[] kmtprmt, TableLayoutPanel tbl)
        {
            SqlDataReader dr = SQL.SqlexecuteReaderSp(cmdtext, false, null);
            dr.Read();
            foreach (Control item in tbl.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = dr[(item as TextBox).TabIndex].ToString();
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = Convert.ToInt32(dr[(item as ComboBox).TabIndex]) - 1;
                }
                else if (item is CheckBox)
                {
                    (item as CheckBox).Checked = Convert.ToBoolean(dr[(item as CheckBox).TabIndex]);
                }
                else if (item is DateTimePicker)
                {
                    (item as DateTimePicker).Value = Convert.ToDateTime(dr[(item as DateTimePicker).TabIndex]);
                }
                else if (item is TableLayoutPanel)
                {
                    asd( cmdtext, kmtprmt, (TableLayoutPanel)item);
                }
            }
        }
        public void panelTemizle(Panel pnl)
        {
            foreach (Control item in pnl.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }
                else if (item is CheckBox)
                {
                    (item as CheckBox).Checked = false;
                }
                else if (item is ListView)
                {
                    (item as ListView).Items.Clear();
                    (item as ListView).Columns.Clear();
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = -1;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
                else if (item is DateTimePicker)
                {
                    (item as DateTimePicker).Value = DateTime.Today;
                }
                else if (item is Panel)
                {
                    panelTemizle((Panel)item);
                }
            }
        }
        
        public void gbodalar(GroupBox gb,string sp,bool spdurum, SqlParameter[] kmtprmtr)
        {
            List<string> odalistesi = new List<string>();
           
            SqlDataReader oku = SQL.SqlexecuteReaderSp(sp, spdurum, kmtprmtr);
            while (oku.Read())
            {
                odalistesi.Add(oku[0].ToString());
            }
                foreach (Control item in gb.Controls)
                {
                    if (item is Button)
                    {

                        if (odalistesi.Contains(item.Text))
                        {
                            item.BackColor = Color.Red;
                        }
                        else
                        {
                            item.BackColor = Color.Green;
                        }

                    }
                }           
        }
        public void günHesaplama(DateTime dt1,DateTime dt2,Label lb)
        {
            TimeSpan sonuc= dt2 - dt1;
            //sonuc = BüyükTarih - KücükTarih;
            lb.Text = sonuc.Days.ToString();
        }
        public void FormlaraTarihSaat(Label lb1, Label lb2)
        {
            lb1.Text = DateTime.Now.ToLongDateString();
            lb2.Text = DateTime.Now.ToLongTimeString();
        }
        public void RezTipineGöreFiyatBelirleme(ComboBox cmb,TextBox txt, string sp, bool spdurum, SqlParameter[] kmtprmtr)
        {
            
            //int rezkatsayisi = Convert.ToInt32(SQL.SqlexecuteScalar("sp_reztipinegörefiyat", true, kmtprmtr));
 
        }
        





    }
}
