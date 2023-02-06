using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments
{
    internal class UserManangement
    {
        public int id { get; set; }
        public string nic { get; set; }
        public string name { get; set; }

        public string username { get; set; }
        public string password { get; set; }
        public string type { get; set; }




        public void SaveCsr(UserManangement csr)
        {
            try
            {
                string sql = "insert into LoginApartments ( nic, name, username, password, type) " +
                    "values('" + csr.nic + "','" + csr.name + "','" + csr.username + "','" + csr.password + "','" + csr.type + "');";


                data.ExecuteQuery(sql);

                MessageBox.Show("Insert Succesful");


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        public void Updatecsr(UserManangement csr)
        {
            string sql = "update LoginApartments set nic ='" + csr.nic + "', name='" + csr.name +
                "',username='" + csr.username + "', password='" + csr.password + "',type='" + csr.type + "' where nic='" + csr.nic + "'";

            data.ExecuteQuery(sql);

            MessageBox.Show("Successfully Updated");
        }
        public void Deletecsr(UserManangement csr)
        {
            try
            {
                string sql = "delete from LoginApartments where nic='" + csr.nic +"'";
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
