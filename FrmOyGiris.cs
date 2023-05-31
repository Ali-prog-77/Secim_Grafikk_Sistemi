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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DBSECIMPROJE;Integrated Security=True");

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnoygiris_Click(object sender, EventArgs e)
        {
            if (txta.Text == "" || txtb.Text == "" || txtc.Text == "" || txtilce.Text == "")
            {
                MessageBox.Show("Lütfen Boşlukları Doldurunuz.");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO dbo.Tblilce (ILCEID,APARTI,BPARTI,CPARTI) VALUES (@1,@2,@3,@4)", baglanti);
                komut.Parameters.AddWithValue("@1", txtilce.Text);
                komut.Parameters.AddWithValue("@2", txta.Text);
                komut.Parameters.AddWithValue("@3", txtb.Text);
                komut.Parameters.AddWithValue("@4", txtc.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Oy Girişi Gerçekleşti!");
            }
            

        }

        private void btngrafik_Click(object sender, EventArgs e)
        {
            FrmGrafik f = new FrmGrafik();
            
            f.Show();
           
            
        }
    }
}
