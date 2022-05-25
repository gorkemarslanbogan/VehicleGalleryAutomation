using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using VeritabanıDestekliGörselProgramlama;

namespace VeritabanıGörsel
{
    public partial class managmentProduct : Form
    {
        public static managmentProduct managmentproduct = new managmentProduct();
        static SqlCommand cmd;
        static int productId;
        static int buttonClickCounter = 0;
        static string UpdateCars = "update product_tbl set pName=@productName,pDescription=@productDescription,pPrice=@productPrice,pCategory=@productCategory,pStock=@productStock,pKm=@producutKm,pUse=@productUse,pVites=@productVites,pColor=@productColor,pYakıt=@productYakıt,pYear=@year where pId=@productId";
        static string DeleteProductSqlCode = "delete from product_tbl where pId=@productId";
        static string sqlquery = "Select * from product_tbl";
        public managmentProduct()
        {
            InitializeComponent();
        }

        private void managmentProduct_Load(object sender, EventArgs e)
        {

            database.GridveriİslemDoldur(dataGridView1, sqlquery);
            dataGridHeaderText();
            componentEnablebControl();




        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            sendDataComponent();
            controlComboboxAndData();
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonsClass1_Click(object sender, EventArgs e)
        {

            DialogResult x = new DialogResult();
            x = MessageBox.Show("Bu Aracı Güncellemek İstediğinizden Eminmisiniz?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (x == DialogResult.Yes)
            {
                componentEnablebControl();
                buttonClickCounter++;

            }
            if (buttonClickCounter == 2)
            {
                bool result = database.sendCommand(UpdateCars, updateCarsİnformation());
                if (result)
                {
                    MessageBox.Show("Güncelleme Tamamlandı.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    database.GridveriİslemDoldur(dataGridView1, sqlquery);
                }
                else
                {
                    MessageBox.Show("İşlem tamamlanmadı!", "Hata");
                }
                buttonClickCounter = 0;

            }

        }

        private void buttonsClass2_Click(object sender, EventArgs e)
        {
            addProduct.addproduct.ShowDialog();
            this.Show();
            if (addProduct.result1)
            {
                database.GridveriİslemDoldur(dataGridView1, sqlquery);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }
        void searchDatainDataGrid()
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
        void controlComboboxAndData()
        {


            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "araba")
            {
                comboBox1_category.SelectedIndex = 1;
            }
            else { comboBox1_category.SelectedIndex = 1; }



            if (dataGridView1.CurrentRow.Cells[8].Value.ToString() == "Manuel")
            {
                comboBox2_vites.SelectedIndex = 1;
            }

            else if (dataGridView1.CurrentRow.Cells[8].Value.ToString() == "Tam otomatik")
            {
                comboBox2_vites.SelectedIndex = 2;
            }

            else
            {
                comboBox2_vites.SelectedIndex = 3;
            }


            if (dataGridView1.CurrentRow.Cells[10].Value.ToString() == "Dizel          ")
            {
                comboBox2_yakıt.SelectedIndex = 1;
            }
            else if (dataGridView1.CurrentRow.Cells[10].Value.ToString() == "Benzin         ")
            {
                comboBox2_yakıt.SelectedIndex = 2;
            }
            else
            {
                comboBox2_yakıt.SelectedIndex = 3;
            }

            if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "1")
            {
                comboBox1_use.SelectedIndex = 1;
            }
            else if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "2")
            {
                comboBox1_use.SelectedIndex = 2;
            }
        }
        void componentEnablebControl()
        {
            comboBox1_use.Enabled = !comboBox1_use.Enabled;
            textBox1_stock.Enabled = !textBox1_stock.Enabled;
            textBox1_productName.Enabled = !textBox1_productName.Enabled;
            textBox3_productPrice.Enabled = !textBox3_productPrice.Enabled;
            textBox4_Km.Enabled = !textBox4_Km.Enabled;
            comboBox1_category.Enabled = !comboBox1_category.Enabled;
            richTextBox1_hasar.Enabled = !richTextBox1_hasar.Enabled;
            comboBox2_vites.Enabled = !comboBox2_vites.Enabled;
            comboBox2_yakıt.Enabled = !comboBox2_yakıt.Enabled;
            textBox1_Color.Enabled = !textBox1_Color.Enabled;
            textBox1_carsYear.Enabled = !textBox1_carsYear.Enabled;
        }
        void sendDataComponent()
        {
            textBox1_stock.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox1_carsYear.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            textBox1_productName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3_productPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4_Km.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            richTextBox1_hasar.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox1_Color.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            productId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
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
        SqlCommand deleteProductToSql()
        {

            cmd = new SqlCommand();

            cmd.Parameters.AddWithValue("@productId", productId);
            return cmd;
        }

        private void buttonsClass3_Click(object sender, EventArgs e)
        {

            DialogResult x = new DialogResult();
            x = MessageBox.Show("Bu Aracı Silmek İstediğinizden Eminmisiniz?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (x == DialogResult.Yes)
            {
                bool result = database.sendCommand(DeleteProductSqlCode, deleteProductToSql());
                if (result)
                {
                    database.GridveriİslemDoldur(dataGridView1, sqlquery);
                }
                else
                {
                    MessageBox.Show("İşlem tamamlanmadı!", "Hata");
                }
            }


        }
        SqlCommand updateCarsİnformation()
        {
            // and pDescription=@productDescription and pPrice=@productPrice and pCategory=@productCategory and pStock=@productStock and pKm=@producutKm and pUse=@productUse and pVites=@productVites and pColor=@productColor and pYakıt=@productYakıt
            cmd = new SqlCommand();


            cmd.Parameters.AddWithValue("@productName", textBox1_productName.Text);
            cmd.Parameters.AddWithValue("@productId", productId);
            cmd.Parameters.AddWithValue("@year", Convert.ToInt32(textBox1_carsYear.Text));
            cmd.Parameters.AddWithValue("@productDescription", richTextBox1_hasar.Text);
            cmd.Parameters.AddWithValue("@productPrice", Convert.ToDouble(textBox3_productPrice.Text));
            cmd.Parameters.AddWithValue("@productCategory", comboBox1_category.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@productStock", Convert.ToInt32(textBox1_stock.Text));
            cmd.Parameters.AddWithValue("@producutKm", Convert.ToDouble(textBox4_Km.Text));
            cmd.Parameters.AddWithValue("@productUse", Convert.ToInt32(comboBox1_use.SelectedIndex));
            cmd.Parameters.AddWithValue("@productVites", comboBox2_vites.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@productColor", textBox1_Color.Text);
            cmd.Parameters.AddWithValue("@productYakıt", comboBox2_yakıt.SelectedItem.ToString());
            return cmd;
        }

        private void textBox1_stock_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_productPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void textBox4_Km_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void textBox1_carsYear_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_carsYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_searchProduct_TextChanged(object sender, EventArgs e)
        {
            searchDatainDataGrid();
        }

        private void radioButton3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void buttonsClass4_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton7.Checked)
                {
                    if (radioButton4.Checked == true)
                    {
                        sqlquery = "select *from product_tbl where pdate > '" + dateTimePicker1.Value.ToString() + "'AND pdate <'" + dateTimePicker2.Value.ToString() + "' order by pYear desc";
                        dataGridView1 = database.GridveriİslemDoldur(dataGridView1, sqlquery);
                    }
                    else if (radioButton5.Checked == true)
                    {

                        sqlquery = "select *from product_tbl where pdate >'" + dateTimePicker1.Value.ToString() + "'AND pdate<'" + dateTimePicker2.Value.ToString() + "' ORDER BY pYear DESC'";
                        dataGridView1 = database.GridveriİslemDoldur(dataGridView1, sqlquery);
                    }
                }
            }
            catch
            {

            }
        }
    }

}
