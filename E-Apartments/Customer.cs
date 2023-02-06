using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments
{
    internal class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string contactno { get; set; }
        public string nicpassport { get; set; }
       // public string leasestartdate { get; set; }
       // public string leaseenddate { get; set; }
        public string dependentdetails { get; set; }
        public string emergencycontact { get; set; }
        public int aptno { get; set; }
       // public int apartmentclass { get; set; }



        public void SaveCsr(Customer csr)
        {
            //Exception handling to store the data
            try
            {
                string sql = "insert into [dbo].[chief occupant] (name, address, email, contactno, " +
                    "nicpassport,dependentdetails, emergencycontact, aptno) " +
                    "values('"+ csr.name +"', '"+ csr.address +"', '"+ csr.email +"', '"+ csr.contactno +"', '"+ csr.nicpassport +"', " +
                    "'"+ csr.dependentdetails +"', '"+ csr.emergencycontact +"', '"+ csr.aptno +"');";
                  
                //Query for inserting customer data
                data.ExecuteQuery(sql);


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        public void Updatecsr(Customer csr)
        {
            string sql = "update [dbo].[chief occupant] " +
                "set name='"+ csr.name +"',address='"+ csr.address +"'," +
                "email='"+ csr.email +"',contactno='"+ csr.contactno +"'," +
                "nicpassport='"+ csr.nicpassport +"', dependentdetails='"+ csr.dependentdetails +"'," +
                "emergencycontact='"+ csr.emergencycontact +"', aptno='"+ csr.aptno +"' where id='"+csr.id+"'";

            data.ExecuteQuery(sql);
        }
        public void Deletecsr(Customer csr)
        {
            string sql = "delete from [dbo].[chief occupant] where id=" + csr.id;
            data.ExecuteQuery(sql);
        }
    }

   

}
