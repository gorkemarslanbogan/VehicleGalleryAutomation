using System;
using System.Windows.Forms;
using VeritabanıDestekliGörselProgramlama;

namespace VeritabanıGörsel
{
    public partial class viewProduct : Form
    {
        public static viewProduct viewproduct = new viewProduct();
        static string sqlquery = "Select * from product_tbl";
        public viewProduct()
        {
            InitializeComponent();
        }

        private void viewProduct_Load(object sender, EventArgs e)
        {
            database.GridveriİslemDoldur(dataGridView1, sqlquery);
            dataGridHeaderText();


        }

        void dataGridHeaderText()
        {
            dataGridView1.Columns[0].HeaderText = "Ürün Id";
            dataGridView1.Columns[1].HeaderText = "Araç Marka";
            dataGridView1.Columns[2].HeaderText = "Hasar Durumu";
            dataGridView1.Columns[3].HeaderText = "Araç Fiyatı";
            dataGridView1.Columns[4].HeaderText = "Kategori";
            dataGridView1.Columns[5].HeaderText = "Stok";
            dataGridView1.Columns[6].HeaderText = "Km";
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderText = "Vites Tipi";
            dataGridView1.Columns[9].HeaderText = "Renk";
            dataGridView1.Columns[10].HeaderText = "Yakıt";
            dataGridView1.Columns[11].HeaderText = "Eklenme Tarihi";
            dataGridView1.Columns[12].HeaderText = "Üretim Yılı";
            dataGridView1.Columns[12].DisplayIndex = 4;
        }

    }
}
