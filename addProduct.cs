using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using VeritabanıDestekliGörselProgramlama;

namespace VeritabanıGörsel
{
    public partial class addProduct : Form
    {
        public static addProduct addproduct = new addProduct();
        public static string addProductSqlCode = "INSERT INTO product_tbl(pName,pDescription,pPrice,pCategory,pStock,pKm,pUse,pVites,pColor,pYakıt,pdate,pYear) values (@productName,@productDescription,@productPrice,@productCategory,@productStock,@producutKm,@productUse,@productVites,@productColor,@productYakıt,@date,@year)";
        static SqlCommand cmd;
        public static bool result1;
        public addProduct()
        {
            InitializeComponent();
        }

        private void addProduct_Load(object sender, EventArgs e)
        {
            comboBox1_category.SelectedIndex = 0;
            comboBox2_kullanımDurumu.SelectedIndex = 0;
            comboBox2_Vites.SelectedIndex = 0;
            comboBox2_yakıt.SelectedIndex = 0;
        }


        private void buttonsClass2_Click(object sender, EventArgs e)
        {
            if (textBox1_productName.Text == string.Empty || textBox3_productPrice.Text == string.Empty || textBox1_Color.Text == string.Empty ||
                 textBox4_Km.Text == string.Empty || richTextBox1.Text == string.Empty)
            {
                textBox1_productName.BackColor = Color.Red;
                textBox1_Color.BackColor = Color.Red;
                textBox1_stock.BackColor = Color.Red;
                textBox3_productPrice.BackColor = Color.Red;
                textBox4_Km.BackColor = Color.Red;
                richTextBox1.BackColor = Color.Red;
                MessageBox.Show("Kırmızı alanlar boş olamaz!", "Uyarı");
            }
            else
            {
                if (comboBox2_kullanımDurumu.SelectedIndex == 0 || comboBox1_category.SelectedIndex == 0 || comboBox2_Vites.SelectedIndex == 0 || comboBox2_yakıt.SelectedIndex == 0)
                {
                    comboBox1_category.BackColor = Color.Red;
                    comboBox2_kullanımDurumu.BackColor = Color.Red;
                    comboBox2_Vites.BackColor = Color.Red;
                    comboBox2_yakıt.BackColor = Color.Red;
                    MessageBox.Show("Kırmızı alanlar boş olamaz!", "Uyarı");
                }
                else
                {
                    bool result = database.sendCommand(addProductSqlCode, addProductToSql());
                    if (result)
                    {
                        MessageBox.Show("Ürün Ekleme İşlemi Başarıyla Tamamlandı.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        afterButtonClick();
                        result1 = result;
                    }
                    else
                    {
                        MessageBox.Show("Hata lütfen tekrar deneyin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }

        private void textBox4_Km_TextChanged(object sender, EventArgs e)
        {
            if (textBox4_Km.Text == "0")
            {
                comboBox2_kullanımDurumu.SelectedIndex = 1;
                richTextBox1.Text = "Sıfır model araç hatası bulunmamaktadır.";
            }
        }

        SqlCommand addProductToSql()
        {
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@productName", textBox1_productName.Text);
            cmd.Parameters.AddWithValue("@productDescription", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@productPrice", Convert.ToDouble(textBox3_productPrice.Text));
            cmd.Parameters.AddWithValue("@productCategory", comboBox1_category.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@productStock", Convert.ToInt32(textBox1_stock.Text));
            cmd.Parameters.AddWithValue("@producutKm", Convert.ToDouble(textBox4_Km.Text));
            cmd.Parameters.AddWithValue("@productUse", Convert.ToInt32(comboBox2_kullanımDurumu.SelectedIndex));
            cmd.Parameters.AddWithValue("@productVites", comboBox2_Vites.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@productColor", textBox1_Color.Text);
            cmd.Parameters.AddWithValue("@year", Convert.ToInt32(textBox1_carsYear.Text));
            cmd.Parameters.AddWithValue("@productYakıt", comboBox2_yakıt.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            return cmd;
        }
        void afterButtonClick()
        {
            textBox1_Color.Clear();
            textBox1_productName.Clear();
            textBox1_stock.Clear();
            textBox3_productPrice.Clear();
            textBox4_Km.Clear();
            comboBox1_category.SelectedIndex = 0;
            comboBox2_kullanımDurumu.SelectedIndex = 0;
            comboBox2_Vites.SelectedIndex = 0;
            comboBox2_yakıt.SelectedIndex = 0;
            textBox1_productName.BackColor = Color.White;
            textBox1_Color.BackColor = Color.White;
            textBox1_stock.BackColor = Color.White;
            textBox3_productPrice.BackColor = Color.White;
            textBox4_Km.BackColor = Color.White;
            richTextBox1.BackColor = Color.White;
            comboBox1_category.BackColor = Color.White;
            comboBox2_kullanımDurumu.BackColor = Color.White;
            comboBox2_Vites.BackColor = Color.White;
            comboBox2_yakıt.BackColor = Color.White;

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

        private void textBox1_carsYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
