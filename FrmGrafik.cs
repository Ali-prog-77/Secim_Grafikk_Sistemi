using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Secim_Grafikk_Sistemi
{
    public partial class FrmGrafik : Form
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DBSECIMPROJE;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmGrafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select ILCEID from dbo.Tblilce",baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                cmbbxilce.Items.Add(reader[0]);    
            }
            baglanti.Close();
        }
    }
}
