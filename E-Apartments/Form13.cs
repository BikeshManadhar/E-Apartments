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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            DataBindtoCombobox();
            DatabindtoGridView();
        }
        private void DataBindtoCombobox()
        {
            cmbBuildingID.DisplayMember = "buildingid";
            cmbBuildingID.ValueMember = "buildingid";
            string sql = "select * from building";
            cmbBuildingID.DataSource = data.getdata(sql).Tables[0];
        }
        private void DatabindtoGridView()
        {
            string sql = "select a.parkingid, a.spacename, a.monthlyprice, b.buildingid, a.createddate " +
                "from parking a INNER JOIN building b " +
                "on b.buildingid = a.buildingid order by a.parkingid DESC";
            dataGridView1.DataSource = data.getdata(sql).Tables[0];
            dataGridView1.Columns[0].HeaderText = "Parkinnd ID";
            dataGridView1.Columns[1].HeaderText = "Parking Space Name";
            dataGridView1.Columns[1].Width = 135;
            dataGridView1.Columns[2].HeaderText = "Monthly Price";
            dataGridView1.Columns[3].HeaderText = "Building ID";
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].HeaderText = "Created Date";
            dataGridView1.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd";
            dataGridView1.Columns[4].Width = 130;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private bool DataValid()
        {
            if (txtParkingID.Text == "")
            {
                MessageBox.Show("Enter Parking ID");
                return false;
            }
            if (txtParkingSpaceName.Text == "")
            {
                MessageBox.Show("Enter Parking Sapce Name");
                return false;
            }
            if (txtMonthlyPrice.Text == "")
            {
                MessageBox.Show("Enter Monthly Price");
                return false;
            }
            if (cmbBuildingID.Text == "")
            {
                MessageBox.Show("choose the building ID");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DataValid())
            {
                //data coversion for the insert query
                //MessageBox.Show("Insert Succesful");
                Parking csr = new Parking();
                csr.parkingid = Convert.ToInt32(txtParkingID.Text);
                csr.spacename = txtParkingSpaceName.Text;
                csr.monthlyprice = Convert.ToDecimal(txtMonthlyPrice.Text);
                csr.Buildingid = Convert.ToInt32(cmbBuildingID.Text);
                csr.createddate = dateCreatedDate.Value.ToString("yyyy-MM-dd");
                csr.SaveCsr(csr);
                DatabindtoGridView();
                ClearFields();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            Parking csr = new Parking();
            csr.parkingid = Convert.ToInt32(txtParkingID.Text);
            csr.spacename = txtParkingSpaceName.Text;
            csr.monthlyprice = Convert.ToDecimal(txtMonthlyPrice.Text);
            csr.Buildingid = Convert.ToInt32(cmbBuildingID.Text);
            csr.createddate = dateCreatedDate.Value.ToString("yyyy-MM-dd");
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
                Parking csr = new Parking();
                csr.parkingid = Convert.ToInt32(txtParkingID.Text);
                csr.Deletecsr(csr);
                DatabindtoGridView();

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtParkingID.Text = row.Cells["parkingid"].Value.ToString();
                txtParkingSpaceName.Text = row.Cells["spacename"].Value.ToString();
                txtMonthlyPrice.Text = row.Cells["monthlyprice"].Value.ToString();
                cmbBuildingID.Text = row.Cells["buildingid"].Value.ToString();
                dateCreatedDate.Text = row.Cells["createddate"].Value.ToString();

            }
        }
        private void ClearFields()
        {
            txtParkingID.Text = "";
            txtParkingSpaceName.Text = "";
            txtMonthlyPrice.Text = "";
            cmbBuildingID.Text = "";
            dateCreatedDate.Text = "";



        }
    }
}
