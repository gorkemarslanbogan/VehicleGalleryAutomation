using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using VeritabanıDestekliGörselProgramlama;

namespace VeritabanıGörsel
{
    public partial class sellProduct : Form
    {
        public static sellProduct sellproduct = new sellProduct();
        static SqlCommand cmd, cmd1;
        static SqlConnection con = new SqlConnection(database.dataConnectString);
        static string sqlquery = "Select * from product_tbl";
        static string sqlCustomerquery = "Select * from customer_tbl";
        static int stock = 0;
        double productPrice;


        public sellProduct()
        {
            InitializeComponent();

        }
        public int productId;
        private void sellProduct_Load(object sender, EventArgs e)
        {
            addCustomerCombox();
            database.GridveriİslemDoldur(dataGridView1, sqlquery);
            dataGridHeaderText();
            comboBox1.SelectedIndex = 0;



        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            productId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBox1_productName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3_productPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            stock = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
            comboBox1.SelectedIndex = 0;
            comboStockData();


        }

        private void buttonsClass1_Click(object sender, EventArgs e)
        {


            string sql = "insert into tbl_islem(pName,islemUrunStok,islemTutar,islemTarih,islemAciklama,userName,pID,customerName) values (@productname,@islemUrunStok,@islemtutar, @tarih, @aciklama, @username, @urunId,@customername)";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@islemUrunStok", Convert.ToInt32(comboBox2_stock.SelectedItem));
            cmd.Parameters.AddWithValue("@islemtutar", Convert.ToDouble(textBox1_totalPrice.Text));
            cmd.Parameters.AddWithValue("@aciklama", richTextBox1_aciklama.Text);
            cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
            cmd.Parameters.AddWithValue("@productname", textBox1_productName.Text);
            if (comboBox1.SelectedIndex != 0 || comboBox1.SelectedIndex != 1)
            {
                cmd.Parameters.AddWithValue("@customername", comboBox1.SelectedItem.ToString());
            }
            cmd.Parameters.AddWithValue("@username", LoginScreen.userNamekey);
            cmd.Parameters.AddWithValue("@urunId", productId);
            bool result = database.sendCommand(sql, cmd);

            sql = "UPDATE product_tbl set pStock=pStock-@stok where pId=@urunId";
            cmd1 = new SqlCommand();
            cmd1.Parameters.AddWithValue("@urunId", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            cmd1.Parameters.AddWithValue("@stok", Convert.ToInt32(comboBox2_stock.SelectedItem));

            bool stockUpdate = database.sendCommand(sql, cmd1);

            if (result == true || stockUpdate == true)
            {
                MessageBox.Show("İşlem başarıyla tamamlandı.", "Mesaj");
                clearComponent();


            }
            else
            {
                MessageBox.Show("İşlem tamamlanamadı lütfen tekrar deneyin!", "Hata");

            }

        }
        void clearComponent()
        {
            richTextBox1_aciklama.Clear();
            comboBox1.SelectedIndex = 0;
            comboBox2_stock.SelectedIndex = 0;
            textBox1_productName.Clear();
            textBox3_productPrice.Clear();
            textBox1_totalPrice.Clear();

        }
  
        void searchData()
        {
            if (textBox1_searchProduct.Text != string.Empty)
            {
                try
                {
                    if (radioButton1.Checked)
                    {
                        //Search car Name
                        if (radioButton4.Checked)
                        {
                            sqlquery = "select *from product_tbl where pName like '%" + textBox1_searchProduct.Text + "%' order by pName ASC";
                            dataGridView1 = database.GridveriİslemDoldur(dataGridView1, sqlquery);
                        }
                        else if (radioButton5.Checked)
                        {
                            sqlquery = "select *from product_tbl where pName like '%" + textBox1_searchProduct.Text + "%' order by pName DESC";
                            dataGridView1 = database.GridveriİslemDoldur(dataGridView1, sqlquery);
                        }

                    }
                    else if (radioButton2.Checked)
                    {
                        if (radioButton4.Checked == true)
                        {
                            sqlquery = "select *from product_tbl where pPrice >=" + textBox1_searchProduct.Text;
                            dataGridView1 = database.GridveriİslemDoldur(dataGridView1, sqlquery);
                        }
                        else if (radioButton5.Checked == true)
                        {

                            sqlquery = "select *from product_tbl where pPrice <=" + textBox1_searchProduct.Text;
                            dataGridView1 = database.GridveriİslemDoldur(dataGridView1, sqlquery);
                        }
                    }
                    else if (radioButton3.Checked)
                    {
                        if (radioButton4.Checked == true)
                        {
                            sqlquery = "select *from product_tbl where pStock >=" + textBox1_searchProduct.Text;
                            dataGridView1 = database.GridveriİslemDoldur(dataGridView1, sqlquery);
                        }
                        else if (radioButton5.Checked == true)
                        {

                            sqlquery = "select *from product_tbl where pStock <=" + textBox1_searchProduct.Text;
                            dataGridView1 = database.GridveriİslemDoldur(dataGridView1, sqlquery);
                        }
                    }

                }
                catch
                {
                    textBox1_searchProduct.Clear();

                }

            }
            else
            {
                sqlquery = "Select * from product_tbl";
                database.GridveriİslemDoldur(dataGridView1, sqlquery);
            }
        }
        void addCustomerCombox()
        {
            cmd = new SqlCommand(sqlCustomerquery, con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                comboBox1.Items.Add(dr["CustomerName".TrimEnd()] + " " + dr["CustomerSurName".TrimEnd()]);

            }
            con.Close();
            comboBox1.SelectedIndex = 0;

        }
        void dataGridHeaderText()
        {
            dataGridView1.Columns[0].Visible = false;
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
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].HeaderText = "Üretim Yılı";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            sendDataComponent();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sendDataComponent();


        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                addCustomer.adduser.ShowDialog();
                this.Show();
                if (addCustomer.result)
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("Seçiniz..");
                    comboBox1.Items.Add("Yeni Müşteri");
                    addCustomerCombox();

                }
            }
        }

        void sendDataComponent()
        {
            productId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBox1_productName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3_productPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            stock = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
            comboStockData();
            comboBox1.SelectedIndex = 0;


        }

        private void comboBox2_stock_SelectedValueChanged(object sender, EventArgs e)
        {

            if (comboBox2_stock.SelectedIndex != 0)
            {
                productPrice = Convert.ToDouble(dataGridView1.CurrentRow.Cells[3].Value) * Convert.ToDouble(comboBox2_stock.SelectedIndex.ToString());
                textBox1_totalPrice.Text = productPrice.ToString();
            }
            else
            {
                textBox1_totalPrice.Text = textBox3_productPrice.Text;
            }

        }

        private void textBox1_searchProduct_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }

        private void ürünleriYönetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            managmentProduct.managmentproduct.ShowDialog();
            this.Show();
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addProduct.addproduct.ShowDialog();
            this.Show();
        }

        private void uygulamayıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void comboStockData()
        {
            comboBox2_stock.Items.Clear();
            comboBox2_stock.Items.Add("Seçiniz..");
            for (int i = 1; i <= stock; i++)
            {
                comboBox2_stock.Items.Add(i);
            }
            comboBox2_stock.SelectedIndex = 0;
        }

    }
}
