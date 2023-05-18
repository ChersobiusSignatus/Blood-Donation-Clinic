namespace BloodManagement
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.dateTimePickerDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTimePickerRequestDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxUrgency = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxRhFactor = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxHospitalName = new System.Windows.Forms.ComboBox();
            this.comboBoxBloodType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BloodManagement.BloodReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 203);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(950, 455);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(140)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(978, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "sum";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(140)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(978, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "average";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(618, 132);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 18);
            this.label18.TabIndex = 116;
            this.label18.Text = "Delivery Date";
            // 
            // dateTimePickerDeliveryDate
            // 
            this.dateTimePickerDeliveryDate.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTimePickerDeliveryDate.Location = new System.Drawing.Point(621, 155);
            this.dateTimePickerDeliveryDate.Name = "dateTimePickerDeliveryDate";
            this.dateTimePickerDeliveryDate.Size = new System.Drawing.Size(220, 22);
            this.dateTimePickerDeliveryDate.TabIndex = 115;
            this.dateTimePickerDeliveryDate.ValueChanged += new System.EventHandler(this.dateTimePickerDeliveryDate_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(618, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 18);
            this.label17.TabIndex = 114;
            this.label17.Text = "Request Date";
            // 
            // dateTimePickerRequestDate
            // 
            this.dateTimePickerRequestDate.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTimePickerRequestDate.Location = new System.Drawing.Point(621, 103);
            this.dateTimePickerRequestDate.Name = "dateTimePickerRequestDate";
            this.dateTimePickerRequestDate.Size = new System.Drawing.Size(115, 22);
            this.dateTimePickerRequestDate.TabIndex = 113;
            this.dateTimePickerRequestDate.ValueChanged += new System.EventHandler(this.dateTimePickerRequestDate_ValueChanged);
            // 
            // comboBoxUrgency
            // 
            this.comboBoxUrgency.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxUrgency.FormattingEnabled = true;
            this.comboBoxUrgency.Items.AddRange(new object[] {
            "Urgent",
            "Not urgent"});
            this.comboBoxUrgency.Location = new System.Drawing.Point(9, 151);
            this.comboBoxUrgency.Name = "comboBoxUrgency";
            this.comboBoxUrgency.Size = new System.Drawing.Size(220, 24);
            this.comboBoxUrgency.TabIndex = 112;
            this.comboBoxUrgency.SelectedIndexChanged += new System.EventHandler(this.comboBoxUrgency_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(6, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 18);
            this.label16.TabIndex = 111;
            this.label16.Text = "Urgency";
            // 
            // comboBoxRhFactor
            // 
            this.comboBoxRhFactor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxRhFactor.FormattingEnabled = true;
            this.comboBoxRhFactor.Items.AddRange(new object[] {
            "+",
            "-"});
            this.comboBoxRhFactor.Location = new System.Drawing.Point(312, 155);
            this.comboBoxRhFactor.Name = "comboBoxRhFactor";
            this.comboBoxRhFactor.Size = new System.Drawing.Size(220, 24);
            this.comboBoxRhFactor.TabIndex = 110;
            this.comboBoxRhFactor.SelectedIndexChanged += new System.EventHandler(this.comboBoxRhFactor_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(309, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 18);
            this.label14.TabIndex = 109;
            this.label14.Text = "RhFactor";
            // 
            // comboBoxHospitalName
            // 
            this.comboBoxHospitalName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxHospitalName.FormattingEnabled = true;
            this.comboBoxHospitalName.Items.AddRange(new object[] {
            "Bellevue Forest Hospital",
            "Dawn Heights Hospital Center",
            "Felicity Oasis Hospital Center",
            "Firefly Vale General Hospital",
            "Flowerhill Eden Hospital Center",
            "Good Eden Hospital Center",
            "Littlerock Meadows Hospital",
            "Noble Lake Community Hospital",
            "Paradise Lake Hospital",
            "Rosemary Oak Medical Center",
            "Silk Garden General Hospital",
            "Snowflake Feather Medical Center",
            "Solitude Isle Hospital Center",
            "Sprite Springs General Hospital",
            "Waterfall Wing Clinic"});
            this.comboBoxHospitalName.Location = new System.Drawing.Point(9, 105);
            this.comboBoxHospitalName.Name = "comboBoxHospitalName";
            this.comboBoxHospitalName.Size = new System.Drawing.Size(220, 24);
            this.comboBoxHospitalName.TabIndex = 108;
            this.comboBoxHospitalName.SelectedIndexChanged += new System.EventHandler(this.comboBoxHospitalName_SelectedIndexChanged);
            // 
            // comboBoxBloodType
            // 
            this.comboBoxBloodType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxBloodType.FormattingEnabled = true;
            this.comboBoxBloodType.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.comboBoxBloodType.Location = new System.Drawing.Point(312, 105);
            this.comboBoxBloodType.Name = "comboBoxBloodType";
            this.comboBoxBloodType.Size = new System.Drawing.Size(220, 24);
            this.comboBoxBloodType.TabIndex = 107;
            this.comboBoxBloodType.SelectedIndexChanged += new System.EventHandler(this.comboBoxBloodType_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(309, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 18);
            this.label13.TabIndex = 106;
            this.label13.Text = "Blood Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 18);
            this.label12.TabIndex = 105;
            this.label12.Text = "Hospital Name";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(140)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(978, 454);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 37);
            this.button3.TabIndex = 119;
            this.button3.Text = "minimum";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(140)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(978, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 37);
            this.button4.TabIndex = 120;
            this.button4.Text = "maximum";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(140)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(978, 506);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 37);
            this.button5.TabIndex = 121;
            this.button5.Text = "total";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(7, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(289, 25);
            this.label9.TabIndex = 122;
            this.label9.Text = "BLOOD REQUEST REPORT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1033, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 31);
            this.pictureBox1.TabIndex = 123;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(895, 121);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 42);
            this.button7.TabIndex = 125;
            this.button7.Text = "Search";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(235, 111);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 126;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(235, 157);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 127;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(538, 135);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(18, 17);
            this.checkBox3.TabIndex = 128;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(847, 112);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(18, 17);
            this.checkBox5.TabIndex = 130;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(847, 160);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(18, 17);
            this.checkBox6.TabIndex = 131;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker1.Location = new System.Drawing.Point(742, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 22);
            this.dateTimePicker1.TabIndex = 132;
            // 
            // ReportForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1080, 670);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dateTimePickerDeliveryDate);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dateTimePickerRequestDate);
            this.Controls.Add(this.comboBoxUrgency);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.comboBoxRhFactor);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBoxHospitalName);
            this.Controls.Add(this.comboBoxBloodType);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeliveryDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateTimePickerRequestDate;
        private System.Windows.Forms.ComboBox comboBoxUrgency;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBoxRhFactor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxHospitalName;
        private System.Windows.Forms.ComboBox comboBoxBloodType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}