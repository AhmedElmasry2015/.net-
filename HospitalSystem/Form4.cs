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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ACER\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;");
            SqlCommand sqlcommand = new SqlCommand();
            SqlCommand sqlcommand1 = new SqlCommand();
            SqlCommand sqlcommand2 = new SqlCommand();
            sqlcommand.Connection = con;
            sqlcommand1.Connection = con;
            sqlcommand2.Connection = con;
            con.Open();
            sqlcommand.CommandText = "update Nurse set Salary='" + textBox2.Text + "',Contact='" + textBox1.Text + "' where Nurseid='" + textBox4.Text + "'";
            sqlcommand.ExecuteNonQuery();
            sqlcommand1.CommandText = "update Department set Dname='" + textBox5.Text + "' where Departmentid='" + textBox3.Text + "'";
            sqlcommand1.ExecuteNonQuery();
            sqlcommand2.CommandText = "update Doctor set Salary='" + textBox6.Text + "' ,Contactno='" + textBox7.Text + "' where Doctorid='" + textBox8.Text + "'";
            sqlcommand2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Record Successs");
        }
    }
}
