using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiHotelDAL
{
    public class SQL
    {
        #region //SqlConnetion baglantisi
        public static SqlConnection getSqlConnection()
        {
            //baglantıdan nesne döndürecek.
            return new SqlConnection(baglanti.con);
        }
        #endregion
        #region //SqlCommand, nesnesi sp ile kullanilacak
        public static SqlCommand getSqlCommandsp(string sp, bool spdurum, SqlParameter[] kmtprmtr)
        {
            SqlCommand komut = new SqlCommand(sp, getSqlConnection());

            if (spdurum == true)
            {
                komut.CommandType = System.Data.CommandType.StoredProcedure;
            }


            if (kmtprmtr != null)
            {
                komut.Parameters.AddRange(kmtprmtr);
            }


            return komut;

        }
        #endregion
        //SqlCommand, nesnesi spsiz
        public static SqlCommand getSqlCommand(string sp, SqlParameter[] kmtprmtr)
        {
            SqlCommand komut = new SqlCommand(sp, getSqlConnection());



            if (kmtprmtr != null)
            {
                komut.Parameters.AddRange(kmtprmtr);
            }


            return komut;
        }
        // ExecuteScalar
        public static object SqlexecuteScalar(string sp, bool spdurum, SqlParameter[] kmtprmtr)
        {
            SqlCommand komut = getSqlCommandsp(sp, spdurum, kmtprmtr);
            komut.Connection.Open();
            object dönen = komut.ExecuteScalar();
            komut.Connection.Close();
            return dönen;
        }
        // ExecuteNonQuery
        public static int SqlexecuteNonQuerry(string sp, bool spdurum, SqlParameter[] kmtprmtr)
        {
            SqlCommand cmd = getSqlCommandsp(sp, spdurum, kmtprmtr);
            cmd.Connection.Open();
            int deger = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return deger;
        }
        //SqlDataReader , ExecuteReader

        public static SqlDataReader SqlexecuteReaderSp(string sp, bool spdurum, SqlParameter[] kmtprmtr)
        {
            SqlCommand komut = getSqlCommandsp(sp, spdurum, kmtprmtr);
            komut.Connection.Open();
            SqlDataReader red = komut.ExecuteReader();
            //komut.Connection.Close();
            return red;
        }
        public static SqlDataReader SqlexecuteReader(string sp, SqlParameter[] kmtprmtr)
        {
            SqlCommand komut = getSqlCommand(sp, kmtprmtr);
            komut.Connection.Open();
            SqlDataReader red1 = komut.ExecuteReader();
            return red1;
        }
    }
}
