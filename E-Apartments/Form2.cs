using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments
{

    public partial class Form2 : Form
    {
        MyConnection db = new MyConnection();
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_Loginapartments", db.con);
                cmd.CommandType = CommandType.StoredProcedure;
                db.con.Open();
                cmd.Parameters.AddWithValue("@uname",txtUser_Name.Text);
                cmd.Parameters.AddWithValue("@upass", txtPassword.Text);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    if (rd[4].ToString() == "Admin")
                    {
                        MyConnection.type = "A";
                        Dashboard d = new Dashboard();
                        d.Show();
                        this.Hide();
                    }
                    else if (rd[4].ToString() == "User")
                    {
                        MyConnection.type = "U";
                        Form7 aja = new Form7(rd[5].ToString());
                        aja.Show();
                        this.Hide();

                    }
                    else if (rd[4].ToString() == "Manager")
                    {
                        MyConnection.type = "M";
                        Form8 aja = new Form8(rd[5].ToString());
                        aja.Show();
                        this.Hide();
                    }
                    else if (rd[4].ToString() == "Clerk") 
                    {
                        MyConnection.type = "C";
                        Form9 aja= new Form9(rd[5].ToString());
                        aja.Show();
                        this.Hide();
                    }
                   
                }
                else 
                {
                    MessageBox.Show("Error Login");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            db.con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
