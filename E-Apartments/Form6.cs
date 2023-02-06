using E_Apartments.constant;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace E_Apartments
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            DataBindtoCombobox();
            DatabindtoGridView();
        }
        private void DataBindtoCombobox()
        {
            //cmbApartmentClass.DisplayMember = "apartmentclass";
            //cmbApartmentClass.ValueMember = "aptno";
            //string sql = "select * from apartment";
            //cmbApartmentClass.DataSource = data.getdata(sql).Tables[0];


        }
        private void DatabindtoGridView()
        {
             string sql = "select buildingid, buildingname, buildinglocation from building  order by buildingid";
            dataGridView1.DataSource = data.getdata(sql).Tables[0];
            dataGridView1.Columns[0].HeaderText = "Building ID";
            dataGridView1.Columns[1].HeaderText = "Building Name";
            dataGridView1.Columns[2].HeaderText = "Building Location";
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

                if (cmbApartmentClass.SelectedIndex == 0)
                {
                    txtApartmentDetails.Text = apartmentclasses.classOne;
                }
                else if (cmbApartmentClass.SelectedIndex == 1)
                {
                    txtApartmentDetails.Text = apartmentclasses.classTwo;
                }
                else if (cmbApartmentClass.SelectedIndex == 2)

                {
                    txtApartmentDetails.Text = apartmentclasses.classThree;
                }
                else if (cmbApartmentClass.SelectedIndex == 3)
                {
                    txtApartmentDetails.Text = apartmentclasses.suite;
                }

          





    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (DataValid())
            {
                //data coversion for the insert query
                //MessageBox.Show("Insert Succesful");
                Building csr = new Building();
                csr.buildingid = Convert.ToInt32(txtBuildingID.Text);
                csr.buildingname = txtBuildingName.Text;
                csr.buildinglocation = txtBuildingLocation.Text;
                csr.SaveCsr(csr);
                DatabindtoGridView();
                //ClearFields();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ClearFields();

        }
        private bool DataValid()
        {
            if (txtBuildingID.Text == "")
            {
                MessageBox.Show("Enter Building ID");
                return false;
            }
            if (txtBuildingName.Text == "")
            {
                MessageBox.Show("Enter Building Name");
                return false;
            }
            if (txtBuildingLocation.Text == "")
            {
                MessageBox.Show("Enter Building Location");
                return false;
            }

            return true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            Building csr = new Building();
            csr.buildingid = Convert.ToInt32(txtBuildingID.Text);
            csr.buildingname = txtBuildingName.Text;
            csr.buildinglocation = txtBuildingLocation.Text;
            csr.Updatecsr(csr);
            DatabindtoGridView();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this record ??",
                                 "Confirm Delete!!",
                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Building csr = new Building();
                csr.buildingid = Convert.ToInt32(txtBuildingID.Text);
                csr.Deletecsr(csr);
                DatabindtoGridView();

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtBuildingID.Text = row.Cells["buildingid"].Value.ToString();
                txtBuildingName.Text = row.Cells["buildingname"].Value.ToString();
                txtBuildingLocation.Text = row.Cells["buildinglocation"].Value.ToString();
                


            }
        }
        private void ClearFields()
        {
            txtBuildingID.Text = "";
            txtBuildingName.Text = "";
            txtBuildingLocation.Text = "";
           


        }
    }
}
