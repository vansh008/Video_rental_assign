using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_rental_assign.Task
{
    public class Video:dbContext
    {
        public Boolean addVideo(String Title,String Ratting,int Year,int cost,int Copies,String Plot,String genre) {
            if (!Title.ToString().Equals("") && !Ratting.ToString().Equals("") && !Year.ToString().Equals("") && !cost.ToString().Equals("") && !Copies.ToString().Equals("") && !Plot.ToString().Equals("") && !genre.ToString().Equals(""))
            {
                DMLQuery("insert into Video values('"+Title+"','"+Ratting+"',"+Year+","+cost+","+Copies+",'"+Plot+"','"+genre+"')");
                MessageBox.Show("Video Record is saved");
                return true;
            }
            else {
                MessageBox.Show("Check Video Record");
                return false;
            }
        }

        public Boolean delVideo(int VideoID) {

            if (VideoID > 0)
            {


                DataTable tbl = new DataTable();
                tbl = FetchRecord("select * from Rent where VideoID=" + VideoID + " and EndDate='book'");
                if (tbl.Rows.Count > 0)
                {
                    MessageBox.Show("First retuen the Video");
                    return false;
                }
                else
                {
                    DMLQuery("delete from Video VideoID=" + VideoID + "");
                    MessageBox.Show("Video Record is deleted ");
                    return true;
                }

            }
            return true;
        }


        public Boolean UpdateVideo(int VideoID,String Title, String Ratting, int Year, int cost, int Copies, String Plot, String genre) {

            if (!Title.ToString().Equals("") && !Ratting.ToString().Equals("") && !Year.ToString().Equals("") && !cost.ToString().Equals("") && !Copies.ToString().Equals("") && !Plot.ToString().Equals("") && !genre.ToString().Equals("") && VideoID>0)
            { 
                DMLQuery("update Video set Title='" + Title + "',Rates='" + Ratting + "',Year=" + Year + ",Cost=" + cost + ",Copies=" + Copies + ",Plot='" + Plot + "',Genre='" + genre + "' where VideoID="+VideoID+")");
                MessageBox.Show("Video Record is Updated");
                return true;
            }
            else
            {
                MessageBox.Show("Check Video Record");
                return false;
            }


        }

        //get the details of all Video of the store 
        public void videoRecord(DataGridView dgv)
        {
            DataTable tbl = new DataTable();
            tbl = FetchRecord("Select * from Video");
            dgv.DataSource = tbl;
        }

    }
}
