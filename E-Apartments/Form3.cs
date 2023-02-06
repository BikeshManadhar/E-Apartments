using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments
{
    public partial class Dashboard : Form
    {
        //string userNic = "";
        public Dashboard()
        {
            InitializeComponent();
            //this.userNic = Id;
        }
        public void loadform(object Form) 
        {
            if (this.Mainpanel.Controls.Count > 0)
                this.Mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock= DockStyle.Fill;
            this.Mainpanel.Controls.Add(f);
            this.Mainpanel.Tag = f;
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 d = new Form2();
            d.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //if (MyConnection.type == "A") 
            //{
            //    //button1.Visible= true;
            //    //button2.Visible = true;
            //    //button3.Visible = true;
            //    //button4.Visible = true;
            //    //button5.Visible = true;
            //    //button6.Visible = true;
            //}
            //else if (MyConnection.type == "U") 
            //{
            //    //button1.Visible= true;
            //    //button2.Visible = true;
            //    //button3.Visible = false;
            //    //button4.Visible = false;      this one is for another program like if admin login to the system he will see all the button but if user will login the system he will only these buttun which has been true and false button are not visible to them
            //    //button5.Visible = true;
            //    //button6.Visible = true;
            //    Form7 aja = new Form7();
            //    aja.Show();
            //    this.Hide();

            //}
            //else if (MyConnection.type == "M")
            //{
            //    Form8 aja = new Form8();
            //    aja.Show();
            //    this.Hide();

            //}
            //else if (MyConnection.type == "U")
            //{
            //    Form9 aja = new Form9();
            //    aja.Show();
            //    this.Hide();

            //}
        }

        private void Mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Form4());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Form5());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new Form6());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new Form13());
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            loadform(new Form16());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loadform(new Form10());
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void Apartments_Click(object sender, EventArgs e)
        {
            loadform(new Form12());
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            loadform(new UserManagement());
        }

        private void panelside_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
