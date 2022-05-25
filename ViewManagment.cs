using System;
using System.Windows.Forms;
using VeritabanıDestekliGörselProgramlama;

namespace VeritabanıGörsel
{
    public partial class ViewManagment : Form
    {
        public static ViewManagment viewManagment = new ViewManagment();
        static int isAdmin = 1;
        string addUser = "insert into tbl_lgn(KullanıcıAdı,sifre,tarih,checkAdmin) values (@user,@password,@time,@admin)";
        static string DeleteUser = "delete from tbl_lgn where KullanıcıAdı=@user and sifre=@password and id=@id";
        static string UpdateUser = "update tbl_lgn set sifre=@password,KullanıcıAdı=@user,checkAdmin=@admin where id=@id";
        public ViewManagment()
        {
            InitializeComponent();
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            database.GridveriDoldur(dataGridView1);
            enableComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2_username.Text == string.Empty || textBox3_password.Text == string.Empty)
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz!");
            }
            else
            {
                if (radioButton1_admin.Checked)
                {
                    isAdmin--;
                    addUsers();
                }
                else if (radioButton1_personel.Checked)
                {
                    addUsers();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            database.userProcess(textBox2_username.Text, textBox3_password.Text, Convert.ToInt32(textBox1_id.Text), DeleteUser);
            database.GridveriDoldur(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1_admin.Checked)
            {
                isAdmin--;
                database.userUpdate(textBox2_username.Text, database.MD5(database.SHA256(textBox3_password.Text)), isAdmin, int.Parse(textBox1_id.Text), UpdateUser);
                database.GridveriDoldur(dataGridView1);
            }
            else
            {
                database.userUpdate(textBox2_username.Text, database.MD5(database.SHA256(textBox3_password.Text)), isAdmin, int.Parse(textBox1_id.Text), UpdateUser);
                database.GridveriDoldur(dataGridView1);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sendDataComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2_username.Clear();
            textBox3_password.Clear();
            textBox1_id.Clear();
        }

        void updateUser()
        {
            if (radioButton1_admin.Checked)
            {
                isAdmin--;
                database.userUpdate(textBox2_username.Text, database.MD5(database.SHA256(textBox3_password.Text)), isAdmin, int.Parse(textBox1_id.Text), UpdateUser);
                database.GridveriDoldur(dataGridView1);
            }
            else
            {
                database.userUpdate(textBox2_username.Text, database.MD5(database.SHA256(textBox3_password.Text)), isAdmin, int.Parse(textBox1_id.Text), UpdateUser);
                database.GridveriDoldur(dataGridView1);
            }
        }
        void sendDataComponent()
        {
            textBox1_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2_username.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3_password.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "1")
            {
                radioButton1_personel.Checked = true;
            }
            else
            {
                radioButton1_admin.Checked = true;
            }
        }
        void enableComponent()
        {
            database.GridveriDoldur(dataGridView1);
            dataGridView1.Columns[0].HeaderCell.Value = "Kullanıcı ID";
            dataGridView1.Columns[1].HeaderCell.Value = "Kullanıcı Adı";
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderCell.Value = "Son oturum";
            dataGridView1.Columns[4].Visible = false;
            textBox1_id.Enabled = false;
            dateTimePicker1.Enabled = false;

        }
        void addUsers()
        {
            database.userProcess(textBox2_username.Text, database.MD5(database.SHA256(textBox3_password.Text)), isAdmin, addUser);
            database.GridveriDoldur(dataGridView1);
        }
    }

}
