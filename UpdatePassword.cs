using System;
using System.Windows.Forms;
using VeritabanıDestekliGörselProgramlama;

namespace VeritabanıGörsel
{
    public partial class UpdatePassword : Form
    {
        public static UpdatePassword updatepassword = new UpdatePassword();
        int result;
        static string UpdateUser = "update tbl_lgn set sifre=@password,KullanıcıAdı=@user where id=@id and checkAdmin=@admin";
        void userNameParametres()
        {
            textBox1_userName.Text = LoginScreen.userNamekey;
            textBox1_userName.Enabled = false;

        }
        public UpdatePassword()
        {


            InitializeComponent();
        }
        private void UpdatePassword_Load_1(object sender, EventArgs e)
        {
            userNameParametres();
            result = captcha();
        }

        private void buttonsClass1_Click(object sender, EventArgs e)
        {
            chancePassword();
        }
        int captcha()
        {
            int sayi1, sayi2;
            Random rnd = new Random();
            sayi1 = rnd.Next(0, 40);
            sayi2 = rnd.Next(0, 60);
            int result = sayi1 + sayi2;
            label_Captcha.Text = "Captcha: " + sayi1.ToString() + "+" + sayi2.ToString();
            return result;
        }
        void chancePassword()
        {
            var oldPasswordResult = database.BaglantiGirisi(LoginScreen.userNamekey, database.MD5(database.SHA256(textBox1_eskiSifre.Text)));
            if (result.ToString() == textBox1_result.Text.ToString())
            {
                if (textBox2_password.Text != textBox2_passwordTry.Text)
                {
                    MessageBox.Show("Şifreler uyuşmuyor!", "Hata");
                    result = captcha();
                }
                else if (oldPasswordResult != true)
                {
                    MessageBox.Show("Şifre Yanlış!", "Hata");
                    result = captcha();
                }
                else if (textBox2_password.Text == string.Empty && textBox2_passwordTry.Text == string.Empty)
                {
                    MessageBox.Show("Şifre boş olamaz!", "Hata");
                    result = captcha();
                }
                else
                {
                    database.userUpdate(textBox1_userName.Text, database.MD5(database.SHA256(textBox2_password.Text)), LoginScreen.adminCheck, Convert.ToInt32(LoginScreen.userId), UpdateUser);
                    MessageBox.Show("Şifre güncelleme tamamlandı!", "Mesaj");
                    clearComponent();
                    this.Hide();

                }
            }
            else
            {
                MessageBox.Show("Captcha Yanlış!", "Hata");
                result = captcha();
            }
        }
        void clearComponent()
        {
            textBox1_eskiSifre.Clear();
            textBox2_password.Clear();
            textBox2_passwordTry.Clear();
            textBox1_result.Clear();
        }
    }
}
