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
    public partial class Form9 : Form
    {
        string userNic = "";
        public Form9(string Id)
        {
            InitializeComponent();
            this.userNic = Id;
        }
        public void loadform(object Form)
        {
            if (this.Mainpanel.Controls.Count > 0)
                this.Mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Mainpanel.Controls.Add(f);
            this.Mainpanel.Tag = f;
            f.Show();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new LeaseAgreement());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 d = new Form2();
            d.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadform(new Form14());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loadform(new Form17());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panelside_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
