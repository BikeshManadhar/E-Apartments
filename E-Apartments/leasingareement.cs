using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments
{
    internal class leasingareement
    {
        public int leasingid { get; set; }
        public int status { get; set; }
        public string leasingstartdate { get; set; }
        public string leasingenddate { get; set; }
        public string createddate { get; set; }

        public int id { get; set; }


        public void SaveCsr(leasingareement csr)
        {
            try
            {
                string sql = "insert into leaseagreement ( status, leasingstartdate, leasingenddate, createddate, id) " +
                   " values('0','"+ csr.leasingstartdate +"','"+ csr.leasingenddate +"','"+ csr.createddate +"', '"+ csr.id +"');";


                data.ExecuteQuery(sql);

                MessageBox.Show("Insert Succesful");


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        public void Updatecsr(leasingareement csr)
        {
            try
            {

                string sql = "update leaseagreement set leasingstartdate='" + csr.leasingstartdate + "',leasingenddate='" + csr.leasingenddate +
                "',createddate='" + csr.createddate + "',id='" + csr.id + "' where leasingid='" + csr.leasingid + "'";

                data.ExecuteQuery(sql);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        public void Deletecsr(leasingareement csr)
        {
            try
            {
                string sql = "delete from leaseagreement where leasingid=" + csr.leasingid;
                data.ExecuteQuery(sql);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
    }
}
