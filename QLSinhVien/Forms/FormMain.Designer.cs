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
            this.components = new System.ComponentModel.Container();
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
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.btnEditClass = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.tabSubjects = new System.Windows.Forms.TabPage();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.tabCourseRegistration = new System.Windows.Forms.TabPage();
            this.dgvCourseRegistration = new System.Windows.Forms.DataGridView();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.tabClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.tabSubjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.tabStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.tabCourseRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 50);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(30, 5);
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1180, 593);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
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
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Size = new System.Drawing.Size(1172, 552);
            this.tabDashboard.TabIndex = 4;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // lblCountCourseRegistrations
            // 
            this.lblCountCourseRegistrations.AutoSize = true;
            this.lblCountCourseRegistrations.Location = new System.Drawing.Point(386, 265);
            this.lblCountCourseRegistrations.Name = "lblCountCourseRegistrations";
            this.lblCountCourseRegistrations.Size = new System.Drawing.Size(247, 24);
            this.lblCountCourseRegistrations.TabIndex = 0;
            this.lblCountCourseRegistrations.Text = "lblCountCourseRegistrations";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng số sinh viên đăng ký học tập:";
            // 
            // lblCountStudents
            // 
            this.lblCountStudents.AutoSize = true;
            this.lblCountStudents.Location = new System.Drawing.Point(247, 202);
            this.lblCountStudents.Name = "lblCountStudents";
            this.lblCountStudents.Size = new System.Drawing.Size(152, 24);
            this.lblCountStudents.TabIndex = 0;
            this.lblCountStudents.Text = "lblCountStudents";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng số sinh viên:";
            // 
            // lblCountSubjects
            // 
            this.lblCountSubjects.AutoSize = true;
            this.lblCountSubjects.Location = new System.Drawing.Point(247, 147);
            this.lblCountSubjects.Name = "lblCountSubjects";
            this.lblCountSubjects.Size = new System.Drawing.Size(151, 24);
            this.lblCountSubjects.TabIndex = 0;
            this.lblCountSubjects.Text = "lblCountSubjects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng số môn học:";
            // 
            // lblCountClasses
            // 
            this.lblCountClasses.AutoSize = true;
            this.lblCountClasses.Location = new System.Drawing.Point(235, 88);
            this.lblCountClasses.Name = "lblCountClasses";
            this.lblCountClasses.Size = new System.Drawing.Size(144, 24);
            this.lblCountClasses.TabIndex = 0;
            this.lblCountClasses.Text = "lblCountClasses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng số lớp học:";
            // 
            // tabClasses
            // 
            this.tabClasses.Controls.Add(this.btnDeleteClass);
            this.tabClasses.Controls.Add(this.btnEditClass);
            this.tabClasses.Controls.Add(this.btnAddClass);
            this.tabClasses.Controls.Add(this.label8);
            this.tabClasses.Controls.Add(this.label5);
            this.tabClasses.Controls.Add(this.label3);
            this.tabClasses.Controls.Add(this.txtDepartment);
            this.tabClasses.Controls.Add(this.txtClassName);
            this.tabClasses.Controls.Add(this.txtClassID);
            this.tabClasses.Controls.Add(this.dgvClasses);
            this.tabClasses.Location = new System.Drawing.Point(4, 4);
            this.tabClasses.Name = "tabClasses";
            this.tabClasses.Padding = new System.Windows.Forms.Padding(3);
            this.tabClasses.Size = new System.Drawing.Size(1172, 552);
            this.tabClasses.TabIndex = 0;
            this.tabClasses.Text = "Quản lý Lớp học";
            this.tabClasses.UseVisualStyleBackColor = true;
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Location = new System.Drawing.Point(641, 90);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(105, 34);
            this.btnDeleteClass.TabIndex = 4;
            this.btnDeleteClass.Text = "Xóa";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // btnEditClass
            // 
            this.btnEditClass.Location = new System.Drawing.Point(508, 90);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(105, 34);
            this.btnEditClass.TabIndex = 4;
            this.btnEditClass.Text = "Sửa";
            this.btnEditClass.UseVisualStyleBackColor = true;
            this.btnEditClass.Click += new System.EventHandler(this.btnEditClass_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(376, 90);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(105, 34);
            this.btnAddClass.TabIndex = 4;
            this.btnAddClass.Text = "Thêm";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(719, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Khoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã lớp";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(779, 34);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(191, 29);
            this.txtDepartment.TabIndex = 2;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(490, 34);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(200, 29);
            this.txtClassName.TabIndex = 2;
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(252, 34);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(122, 29);
            this.txtClassID.TabIndex = 2;
            // 
            // dgvClasses
            // 
            this.dgvClasses.AllowUserToAddRows = false;
            this.dgvClasses.AllowUserToDeleteRows = false;
            this.dgvClasses.AllowUserToOrderColumns = true;
            this.dgvClasses.AllowUserToResizeRows = false;
            this.dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvClasses.Location = new System.Drawing.Point(3, 142);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.ReadOnly = true;
            this.dgvClasses.RowHeadersVisible = false;
            this.dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasses.Size = new System.Drawing.Size(1166, 407);
            this.dgvClasses.TabIndex = 1;
            this.dgvClasses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasses_CellClick);
            // 
            // tabSubjects
            // 
            this.tabSubjects.Controls.Add(this.button1);
            this.tabSubjects.Controls.Add(this.button2);
            this.tabSubjects.Controls.Add(this.button3);
            this.tabSubjects.Controls.Add(this.label7);
            this.tabSubjects.Controls.Add(this.label9);
            this.tabSubjects.Controls.Add(this.label10);
            this.tabSubjects.Controls.Add(this.textBox1);
            this.tabSubjects.Controls.Add(this.textBox2);
            this.tabSubjects.Controls.Add(this.textBox3);
            this.tabSubjects.Controls.Add(this.dgvSubjects);
            this.tabSubjects.Location = new System.Drawing.Point(4, 4);
            this.tabSubjects.Name = "tabSubjects";
            this.tabSubjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubjects.Size = new System.Drawing.Size(1172, 552);
            this.tabSubjects.TabIndex = 1;
            this.tabSubjects.Text = "Quản lý Môn học";
            this.tabSubjects.UseVisualStyleBackColor = true;
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.AllowUserToDeleteRows = false;
            this.dgvSubjects.AllowUserToOrderColumns = true;
            this.dgvSubjects.AllowUserToResizeRows = false;
            this.dgvSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSubjects.Location = new System.Drawing.Point(3, 142);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.ReadOnly = true;
            this.dgvSubjects.RowHeadersVisible = false;
            this.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjects.Size = new System.Drawing.Size(1166, 407);
            this.dgvSubjects.TabIndex = 18;
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
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudents.Size = new System.Drawing.Size(1172, 552);
            this.tabStudents.TabIndex = 2;
            this.tabStudents.Text = "Quản lý Hồ sơ SV";
            this.tabStudents.UseVisualStyleBackColor = true;
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
            this.dgvStudents.Location = new System.Drawing.Point(3, 142);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(1166, 407);
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
            this.tabCourseRegistration.Name = "tabCourseRegistration";
            this.tabCourseRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tabCourseRegistration.Size = new System.Drawing.Size(1172, 552);
            this.tabCourseRegistration.TabIndex = 3;
            this.tabCourseRegistration.Text = "Quản lý Môn đky MH";
            this.tabCourseRegistration.UseVisualStyleBackColor = true;
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
            this.dgvCourseRegistration.Location = new System.Drawing.Point(3, 142);
            this.dgvCourseRegistration.Name = "dgvCourseRegistration";
            this.dgvCourseRegistration.ReadOnly = true;
            this.dgvCourseRegistration.RowHeadersVisible = false;
            this.dgvCourseRegistration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourseRegistration.Size = new System.Drawing.Size(1166, 407);
            this.dgvCourseRegistration.TabIndex = 2;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.Location = new System.Drawing.Point(0, 0);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(1180, 47);
            this.lblAppTitle.TabIndex = 1;
            this.lblAppTitle.Text = "lblAppTitle";
            this.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 34);
            this.button1.TabIndex = 25;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 34);
            this.button2.TabIndex = 26;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(374, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 34);
            this.button3.TabIndex = 27;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(717, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Khoa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tên lớp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "Mã lớp";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(777, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 29);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(488, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 29);
            this.textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(250, 27);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 29);
            this.textBox3.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(656, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 34);
            this.button4.TabIndex = 11;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(523, 83);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 34);
            this.button5.TabIndex = 12;
            this.button5.Text = "Sửa";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(391, 83);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 34);
            this.button6.TabIndex = 13;
            this.button6.Text = "Thêm";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(734, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 24);
            this.label11.TabIndex = 8;
            this.label11.Text = "Khoa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(424, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 24);
            this.label12.TabIndex = 9;
            this.label12.Text = "Tên lớp";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(194, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 24);
            this.label13.TabIndex = 10;
            this.label13.Text = "Mã lớp";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(794, 27);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 29);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(505, 27);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 29);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(267, 27);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(122, 29);
            this.textBox6.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(656, 81);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 34);
            this.button7.TabIndex = 11;
            this.button7.Text = "Xóa";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(523, 81);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(105, 34);
            this.button8.TabIndex = 12;
            this.button8.Text = "Sửa";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(391, 81);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(105, 34);
            this.button9.TabIndex = 13;
            this.button9.Text = "Thêm";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(734, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 24);
            this.label14.TabIndex = 8;
            this.label14.Text = "Khoa";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(424, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 24);
            this.label15.TabIndex = 9;
            this.label15.Text = "Tên lớp";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(194, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 24);
            this.label16.TabIndex = 10;
            this.label16.Text = "Mã lớp";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(794, 25);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(191, 29);
            this.textBox7.TabIndex = 5;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(505, 25);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(200, 29);
            this.textBox8.TabIndex = 6;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(267, 25);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(122, 29);
            this.textBox9.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 643);
            this.Controls.Add(this.lblAppTitle);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1196, 682);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1196, 682);
            this.Name = "FormMain";
            this.Text = "Quản Lý sinh viên";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.tabDashboard.PerformLayout();
            this.tabClasses.ResumeLayout(false);
            this.tabClasses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.tabSubjects.ResumeLayout(false);
            this.tabSubjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.tabStudents.ResumeLayout(false);
            this.tabStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.tabCourseRegistration.ResumeLayout(false);
            this.tabCourseRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseRegistration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabClasses;
        private System.Windows.Forms.TabPage tabSubjects;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.TabPage tabCourseRegistration;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.Label lblCountCourseRegistrations;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCountStudents;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCountSubjects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCountClasses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Button btnEditClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridView dgvCourseRegistration;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

