using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_rental_assign.Task
{
   public class Rental : dbContext
    {

        public Boolean getBooking(int cusID) {
            DataTable tbl = new DataTable();
            String query = "select * from Rent where CusID="+cusID+" and EndDate='Book'";
            tbl=FetchRecord(query);
            if (tbl.Rows.Count< 2)
            {
                return true;
            }
            else {
                return false;
            }
        }


        //check the sample of video how much are booked or not 
        public Boolean chkVideo(int VideoID) {
            String Query = "select * from Rent where VideoID="+VideoID+" and EndDate='Book'";
            DataTable tbl = new DataTable();
            DataTable tbl1 = new DataTable();
            tbl = FetchRecord(Query);
            int copies = 0;
            Query = "";
            Query = "select * from Video where VideoID="+VideoID+"";
            tbl1 = FetchRecord(Query);
            copies = Convert.ToInt32(tbl1.Rows[0]["Copies"].ToString());
            if (tbl.Rows.Count < copies)
            {
                return true;
            }
            else {
                return false;
            }


        }

        // in this we need to book the video to confirm the video first check the booking of the user and then video 
        public Boolean Booking(int cusID, int VideoID, String StrtDate) {
            if (getBooking(cusID))
            {
                if (chkVideo(VideoID))
                {
                    String Query = "insert into Rent values(" + cusID + "," + VideoID + ",'" + StrtDate + "','Book')";
                    DMLQuery(Query);
                    MessageBox.Show("Booking is Confirmed");
                }
                else {
                    MessageBox.Show("ALl samplaes are booked ");
                }
            }
            else {
                MessageBox.Show("You already booked 2 Video Now you don't have limit");
            }
            return true;
        }


        public Boolean returnVideo(int rentID,int cusID, int VideoID, String StartDate,String EndDate) {

            DateTime new_date = DateTime.Now;


            //convert the old date from string to Date fromat
            DateTime prev_date = Convert.ToDateTime(StartDate);


            //get the difference in the days fromat
            String Daysdiff = (new_date - prev_date).TotalDays.ToString();


            // calculate the round off value 
            Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));

            DataTable tbl = new DataTable();
            tbl = FetchRecord("select * from Video where VideoID="+VideoID+"");

            int cost =Convert.ToInt32(tbl.Rows[0]["Cost"]);


            int Charges = Convert.ToInt32(DaysInterval) * cost;




            String query = "update Rent set CusID="+cusID+",VideoID="+VideoID+", BookingDate='"+StartDate+"',EndDate='"+EndDate+"' where ID="+rentID+"";

            DMLQuery(query);

            MessageBox.Show("Video is return and charges "+Charges);

            return true;

        }

        //get the record from the rental table 
        public void rentRecord(DataGridView dgv) {
            DataTable tbl = new DataTable();
            tbl = FetchRecord("select * from Rent");
            dgv.DataSource = tbl;
        }


        //delete the video rental record 
        public Boolean delRental(int RentID) {
            string query = "delete from Rent where ID="+RentID+"";
            DMLQuery(query);
            MessageBox.Show("Record is deleted ");
            return true;
        }
    }
}
