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
namespace HospitalSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ACER\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;");
            SqlCommand sqlcommand = new SqlCommand();
            SqlCommand sqlcommand2 = new SqlCommand();
            SqlCommand sqlcommand3 = new SqlCommand();
            sqlcommand.Connection = con;
            sqlcommand2.Connection = con;
            sqlcommand3.Connection = con;
            con.Open();
            sqlcommand.CommandText = "DELETE FROM Nurse where Nurseid='"+textBox1.Text+"'";
            sqlcommand.ExecuteNonQuery();
            sqlcommand2.CommandText = "DELETE FROM Department where Departmentid='" + textBox2.Text + "'";
            sqlcommand2.ExecuteNonQuery();
            sqlcommand3.CommandText = "DELETE FROM Doctor where Doctorid='" + textBox3.Text + "'";
            sqlcommand3.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deletion Completed Successfully");
        }
    }
}
