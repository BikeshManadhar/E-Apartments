using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments
{
    internal class Apartment
    {
        public int aptno { get; set; }
        public string aptname { get; set; }
        public int buildingid { get; set; }
        public decimal refundablefee { get; set; }
        public string firstmonthfee { get; set; }
        public string buildingname { get; set; }
        public int id { get; set; }
        public string apartmentclass { get; set; }

        public void serchch(Apartment csr)
        {



        }

        public void SaveCsr(Apartment csr)
        {
            try
            {
                string sql = "insert into apartment (aptno, aptname, refundablefee, firstmonthfee, " +
                    "apartmentclass,buildingid) " +
                    "values('" + csr.aptno + "','" + csr.aptname + "','" + csr.refundablefee + "','" + csr.firstmonthfee + "','" + csr.apartmentclass + "','" + csr.buildingid + "');";


                data.ExecuteQuery(sql);

                MessageBox.Show("Insert Succesful");


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        public void Updatecsr(Apartment csr)
        {
            string sql = "update apartment set aptno='" + csr.aptno + "',aptname='" + csr.aptname +
                "',refundablefee='" + csr.refundablefee + "',firstmonthfee='" + csr.firstmonthfee + "',apartmentclass='" + csr.apartmentclass + "' where aptno='" + csr.aptno + "'";

            data.ExecuteQuery(sql);
        }
        public void Deletecsr(Apartment csr)
        {
            try
            {
                string sql = "delete from apartment where aptno=" + csr.aptno;
                data.ExecuteQuery(sql);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
    }
}
