namespace Course_Capstone
{
    partial class CourseCapstone
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
            this.txtNumberCourses = new System.Windows.Forms.TextBox();
            this.txtNameFirstLast = new System.Windows.Forms.TextBox();
            this.startDates = new System.Windows.Forms.MonthCalendar();
            this.cboCourses = new System.Windows.Forms.ComboBox();
            this.radioHybrid = new System.Windows.Forms.RadioButton();
            this.radioOnline = new System.Windows.Forms.RadioButton();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.numberCourses = new System.Windows.Forms.Label();
            this.nameFirstLast = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumberCourses
            // 
            this.txtNumberCourses.Location = new System.Drawing.Point(160, 31);
            this.txtNumberCourses.Name = "txtNumberCourses";
            this.txtNumberCourses.Size = new System.Drawing.Size(98, 20);
            this.txtNumberCourses.TabIndex = 0;
            this.txtNumberCourses.TextChanged += new System.EventHandler(this.txtNumberCourses_TextChanged);
            // 
            // txtNameFirstLast
            // 
            this.txtNameFirstLast.Location = new System.Drawing.Point(160, 68);
            this.txtNameFirstLast.Name = "txtNameFirstLast";
            this.txtNameFirstLast.Size = new System.Drawing.Size(98, 20);
            this.txtNameFirstLast.TabIndex = 1;
            // 
            // startDates
            // 
            this.startDates.Location = new System.Drawing.Point(33, 123);
            this.startDates.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.startDates.Name = "startDates";
            this.startDates.ShowToday = false;
            this.startDates.ShowTodayCircle = false;
            this.startDates.TabIndex = 2;
            // 
            // cboCourses
            // 
            this.cboCourses.FormattingEnabled = true;
            this.cboCourses.Items.AddRange(new object[] {
            "ISMG6020",
            "ACCT6031",
            "MGMT2030"});
            this.cboCourses.Location = new System.Drawing.Point(31, 298);
            this.cboCourses.Name = "cboCourses";
            this.cboCourses.Size = new System.Drawing.Size(226, 21);
            this.cboCourses.TabIndex = 3;
            this.cboCourses.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // radioHybrid
            // 
            this.radioHybrid.AutoSize = true;
            this.radioHybrid.Location = new System.Drawing.Point(58, 340);
            this.radioHybrid.Name = "radioHybrid";
            this.radioHybrid.Size = new System.Drawing.Size(55, 17);
            this.radioHybrid.TabIndex = 4;
            this.radioHybrid.TabStop = true;
            this.radioHybrid.Text = "Hybrid";
            this.radioHybrid.UseVisualStyleBackColor = true;
            // 
            // radioOnline
            // 
            this.radioOnline.AutoSize = true;
            this.radioOnline.Location = new System.Drawing.Point(170, 340);
            this.radioOnline.Name = "radioOnline";
            this.radioOnline.Size = new System.Drawing.Size(55, 17);
            this.radioOnline.TabIndex = 5;
            this.radioOnline.TabStop = true;
            this.radioOnline.Text = "Online";
            this.radioOnline.UseVisualStyleBackColor = true;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(31, 377);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(102, 40);
            this.btnSet.TabIndex = 6;
            this.btnSet.Text = "&Set";
            this.btnSet.UseVisualStyleBackColor = true;
            // 
            // btnGet
            // 
            this.btnGet.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGet.Location = new System.Drawing.Point(170, 377);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(102, 40);
            this.btnGet.TabIndex = 7;
            this.btnGet.Text = "&Get";
            this.btnGet.UseVisualStyleBackColor = true;
            // 
            // numberCourses
            // 
            this.numberCourses.AutoSize = true;
            this.numberCourses.Location = new System.Drawing.Point(28, 34);
            this.numberCourses.Name = "numberCourses";
            this.numberCourses.Size = new System.Drawing.Size(97, 13);
            this.numberCourses.TabIndex = 8;
            this.numberCourses.Text = "Number of Courses";
            // 
            // nameFirstLast
            // 
            this.nameFirstLast.AutoSize = true;
            this.nameFirstLast.Location = new System.Drawing.Point(28, 71);
            this.nameFirstLast.Name = "nameFirstLast";
            this.nameFirstLast.Size = new System.Drawing.Size(86, 13);
            this.nameFirstLast.TabIndex = 9;
            this.nameFirstLast.Text = "Name (First Last)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Course Start Date:";
            // 
            // CourseCapstone
            // 
            this.AcceptButton = this.btnSet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnGet;
            this.ClientSize = new System.Drawing.Size(295, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameFirstLast);
            this.Controls.Add(this.numberCourses);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.radioOnline);
            this.Controls.Add(this.radioHybrid);
            this.Controls.Add(this.cboCourses);
            this.Controls.Add(this.startDates);
            this.Controls.Add(this.txtNameFirstLast);
            this.Controls.Add(this.txtNumberCourses);
            this.Name = "CourseCapstone";
            this.Text = "Course Capstone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberCourses;
        private System.Windows.Forms.TextBox txtNameFirstLast;
        private System.Windows.Forms.MonthCalendar startDates;
        private System.Windows.Forms.ComboBox cboCourses;
        private System.Windows.Forms.RadioButton radioHybrid;
        private System.Windows.Forms.RadioButton radioOnline;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label numberCourses;
        private System.Windows.Forms.Label nameFirstLast;
        private System.Windows.Forms.Label label3;
    }
}

