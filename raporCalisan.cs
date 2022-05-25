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
using VeritabanıDestekliGörselProgramlama;

namespace VeritabanıGörsel
{
    public partial class raporCalisan : Form
    {

        static SqlConnection con;
        static SqlDataAdapter da;
        static DataSet ds;
        string sorgu = "Select tbl_islem.islemİd,tbl_islem.pName,islemUrunStok,tbl_islem.islemTutar,tbl_islem.userName from tbl_islem inner join product_tbl on tbl_islem.pName=product_tbl.pName";
        public static raporCalisan rapor = new raporCalisan();
        public static string kullaniciAdi;
        public raporCalisan()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                try
                {
                    sorgu = "Select tbl_islem.islemİd,tbl_islem.pName,islemUrunStok,tbl_islem.islemTutar,tbl_islem.userName from tbl_islem inner join product_tbl on tbl_islem.pName=product_tbl.pName where tbl_islem.userName = '" + textBox1.Text + "'";
                    GridveriDoldur(dataGridView1, sorgu);
                    
                }
                catch (Exception)
                {
                    sorgu = "Select tbl_islem.islemİd,tbl_islem.pName,islemUrunStok,tbl_islem.islemTutar,tbl_islem.userName from tbl_islem inner join product_tbl on tbl_islem.pName=product_tbl.pName";
                    GridveriDoldur(dataGridView1, sorgu);
                    throw;
                }
            }
            else
            {
                sorgu = "Select tbl_islem.islemİd,tbl_islem.pName,islemUrunStok,tbl_islem.islemTutar,tbl_islem.userName from tbl_islem inner join product_tbl on tbl_islem.pName=product_tbl.pName";
                GridveriDoldur(dataGridView1, sorgu);
            }
        }
        DataGridView GridveriDoldur(DataGridView gridim, String sorgu)
        {

            con = new SqlConnection(database.dataConnectString);
            da = new SqlDataAdapter(sorgu, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tbl_islem");
            gridim.DataSource = ds.Tables["tbl_islem"];
            con.Close();
            columsHeader();
            return gridim;
        }
        void columsHeader()
        {
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Ürün Adı";
            dataGridView1.Columns[2].HeaderText = "Adet";
            dataGridView1.Columns[3].HeaderText = "Tutar";
            dataGridView1.Columns[4].HeaderText = "Personel";
            
        }

        private void raporCalisan_Load(object sender, EventArgs e)
        {
            GridveriDoldur(dataGridView1, sorgu);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                calisanRaporDetay.calisanrapordetay.ShowDialog();
                kullaniciAdi = textBox1.Text;
                calisanRaporDetay.ds = ds;
                this.Show();
            }
            else
            {
                MessageBox.Show("Lütfen personel ismini giriniz!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
