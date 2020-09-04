namespace Video_rental_assign
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete_cus = new System.Windows.Forms.Button();
            this.updating_cus = new System.Windows.Forms.Button();
            this.adding_cust = new System.Windows.Forms.Button();
            this.addres_cus = new System.Windows.Forms.TextBox();
            this.ph_cus = new System.Windows.Forms.TextBox();
            this.email_cus = new System.Windows.Forms.TextBox();
            this.cust_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.mov_delete = new System.Windows.Forms.Button();
            this.mov_return = new System.Windows.Forms.Button();
            this.Issue_new_mov = new System.Windows.Forms.Button();
            this.mov_RenID = new System.Windows.Forms.TextBox();
            this.Cus_RenID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.delete_video_btn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_update_video = new System.Windows.Forms.Button();
            this.mov_genre = new System.Windows.Forms.TextBox();
            this.Video_add = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.mov_plot = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mov_copies = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mov_cost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mov_year = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mov_rate = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Mov_title = new System.Windows.Forms.TextBox();
            this.grid_video_show = new System.Windows.Forms.Button();
            this.customer_btn_gridview = new System.Windows.Forms.Button();
            this.Rental_btn_gridview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video Rental ";
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 55);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(877, 194);
            this.dgv.TabIndex = 1;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.delete_cus);
            this.groupBox1.Controls.Add(this.updating_cus);
            this.groupBox1.Controls.Add(this.adding_cust);
            this.groupBox1.Controls.Add(this.addres_cus);
            this.groupBox1.Controls.Add(this.ph_cus);
            this.groupBox1.Controls.Add(this.email_cus);
            this.groupBox1.Controls.Add(this.cust_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(13, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 201);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // delete_cus
            // 
            this.delete_cus.Location = new System.Drawing.Point(272, 131);
            this.delete_cus.Name = "delete_cus";
            this.delete_cus.Size = new System.Drawing.Size(75, 23);
            this.delete_cus.TabIndex = 21;
            this.delete_cus.Text = "Delete";
            this.delete_cus.UseVisualStyleBackColor = true;
            this.delete_cus.Click += new System.EventHandler(this.delete_cus_Click);
            // 
            // updating_cus
            // 
            this.updating_cus.Location = new System.Drawing.Point(272, 87);
            this.updating_cus.Name = "updating_cus";
            this.updating_cus.Size = new System.Drawing.Size(75, 23);
            this.updating_cus.TabIndex = 20;
            this.updating_cus.Text = "Update";
            this.updating_cus.UseVisualStyleBackColor = true;
            this.updating_cus.Click += new System.EventHandler(this.updating_cus_Click);
            // 
            // adding_cust
            // 
            this.adding_cust.Location = new System.Drawing.Point(272, 37);
            this.adding_cust.Name = "adding_cust";
            this.adding_cust.Size = new System.Drawing.Size(75, 23);
            this.adding_cust.TabIndex = 19;
            this.adding_cust.Text = "Add ";
            this.adding_cust.UseVisualStyleBackColor = true;
            this.adding_cust.Click += new System.EventHandler(this.adding_cust_Click);
            // 
            // addres_cus
            // 
            this.addres_cus.Location = new System.Drawing.Point(121, 151);
            this.addres_cus.Name = "addres_cus";
            this.addres_cus.Size = new System.Drawing.Size(127, 20);
            this.addres_cus.TabIndex = 18;
            // 
            // ph_cus
            // 
            this.ph_cus.Location = new System.Drawing.Point(121, 110);
            this.ph_cus.Name = "ph_cus";
            this.ph_cus.Size = new System.Drawing.Size(127, 20);
            this.ph_cus.TabIndex = 17;
            // 
            // email_cus
            // 
            this.email_cus.Location = new System.Drawing.Point(121, 72);
            this.email_cus.Name = "email_cus";
            this.email_cus.Size = new System.Drawing.Size(127, 20);
            this.email_cus.TabIndex = 16;
            // 
            // cust_name
            // 
            this.cust_name.Location = new System.Drawing.Point(121, 37);
            this.cust_name.Name = "cust_name";
            this.cust_name.Size = new System.Drawing.Size(127, 20);
            this.cust_name.TabIndex = 15;
            this.cust_name.TextChanged += new System.EventHandler(this.cust_name_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.dtpEnd);
            this.groupBox2.Controls.Add(this.dtpStart);
            this.groupBox2.Controls.Add(this.mov_delete);
            this.groupBox2.Controls.Add(this.mov_return);
            this.groupBox2.Controls.Add(this.Issue_new_mov);
            this.groupBox2.Controls.Add(this.mov_RenID);
            this.groupBox2.Controls.Add(this.Cus_RenID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(409, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 200);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rental System";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(170, 147);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(127, 20);
            this.dtpEnd.TabIndex = 23;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(170, 108);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(127, 20);
            this.dtpStart.TabIndex = 22;
            // 
            // mov_delete
            // 
            this.mov_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mov_delete.Location = new System.Drawing.Point(338, 106);
            this.mov_delete.Name = "mov_delete";
            this.mov_delete.Size = new System.Drawing.Size(75, 23);
            this.mov_delete.TabIndex = 21;
            this.mov_delete.Text = "Delete";
            this.mov_delete.UseVisualStyleBackColor = false;
            this.mov_delete.Click += new System.EventHandler(this.mov_delete_Click);
            // 
            // mov_return
            // 
            this.mov_return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mov_return.Location = new System.Drawing.Point(338, 71);
            this.mov_return.Name = "mov_return";
            this.mov_return.Size = new System.Drawing.Size(75, 23);
            this.mov_return.TabIndex = 20;
            this.mov_return.Text = "Return";
            this.mov_return.UseVisualStyleBackColor = false;
            this.mov_return.Click += new System.EventHandler(this.mov_return_Click);
            // 
            // Issue_new_mov
            // 
            this.Issue_new_mov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Issue_new_mov.Location = new System.Drawing.Point(338, 36);
            this.Issue_new_mov.Name = "Issue_new_mov";
            this.Issue_new_mov.Size = new System.Drawing.Size(75, 23);
            this.Issue_new_mov.TabIndex = 19;
            this.Issue_new_mov.Text = "Issue";
            this.Issue_new_mov.UseVisualStyleBackColor = false;
            this.Issue_new_mov.Click += new System.EventHandler(this.Issue_new_mov_Click);
            // 
            // mov_RenID
            // 
            this.mov_RenID.Location = new System.Drawing.Point(170, 70);
            this.mov_RenID.Name = "mov_RenID";
            this.mov_RenID.Size = new System.Drawing.Size(127, 20);
            this.mov_RenID.TabIndex = 18;
            // 
            // Cus_RenID
            // 
            this.Cus_RenID.Location = new System.Drawing.Point(170, 35);
            this.Cus_RenID.Name = "Cus_RenID";
            this.Cus_RenID.Size = new System.Drawing.Size(127, 20);
            this.Cus_RenID.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Movie ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Issue Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Return Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "Customer ID";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.delete_video_btn);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.btn_update_video);
            this.groupBox3.Controls.Add(this.mov_genre);
            this.groupBox3.Controls.Add(this.Video_add);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.mov_plot);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.mov_copies);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.mov_cost);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.mov_year);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.mov_rate);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.Mov_title);
            this.groupBox3.Location = new System.Drawing.Point(13, 490);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(832, 220);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Video adding System";
            // 
            // delete_video_btn
            // 
            this.delete_video_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.delete_video_btn.Location = new System.Drawing.Point(577, 167);
            this.delete_video_btn.Name = "delete_video_btn";
            this.delete_video_btn.Size = new System.Drawing.Size(85, 30);
            this.delete_video_btn.TabIndex = 32;
            this.delete_video_btn.Text = "Delete";
            this.delete_video_btn.UseVisualStyleBackColor = false;
            this.delete_video_btn.Click += new System.EventHandler(this.delete_video_btn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(559, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 24);
            this.label15.TabIndex = 38;
            this.label15.Text = "Genre";
            // 
            // btn_update_video
            // 
            this.btn_update_video.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_update_video.Location = new System.Drawing.Point(577, 132);
            this.btn_update_video.Name = "btn_update_video";
            this.btn_update_video.Size = new System.Drawing.Size(85, 29);
            this.btn_update_video.TabIndex = 30;
            this.btn_update_video.Text = "Update";
            this.btn_update_video.UseVisualStyleBackColor = false;
            this.btn_update_video.Click += new System.EventHandler(this.btn_update_video_Click);
            // 
            // mov_genre
            // 
            this.mov_genre.Location = new System.Drawing.Point(663, 64);
            this.mov_genre.Name = "mov_genre";
            this.mov_genre.Size = new System.Drawing.Size(127, 20);
            this.mov_genre.TabIndex = 39;
            // 
            // Video_add
            // 
            this.Video_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Video_add.Location = new System.Drawing.Point(577, 97);
            this.Video_add.Name = "Video_add";
            this.Video_add.Size = new System.Drawing.Size(85, 29);
            this.Video_add.TabIndex = 28;
            this.Video_add.Text = "Add ";
            this.Video_add.UseVisualStyleBackColor = false;
            this.Video_add.Click += new System.EventHandler(this.Video_add_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(313, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 24);
            this.label12.TabIndex = 34;
            this.label12.Text = "Plot";
            // 
            // mov_plot
            // 
            this.mov_plot.Location = new System.Drawing.Point(417, 137);
            this.mov_plot.Name = "mov_plot";
            this.mov_plot.Size = new System.Drawing.Size(127, 20);
            this.mov_plot.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(286, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 24);
            this.label13.TabIndex = 33;
            this.label13.Text = "Movie Copies";
            // 
            // mov_copies
            // 
            this.mov_copies.Location = new System.Drawing.Point(417, 99);
            this.mov_copies.Name = "mov_copies";
            this.mov_copies.Size = new System.Drawing.Size(127, 20);
            this.mov_copies.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(313, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 24);
            this.label14.TabIndex = 31;
            this.label14.Text = "Cost";
            // 
            // mov_cost
            // 
            this.mov_cost.Enabled = false;
            this.mov_cost.Location = new System.Drawing.Point(417, 64);
            this.mov_cost.Name = "mov_cost";
            this.mov_cost.Size = new System.Drawing.Size(127, 20);
            this.mov_cost.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 24);
            this.label11.TabIndex = 25;
            this.label11.Text = "Year";
            // 
            // mov_year
            // 
            this.mov_year.Location = new System.Drawing.Point(147, 137);
            this.mov_year.Name = "mov_year";
            this.mov_year.Size = new System.Drawing.Size(127, 20);
            this.mov_year.TabIndex = 29;
            this.mov_year.TextChanged += new System.EventHandler(this.mov_year_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "Rates";
            // 
            // mov_rate
            // 
            this.mov_rate.Location = new System.Drawing.Point(147, 99);
            this.mov_rate.Name = "mov_rate";
            this.mov_rate.Size = new System.Drawing.Size(127, 20);
            this.mov_rate.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(43, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 24);
            this.label16.TabIndex = 23;
            this.label16.Text = "Title";
            // 
            // Mov_title
            // 
            this.Mov_title.Location = new System.Drawing.Point(147, 64);
            this.Mov_title.Name = "Mov_title";
            this.Mov_title.Size = new System.Drawing.Size(127, 20);
            this.Mov_title.TabIndex = 26;
            // 
            // grid_video_show
            // 
            this.grid_video_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grid_video_show.Location = new System.Drawing.Point(70, 12);
            this.grid_video_show.Name = "grid_video_show";
            this.grid_video_show.Size = new System.Drawing.Size(134, 37);
            this.grid_video_show.TabIndex = 5;
            this.grid_video_show.Text = "Video";
            this.grid_video_show.UseVisualStyleBackColor = false;
            this.grid_video_show.Click += new System.EventHandler(this.grid_video_show_Click);
            // 
            // customer_btn_gridview
            // 
            this.customer_btn_gridview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.customer_btn_gridview.Location = new System.Drawing.Point(210, 13);
            this.customer_btn_gridview.Name = "customer_btn_gridview";
            this.customer_btn_gridview.Size = new System.Drawing.Size(134, 37);
            this.customer_btn_gridview.TabIndex = 6;
            this.customer_btn_gridview.Text = "Customer";
            this.customer_btn_gridview.UseVisualStyleBackColor = false;
            this.customer_btn_gridview.Click += new System.EventHandler(this.customer_btn_gridview_Click);
            // 
            // Rental_btn_gridview
            // 
            this.Rental_btn_gridview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Rental_btn_gridview.Location = new System.Drawing.Point(579, 13);
            this.Rental_btn_gridview.Name = "Rental_btn_gridview";
            this.Rental_btn_gridview.Size = new System.Drawing.Size(134, 37);
            this.Rental_btn_gridview.TabIndex = 7;
            this.Rental_btn_gridview.Text = "Rental";
            this.Rental_btn_gridview.UseVisualStyleBackColor = false;
            this.Rental_btn_gridview.Click += new System.EventHandler(this.Rental_btn_gridview_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(901, 722);
            this.Controls.Add(this.Rental_btn_gridview);
            this.Controls.Add(this.customer_btn_gridview);
            this.Controls.Add(this.grid_video_show);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delete_cus;
        private System.Windows.Forms.Button updating_cus;
        private System.Windows.Forms.Button adding_cust;
        private System.Windows.Forms.TextBox addres_cus;
        private System.Windows.Forms.TextBox ph_cus;
        private System.Windows.Forms.TextBox email_cus;
        private System.Windows.Forms.TextBox cust_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button mov_delete;
        private System.Windows.Forms.Button mov_return;
        private System.Windows.Forms.Button Issue_new_mov;
        private System.Windows.Forms.TextBox mov_RenID;
        private System.Windows.Forms.TextBox Cus_RenID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button delete_video_btn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_update_video;
        private System.Windows.Forms.TextBox mov_genre;
        private System.Windows.Forms.Button Video_add;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox mov_plot;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox mov_copies;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox mov_cost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox mov_year;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox mov_rate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Mov_title;
        private System.Windows.Forms.Button grid_video_show;
        private System.Windows.Forms.Button customer_btn_gridview;
        private System.Windows.Forms.Button Rental_btn_gridview;
    }
}

