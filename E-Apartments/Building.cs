using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments
{
    internal class Building
    {
        public int buildingid { get; set; }
        public string buildingname { get; set; }
       
    public string buildinglocation { get; set; }


        public void SaveCsr(Building csr)
        {
            try
            {
                string sql = "insert into building (buildingid, buildingname, buildinglocation) " +
                    "values('" + csr.buildingid + "','" + csr.buildingname + "','" + csr.buildinglocation + "');";


                data.ExecuteQuery(sql);

                MessageBox.Show("Insert Succesful");


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        public void Updatecsr(Building csr)
        {
            string sql = "update building set buildingid='" + csr.buildingid + "',buildingname='" + csr.buildingname +
                "',buildinglocation='" + csr.buildinglocation + "' where buildingid='" + csr.buildingid + "'";

            data.ExecuteQuery(sql);

            MessageBox.Show("Successfully Updated");
        }
        public void Deletecsr(Building csr)
        {
            try
            {
                string sql = "delete from building where buildingid=" + csr.buildingid;
                data.ExecuteQuery(sql);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            MessageBox.Show("Successfully Deleted");

        }
    }
}
