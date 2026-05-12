namespace QLSinhVien
{
    partial class FormMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.lblCountCourseRegistrations = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCountStudents = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCountSubjects = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCountClasses = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabClasses = new System.Windows.Forms.TabPage();
            this.tabSubjects = new System.Windows.Forms.TabPage();
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.tabCourseRegistration = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.dgvCourseRegistration = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.tabStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.tabCourseRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseRegistration)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabDashboard);
            this.tabControl1.Controls.Add(this.tabClasses);
            this.tabControl1.Controls.Add(this.tabSubjects);
            this.tabControl1.Controls.Add(this.tabStudents);
            this.tabControl1.Controls.Add(this.tabCourseRegistration);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(30, 5);
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1571, 782);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.lblCountCourseRegistrations);
            this.tabDashboard.Controls.Add(this.label6);
            this.tabDashboard.Controls.Add(this.lblCountStudents);
            this.tabDashboard.Controls.Add(this.label4);
            this.tabDashboard.Controls.Add(this.lblCountSubjects);
            this.tabDashboard.Controls.Add(this.label2);
            this.tabDashboard.Controls.Add(this.lblCountClasses);
            this.tabDashboard.Controls.Add(this.label1);
            this.tabDashboard.Location = new System.Drawing.Point(4, 4);
            this.tabDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Size = new System.Drawing.Size(1563, 736);
            this.tabDashboard.TabIndex = 4;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // lblCountCourseRegistrations
            // 
            this.lblCountCourseRegistrations.AutoSize = true;
            this.lblCountCourseRegistrations.Location = new System.Drawing.Point(515, 326);
            this.lblCountCourseRegistrations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountCourseRegistrations.Name = "lblCountCourseRegistrations";
            this.lblCountCourseRegistrations.Size = new System.Drawing.Size(321, 29);
            this.lblCountCourseRegistrations.TabIndex = 0;
            this.lblCountCourseRegistrations.Text = "lblCountCourseRegistrations";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 326);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(381, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng số sinh viên đăng ký học tập:";
            // 
            // lblCountStudents
            // 
            this.lblCountStudents.AutoSize = true;
            this.lblCountStudents.Location = new System.Drawing.Point(329, 249);
            this.lblCountStudents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountStudents.Name = "lblCountStudents";
            this.lblCountStudents.Size = new System.Drawing.Size(196, 29);
            this.lblCountStudents.TabIndex = 0;
            this.lblCountStudents.Text = "lblCountStudents";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng số sinh viên:";
            // 
            // lblCountSubjects
            // 
            this.lblCountSubjects.AutoSize = true;
            this.lblCountSubjects.Location = new System.Drawing.Point(329, 181);
            this.lblCountSubjects.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountSubjects.Name = "lblCountSubjects";
            this.lblCountSubjects.Size = new System.Drawing.Size(195, 29);
            this.lblCountSubjects.TabIndex = 0;
            this.lblCountSubjects.Text = "lblCountSubjects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng số môn học:";
            // 
            // lblCountClasses
            // 
            this.lblCountClasses.AutoSize = true;
            this.lblCountClasses.Location = new System.Drawing.Point(313, 108);
            this.lblCountClasses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountClasses.Name = "lblCountClasses";
            this.lblCountClasses.Size = new System.Drawing.Size(188, 29);
            this.lblCountClasses.TabIndex = 0;
            this.lblCountClasses.Text = "lblCountClasses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng số lớp học:";
            // 
            // tabClasses
            // 
            this.tabClasses.Location = new System.Drawing.Point(4, 4);
            this.tabClasses.Margin = new System.Windows.Forms.Padding(4);
            this.tabClasses.Name = "tabClasses";
            this.tabClasses.Padding = new System.Windows.Forms.Padding(4);
            this.tabClasses.Size = new System.Drawing.Size(1563, 736);
            this.tabClasses.TabIndex = 0;
            this.tabClasses.Text = "Quản lý Lớp học";
            this.tabClasses.UseVisualStyleBackColor = true;
            // 
            // tabSubjects
            // 
            this.tabSubjects.Location = new System.Drawing.Point(4, 4);
            this.tabSubjects.Margin = new System.Windows.Forms.Padding(4);
            this.tabSubjects.Name = "tabSubjects";
            this.tabSubjects.Padding = new System.Windows.Forms.Padding(4);
            this.tabSubjects.Size = new System.Drawing.Size(1563, 736);
            this.tabSubjects.TabIndex = 1;
            this.tabSubjects.Text = "Quản lý Môn học";
            this.tabSubjects.UseVisualStyleBackColor = true;
            // 
            // tabStudents
            // 
            this.tabStudents.Controls.Add(this.button4);
            this.tabStudents.Controls.Add(this.button5);
            this.tabStudents.Controls.Add(this.button6);
            this.tabStudents.Controls.Add(this.label11);
            this.tabStudents.Controls.Add(this.label12);
            this.tabStudents.Controls.Add(this.label13);
            this.tabStudents.Controls.Add(this.textBox4);
            this.tabStudents.Controls.Add(this.textBox5);
            this.tabStudents.Controls.Add(this.textBox6);
            this.tabStudents.Controls.Add(this.dgvStudents);
            this.tabStudents.Location = new System.Drawing.Point(4, 4);
            this.tabStudents.Margin = new System.Windows.Forms.Padding(4);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Padding = new System.Windows.Forms.Padding(4);
            this.tabStudents.Size = new System.Drawing.Size(1563, 736);
            this.tabStudents.TabIndex = 2;
            this.tabStudents.Text = "Quản lý Hồ sơ SV";
            this.tabStudents.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(875, 102);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 42);
            this.button4.TabIndex = 11;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(697, 102);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 42);
            this.button5.TabIndex = 12;
            this.button5.Text = "Sửa";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(521, 102);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 42);
            this.button6.TabIndex = 13;
            this.button6.Text = "Thêm";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(979, 39);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 29);
            this.label11.TabIndex = 8;
            this.label11.Text = "Khoa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(565, 39);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 29);
            this.label12.TabIndex = 9;
            this.label12.Text = "Tên lớp";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(259, 37);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 29);
            this.label13.TabIndex = 10;
            this.label13.Text = "Mã lớp";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1059, 33);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(253, 34);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(673, 33);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(265, 34);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(356, 33);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(161, 34);
            this.textBox6.TabIndex = 7;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AllowUserToOrderColumns = true;
            this.dgvStudents.AllowUserToResizeRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStudents.Location = new System.Drawing.Point(4, 231);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(1555, 501);
            this.dgvStudents.TabIndex = 2;
            // 
            // tabCourseRegistration
            // 
            this.tabCourseRegistration.Controls.Add(this.button7);
            this.tabCourseRegistration.Controls.Add(this.button8);
            this.tabCourseRegistration.Controls.Add(this.button9);
            this.tabCourseRegistration.Controls.Add(this.label14);
            this.tabCourseRegistration.Controls.Add(this.label15);
            this.tabCourseRegistration.Controls.Add(this.label16);
            this.tabCourseRegistration.Controls.Add(this.textBox7);
            this.tabCourseRegistration.Controls.Add(this.textBox8);
            this.tabCourseRegistration.Controls.Add(this.textBox9);
            this.tabCourseRegistration.Controls.Add(this.dgvCourseRegistration);
            this.tabCourseRegistration.Location = new System.Drawing.Point(4, 4);
            this.tabCourseRegistration.Margin = new System.Windows.Forms.Padding(4);
            this.tabCourseRegistration.Name = "tabCourseRegistration";
            this.tabCourseRegistration.Padding = new System.Windows.Forms.Padding(4);
            this.tabCourseRegistration.Size = new System.Drawing.Size(1563, 736);
            this.tabCourseRegistration.TabIndex = 3;
            this.tabCourseRegistration.Text = "Quản lý Môn đky MH";
            this.tabCourseRegistration.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(875, 100);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(140, 42);
            this.button7.TabIndex = 11;
            this.button7.Text = "Xóa";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(697, 100);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 42);
            this.button8.TabIndex = 12;
            this.button8.Text = "Sửa";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(521, 100);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(140, 42);
            this.button9.TabIndex = 13;
            this.button9.Text = "Thêm";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(979, 37);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 29);
            this.label14.TabIndex = 8;
            this.label14.Text = "Khoa";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(565, 37);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 29);
            this.label15.TabIndex = 9;
            this.label15.Text = "Tên lớp";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(259, 34);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 29);
            this.label16.TabIndex = 10;
            this.label16.Text = "Mã lớp";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1059, 31);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(253, 34);
            this.textBox7.TabIndex = 5;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(673, 31);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(265, 34);
            this.textBox8.TabIndex = 6;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(356, 31);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(161, 34);
            this.textBox9.TabIndex = 7;
            // 
            // dgvCourseRegistration
            // 
            this.dgvCourseRegistration.AllowUserToAddRows = false;
            this.dgvCourseRegistration.AllowUserToDeleteRows = false;
            this.dgvCourseRegistration.AllowUserToOrderColumns = true;
            this.dgvCourseRegistration.AllowUserToResizeRows = false;
            this.dgvCourseRegistration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourseRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseRegistration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCourseRegistration.Location = new System.Drawing.Point(4, 231);
            this.dgvCourseRegistration.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCourseRegistration.Name = "dgvCourseRegistration";
            this.dgvCourseRegistration.ReadOnly = true;
            this.dgvCourseRegistration.RowHeadersVisible = false;
            this.dgvCourseRegistration.RowHeadersWidth = 51;
            this.dgvCourseRegistration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourseRegistration.Size = new System.Drawing.Size(1555, 501);
            this.dgvCourseRegistration.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 782);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1589, 829);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1589, 829);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý sinh viên";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.tabDashboard.PerformLayout();
            this.tabStudents.ResumeLayout(false);
            this.tabStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.tabCourseRegistration.ResumeLayout(false);
            this.tabCourseRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseRegistration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSubjects;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.TabPage tabCourseRegistration;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.Label lblCountCourseRegistrations;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCountStudents;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCountSubjects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCountClasses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridView dgvCourseRegistration;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TabPage tabClasses;
    }
}

