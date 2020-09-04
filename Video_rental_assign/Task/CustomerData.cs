using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_rental_assign.Task
{
    public class CustomerData : dbContext
    {
        ///create the method that is used to add the details of the customer
        public Boolean addCustomer(String Name, String Email, String Phone, String Address) {
            String query = "insert into customer values('" + Name + "','" + Email + "','" + Phone + "','" + Address + "') ";
            DMLQuery(query);
            return true;
        }

        //this method is used to delete the detal sof the cusotmer if he didnot book any video
        public Boolean delCustomer(int CusID) {

            DataTable tbl=new DataTable();
            tbl = FetchRecord("select * from Rent where CusID="+CusID+" and StartDate='book'");
            if (tbl.Rows.Count > 0)
            {
                MessageBox.Show("First retuen the Video");
                return false;
            }
            else {
                DMLQuery("delete from Customer ID="+CusID+"");
                return true;
            }

        }
        //get the details of all cusotmer of the store 
        public void customerRecord(DataGridView dgv) {
            DataTable tbl = new DataTable();
            tbl = FetchRecord("Select * from Customer");
            dgv.DataSource = tbl;
        }

        //upate the record of the Cusotmer
        public Boolean UpdateCustomer(int CusID,String Name, String Email, String Phone, String Address) {

            if (!Name.ToString().Equals("") && !Email.ToString().Equals("") && !Phone.ToString().Equals("") && !Address.ToString().Equals("") && CusID > 0)
            {
                DMLQuery("Update Customer set Name='" + Name + "', Email='" + Email + "',Phone='" + Phone + "',Address='" + Address + "' where ID=" + CusID + "");
                MessageBox.Show("Record is Sucessfully updated");
                return true;
            }
            else {
                return false;
            }

        }

    }
}
