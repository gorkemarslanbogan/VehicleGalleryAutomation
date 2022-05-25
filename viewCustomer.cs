using System;
using System.Windows.Forms;
using VeritabanıDestekliGörselProgramlama;

namespace VeritabanıGörsel
{
    public partial class viewCustomer : Form
    {
        static string sqlquery = "Select * from customer_tbl";
        public static viewCustomer viewcustomer = new viewCustomer();
        public viewCustomer()
        {
            InitializeComponent();
        }

        private void viewCustomer_Load(object sender, EventArgs e)
        {
            database.CustomerGridDataFill(dataGridView1, sqlquery);
            dataHeaderName();
        }
        void dataHeaderName()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Müşteri Adı";
            dataGridView1.Columns[2].HeaderText = "Müşteri Soyadı";
            dataGridView1.Columns[3].HeaderText = "Telefon Numarası";
            dataGridView1.Columns[4].Visible = false;
        }
    }
}
