using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Video_rental_assign.Task;
namespace Video_rental_assign
{
    public partial class Form1 : Form
    {
        CustomerData obj_Customer = new CustomerData();
        Video obj_Video = new Video();
        Rental obj_Rent = new Rental();

        int rentID = 0;

        int btnVideo = 0,btnCustomer=0,btnRent=0;


        public Form1()
        {
            InitializeComponent();
        }

        private void cust_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void adding_cust_Click(object sender, EventArgs e)
        {
            //first check the user name and password 
            if (!cust_name.Text.ToString().Equals("") && !email_cus.Text.ToString().Equals("") && !ph_cus.Text.ToString().Equals("") && !addres_cus.Text.ToString().Equals(""))
            {
                if (obj_Customer.addCustomer(cust_name.Text, email_cus.Text, ph_cus.Text, addres_cus.Text)) {
                    MessageBox.Show("Customer Record is saved ");        
                }
            }
            else {
                MessageBox.Show("Must fill all Details ");
            }

            cust_name.Text = "";
            ph_cus.Text = "";
            addres_cus.Text = "";
            email_cus.Text = "";
        }

        private void delete_cus_Click(object sender, EventArgs e)
        {
            //delete the customer record 
            if (Cus_RenID.Text.ToString().Equals("")) {
                if (obj_Customer.delCustomer(Convert.ToInt32(Cus_RenID.Text.ToString()))) {
                    
                }
            }

            cust_name.Text = "";
            ph_cus.Text = "";
            addres_cus.Text = "";
            email_cus.Text = "";
            Cus_RenID.Text = "";

        }

        private void updating_cus_Click(object sender, EventArgs e)
        {
            if (obj_Customer.UpdateCustomer(Convert.ToInt32(Cus_RenID.Text.ToString()), cust_name.Text, email_cus.Text, ph_cus.Text, addres_cus.Text))
            {

            }
            else {
                MessageBox.Show("Update the record of the Customer");
            }

            cust_name.Text = "";
            ph_cus.Text = "";
            addres_cus.Text = "";
            email_cus.Text = "";
            Cus_RenID.Text = "";

        }

        private void Video_add_Click(object sender, EventArgs e)
        {
            if (obj_Video.addVideo(Mov_title.Text, mov_rate.Text, Convert.ToInt32(mov_year.Text), Convert.ToInt32(mov_cost.Text), Convert.ToInt32(mov_copies.Text), mov_plot.Text, mov_genre.Text)) {

            }
            mov_copies.Text = "";
            mov_cost.Text = "";
            mov_genre.Text = "";
            mov_plot.Text = "";
            mov_rate.Text = "";
            Mov_title.Text = "";
            mov_rate.Text = "";

        }

        private void delete_video_btn_Click(object sender, EventArgs e)
        {
            if (obj_Video.delVideo(Convert.ToInt32(mov_RenID.Text.ToString()))) {
                    
            }
            mov_copies.Text = "";
            mov_cost.Text = "";
            mov_genre.Text = "";
            mov_plot.Text = "";
            mov_rate.Text = "";
            Mov_title.Text = "";
            mov_rate.Text = "";

            mov_RenID.Text = "";

        }

        private void btn_update_video_Click(object sender, EventArgs e)
        {
            if (obj_Video.UpdateVideo(Convert.ToInt32(mov_RenID.Text.ToString()),Mov_title.Text, mov_rate.Text, Convert.ToInt32(mov_year.Text), Convert.ToInt32(mov_cost.Text), Convert.ToInt32(mov_copies.Text), mov_plot.Text, mov_genre.Text))
            {

            }
            mov_copies.Text = "";
            mov_cost.Text = "";
            mov_genre.Text = "";
            mov_plot.Text = "";
            mov_rate.Text = "";
            Mov_title.Text = "";
            mov_rate.Text = "";


        }

        private void grid_video_show_Click(object sender, EventArgs e)
        {
            //get the recrod from the video table 
            obj_Video.videoRecord(dgv);
            btnVideo = 1;
            btnRent = 0;
            btnCustomer = 0;
        }

        private void customer_btn_gridview_Click(object sender, EventArgs e)
        {
            //get the recrod from the customer table 
            obj_Customer.customerRecord(dgv);
            btnCustomer = 1;
            btnRent = 0;
            btnVideo = 0;
        }

        private void Rental_btn_gridview_Click(object sender, EventArgs e)
        {
            //get the recrod from the Rental table 
            obj_Rent.rentRecord(dgv);
            btnRent = 1;
            btnVideo = 0;
            btnCustomer = 0;
        }

        private void mov_year_TextChanged(object sender, EventArgs e)
        {
            try {
                //we have use the concept of the Textchanged event to generate the charges of the cost 
                //dislay the cost of the price of the video after adding the year of the video
                DateTime dateNow = DateTime.Now;

                int Currentyear = dateNow.Year;

                int diffYear = Currentyear - Convert.ToInt32(mov_year.Text.ToString());
                int cost = 0;
                // MessageBox.Show(diff.ToString());
                if (diffYear >= 5)
                {
                    cost = 2;
                }
                if (diffYear >= 0 && diffYear < 5)
                {
                    cost = 5;

                }
                mov_cost.Text = "" + cost;


            }
            catch (Exception ex) {

            }



            }

        private void mov_delete_Click(object sender, EventArgs e)
        {
            if (rentID>0) {
                obj_Rent.delRental(rentID);   
            }
            rentID = 0;
        }

        private void mov_return_Click(object sender, EventArgs e)
        {
            if (rentID > 0)
            {

                obj_Rent.returnVideo(rentID, Convert.ToInt32(Cus_RenID.Text), Convert.ToInt32(mov_RenID.Text), dtpStart.Text, dtpEnd.Text);
            }

            mov_RenID.Text = "";
            mov_copies.Text = "";
            mov_cost.Text = "";
            mov_genre.Text = "";
            mov_plot.Text = "";
            mov_rate.Text = "";
            Mov_title.Text = "";
            mov_rate.Text = "";


            cust_name.Text = "";
            ph_cus.Text = "";
            addres_cus.Text = "";
            email_cus.Text = "";
            Cus_RenID.Text = "";

            rentID = 0;

        }

        private void Issue_new_mov_Click(object sender, EventArgs e)
        {
            if (obj_Rent.Booking(Convert.ToInt32(Cus_RenID.Text), Convert.ToInt32(mov_RenID.Text), dtpStart.Text.ToString()))
            {

            }
            else {
                MessageBox.Show("Check Video ");
            }


            mov_RenID.Text = "";
            mov_copies.Text = "";
            mov_cost.Text = "";
            mov_genre.Text = "";
            mov_plot.Text = "";
            mov_rate.Text = "";
            Mov_title.Text = "";
            mov_rate.Text = "";


            cust_name.Text = "";
            ph_cus.Text = "";
            addres_cus.Text = "";
            email_cus.Text = "";
            Cus_RenID.Text = "";

            rentID = 0;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnVideo==1) {
                mov_RenID.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                Mov_title.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                mov_rate.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                mov_year.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                mov_cost.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                mov_copies.Text = dgv.CurrentRow.Cells[5].Value.ToString();
                mov_plot.Text = dgv.CurrentRow.Cells[6].Value.ToString();
                mov_genre.Text = dgv.CurrentRow.Cells[7].Value.ToString();

            }
            if (btnCustomer==1) {
                    Cus_RenID.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                    cust_name.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                    email_cus.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                    ph_cus.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                addres_cus.Text = dgv.CurrentRow.Cells[4].Value.ToString();
            }

            if (btnRent==1) {
                rentID= Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
                Cus_RenID.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                mov_RenID.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                dtpStart.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                

            }



            btnVideo = 0;
            btnRent = 0;
            btnCustomer = 0;
        }
    }
    
}
