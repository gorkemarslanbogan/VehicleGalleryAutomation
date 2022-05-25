using System;
using System.Windows.Forms;

namespace VeritabanıGörsel
{
    public partial class HomeScreen : Form
    {
        public static HomeScreen homescreen = new HomeScreen();
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void uygulamayıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddUsers.addusers.ShowDialog();

        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UpdatePassword.updatepassword.ShowDialog();
            this.Show();
        }

        private void kullanıcıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ViewManagment.viewManagment.ShowDialog();
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ürünSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sellProduct.sellproduct.ShowDialog();
            this.Show();
        }

        private void ürünleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewProduct.viewproduct.ShowDialog();
            this.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sellProduct.sellproduct.ShowDialog();
            this.Show();
        }

        private void ürünEkleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            managmentProduct.managmentproduct.ShowDialog();
            this.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            addProduct.addproduct.ShowDialog();
            this.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            sellProduct.sellproduct.ShowDialog();
            this.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Satış_Raporlar.sellRapors.ShowDialog();
            this.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            addCustomer.adduser.ShowDialog();
            this.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            viewCustomer.viewcustomer.ShowDialog();
            this.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            managmentCustomer.managmentcustomer.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            addProduct.addproduct.ShowDialog();
            this.Show();
        }

        private void buttonsClass2_addProduct_Click(object sender, EventArgs e)
        {
            addProduct.addproduct.ShowDialog();
            this.Show();
        }

        private void buttonsClass3_Click(object sender, EventArgs e)
        {
            ViewManagment.viewManagment.ShowDialog();
            this.Show();
        }

        private void buttonsClass5_Click(object sender, EventArgs e)
        {
            managmentCustomer.managmentcustomer.ShowDialog();
            this.Show();
        }

        private void buttonsClass4_Click(object sender, EventArgs e)
        {
            sellProduct.sellproduct.ShowDialog();
            this.Show();
        }

        private void buttonsClass6_Click(object sender, EventArgs e)
        {
            UpdatePassword.updatepassword.ShowDialog();
            this.Show();
        }

        private void buttonsClass7_Click(object sender, EventArgs e)
        {
            addCustomer.adduser.ShowDialog();
            this.Show();
        }

        private void buttonsClass2_Click(object sender, EventArgs e)
        {
            Satış_Raporlar.sellRapors.ShowDialog();
            this.Show();
        }

        private void buttonsClass1_Click(object sender, EventArgs e)
        {
            managmentProduct.managmentproduct.ShowDialog();
            this.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            raporCalisan.rapor.ShowDialog();
            this.Show();
        }

        private void HomeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
