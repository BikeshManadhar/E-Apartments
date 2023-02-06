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
    public partial class customerleasingextend : Form
    {
        string userNic = "";
        public customerleasingextend(string Id)
        {
            InitializeComponent();
            this.userNic = Id;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void customerleasingextend_Load(object sender, EventArgs e)
        {
            DatabindtoGridView();
            ClearFields();
        }
        private void ClearFields()
        {
            txtLeasingID.Text = "";
            txtStartDate.Text = "";
            txtEndDate.Text = "";
            txtNIC.Text = "";


        }
        private void DatabindtoGridView()
        {
            string sql = "SELECT [leaseagreement].leasingid,[leaseagreement].leasingstartdate," +
                "[leaseagreement].leasingenddate,[LoginApartments].nic " +
                "FROM [leaseagreement]," +
                "[chief occupant],[LoginApartments] " +
                "WHERE [leaseagreement].id = [chief occupant].id " +
                "AND [chief occupant].nicpassport = [LoginApartments].nic " +
                "AND [LoginApartments].nic = '"+userNic+"' " +
                "ORDER BY [leaseagreement].leasingid ASC;";

            dataGridView1.DataSource = data.getdata(sql).Tables[0];
            dataGridView1.Columns[0].HeaderText = "Leasing ID";
            dataGridView1.Columns[1].HeaderText = "Leasing Start Date";
            dataGridView1.Columns[2].HeaderText = "Leasing End Date";
            dataGridView1.Columns[3].HeaderText = "NIC";
           

            //Assgining the name for header text name
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            
            string sql = "INSERT INTO [dbo].[leasingrequest] ([requestdate],[leasingid],[reqstatus]) " +
                "VALUES ('"+ DateTime.Now.ToString("yyyy-MM-dd") + "','"+txtLeasingID.Text +"','no');";

            data.ExecuteQuery(sql);

            MessageBox.Show("Request Successful");
            ClearFields();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtLeasingID.Text = row.Cells["leasingid"].Value.ToString();
                txtStartDate.Text = row.Cells["leasingstartdate"].Value.ToString();
                txtEndDate.Text = row.Cells["leasingenddate"].Value.ToString();
                txtNIC.Text = row.Cells["nic"].Value.ToString();
                //  dateCreatedDate.Text = row.Cells["createddate"].Value.ToString();
               // MessageBox.Show("Request Send Successful");
               // DatabindtoGridView();
                //ClearFields();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
