using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using VeritabanıDestekliGörselProgramlama;

namespace VeritabanıGörsel
{
    public partial class addCustomer : Form
    {
        public static addCustomer adduser = new addCustomer();
        static SqlCommand cmd;
        public static bool result;
        static string addCustomerSql = "insert into customer_tbl(customerName,customerSurName,phone,date) values (@name,@surname,@phone,@date)";
        public addCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1_userName.Text != string.Empty && textBox2_surName.Text != string.Empty && maskedTextBox1_telephone.Text != string.Empty)
            {
                result = database.sendCommand(addCustomerSql, AddCustomers());
                if (result)
                {
                    MessageBox.Show("Kayıt gerçekleşti..", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kayıt gerçekleşmedi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        SqlCommand AddCustomers()
        {
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@name", textBox1_userName.Text);
            cmd.Parameters.AddWithValue("@surname", textBox2_surName.Text);
            cmd.Parameters.AddWithValue("@phone", maskedTextBox1_telephone.Text.ToString());
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString());
            return cmd;
        }

        
    }

}
