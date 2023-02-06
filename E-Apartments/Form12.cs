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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            DatabindtoGridView();
        }
        private void DatabindtoGridView()
        {
            string sql = "select a.leasingid, a.leasingstartdate, a.leasingenddate, a.createddate, b.id " +
                "from leaseagreement a INNER JOIN [dbo].[chief occupant] b " +
                "on b.id = a.id order by a.leasingid DESC";
            dataGridView1.DataSource = data.getdata(sql).Tables[0];
            //dataGridView1.Columns[0].HeaderText = "Parkinnd ID";
            //dataGridView1.Columns[1].HeaderText = "Parking Space Name";
            //dataGridView1.Columns[1].Width = 135;
            //dataGridView1.Columns[2].HeaderText = "Monthly Price";
            //dataGridView1.Columns[3].HeaderText = "Building ID";
            //dataGridView1.Columns[3].Width = 70;
            //dataGridView1.Columns[4].HeaderText = "Created Date";
            //dataGridView1.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd";
            //dataGridView1.Columns[4].Width = 130;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DataValid())
            {
                //data coversion for the insert query
                //MessageBox.Show("Insert Succesful");
                leasingareement csr = new leasingareement();
                csr.leasingid = Convert.ToInt32(txtLeasingID.Text);
                csr.leasingstartdate = LeasingStartDate.Value.ToString("yyyy-MM-dd");
                csr.leasingenddate = LeasingEndDate.Value.ToString("yyyy-MM-dd");
                csr.createddate = LeasingCreatedDate.Value.ToString("yyyy-MM-dd");
                csr.id = Convert.ToInt32(txtID.Text);
                csr.SaveCsr(csr);
                DatabindtoGridView();
                ClearFields();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private bool DataValid()
        {
            if (LeasingStartDate.Text == "")
            {
                MessageBox.Show("Enter Leasing Start date");
                return false;
            }
            if (LeasingEndDate.Text == "")
            {
                MessageBox.Show("Enter Leasing End Date");
                return false;
            }
            if (LeasingCreatedDate.Text == "")
            {
                MessageBox.Show("Enter Created Date");
                return false;
            }
            if (txtID.Text == "")
            {
                MessageBox.Show("Customer ID");
                return false;
            }
            return true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtLeasingID.Text = row.Cells["leasingid"].Value.ToString();
                LeasingStartDate.Text = row.Cells["leasingstartdate"].Value.ToString();
                LeasingEndDate.Text = row.Cells["leasingenddate"].Value.ToString();
                LeasingCreatedDate.Text = row.Cells["createddate"].Value.ToString();
                txtID.Text = row.Cells["id"].Value.ToString();

            }
        }
        private void ClearFields()
        {
            txtLeasingID.Text = "";
            LeasingStartDate.Text = "";
            LeasingEndDate.Text = "";
            LeasingCreatedDate.Text = "";
            txtID.Text = "";



        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            leasingareement csr = new leasingareement();
            csr.leasingid = Convert.ToInt32(txtLeasingID.Text);
            csr.leasingstartdate = LeasingStartDate.Value.ToString("yyyy-MM-dd");
            csr.leasingenddate = LeasingEndDate.Value.ToString("yyyy-MM-dd");
            csr.createddate = LeasingCreatedDate.Value.ToString("yyyy-MM-dd");
            csr.id = Convert.ToInt32(txtID.Text);
            csr.Updatecsr(csr);
            DatabindtoGridView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
              var confirmResult = MessageBox.Show("Are you sure to delete this record ??",
                                "Confirm Delete!!",
                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                leasingareement csr = new leasingareement();
                csr.leasingid = Convert.ToInt32(txtLeasingID.Text);
                csr.Deletecsr(csr);
                DatabindtoGridView();

            }
        }
    }
}
