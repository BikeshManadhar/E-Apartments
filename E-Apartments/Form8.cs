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
    public partial class Form8 : Form
    {
        string userNic = "";
        public Form8(string Id)
        {
            InitializeComponent();
            this.userNic = Id;
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 d = new Form2();
            d.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Form14());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void panelside_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
