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
            this.tabClasses = new System.Windows.Forms.TabPage();
            this.tabSubjects = new System.Windows.Forms.TabPage();
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.tabCourseRegistration = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
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
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(30, 5);
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1180, 642);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Location = new System.Drawing.Point(4, 4);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Size = new System.Drawing.Size(1172, 601);
            this.tabDashboard.TabIndex = 4;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // tabClasses
            // 
            this.tabClasses.Location = new System.Drawing.Point(4, 4);
            this.tabClasses.Name = "tabClasses";
            this.tabClasses.Padding = new System.Windows.Forms.Padding(3);
            this.tabClasses.Size = new System.Drawing.Size(1172, 601);
            this.tabClasses.TabIndex = 0;
            this.tabClasses.Text = "Quản lý Lớp học";
            this.tabClasses.UseVisualStyleBackColor = true;
            // 
            // tabSubjects
            // 
            this.tabSubjects.Location = new System.Drawing.Point(4, 4);
            this.tabSubjects.Name = "tabSubjects";
            this.tabSubjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubjects.Size = new System.Drawing.Size(1172, 601);
            this.tabSubjects.TabIndex = 1;
            this.tabSubjects.Text = "Quản lý Môn học";
            this.tabSubjects.UseVisualStyleBackColor = true;
            // 
            // tabStudents
            // 
            this.tabStudents.Location = new System.Drawing.Point(4, 4);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudents.Size = new System.Drawing.Size(1172, 601);
            this.tabStudents.TabIndex = 2;
            this.tabStudents.Text = "Quản lý Hồ sơ SV";
            this.tabStudents.UseVisualStyleBackColor = true;
            // 
            // tabCourseRegistration
            // 
            this.tabCourseRegistration.Location = new System.Drawing.Point(4, 4);
            this.tabCourseRegistration.Name = "tabCourseRegistration";
            this.tabCourseRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tabCourseRegistration.Size = new System.Drawing.Size(1172, 601);
            this.tabCourseRegistration.TabIndex = 3;
            this.tabCourseRegistration.Text = "Quản lý Môn đky MH";
            this.tabCourseRegistration.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 642);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1196, 681);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1196, 681);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý sinh viên";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSubjects;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.TabPage tabCourseRegistration;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.TabPage tabClasses;
    }
}

