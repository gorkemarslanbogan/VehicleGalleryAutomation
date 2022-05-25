using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using VeritabanıDestekliGörselProgramlama;

namespace VeritabanıGörsel
{
    public partial class managmentCustomer : Form
    {
        static string sqlquery = "Select * from customer_tbl";
        static SqlCommand cmd;
        public static managmentCustomer managmentcustomer = new managmentCustomer();
        int customerId;
        static string UpdateCustomerSql = "update customer_tbl set customerName=@name,customerSurName=@surname,phone=@phone,date=@date where customerId=@id";
        static string addCustomerSql = "insert into customer_tbl(customerName,customerSurName,phone,date) values (@name,@surname,@phone,@date)";
        static string DeleteCustomerSql = "delete from customer_tbl where customerId=@id";
        public managmentCustomer()
        {
            InitializeComponent();
        }

        private void managmentCustomer_Load(object sender, EventArgs e)
        {
            database.CustomerGridDataFill(dataGridView1, sqlquery);
            dataHeaderName();
        }
        void dataSendComponent()
        {
            
            textBox1_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2_surName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        void dataHeaderName()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Müşteri Adı";
            dataGridView1.Columns[2].HeaderText = "Müşteri Soyadı";
            dataGridView1.Columns[3].HeaderText = "Telefon Numarası";
            dataGridView1.Columns[4].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1_name.Text != string.Empty && textBox2_surName.Text != string.Empty && maskedTextBox1.Text != string.Empty)
            {
                bool result = database.sendCommand(addCustomerSql, AddCustomers());
                if (result)
                {
                    MessageBox.Show("Kayıt gerçekleşti..", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearComponent();
                    database.CustomerGridDataFill(dataGridView1, sqlquery);
                }
                else
                {
                    MessageBox.Show("Kayıt gerçekleşmedi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void dataTransferComponent()
        {
            try
            {

                customerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                textBox1_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2_surName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }
        SqlCommand AddCustomers()
        {
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@name", textBox1_name.Text);
            cmd.Parameters.AddWithValue("@surname", textBox2_surName.Text);
            cmd.Parameters.AddWithValue("@phone", maskedTextBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString());
            return cmd;
        }
        SqlCommand UpdateCustomers()
        {
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@id", customerId);
            cmd.Parameters.AddWithValue("@name", textBox1_name.Text);
            cmd.Parameters.AddWithValue("@surname", textBox2_surName.Text);
            cmd.Parameters.AddWithValue("@phone", maskedTextBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString());
            return cmd;
        }
        SqlCommand DeleteCustomers()
        {
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@id", customerId);
            return cmd;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1_name.Text != string.Empty && textBox2_surName.Text != string.Empty && maskedTextBox1.Text != string.Empty)
            {
                bool result = database.sendCommand(UpdateCustomerSql, UpdateCustomers());
                if (result)
                {
                    MessageBox.Show("Güncelleme Tamamlandı..", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearComponent();
                    database.CustomerGridDataFill(dataGridView1, sqlquery);
                }
                else
                {
                    MessageBox.Show("Güncelleme Tamamlanmadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool result = database.sendCommand(DeleteCustomerSql, DeleteCustomers());
            if (result)
            {

                MessageBox.Show("Silme İşlem Tamamlandı..", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                database.CustomerGridDataFill(dataGridView1, sqlquery);
                clearComponent();
            }
            else
            {
                MessageBox.Show("Silme İşlemi Tamamlanmadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataTransferComponent();
        }
        void clearComponent()
        {
            textBox1_name.Clear();
            textBox2_surName.Clear();
            maskedTextBox1.Clear();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataTransferComponent();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            dataSendComponent();
        }
    }
}
