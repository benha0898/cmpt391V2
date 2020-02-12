namespace WindowForm.Modify
{
    partial class ModifyDepartment
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
            this.dept_label = new System.Windows.Forms.Label();
            this.dept_input = new System.Windows.Forms.ComboBox();
            this.sucess_label = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.search_label = new System.Windows.Forms.Label();
            this.modify_dept_label = new System.Windows.Forms.Label();
            this.building_input = new System.Windows.Forms.NumericUpDown();
            this.dept_name_label = new System.Windows.Forms.Label();
            this.dept_name_input = new System.Windows.Forms.TextBox();
            this.building_label = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dept_details_label = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.building_input)).BeginInit();
            this.SuspendLayout();
            // 
            // dept_label
            // 
            this.dept_label.AutoSize = true;
            this.dept_label.Location = new System.Drawing.Point(15, 120);
            this.dept_label.Name = "dept_label";
            this.dept_label.Size = new System.Drawing.Size(62, 13);
            this.dept_label.TabIndex = 132;
            this.dept_label.Text = "Department";
            // 
            // dept_input
            // 
            this.dept_input.FormattingEnabled = true;
            this.dept_input.Location = new System.Drawing.Point(18, 136);
            this.dept_input.Name = "dept_input";
            this.dept_input.Size = new System.Drawing.Size(149, 21);
            this.dept_input.TabIndex = 131;
            // 
            // sucess_label
            // 
            this.sucess_label.AutoSize = true;
            this.sucess_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucess_label.Location = new System.Drawing.Point(13, 416);
            this.sucess_label.Name = "sucess_label";
            this.sucess_label.Size = new System.Drawing.Size(222, 25);
            this.sucess_label.TabIndex = 129;
            this.sucess_label.Text = "Department Updated: ";
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(18, 183);
            this.search_button.Margin = new System.Windows.Forms.Padding(2);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(92, 27);
            this.search_button.TabIndex = 128;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_label.Location = new System.Drawing.Point(14, 87);
            this.search_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(66, 20);
            this.search_label.TabIndex = 127;
            this.search_label.Text = "Search";
            // 
            // modify_dept_label
            // 
            this.modify_dept_label.AutoSize = true;
            this.modify_dept_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_dept_label.Location = new System.Drawing.Point(3, 9);
            this.modify_dept_label.Name = "modify_dept_label";
            this.modify_dept_label.Size = new System.Drawing.Size(261, 33);
            this.modify_dept_label.TabIndex = 126;
            this.modify_dept_label.Text = "Modify Department";
            // 
            // building_input
            // 
            this.building_input.Location = new System.Drawing.Point(316, 190);
            this.building_input.Margin = new System.Windows.Forms.Padding(2);
            this.building_input.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.building_input.Name = "building_input";
            this.building_input.Size = new System.Drawing.Size(144, 20);
            this.building_input.TabIndex = 134;
            // 
            // dept_name_label
            // 
            this.dept_name_label.AutoSize = true;
            this.dept_name_label.Location = new System.Drawing.Point(312, 120);
            this.dept_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dept_name_label.Name = "dept_name_label";
            this.dept_name_label.Size = new System.Drawing.Size(93, 13);
            this.dept_name_label.TabIndex = 135;
            this.dept_name_label.Text = "Department Name";
            // 
            // dept_name_input
            // 
            this.dept_name_input.Location = new System.Drawing.Point(315, 135);
            this.dept_name_input.Margin = new System.Windows.Forms.Padding(2);
            this.dept_name_input.Name = "dept_name_input";
            this.dept_name_input.Size = new System.Drawing.Size(145, 20);
            this.dept_name_input.TabIndex = 133;
            // 
            // building_label
            // 
            this.building_label.AutoSize = true;
            this.building_label.Location = new System.Drawing.Point(312, 175);
            this.building_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.building_label.Name = "building_label";
            this.building_label.Size = new System.Drawing.Size(44, 13);
            this.building_label.TabIndex = 136;
            this.building_label.Text = "Building";
            this.building_label.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(272, 461);
            this.splitter1.TabIndex = 137;
            this.splitter1.TabStop = false;
            // 
            // dept_details_label
            // 
            this.dept_details_label.AutoSize = true;
            this.dept_details_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dept_details_label.Location = new System.Drawing.Point(311, 87);
            this.dept_details_label.Name = "dept_details_label";
            this.dept_details_label.Size = new System.Drawing.Size(165, 20);
            this.dept_details_label.TabIndex = 138;
            this.dept_details_label.Text = "Department Details";
            // 
            // delete_button
            // 
            this.delete_button.Enabled = false;
            this.delete_button.Location = new System.Drawing.Point(440, 253);
            this.delete_button.Margin = new System.Windows.Forms.Padding(2);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(103, 24);
            this.delete_button.TabIndex = 140;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // update_button
            // 
            this.update_button.Enabled = false;
            this.update_button.Location = new System.Drawing.Point(313, 253);
            this.update_button.Margin = new System.Windows.Forms.Padding(2);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(110, 24);
            this.update_button.TabIndex = 139;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            // 
            // ModifyDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 461);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.dept_details_label);
            this.Controls.Add(this.building_label);
            this.Controls.Add(this.building_input);
            this.Controls.Add(this.dept_name_label);
            this.Controls.Add(this.dept_name_input);
            this.Controls.Add(this.dept_label);
            this.Controls.Add(this.dept_input);
            this.Controls.Add(this.sucess_label);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_label);
            this.Controls.Add(this.modify_dept_label);
            this.Controls.Add(this.splitter1);
            this.Name = "ModifyDepartment";
            this.Text = "Modify Department";
            ((System.ComponentModel.ISupportInitialize)(this.building_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dept_label;
        private System.Windows.Forms.ComboBox dept_input;
        private System.Windows.Forms.Label sucess_label;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.Label modify_dept_label;
        private System.Windows.Forms.NumericUpDown building_input;
        private System.Windows.Forms.Label dept_name_label;
        private System.Windows.Forms.TextBox dept_name_input;
        private System.Windows.Forms.Label building_label;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label dept_details_label;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
    }
}