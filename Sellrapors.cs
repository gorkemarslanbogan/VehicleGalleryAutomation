using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using VeritabanıDestekliGörselProgramlama;

namespace VeritabanıGörsel
{
    public partial class Satış_Raporlar : Form
    {
        public static Satış_Raporlar sellRapors = new Satış_Raporlar();
        static string sqlquery = "select *from tbl_islem";
        static SqlConnection con;
        static SqlDataAdapter da;
        static DataSet ds;
        public Satış_Raporlar()
        {
            InitializeComponent();
        }

        private void Satış_Raporlar_Load(object sender, EventArgs e)
        {
            fillReport(sqlquery);


        }
        void fillReport(String query)
        {
            con = new SqlConnection(database.dataConnectString);
            da = new SqlDataAdapter(query, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tbl_islem");
            sellReport1.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = sellReport1;
            con.Close();
        }


    }
}
