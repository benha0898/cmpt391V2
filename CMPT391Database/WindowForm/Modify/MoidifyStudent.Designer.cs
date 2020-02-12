namespace WindowForm.Modify
{
    partial class MoidifyStudent
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
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.student_input = new System.Windows.Forms.NumericUpDown();
            this.studentid_label = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.search_label = new System.Windows.Forms.Label();
            this.modify_student_label = new System.Windows.Forms.Label();
            this.sucess_label = new System.Windows.Forms.Label();
            this.major_checkbox = new System.Windows.Forms.CheckBox();
            this.major_label = new System.Windows.Forms.Label();
            this.major_input = new System.Windows.Forms.ComboBox();
            this.credits_label = new System.Windows.Forms.Label();
            this.credits_input = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.dob_datetime = new System.Windows.Forms.DateTimePicker();
            this.dob_label = new System.Windows.Forms.Label();
            this.postal_label = new System.Windows.Forms.Label();
            this.postal_input = new System.Windows.Forms.TextBox();
            this.country_label = new System.Windows.Forms.Label();
            this.country_input = new System.Windows.Forms.TextBox();
            this.province_label = new System.Windows.Forms.Label();
            this.province_input = new System.Windows.Forms.TextBox();
            this.city_label = new System.Windows.Forms.Label();
            this.city_input = new System.Windows.Forms.TextBox();
            this.street_label = new System.Windows.Forms.Label();
            this.street_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.last_name_label = new System.Windows.Forms.Label();
            this.last_name_input = new System.Windows.Forms.TextBox();
            this.first_name_label = new System.Windows.Forms.Label();
            this.first_name_input = new System.Windows.Forms.TextBox();
            this.personal_label = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.student_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credits_input)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_button
            // 
            this.delete_button.Enabled = false;
            this.delete_button.Location = new System.Drawing.Point(570, 426);
            this.delete_button.Margin = new System.Windows.Forms.Padding(2);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(56, 24);
            this.delete_button.TabIndex = 82;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // update_button
            // 
            this.update_button.Enabled = false;
            this.update_button.Location = new System.Drawing.Point(488, 426);
            this.update_button.Margin = new System.Windows.Forms.Padding(2);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(56, 24);
            this.update_button.TabIndex = 81;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            // 
            // student_input
            // 
            this.student_input.Location = new System.Drawing.Point(18, 124);
            this.student_input.Margin = new System.Windows.Forms.Padding(2);
            this.student_input.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.student_input.Name = "student_input";
            this.student_input.Size = new System.Drawing.Size(140, 20);
            this.student_input.TabIndex = 80;
            // 
            // studentid_label
            // 
            this.studentid_label.AutoSize = true;
            this.studentid_label.Location = new System.Drawing.Point(16, 105);
            this.studentid_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentid_label.Name = "studentid_label";
            this.studentid_label.Size = new System.Drawing.Size(58, 13);
            this.studentid_label.TabIndex = 79;
            this.studentid_label.Text = "Student ID";
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(18, 158);
            this.search_button.Margin = new System.Windows.Forms.Padding(2);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(92, 27);
            this.search_button.TabIndex = 78;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_label.Location = new System.Drawing.Point(15, 75);
            this.search_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(66, 20);
            this.search_label.TabIndex = 77;
            this.search_label.Text = "Search";
            // 
            // modify_student_label
            // 
            this.modify_student_label.AutoSize = true;
            this.modify_student_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_student_label.Location = new System.Drawing.Point(12, 9);
            this.modify_student_label.Name = "modify_student_label";
            this.modify_student_label.Size = new System.Drawing.Size(208, 33);
            this.modify_student_label.TabIndex = 83;
            this.modify_student_label.Text = "Modify Student";
            // 
            // sucess_label
            // 
            this.sucess_label.AutoSize = true;
            this.sucess_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucess_label.Location = new System.Drawing.Point(12, 410);
            this.sucess_label.Name = "sucess_label";
            this.sucess_label.Size = new System.Drawing.Size(185, 25);
            this.sucess_label.TabIndex = 109;
            this.sucess_label.Text = "Student Updated: ";
            // 
            // major_checkbox
            // 
            this.major_checkbox.AutoCheck = false;
            this.major_checkbox.AutoSize = true;
            this.major_checkbox.Location = new System.Drawing.Point(378, 378);
            this.major_checkbox.Name = "major_checkbox";
            this.major_checkbox.Size = new System.Drawing.Size(81, 17);
            this.major_checkbox.TabIndex = 108;
            this.major_checkbox.Text = "Undeclared";
            this.major_checkbox.UseVisualStyleBackColor = true;
            // 
            // major_label
            // 
            this.major_label.AutoSize = true;
            this.major_label.Location = new System.Drawing.Point(375, 334);
            this.major_label.Name = "major_label";
            this.major_label.Size = new System.Drawing.Size(33, 13);
            this.major_label.TabIndex = 106;
            this.major_label.Text = "Major";
            // 
            // major_input
            // 
            this.major_input.FormattingEnabled = true;
            this.major_input.Location = new System.Drawing.Point(378, 350);
            this.major_input.Name = "major_input";
            this.major_input.Size = new System.Drawing.Size(100, 21);
            this.major_input.TabIndex = 105;
            // 
            // credits_label
            // 
            this.credits_label.AutoSize = true;
            this.credits_label.Location = new System.Drawing.Point(252, 334);
            this.credits_label.Name = "credits_label";
            this.credits_label.Size = new System.Drawing.Size(66, 13);
            this.credits_label.TabIndex = 104;
            this.credits_label.Text = "Total Credits";
            // 
            // credits_input
            // 
            this.credits_input.Location = new System.Drawing.Point(255, 350);
            this.credits_input.Name = "credits_input";
            this.credits_input.Size = new System.Drawing.Size(102, 20);
            this.credits_input.TabIndex = 103;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(251, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 102;
            this.label10.Text = "Other";
            // 
            // dob_datetime
            // 
            this.dob_datetime.Location = new System.Drawing.Point(497, 103);
            this.dob_datetime.Name = "dob_datetime";
            this.dob_datetime.Size = new System.Drawing.Size(121, 20);
            this.dob_datetime.TabIndex = 101;
            // 
            // dob_label
            // 
            this.dob_label.AutoSize = true;
            this.dob_label.Location = new System.Drawing.Point(494, 87);
            this.dob_label.Name = "dob_label";
            this.dob_label.Size = new System.Drawing.Size(66, 13);
            this.dob_label.TabIndex = 100;
            this.dob_label.Text = "Date of Birth";
            // 
            // postal_label
            // 
            this.postal_label.AutoSize = true;
            this.postal_label.Location = new System.Drawing.Point(375, 244);
            this.postal_label.Name = "postal_label";
            this.postal_label.Size = new System.Drawing.Size(64, 13);
            this.postal_label.TabIndex = 99;
            this.postal_label.Text = "Postal Code";
            // 
            // postal_input
            // 
            this.postal_input.Location = new System.Drawing.Point(378, 260);
            this.postal_input.Name = "postal_input";
            this.postal_input.Size = new System.Drawing.Size(100, 20);
            this.postal_input.TabIndex = 98;
            // 
            // country_label
            // 
            this.country_label.AutoSize = true;
            this.country_label.Location = new System.Drawing.Point(254, 244);
            this.country_label.Name = "country_label";
            this.country_label.Size = new System.Drawing.Size(43, 13);
            this.country_label.TabIndex = 97;
            this.country_label.Text = "Country";
            // 
            // country_input
            // 
            this.country_input.Location = new System.Drawing.Point(257, 260);
            this.country_input.Name = "country_input";
            this.country_input.Size = new System.Drawing.Size(100, 20);
            this.country_input.TabIndex = 96;
            // 
            // province_label
            // 
            this.province_label.AutoSize = true;
            this.province_label.Location = new System.Drawing.Point(494, 184);
            this.province_label.Name = "province_label";
            this.province_label.Size = new System.Drawing.Size(49, 13);
            this.province_label.TabIndex = 95;
            this.province_label.Text = "Province";
            // 
            // province_input
            // 
            this.province_input.Location = new System.Drawing.Point(497, 200);
            this.province_input.Name = "province_input";
            this.province_input.Size = new System.Drawing.Size(100, 20);
            this.province_input.TabIndex = 94;
            // 
            // city_label
            // 
            this.city_label.AutoSize = true;
            this.city_label.Location = new System.Drawing.Point(375, 184);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(24, 13);
            this.city_label.TabIndex = 93;
            this.city_label.Text = "City";
            // 
            // city_input
            // 
            this.city_input.Location = new System.Drawing.Point(378, 200);
            this.city_input.Name = "city_input";
            this.city_input.Size = new System.Drawing.Size(100, 20);
            this.city_input.TabIndex = 92;
            // 
            // street_label
            // 
            this.street_label.AutoSize = true;
            this.street_label.Location = new System.Drawing.Point(252, 184);
            this.street_label.Name = "street_label";
            this.street_label.Size = new System.Drawing.Size(35, 13);
            this.street_label.TabIndex = 91;
            this.street_label.Text = "Street";
            // 
            // street_input
            // 
            this.street_input.Location = new System.Drawing.Point(255, 200);
            this.street_input.Name = "street_input";
            this.street_input.Size = new System.Drawing.Size(100, 20);
            this.street_input.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 89;
            this.label3.Text = "Address";
            // 
            // last_name_label
            // 
            this.last_name_label.AutoSize = true;
            this.last_name_label.Location = new System.Drawing.Point(375, 87);
            this.last_name_label.Name = "last_name_label";
            this.last_name_label.Size = new System.Drawing.Size(58, 13);
            this.last_name_label.TabIndex = 88;
            this.last_name_label.Text = "Last Name";
            // 
            // last_name_input
            // 
            this.last_name_input.Location = new System.Drawing.Point(378, 103);
            this.last_name_input.Name = "last_name_input";
            this.last_name_input.Size = new System.Drawing.Size(100, 20);
            this.last_name_input.TabIndex = 87;
            // 
            // first_name_label
            // 
            this.first_name_label.AutoSize = true;
            this.first_name_label.Location = new System.Drawing.Point(252, 87);
            this.first_name_label.Name = "first_name_label";
            this.first_name_label.Size = new System.Drawing.Size(57, 13);
            this.first_name_label.TabIndex = 86;
            this.first_name_label.Text = "First Name";
            // 
            // first_name_input
            // 
            this.first_name_input.Location = new System.Drawing.Point(255, 103);
            this.first_name_input.Name = "first_name_input";
            this.first_name_input.Size = new System.Drawing.Size(100, 20);
            this.first_name_input.TabIndex = 85;
            // 
            // personal_label
            // 
            this.personal_label.AutoSize = true;
            this.personal_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personal_label.Location = new System.Drawing.Point(251, 58);
            this.personal_label.Name = "personal_label";
            this.personal_label.Size = new System.Drawing.Size(140, 20);
            this.personal_label.TabIndex = 84;
            this.personal_label.Text = "Personal Details";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(222, 461);
            this.splitter1.TabIndex = 110;
            this.splitter1.TabStop = false;
            // 
            // MoidifyStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 461);
            this.Controls.Add(this.sucess_label);
            this.Controls.Add(this.major_checkbox);
            this.Controls.Add(this.major_label);
            this.Controls.Add(this.major_input);
            this.Controls.Add(this.credits_label);
            this.Controls.Add(this.credits_input);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dob_datetime);
            this.Controls.Add(this.dob_label);
            this.Controls.Add(this.postal_label);
            this.Controls.Add(this.postal_input);
            this.Controls.Add(this.country_label);
            this.Controls.Add(this.country_input);
            this.Controls.Add(this.province_label);
            this.Controls.Add(this.province_input);
            this.Controls.Add(this.city_label);
            this.Controls.Add(this.city_input);
            this.Controls.Add(this.street_label);
            this.Controls.Add(this.street_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.last_name_label);
            this.Controls.Add(this.last_name_input);
            this.Controls.Add(this.first_name_label);
            this.Controls.Add(this.first_name_input);
            this.Controls.Add(this.personal_label);
            this.Controls.Add(this.modify_student_label);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.student_input);
            this.Controls.Add(this.studentid_label);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_label);
            this.Controls.Add(this.splitter1);
            this.Name = "MoidifyStudent";
            this.Text = "Moidify Student";
            ((System.ComponentModel.ISupportInitialize)(this.student_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credits_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.NumericUpDown student_input;
        private System.Windows.Forms.Label studentid_label;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.Label modify_student_label;
        private System.Windows.Forms.Label sucess_label;
        private System.Windows.Forms.CheckBox major_checkbox;
        private System.Windows.Forms.Label major_label;
        private System.Windows.Forms.ComboBox major_input;
        private System.Windows.Forms.Label credits_label;
        private System.Windows.Forms.NumericUpDown credits_input;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dob_datetime;
        private System.Windows.Forms.Label dob_label;
        private System.Windows.Forms.Label postal_label;
        private System.Windows.Forms.TextBox postal_input;
        private System.Windows.Forms.Label country_label;
        private System.Windows.Forms.TextBox country_input;
        private System.Windows.Forms.Label province_label;
        private System.Windows.Forms.TextBox province_input;
        private System.Windows.Forms.Label city_label;
        private System.Windows.Forms.TextBox city_input;
        private System.Windows.Forms.Label street_label;
        private System.Windows.Forms.TextBox street_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label last_name_label;
        private System.Windows.Forms.TextBox last_name_input;
        private System.Windows.Forms.Label first_name_label;
        private System.Windows.Forms.TextBox first_name_input;
        private System.Windows.Forms.Label personal_label;
        private System.Windows.Forms.Splitter splitter1;
    }
}