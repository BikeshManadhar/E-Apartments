using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments
{
    internal class Parking
    {
        public int parkingid { get; set; }
        public string spacename { get; set; }
        public decimal monthlyprice { get; set; }
        public int Buildingid { get; set; }
        public string createddate { get; set; }
        

        public void SaveCsr(Parking csr)
        {
            try
            {
                string sql = "insert into parking (parkingid, spacename, monthlyprice,buildingid, createddate) " +
                    "values('" + csr.parkingid + "','" + csr.spacename + "','" + csr.monthlyprice + "','" + csr.Buildingid + "','" + csr.createddate +"');";


                data.ExecuteQuery(sql);

                MessageBox.Show("Insert Succesful");


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        public void Updatecsr(Parking csr)
        {
            try
            {

                string sql = "update parking set parkingid='" + csr.parkingid + "',spacename='" + csr.spacename +
                "',monthlyprice='" + csr.monthlyprice + "',buildingid='" + csr.Buildingid + "',createddate='" + csr.createddate + "' where parkingid='" + csr.parkingid + "'";

                data.ExecuteQuery(sql);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            
        }

        public void Deletecsr(Parking csr)
        {
            try
            {
                string sql = "delete from parking where parkingid=" + csr.parkingid;
                data.ExecuteQuery(sql);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
    }
}
