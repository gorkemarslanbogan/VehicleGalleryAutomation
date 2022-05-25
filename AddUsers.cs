using System;
using System.Windows.Forms;
using VeritabanıDestekliGörselProgramlama;

namespace VeritabanıGörsel
{
    public partial class AddUsers : Form
    {
        public static AddUsers addusers = new AddUsers();
        static int controlUser = 1;
        string addsqlUsers = "insert into tbl_lgn(KullanıcıAdı,sifre,tarih,checkAdmin) values (@user,@password,@time,@admin)";
        public AddUsers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlComponent();
        }
        void controlComponent()
        {
            if (textBox2_password.Text != textBox2_passwordTry.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor!", "Hata");
            }
            else if (textBox1_userName.Text == string.Empty)
            {
                MessageBox.Show("Kullanıcı adı boş olamaz!", "Hata");
            }
            else if (textBox2_password.Text == string.Empty && textBox2_passwordTry.Text == string.Empty)
            {
                MessageBox.Show("Şifre boş olamaz!", "Hata");
            }
            else
            {
                if (radioButton1_admin.Checked)
                {
                    controlUser--;
                    addUser();
                }
                else
                {
                    addUser();
                }
            }
        }
        void addUser()
        {
            bool resultAddUsers = database.userProcess(textBox1_userName.Text, database.MD5(database.SHA256(textBox2_password.Text)), controlUser, addsqlUsers);
            if (resultAddUsers)
            {
                MessageBox.Show("Kayıt Tamamlandı!", "Mesaj");
                this.Hide();
                HomeScreen.homescreen.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hata kayıt tamamlanamadı!", "Hata");

            }
        }

      
    }

}
