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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            DatabindtoGridView();
        }
        private void DatabindtoGridView()
        {
            string sql = "select a.id, a.name, a.address, a.email, a.contactno, a.nicpassport, b.leasingstartdate, b.leasingenddate," +
                " a.dependentdetails, a.emergencycontact from [dbo].[chief occupant] a INNER JOIN leaseagreement b on b.id = a.id order by a.id DESC"; dataGridView1.DataSource = data.getdata(sql).Tables[0];
            dataGridView1.DataSource = data.getdata(sql).Tables[0];
            dataGridView1.Columns[0].HeaderText = "Customer ID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Address";
            dataGridView1.Columns[3].HeaderText = "Email";
            dataGridView1.Columns[4].HeaderText = "Contact No";
            dataGridView1.Columns[5].HeaderText = "NIC/Passport";
            dataGridView1.Columns[6].HeaderText = "Lease start date";
            dataGridView1.Columns[7].HeaderText = "Lease End date";
            dataGridView1.Columns[8].HeaderText = "Dependent Details";
            dataGridView1.Columns[9].HeaderText = "Emergency contact";

        }
    }
}
