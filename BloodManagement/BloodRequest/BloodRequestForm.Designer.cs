namespace BloodManagement
{
    partial class BloodRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloodRequestForm));
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxBloodType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DataGridViewRequest = new System.Windows.Forms.DataGridView();
            this.comboBoxHospitalName = new System.Windows.Forms.ComboBox();
            this.comboBoxRhFactor = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxUrgency = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dateTimePickerDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerRequestDate = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRequest)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 25);
            this.label9.TabIndex = 64;
            this.label9.Text = "BLOOD REQUEST";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1009, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 31);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.comboBoxBloodType.Location = new System.Drawing.Point(247, 451);
            this.comboBoxBloodType.Name = "comboBoxBloodType";
            this.comboBoxBloodType.Size = new System.Drawing.Size(220, 24);
            this.comboBoxBloodType.TabIndex = 83;
            this.comboBoxBloodType.SelectedIndexChanged += new System.EventHandler(this.comboBoxBloodType_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(140)))));
            this.label13.Location = new System.Drawing.Point(244, 430);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 18);
            this.label13.TabIndex = 82;
            this.label13.Text = "Blood Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(140)))));
            this.label12.Location = new System.Drawing.Point(244, 375);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 18);
            this.label12.TabIndex = 80;
            this.label12.Text = "Hospital Name";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(155)))), ((int)(((byte)(187)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(84, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 30);
            this.button2.TabIndex = 77;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(922, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 30);
            this.button5.TabIndex = 74;
            this.button5.Text = "Info";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(831, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 30);
            this.button1.TabIndex = 72;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataGridViewRequest
            // 
            this.DataGridViewRequest.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.DataGridViewRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewRequest.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGridViewRequest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewRequest.Location = new System.Drawing.Point(247, 184);
            this.DataGridViewRequest.Name = "DataGridViewRequest";
            this.DataGridViewRequest.RowHeadersWidth = 51;
            this.DataGridViewRequest.RowTemplate.Height = 24;
            this.DataGridViewRequest.Size = new System.Drawing.Size(749, 174);
            this.DataGridViewRequest.TabIndex = 71;
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
            this.comboBoxHospitalName.Location = new System.Drawing.Point(247, 394);
            this.comboBoxHospitalName.Name = "comboBoxHospitalName";
            this.comboBoxHospitalName.Size = new System.Drawing.Size(220, 24);
            this.comboBoxHospitalName.TabIndex = 94;
            this.comboBoxHospitalName.SelectedIndexChanged += new System.EventHandler(this.comboBoxHospitalName_SelectedIndexChanged);
            // 
            // comboBoxRhFactor
            // 
            this.comboBoxRhFactor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxRhFactor.FormattingEnabled = true;
            this.comboBoxRhFactor.Items.AddRange(new object[] {
            "+",
            "-"});
            this.comboBoxRhFactor.Location = new System.Drawing.Point(247, 508);
            this.comboBoxRhFactor.Name = "comboBoxRhFactor";
            this.comboBoxRhFactor.Size = new System.Drawing.Size(220, 24);
            this.comboBoxRhFactor.TabIndex = 96;
            this.comboBoxRhFactor.SelectedIndexChanged += new System.EventHandler(this.comboBoxRhFactor_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(140)))));
            this.label14.Location = new System.Drawing.Point(244, 487);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 18);
            this.label14.TabIndex = 95;
            this.label14.Text = "RhFactor";
            // 
            // comboBoxUrgency
            // 
            this.comboBoxUrgency.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxUrgency.FormattingEnabled = true;
            this.comboBoxUrgency.Items.AddRange(new object[] {
            "Urgent",
            "Not urgent"});
            this.comboBoxUrgency.Location = new System.Drawing.Point(488, 394);
            this.comboBoxUrgency.Name = "comboBoxUrgency";
            this.comboBoxUrgency.Size = new System.Drawing.Size(220, 24);
            this.comboBoxUrgency.TabIndex = 98;
            this.comboBoxUrgency.SelectedIndexChanged += new System.EventHandler(this.comboBoxUrgency_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(140)))));
            this.label16.Location = new System.Drawing.Point(485, 375);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 18);
            this.label16.TabIndex = 97;
            this.label16.Text = "Urgency";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(140)))));
            this.label17.Location = new System.Drawing.Point(485, 430);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 18);
            this.label17.TabIndex = 100;
            this.label17.Text = "Request Date";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(140)))));
            this.label18.Location = new System.Drawing.Point(485, 487);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 18);
            this.label18.TabIndex = 102;
            this.label18.Text = "Delivery Date";
            // 
            // dateTimePickerDeliveryDate
            // 
            this.dateTimePickerDeliveryDate.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTimePickerDeliveryDate.Location = new System.Drawing.Point(488, 510);
            this.dateTimePickerDeliveryDate.Name = "dateTimePickerDeliveryDate";
            this.dateTimePickerDeliveryDate.Size = new System.Drawing.Size(220, 22);
            this.dateTimePickerDeliveryDate.TabIndex = 101;
            this.dateTimePickerDeliveryDate.ValueChanged += new System.EventHandler(this.dateTimePickerDeliveryDate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.label7.Location = new System.Drawing.Point(12, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "Blood Request";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.label6.Location = new System.Drawing.Point(12, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "Blood";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.label4.Location = new System.Drawing.Point(12, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Donors";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.label3.Location = new System.Drawing.Point(12, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Employees";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Delivered",
            "Cancelled"});
            this.comboBoxStatus.Location = new System.Drawing.Point(15, 92);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(220, 24);
            this.comboBoxStatus.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 103;
            this.label1.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(743, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 175);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(15, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 22);
            this.textBox1.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(140)))));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 105;
            this.label2.Text = "ID";
            // 
            // dateTimePickerRequestDate
            // 
            this.dateTimePickerRequestDate.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTimePickerRequestDate.Location = new System.Drawing.Point(488, 453);
            this.dateTimePickerRequestDate.Name = "dateTimePickerRequestDate";
            this.dateTimePickerRequestDate.Size = new System.Drawing.Size(220, 22);
            this.dateTimePickerRequestDate.TabIndex = 99;
            this.dateTimePickerRequestDate.ValueChanged += new System.EventHandler(this.dateTimePickerRequestDate_ValueChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(743, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 30);
            this.button3.TabIndex = 106;
            this.button3.Text = "Report";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BloodRequestForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1080, 607);
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
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataGridViewRequest);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BloodRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BloodRequest";
            this.Load += new System.EventHandler(this.BloodRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRequest)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxBloodType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DataGridViewRequest;
        private System.Windows.Forms.ComboBox comboBoxHospitalName;
        private System.Windows.Forms.ComboBox comboBoxRhFactor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxUrgency;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeliveryDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerRequestDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}