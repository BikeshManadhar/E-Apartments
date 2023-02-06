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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DatabindtoGridView()
        {
            string sql = "select a.aptno, a.aptname, b.buildingid, a.refundablefee, a.firstmonthfee, a.apartmentclass  from apartment a INNER JOIN building b " +
                "on b.buildingid = a.buildingid order by a.aptno DESC";
            dataGridView1.DataSource = data.getdata(sql).Tables[0];
            dataGridView1.Columns[0].HeaderText = "Building ID";
            dataGridView1.Columns[1].HeaderText = "Building Name";
            dataGridView1.Columns[2].HeaderText = "Building Location";

        }
    }
}
