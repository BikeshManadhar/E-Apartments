using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace E_Apartments
{
    public partial class Form14 : Form
    {
        //string userNic = "";
        public static string cs = ConfigurationManager.ConnectionStrings["dbcon"].ToString();
        public Form14()
        {
            InitializeComponent();
            //this.userNic = Id;
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            DatabindtoGridView();
            ClearFields();
        }
        private void ClearFields()
        {
            txtLeasingID.Text = "";
            txtLeasingRequestID.Text = "";
            txtStartDate.Text = "";
            txtEndDate.Text = "";
            txtNIC.Text = "";
           

        }
        private void DatabindtoGridView()
        {
            string sql = "SELECT [leaseagreement].leasingid,[leaseagreement].leasingstartdate," +
                "[leaseagreement].leasingenddate,[LoginApartments].nic,[leasingrequest].leasingrequestid " +
                "FROM [leaseagreement],[chief occupant],[LoginApartments],[leasingrequest] " +
                "WHERE [leaseagreement].id = [chief occupant].id " +
                "AND [chief occupant].nicpassport = [LoginApartments].nic " +
                "AND [leasingrequest].reqstatus = 'no' " +
                "ORDER BY [leasingrequest].leasingid DESC;";

            dataGridView1.DataSource = data.getdata(sql).Tables[0];
            dataGridView1.Columns[0].HeaderText = "Leasing ID";
            dataGridView1.Columns[1].HeaderText = "Leasing Start Date";
            dataGridView1.Columns[2].HeaderText = "Leasing End Date";
            dataGridView1.Columns[3].HeaderText = "NIC";
            dataGridView1.Columns[4].HeaderText = "Leasing Request ID";


            //Assgining the name for header text name
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtLeasingID.Text = row.Cells["leasingid"].Value.ToString();
                txtStartDate.Text = row.Cells["leasingstartdate"].Value.ToString();
                txtEndDate.Text = row.Cells["leasingenddate"].Value.ToString();
                txtNIC.Text = row.Cells["nic"].Value.ToString();
                txtLeasingRequestID.Text = row.Cells["leasingrequestid"].Value.ToString();
                //  dateCreatedDate.Text = row.Cells["createddate"].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql = "UPDATE [leasingrequest] SET [reqstatus] = 'yes' " +
                "WHERE [leasingrequestid] = '"+txtLeasingRequestID.Text+"';";

            DateTime StartDate = Convert.ToDateTime(txtStartDate.Text);
            DateTime EndDate = Convert.ToDateTime(txtEndDate.Text);
            int years = EndDate.Year - StartDate.Year;
            DateTime newDate = EndDate.AddYears(years);
            string newDateString = newDate.ToString("yyyy-MM-dd");

            string Id = GetUserId(txtNIC.Text);

            string sql2 = "INSERT INTO [leaseagreement]([status], [leasingstartdate], " +
                "[leasingenddate], [createddate], [id], [comment]) " +
                "VALUES ('0','"+ txtEndDate.Text + "', '"+newDateString+"', '"
                + DateTime.Now.ToString("yyyy-MM-dd") + "', '"+Id+"', '');";

            data.ExecuteQuery(sql);
            data.ExecuteQuery(sql2);

            MessageBox.Show("Request Send Successful");
            DatabindtoGridView();
            ClearFields();
        }

        string GetUserId (string nic)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string sql = "SELECT [chief occupant].id FROM leaseagreement, " +
                    "[chief occupant] WHERE leaseagreement.id = [chief occupant].id " +
                    "AND [chief occupant].nicpassport = '"+nic+"';";
                SqlCommand sqlCommand = new SqlCommand(sql, con);
                string userId = "";
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    userId = reader.GetInt32(0).ToString();
                }

                return userId;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void DatabindtoGridView()
        //{
        //    string sql = "select a.aptno, a.aptname, b.buildingid, a.refundablefee, " +
        //        "a.firstmonthfee, b.buildingname, a.apartmentclass " +
        //        "from apartment a INNER JOIN building b " +
        //        "on b.buildingid = a.buildingid order by a.aptno DESC";
        //    dataGridView1.DataSource = data.getdata(sql).Tables[0];
        //    dataGridView1.DataSource = data.getdata(sql).Tables[0];
        //    dataGridView1.Columns[0].HeaderText = "Apartment No";
        //    dataGridView1.Columns[1].HeaderText = "Apartment Name";
        //    dataGridView1.Columns[2].HeaderText = "Bulding ID";
        //    dataGridView1.Columns[3].HeaderText = "Refundable Fee";
        //    dataGridView1.Columns[4].HeaderText = "First Month Fee";
        //    dataGridView1.Columns[5].HeaderText = "Building Name";
        //    dataGridView1.Columns[6].HeaderText = "Apartment Class";


        //}
    }
}
