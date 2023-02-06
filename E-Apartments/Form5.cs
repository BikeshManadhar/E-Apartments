using E_Apartments.constant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace E_Apartments
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
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

            cmbBuildingName.DisplayMember = "buildingname";
            cmbBuildingName.ValueMember = "buildingid";
            string sqll = "select * from building";
            cmbBuildingName.DataSource = data.getdata(sqll).Tables[0];

            //cmbID.DisplayMember = "id";
            //cmbID.ValueMember = "id";
            //string sqlll = "select * from [dbo].[chief occupant]";
            //cmbID.DataSource = data.getdata(sqlll).Tables[0];

            //cmbApartmentClass.DisplayMember = "apartmentclass";
            //cmbApartmentClass.ValueMember = "aptno";
            //string sqllll = "select apartmentclass,min(aptno) from apartment group by apartmentclass";
            //cmbApartmentClass.DataSource = data.getdata(sqllll).Tables[0];
        }

        //csr.aptno = Convert.ToInt32(txtApartmentNo.Text);
        //    csr.aptname = txtApartmentName.Text;
        //    csr.buildingid = Convert.ToInt32(cmbBuildingID.Text);
        //    csr.refundablefee = Convert.ToDecimal(txtRefundableFee.Text);
        //    csr.firstmonthfee = txtFirstMonthFee.Text;
        //    csr.buildingname = cmbBuildingName.Text;
        //    csr.apartmentclass = cmbApartmentClass.Text;
        //    csr.SaveCsr(csr)
        //txtApartmentNo

        private void DatabindtoGridView()
        {
            try
            {


                string apartmentFlag = txtApartmentNo.Text.ToString() == "" ? "0" : txtApartmentNo.Text.ToString();
                string buildingIdFlag = cmbBuildingID.Text.ToString() == "" ? "0" : cmbBuildingID.Text.ToString();
                string ApartmentNamFlag = txtApartmentName.Text.ToString() == "" ? "0" : txtApartmentName.Text.ToString();
                string BuildingNameFlag = cmbBuildingName.SelectedValue.ToString() == "" ? "0" : cmbBuildingName.SelectedValue.ToString();


                string sql = "" +
                    " declare @apartmentFlag  int = " + apartmentFlag + "; " +
                    " declare @buildingIdFlag  int = " + buildingIdFlag + "; " +
                    " declare @BuildingNameFlag  int = " + BuildingNameFlag + ";" +
                    " select a.aptno, a.aptname, b.buildingid, " +
                    " a.refundablefee, a.firstmonthfee, b.buildingname, a.apartmentclass " +
                    " from apartment a INNER JOIN building b  " +
                    " on b.buildingid = a.buildingid  " +
                    " where " +
                    "(" +
                      "(@apartmentFlag = 0 AND a.aptno > 0) OR " +
                      "(@apartmentFlag <> 0  AND a.aptno = @apartmentFlag )" +
                     ") " +
                     "and" +
                     "(" +
                        "(@buildingIdFlag = 0 AND b.buildingid > 0) OR " +
                        "(@buildingIdFlag <> 0  AND b.buildingid = @buildingIdFlag )" +
                     ") " +
                     " and " +
                     " (" +
                        "('" + ApartmentNamFlag + "' = '0' AND LEN(A.aptname) > 0) OR " +
                        "('" + ApartmentNamFlag + "' <> '0'  AND A.aptname = '" + ApartmentNamFlag + "' )" +
                     " )  " +
                     "and" +
                     "(" +
                        "(@BuildingNameFlag  =  0  AND LEN(b.buildingid) > 0) OR " +
                        "(@BuildingNameFlag  <> 0  AND b.buildingid = @BuildingNameFlag )" +
                     ") " +

                    "order by a.aptno DESC";

                dataGridView1.DataSource = data.getdata(sql).Tables[0];
                dataGridView1.Columns[0].HeaderText = "Apartment No";
                dataGridView1.Columns[1].HeaderText = "Apartment Name";
                dataGridView1.Columns[2].HeaderText = "Bulding ID";
                dataGridView1.Columns[3].HeaderText = "Refundable Fee";
                dataGridView1.Columns[4].HeaderText = "First Month Fee";
                dataGridView1.Columns[5].HeaderText = "Building Name";
                dataGridView1.Columns[6].HeaderText = "Apartment Class";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (DataValid())
            {


                Apartment csr = new Apartment();
                csr.aptno = Convert.ToInt32(txtApartmentNo.Text);
                csr.aptname = txtApartmentName.Text;
                csr.buildingid = Convert.ToInt32(cmbBuildingID.Text);
                csr.refundablefee = Convert.ToDecimal(txtRefundableFee.Text);
                csr.firstmonthfee = txtFirstMonthFee.Text;
                csr.buildingname = cmbBuildingName.Text;
                csr.apartmentclass = cmbApartmentClass.Text;
                csr.SaveCsr(csr);
                DatabindtoGridView();
                ClearFields();

                //csr.name = txtName.Text;
                //csr.address = txtAddress.Text;
                //csr.email = txtEmail.Text;
                //csr.contactno = txtContactNo.Text;
                //csr.nicpassport = txtNICPassport.Text;
                ////csr.refundablefee = Convert.ToDecimal(txtRefundablefee.Text);
                ////csr.firstmonthfee = Convert.ToDecimal(txtFirstMonthfee.Text);
                //csr.dependentdetails = txtDependentDetails.Text;
                //csr.leaseenddate = dateLeaseEndDate.Value.ToString("yyyy-MM-dd");
                //csr.leasestartdate = dateLeaseEndDate.Value.ToString("yyyy-MM-dd"); //get start date to heere 
                //csr.emergencycontact = txtEmergencyContactNo.Text;
                //// csr.apartmentclass = cmbApartmentClass.SelectedValue.ToString();
                //csr.aptno = cmbApartmentNo.SelectedIndex;
                //csr.SaveCsr(csr);
                //DatabindtoGridView();
                //ClearFields();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();

        }
        private bool DataValid()
        {
            if (txtApartmentNo.Text == "")
            {
                MessageBox.Show("Enter the Apartnment No");
                return false;
            }
            if (txtApartmentName.Text == "")
            {
                MessageBox.Show("Enter your Apartment Name");
                return false;
            }
            if (txtRefundableFee.Text == "")
            {
                MessageBox.Show("Enter your Refunadalble deposite");
                return false;
            }
            if (!Information.IsNumeric(txtRefundableFee.Text))
            {
                MessageBox.Show("please enter a numeric Vlao");
                return false;
            }
            if (lblFirstMonthFee.Text == "")
            {
                MessageBox.Show("Enter your First Month Fee");
                return false;
            }
            //if (!Information.IsNumeric(txtFirstMonthFee.Text))
            //{
            //    MessageBox.Show("please enter a numeric ghnta");
            //    return false;
            //}
            //if (txtAparm.Text == "")
            //{
            //    MessageBox.Show("Enter your Email");
            //    return false;
            //}
            //if (txtContactNo.Text == "")
            //{
            //    MessageBox.Show("Enter your Contact Number");
            //    return false;
            //}
            //if (!Information.IsNumeric(txtContactNo.Text))
            //{
            //    MessageBox.Show("please enter a numeric Value");
            //    return false;
            //}
            //if (txtNICPassport.Text == "")
            //{
            //    MessageBox.Show("Enter your NIC or Passport No");
            //    return false;
            //}
            //if (!Information.IsNumeric(txtNICPassport.Text))
            //{
            //    MessageBox.Show("please enter a numeric Value");
            //    return false;
            //}
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
            //if (txtFirstMonthfee.Text == "")
            //{
            //    MessageBox.Show("Enter your First Month Fee");
            //    return false;
            //}
            //if (!Information.IsNumeric(txtFirstMonthfee.Text))
            //{
            //    MessageBox.Show("please enter a numeric Value");
            //    return false;
            //}
            //if (txtDependentDetails.Text == "")
            //{
            //    MessageBox.Show("Enter your Dependent details");
            //    return false;
            //}
            //if (txtEmergencyContactNo.Text == "")
            //{
            //    MessageBox.Show("Enter your Emergency Contact Number");
            //    return false;
            //}
            //if (!Information.IsNumeric(txtEmergencyContactNo.Text))
            //{
            //    MessageBox.Show("please enter a numeric Value");
            //    return false;
            //}
            return true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.SelectedRows[0].Index;
                Apartment csr = new Apartment();
                csr.aptno = Convert.ToInt32(txtApartmentNo.Text);
                csr.aptname = txtApartmentName.Text;
                csr.buildingid = Convert.ToInt32(cmbBuildingID.Text);
                csr.refundablefee = Convert.ToDecimal(txtRefundableFee.Text);
                csr.firstmonthfee = txtFirstMonthFee.Text;
                csr.buildingname = cmbBuildingName.Text;
                csr.apartmentclass = cmbApartmentClass.Text;
                csr.Updatecsr(csr);

                ClearFields();
                DatabindtoGridView();

            }
            catch
            {
                MessageBox.Show("Please Select a row");
            }

            ////MessageBox.Show(index.ToString());

            //Employee emp = new Employee();
            //emp.EmpNo = Convert.ToInt32(txt1.Text);
            //emp.Name = txt2.Text.ToString();
            //emp.Salary = Convert.ToDecimal(txt3.Text);
            //emp.DeptCode = cmb.SelectedValue.ToString();
            //emp.Dob = dateofbirth.Value.ToString("yyyy-MM-dd");
            //emp.UpdateEmp(emp);//Save employee record
            //DatabindtoGridView();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            /*
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtApartmentNo.Text = row.Cells["aptno"].Value.ToString();
                txtApartmentName.Text = row.Cells["aptname"].Value.ToString();
                cmbBuildingID.Text = row.Cells["buildingid"].Value.ToString();
                txtRefundableFee.Text = row.Cells["refundablefee"].Value.ToString();
                txtFirstMonthFee.Text = row.Cells["firstmonthfee"].Value.ToString();
                cmbBuildingName.Text = row.Cells["buildingname"].Value.ToString();
                cmbApartmentClass.Text = row.Cells["apartmentclass"].Value.ToString(); 
            }*/
        }

        private void ClearFields()
        {
            txtApartmentNo.Text = "";
            txtApartmentName.Text = "";
            txtRefundableFee.Text = "";
            txtFirstMonthFee.Text = "";

            DatabindtoGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtApartmentNo.Text = row.Cells["aptno"].Value.ToString();
                txtApartmentName.Text = row.Cells["aptname"].Value.ToString();
                cmbBuildingID.Text = row.Cells["buildingid"].Value.ToString();
                txtRefundableFee.Text = row.Cells["refundablefee"].Value.ToString();
                txtFirstMonthFee.Text = row.Cells["firstmonthfee"].Value.ToString();
                cmbBuildingName.Text = row.Cells["buildingname"].Value.ToString();
                cmbApartmentClass.Text = row.Cells["apartmentclass"].Value.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this record ??",
                                 "Confirm Delete!!",
                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Apartment csr = new Apartment();
                csr.aptno = Convert.ToInt32(txtApartmentNo.Text);
                csr.Deletecsr(csr);

                ClearFields();
                DatabindtoGridView();

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DatabindtoGridView();
        }

        private void txtApartmentNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApartmentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbApartmentClass_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
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
            catch { }

        }

        private void cmbApartmentClass_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
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
            catch { }
        }
    }
}
