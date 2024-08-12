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


namespace Quiet_Attic_Film__Production
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         SqlConnection conn =  new SqlConnection();
         conn.ConnectionString = "Data Source=DESKTOP-IHF5JOA\\SQLEXPRESS;Initial Catalog=QuietAtticFilms;Integrated Security=True";
         conn.Open();
         SqlCommand cmd = new SqlCommand(" insert into Client values(@Client_Id,@Name,@Contact_No)", conn);
         cmd.Connection = conn;
         cmd.Parameters.AddWithValue("@Client_Id", int.Parse(textBox1.Text));
         cmd.Parameters.AddWithValue("@Name", textBox2.Text);
         cmd.Parameters.AddWithValue("@Contact_No", int.Parse(textBox3.Text));
         cmd.ExecuteNonQuery();
         conn.Close();
         MessageBox.Show("Successfully");






        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-IHF5JOA\\SQLEXPRESS;Initial Catalog=QuietAtticFilms;Integrated Security=True";
            conn.Open();
            SqlCommand cmd = new SqlCommand(" Update Client set Client_Id=@Client_Id,Name=@Name,Contact_No=@Contact_No where Client_Id=@Client_Id", conn);
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@Client_Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Contact_No", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-IHF5JOA\\SQLEXPRESS;Initial Catalog=QuietAtticFilms;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Client where Client_Id='" + textBox1.Text + "'";
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Deleted");
        }
    }
}
