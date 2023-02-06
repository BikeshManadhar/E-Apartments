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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            DatabindtoGridView();
            DatabindtoGridView1();
        }
        private void DatabindtoGridView()
        {
            string sql = "select a.leasingid, a.status, a.leasingstartdate, a.leasingenddate, a.createddate, b.id " +
                "from leaseagreement a INNER JOIN [dbo].[chief occupant] b " +
                "on b.id = a.id order by a.leasingid DESC";
            dataGridView1.DataSource = data.getdata(sql).Tables[0];
            

        }
        private void DatabindtoGridView1()
        {
            string sql = "select a.leasingrequestid, a.requestdate, b.leasingid, a.reqstatus " +
                            "from leasingrequest a INNER JOIN leaseagreement b " +
                            "on b.leasingid = a.leasingid order by a.leasingrequestid DESC";
            dataGridView2.DataSource = data.getdata(sql).Tables[0];


        }
    }
}
