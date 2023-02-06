using E_Apartments.constant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.ConstrainedExecution;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace E_Apartments
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DataBindtoCombobox();
            DatabindtoGridView();
        }
        private void DataBindtoCombobox()
        {
            cmbApartmentNo.DisplayMember = "aptno";
            cmbApartmentNo.ValueMember = "aptno";
            string sqllll = "select * from apartment";
            cmbApartmentNo.DataSource = data.getdata(sqllll).Tables[0];

            cmbApartmentClass.DisplayMember = "apartmentclass";
            cmbApartmentClass.ValueMember = "aptno";
            string sqll = "select * from apartment";
            cmbApartmentClass.DataSource = data.getdata(sqll).Tables[0];

           

         
        }
        private void DatabindtoGridView()
        {
            string sql = "select a.id, a.name, a.address, a.email, a.contactno, " +
                "a.nicpassport, a.dependentdetails, a.emergencycontact,b.aptno " +
                "from[dbo].[chief occupant] a " +
                "INNER JOIN apartment b on b.aptno = a.aptno order by a.id DESC";
            
            dataGridView1.DataSource = data.getdata(sql).Tables[0];
            dataGridView1.Columns[0].HeaderText = "Customer ID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Address";
            dataGridView1.Columns[3].HeaderText = "Email";
            dataGridView1.Columns[4].HeaderText = "Contact No";
            dataGridView1.Columns[5].HeaderText = "NIC/Passport";
            dataGridView1.Columns[6].HeaderText = "Dependent details";
            dataGridView1.Columns[7].HeaderText = "Emergency contact";
            dataGridView1.Columns[8].HeaderText = "Apartment No";
            //dataGridView1.Columns[9].HeaderText = "Emergency contact";

            //Assgining the name for header text name
            
        }

        private void cmbApartmentClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbApartmentClass.SelectedIndex == 0)
            {
                txtApartmentDetails.Text = apartmentclasses.classOne;
            } else if (cmbApartmentClass.SelectedIndex == 1) {
                txtApartmentDetails.Text = apartmentclasses.classTwo;
            } else if (cmbApartmentClass.SelectedIndex == 2)

            {
                txtApartmentDetails.Text = apartmentclasses.classThree;
            } else if (cmbApartmentClass.SelectedIndex == 3) 
            {
                txtApartmentDetails.Text = apartmentclasses.suite;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtID.Text = row.Cells["id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtContactNo.Text = row.Cells["contactno"].Value.ToString();
                txtNICPassport.Text = row.Cells["nicpassport"].Value.ToString();
                //txtRefundablefee.Text = row.Cells["refundablefee"].Value.ToString();
               // txtFirstMonthfee.Text = row.Cells["firstmonthfee"].Value.ToString();
                txtDependentDetails.Text = row.Cells["dependentdetails"].Value.ToString();
               //dateLeaseEndDate.Text = row.Cells["leaseenddate"].Value.ToString();
                txtEmergencyContactNo.Text = row.Cells["emergencycontact"].Value.ToString();
                cmbApartmentNo.Text = row.Cells["aptno"].Value.ToString();
                //cmbApartmentNo.Text = row.Cells["aptno"].Value.ToString();
                              
            }
        }
        

        private void ClearFields() 
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtContactNo.Text = "";
            txtNICPassport.Text = "";
           // txtRefundablefee.Text = "";
            txtDependentDetails.Text = "";
            txtEmergencyContactNo.Text = "";
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private bool DataValid()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter Your Name");
                return false;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Enter your address");
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Enter your Email");
                return false;
            }
            if (txtContactNo.Text == "")
            {
                MessageBox.Show("Enter your Contact Number");
                return false;
            }
            if (!Information.IsNumeric(txtContactNo.Text))
            {
                MessageBox.Show("please enter a numeric Value");
                return false;
            }
                if (txtNICPassport.Text == "")
            {
                MessageBox.Show("Enter your NIC or Passport No");
                return false;
            }
            if (!Information.IsNumeric(txtNICPassport.Text))
            {
                MessageBox.Show("please enter a numeric Value");
                return false;
            }
            if (txtDependentDetails.Text == "")
            {
                MessageBox.Show("Enter your Dependent details");
                return false;
            }
            if (txtEmergencyContactNo.Text == "")
            {
                MessageBox.Show("Enter your Emergency Contact No");
                return false;
            }

            if (!Information.IsNumeric(txtEmergencyContactNo.Text))
            {
                MessageBox.Show("please enter a numeric Value");
                return false;
            }
            //if (txtRefundablefee.Text == "")
            //{
            //    MessageBox.Show("Enter your Refunadalble deposite");
            //    return false;
            //}
            //if (!Information.IsNumeric(txtRefundablefee.Text))
            //{
            //    MessageBox.Show("please enter a numeric Value");
            //    return false;
            //}


            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (DataValid())
            {
                //data coversion for the insert query
                
                Customer csr = new Customer();
                //csr.id = Convert.ToInt32(txtID.Text);
                csr.name = txtName.Text;
                csr.address = txtAddress.Text;
                csr.email = txtEmail.Text;
                csr.contactno = txtContactNo.Text;
                csr.nicpassport = txtNICPassport.Text;
                csr.dependentdetails = txtDependentDetails.Text;
                // csr.leaseenddate  = dateLeaseEndDate.Value.ToString("yyyy-MM-dd");
                //csr.leasestartdate = dateLeaseEndDate.Value.ToString("yyyy-MM-dd"); 
                csr.emergencycontact = txtEmergencyContactNo.Text;
                csr.aptno = Convert.ToInt32(cmbApartmentNo.Text);
                csr.SaveCsr(csr);
                MessageBox.Show("Insert Succesful");
                DatabindtoGridView();
                ClearFields();

            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            Customer csr = new Customer();
            csr.id = Convert.ToInt32(txtID.Text);
            csr.name = txtName.Text;
            csr.address = txtAddress.Text;
            csr.email = txtEmail.Text;
            csr.contactno = txtContactNo.Text;
            csr.nicpassport = txtNICPassport.Text;
            csr.dependentdetails = txtDependentDetails.Text;
            // csr.leaseenddate  = dateLeaseEndDate.Value.ToString("yyyy-MM-dd");
            //csr.leasestartdate = dateLeaseEndDate.Value.ToString("yyyy-MM-dd"); 
            csr.emergencycontact = txtEmergencyContactNo.Text;
            csr.aptno = Convert.ToInt32(cmbApartmentNo.Text);
            csr.Updatecsr(csr);
            DatabindtoGridView();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this record ??",
                               "Confirm Delete!!",
                               MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Customer csr = new Customer();
                csr.id = Convert.ToInt32(txtID.Text);
                csr.Deletecsr(csr);
                DatabindtoGridView();

            }
        }
    }
    
}
