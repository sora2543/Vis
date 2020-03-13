using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Work4
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void Data_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = " SELECT * FROM data";
            sql = "INSERT INTO data (user,list,address,phone) VALUES('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            MySqlConnection con = new MySqlConnection("host=localhost;user=min;password=0854559377as;database=transportgoodies");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();           
                //MessageBox.Show("Login ได้แล้ว");
                this.Hide();
                Main f = new Main();
                f.Show();            

            /*MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                MessageBox.Show(reader.GetString("user") + " " + reader.GetString("list") +" "+ reader.GetString("address") + " " + reader.GetString("phone"));
            }*/

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f = new Main();
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
