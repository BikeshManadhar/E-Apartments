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
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            DatabindtoGridView();
        }
        private void DatabindtoGridView()
        {
            string sql = "select id, nic,name,username, password, type from LoginApartments order by id";
            dataGridView1.DataSource = data.getdata(sql).Tables[0];
            dataGridView1.Columns[0].HeaderText = " ID";
            dataGridView1.Columns[1].HeaderText = " NIC/Passport";
            dataGridView1.Columns[2].HeaderText = "Name";
            //dataGridView1.Columns[1].Width = 135;
            dataGridView1.Columns[3].HeaderText = "User Name";
            dataGridView1.Columns[4].HeaderText = "Password";
            //dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[5].HeaderText = "Type";
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private bool DataValid()
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Enter NIC passport");
                return false;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter Name");
                return false;
            }
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Enter User Name");
                return false;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter Password");
                return false;
            }
            if (txtType.Text == "")
            {
                MessageBox.Show("choose Type");
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
                UserManangement csr = new UserManangement();
                //csr.nic = Convert.ToInt32(txtNICPassport.Text);
                csr.nic = txtID.Text;
                csr.name = txtName.Text;
                csr.username = txtUserName.Text;
                csr.password = txtPassword.Text;
                csr.type = txtType.Text;
                csr.SaveCsr(csr);
                DatabindtoGridView();
                ClearFields();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                int index = dataGridView1.SelectedRows[0].Index;
                UserManangement csr = new UserManangement();
                //csr.id = Convert.ToInt32(txtID.Text);
                csr.nic = txtID.Text;
                csr.name = txtName.Text;
                csr.username = txtUserName.Text;
                csr.password = txtPassword.Text;
                csr.type = txtType.Text;
                csr.Updatecsr(csr);
                DatabindtoGridView();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this record ??",
                                "Confirm Delete!!",
                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                UserManangement csr = new UserManangement();
                csr.nic = txtID.Text;
                csr.Deletecsr(csr);
                DatabindtoGridView();

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
               txtID.Text = row.Cells["id"].Value.ToString();
                txtID.Text = row.Cells["nic"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtUserName.Text = row.Cells["username"].Value.ToString();
                txtPassword.Text = row.Cells["password"].Value.ToString();
                txtType.Text = row.Cells["type"].Value.ToString();

            }
        }
        private void ClearFields()
        {
            //txtID.Text = "";
            txtID.Text = "";
            txtName.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtType.Text = "";



        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
