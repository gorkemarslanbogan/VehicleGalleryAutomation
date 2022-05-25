using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace VeritabanıDestekliGörselProgramlama
{
    internal class database
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static DataSet ds;
        static SqlCommand cmd;
        static SqlDataReader dr;
        public static string dataConnectString = "Data Source=DESKTOP-JTEMF7K\\SQLEXPRESS;Initial Catalog=machine;Integrated Security=True";

        //checkConnection
        public static bool BaglantiDurumu()
        {
            using (con = new SqlConnection(dataConnectString))
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }

        }
        //

        //dataProcess
        public static DataGridView GridveriDoldur(DataGridView gridim)
        {
            string sorgu = "Select *from tbl_lgn";
            con = new SqlConnection(dataConnectString);
            da = new SqlDataAdapter(sorgu, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tbl_lgn");
            gridim.DataSource = ds.Tables["tbl_lgn"];
            con.Close();
            return gridim;
        }
        public static DataGridView GridveriİslemDoldur(DataGridView gridim, string sql)
        {
            con = new SqlConnection(dataConnectString);
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "product_tbl");
            gridim.DataSource = ds.Tables["product_tbl"];
            con.Close();
            return gridim;
        }
        public static DataGridView CustomerGridDataFill(DataGridView gridim, string sql)
        {
            con = new SqlConnection(dataConnectString);
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "customer_tbl");
            gridim.DataSource = ds.Tables["customer_tbl"];
            con.Close();
            return gridim;
        }
        public static DataGridView sellRapors(DataGridView gridim, string sql)
        {

            con = new SqlConnection(dataConnectString);
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tbl_islem");
            gridim.DataSource = ds.Tables["tbl_islem"];
            con.Close();
            return gridim;
        }
        //

        //userProcess
        public static bool BaglantiGirisi(string kullaniciAdi, string sifre)
        {
            string sorgu = ("select *from tbl_lgn where KullanıcıAdı =@user and sifre =@password ");
            con = new SqlConnection(dataConnectString);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", kullaniciAdi);
            cmd.Parameters.AddWithValue("@password", sifre);
            con.Open();
            dr = cmd.ExecuteReader();
            // veri geldiyse 
            if (dr.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool userProcess(string kullaniciAdi, string sifre, int checkAdmin, string sql)
        {

            con = new SqlConnection(dataConnectString);
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@user", kullaniciAdi);
            cmd.Parameters.AddWithValue("@password", sifre);
            cmd.Parameters.AddWithValue("@id", checkAdmin);
            cmd.Parameters.AddWithValue("@admin", checkAdmin);
            cmd.Parameters.AddWithValue("@time", DateTime.Now);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public static bool userUpdate(string kullaniciAdi, string sifre, int checkAdmin, int id, string sql)
        {

            con = new SqlConnection(dataConnectString);
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@user", kullaniciAdi);
            cmd.Parameters.AddWithValue("@password", sifre);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@admin", checkAdmin);
            cmd.Parameters.AddWithValue("@time", DateTime.Now);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static string bringUserData(string username, string password)
        {
            string query = "select id FROM tbl_lgn where KullanıcıAdı=@user and sifre=@password";
            con = new SqlConnection(dataConnectString);
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@password", password);
            con.Open();
            dr = cmd.ExecuteReader();
            string data = "";
            if (dr.Read())
            {
                data = dr["id"].ToString();
                con.Close();

            }
            return data;

        }
        public static string bringisAdminData(string username, string password)
        {
            string query = "select checkAdmin FROM tbl_lgn where KullanıcıAdı=@user and sifre=@password";
            con = new SqlConnection(dataConnectString);
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@password", password);
            con.Open();
            dr = cmd.ExecuteReader();
            string data = "";
            if (dr.Read())
            {
                data = dr["checkAdmin"].ToString();
                con.Close();

            }
            return data;

        }
        public static bool sendCommand(string sql, SqlCommand cmd)
        {
            con = new SqlConnection(dataConnectString);
            cmd.CommandText = sql;
            cmd.Connection = con;
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }
        //

        //password 
        public static string MD5(string MD5Input)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] array = Encoding.UTF8.GetBytes(MD5Input);
            array = md5.ComputeHash(array);
            StringBuilder sb = new StringBuilder();
            foreach (var item in array)
            {
                sb.Append(item.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
        public static string SHA256(string MD5Input)
        {
            SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();
            byte[] array = Encoding.UTF8.GetBytes(MD5Input);
            array = sha256.ComputeHash(array);
            StringBuilder sb = new StringBuilder();
            foreach (var item in array)
            {
                sb.Append(item.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
        //
    }

}
