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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ACER\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;");
            SqlCommand sqlcommand = new SqlCommand();
            SqlCommand sqlcommand1 = new SqlCommand();
            SqlCommand sqlcommand2 = new SqlCommand();
            SqlCommand sqlcommand3 = new SqlCommand();
            sqlcommand.Connection = con;
            sqlcommand1.Connection = con;
            sqlcommand2.Connection = con;
            sqlcommand3.Connection = con;
            con.Open();
            sqlcommand.CommandText = "INSERT INTO Room(Roomid) VALUES('" + textBox6.Text + "')";
            sqlcommand.ExecuteNonQuery();
            sqlcommand1.CommandText = "INSERT INTO Nurse(Nurseid,Roomid,Salary,Sex,Contact)values('" + textBox5.Text + "','" + textBox6.Text + "','" + textBox4.Text + "','" + textBox7.Text + "','" + textBox3.Text + "')";
            sqlcommand1.ExecuteNonQuery();
            sqlcommand2.CommandText = "INSERT INTO Department VALUES('" + textBox1.Text + "','" + textBox2.Text + "')";
            sqlcommand2.ExecuteNonQuery();
            sqlcommand3.CommandText = "INSERT INTO Doctor(Doctorid,Departmentid,Contactno,Salary,Sex,Eaddress) VALUES('" + textBox8.Text + "','" + textBox1.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "')";
            sqlcommand3.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Success");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
