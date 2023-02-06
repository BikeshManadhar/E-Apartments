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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            DatabindtoGridView();
            ClearFields();
        }

        private void ClearFields()
        {
            txtLeasingID.Text = "";
            
            txtStartDate.Text = "";
            txtEndDate.Text = "";
       


        }
        private void DatabindtoGridView()
        {
            string sql = "SELECT leaseagreement.leasingid, leaseagreement.leasingstartdate, " +
                "leaseagreement.leasingenddate " +
                "FROM leaseagreement WHERE leaseagreement.status = '0'";

            dataGridView1.DataSource = data.getdata(sql).Tables[0];
            dataGridView1.Columns[0].HeaderText = "Leasing ID";
            dataGridView1.Columns[1].HeaderText = "Leasing Start Date";
            dataGridView1.Columns[2].HeaderText = "Leasing End Date";

            //Assgining the name for header text name
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtLeasingID.Text = row.Cells["leasingid"].Value.ToString();
                txtStartDate.Text = row.Cells["leasingstartdate"].Value.ToString();
                txtEndDate.Text = row.Cells["leasingenddate"].Value.ToString();

            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE [leaseagreement] SET [status] = '1' " +
                "WHERE [leasingid] = '"+ txtLeasingID.Text + "';";

            data.ExecuteQuery(sql);

            MessageBox.Show("Accept Leasing Successful");
            DatabindtoGridView();
            ClearFields();
        }
    }
}
