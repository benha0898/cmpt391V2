namespace WindowForm.Add
{
    partial class Student
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
            this.add_student_label = new System.Windows.Forms.Label();
            this.personal_label = new System.Windows.Forms.Label();
            this.first_name_input = new System.Windows.Forms.TextBox();
            this.first_name_label = new System.Windows.Forms.Label();
            this.last_name_label = new System.Windows.Forms.Label();
            this.last_name_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.city_label = new System.Windows.Forms.Label();
            this.city_input = new System.Windows.Forms.TextBox();
            this.street_label = new System.Windows.Forms.Label();
            this.street_input = new System.Windows.Forms.TextBox();
            this.country_label = new System.Windows.Forms.Label();
            this.country_input = new System.Windows.Forms.TextBox();
            this.province_label = new System.Windows.Forms.Label();
            this.province_input = new System.Windows.Forms.TextBox();
            this.postal_label = new System.Windows.Forms.Label();
            this.postal_input = new System.Windows.Forms.TextBox();
            this.dob_label = new System.Windows.Forms.Label();
            this.dob_datetime = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.credits_input = new System.Windows.Forms.NumericUpDown();
            this.credits_label = new System.Windows.Forms.Label();
            this.major_input = new System.Windows.Forms.ComboBox();
            this.major_label = new System.Windows.Forms.Label();
            this.submit_button = new System.Windows.Forms.Button();
            this.major_checkbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.credits_input)).BeginInit();
            this.SuspendLayout();
            // 
            // add_student_label
            // 
            this.add_student_label.AutoSize = true;
            this.add_student_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_student_label.Location = new System.Drawing.Point(12, 9);
            this.add_student_label.Name = "add_student_label";
            this.add_student_label.Size = new System.Drawing.Size(173, 33);
            this.add_student_label.TabIndex = 0;
            this.add_student_label.Text = "Add Student";
            // 
            // personal_label
            // 
            this.personal_label.AutoSize = true;
            this.personal_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personal_label.Location = new System.Drawing.Point(14, 75);
            this.personal_label.Name = "personal_label";
            this.personal_label.Size = new System.Drawing.Size(140, 20);
            this.personal_label.TabIndex = 1;
            this.personal_label.Text = "Personal Details";
            // 
            // first_name_input
            // 
            this.first_name_input.Location = new System.Drawing.Point(18, 122);
            this.first_name_input.Name = "first_name_input";
            this.first_name_input.Size = new System.Drawing.Size(100, 20);
            this.first_name_input.TabIndex = 2;
            // 
            // first_name_label
            // 
            this.first_name_label.AutoSize = true;
            this.first_name_label.Location = new System.Drawing.Point(15, 106);
            this.first_name_label.Name = "first_name_label";
            this.first_name_label.Size = new System.Drawing.Size(57, 13);
            this.first_name_label.TabIndex = 3;
            this.first_name_label.Text = "First Name";
            // 
            // last_name_label
            // 
            this.last_name_label.AutoSize = true;
            this.last_name_label.Location = new System.Drawing.Point(138, 106);
            this.last_name_label.Name = "last_name_label";
            this.last_name_label.Size = new System.Drawing.Size(58, 13);
            this.last_name_label.TabIndex = 5;
            this.last_name_label.Text = "Last Name";
            // 
            // last_name_input
            // 
            this.last_name_input.Location = new System.Drawing.Point(141, 122);
            this.last_name_input.Name = "last_name_input";
            this.last_name_input.Size = new System.Drawing.Size(100, 20);
            this.last_name_input.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // city_label
            // 
            this.city_label.AutoSize = true;
            this.city_label.Location = new System.Drawing.Point(138, 201);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(24, 13);
            this.city_label.TabIndex = 10;
            this.city_label.Text = "City";
            // 
            // city_input
            // 
            this.city_input.Location = new System.Drawing.Point(141, 217);
            this.city_input.Name = "city_input";
            this.city_input.Size = new System.Drawing.Size(100, 20);
            this.city_input.TabIndex = 9;
            this.city_input.Text = "Edmonton";
            // 
            // street_label
            // 
            this.street_label.AutoSize = true;
            this.street_label.Location = new System.Drawing.Point(15, 201);
            this.street_label.Name = "street_label";
            this.street_label.Size = new System.Drawing.Size(35, 13);
            this.street_label.TabIndex = 8;
            this.street_label.Text = "Street";
            // 
            // street_input
            // 
            this.street_input.Location = new System.Drawing.Point(18, 217);
            this.street_input.Name = "street_input";
            this.street_input.Size = new System.Drawing.Size(100, 20);
            this.street_input.TabIndex = 7;
            // 
            // country_label
            // 
            this.country_label.AutoSize = true;
            this.country_label.Location = new System.Drawing.Point(380, 201);
            this.country_label.Name = "country_label";
            this.country_label.Size = new System.Drawing.Size(43, 13);
            this.country_label.TabIndex = 14;
            this.country_label.Text = "Country";
            // 
            // country_input
            // 
            this.country_input.Location = new System.Drawing.Point(383, 217);
            this.country_input.Name = "country_input";
            this.country_input.Size = new System.Drawing.Size(100, 20);
            this.country_input.TabIndex = 13;
            this.country_input.Text = "Canada";
            // 
            // province_label
            // 
            this.province_label.AutoSize = true;
            this.province_label.Location = new System.Drawing.Point(257, 201);
            this.province_label.Name = "province_label";
            this.province_label.Size = new System.Drawing.Size(49, 13);
            this.province_label.TabIndex = 12;
            this.province_label.Text = "Province";
            // 
            // province_input
            // 
            this.province_input.Location = new System.Drawing.Point(260, 217);
            this.province_input.Name = "province_input";
            this.province_input.Size = new System.Drawing.Size(100, 20);
            this.province_input.TabIndex = 11;
            this.province_input.Text = "Alberta";
            // 
            // postal_label
            // 
            this.postal_label.AutoSize = true;
            this.postal_label.Location = new System.Drawing.Point(501, 201);
            this.postal_label.Name = "postal_label";
            this.postal_label.Size = new System.Drawing.Size(64, 13);
            this.postal_label.TabIndex = 16;
            this.postal_label.Text = "Postal Code";
            // 
            // postal_input
            // 
            this.postal_input.Location = new System.Drawing.Point(504, 217);
            this.postal_input.Name = "postal_input";
            this.postal_input.Size = new System.Drawing.Size(100, 20);
            this.postal_input.TabIndex = 15;
            // 
            // dob_label
            // 
            this.dob_label.AutoSize = true;
            this.dob_label.Location = new System.Drawing.Point(257, 106);
            this.dob_label.Name = "dob_label";
            this.dob_label.Size = new System.Drawing.Size(66, 13);
            this.dob_label.TabIndex = 17;
            this.dob_label.Text = "Date of Birth";
            // 
            // dob_datetime
            // 
            this.dob_datetime.Location = new System.Drawing.Point(260, 122);
            this.dob_datetime.Name = "dob_datetime";
            this.dob_datetime.Size = new System.Drawing.Size(121, 20);
            this.dob_datetime.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Other";
            // 
            // credits_input
            // 
            this.credits_input.Location = new System.Drawing.Point(18, 325);
            this.credits_input.Name = "credits_input";
            this.credits_input.Size = new System.Drawing.Size(100, 20);
            this.credits_input.TabIndex = 20;
            // 
            // credits_label
            // 
            this.credits_label.AutoSize = true;
            this.credits_label.Location = new System.Drawing.Point(15, 309);
            this.credits_label.Name = "credits_label";
            this.credits_label.Size = new System.Drawing.Size(66, 13);
            this.credits_label.TabIndex = 21;
            this.credits_label.Text = "Total Credits";
            // 
            // major_input
            // 
            this.major_input.FormattingEnabled = true;
            this.major_input.Location = new System.Drawing.Point(141, 325);
            this.major_input.Name = "major_input";
            this.major_input.Size = new System.Drawing.Size(121, 21);
            this.major_input.TabIndex = 22;
            // 
            // major_label
            // 
            this.major_label.AutoSize = true;
            this.major_label.Location = new System.Drawing.Point(138, 309);
            this.major_label.Name = "major_label";
            this.major_label.Size = new System.Drawing.Size(33, 13);
            this.major_label.TabIndex = 23;
            this.major_label.Text = "Major";
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(18, 403);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(110, 32);
            this.submit_button.TabIndex = 24;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            // 
            // major_checkbox
            // 
            this.major_checkbox.AutoCheck = false;
            this.major_checkbox.AutoSize = true;
            this.major_checkbox.Location = new System.Drawing.Point(141, 353);
            this.major_checkbox.Name = "major_checkbox";
            this.major_checkbox.Size = new System.Drawing.Size(81, 17);
            this.major_checkbox.TabIndex = 25;
            this.major_checkbox.Text = "Undeclared";
            this.major_checkbox.UseVisualStyleBackColor = true;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 473);
            this.Controls.Add(this.major_checkbox);
            this.Controls.Add(this.submit_button);
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
            this.Controls.Add(this.add_student_label);
            this.Name = "Student";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.credits_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label add_student_label;
        private System.Windows.Forms.Label personal_label;
        private System.Windows.Forms.TextBox first_name_input;
        private System.Windows.Forms.Label first_name_label;
        private System.Windows.Forms.Label last_name_label;
        private System.Windows.Forms.TextBox last_name_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label city_label;
        private System.Windows.Forms.TextBox city_input;
        private System.Windows.Forms.Label street_label;
        private System.Windows.Forms.TextBox street_input;
        private System.Windows.Forms.Label country_label;
        private System.Windows.Forms.TextBox country_input;
        private System.Windows.Forms.Label province_label;
        private System.Windows.Forms.TextBox province_input;
        private System.Windows.Forms.Label postal_label;
        private System.Windows.Forms.TextBox postal_input;
        private System.Windows.Forms.Label dob_label;
        private System.Windows.Forms.DateTimePicker dob_datetime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown credits_input;
        private System.Windows.Forms.Label credits_label;
        private System.Windows.Forms.ComboBox major_input;
        private System.Windows.Forms.Label major_label;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.CheckBox major_checkbox;
    }
}