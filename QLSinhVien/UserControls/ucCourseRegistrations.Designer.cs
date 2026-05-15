using System;

namespace QLSinhVien.UserControls
{
    partial class ucCourseRegistrations
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvCourseRegistrations = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cboSubjects = new System.Windows.Forms.ComboBox();
            this.cboStudents = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseRegistrations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCourseRegistrations
            // 
            this.dgvCourseRegistrations.AllowUserToAddRows = false;
            this.dgvCourseRegistrations.AllowUserToDeleteRows = false;
            this.dgvCourseRegistrations.AllowUserToOrderColumns = true;
            this.dgvCourseRegistrations.AllowUserToResizeRows = false;
            this.dgvCourseRegistrations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourseRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseRegistrations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCourseRegistrations.Location = new System.Drawing.Point(0, 234);
            this.dgvCourseRegistrations.Name = "dgvCourseRegistrations";
            this.dgvCourseRegistrations.ReadOnly = true;
            this.dgvCourseRegistrations.RowHeadersVisible = false;
            this.dgvCourseRegistrations.RowHeadersWidth = 51;
            this.dgvCourseRegistrations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourseRegistrations.Size = new System.Drawing.Size(1280, 526);
            this.dgvCourseRegistrations.TabIndex = 2;
            this.dgvCourseRegistrations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourseRegistrations_CellClick);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1280, 50);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quản lý Đăng ký môn học";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(511, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Danh sách Môn học";
            // 
            // cboSubjects
            // 
            this.cboSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSubjects.FormattingEnabled = true;
            this.cboSubjects.Location = new System.Drawing.Point(517, 90);
            this.cboSubjects.Name = "cboSubjects";
            this.cboSubjects.Size = new System.Drawing.Size(276, 39);
            this.cboSubjects.TabIndex = 1;
            // 
            // cboStudents
            // 
            this.cboStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStudents.FormattingEnabled = true;
            this.cboStudents.Location = new System.Drawing.Point(161, 90);
            this.cboStudents.Name = "cboStudents";
            this.cboStudents.Size = new System.Drawing.Size(318, 39);
            this.cboStudents.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Danh sách Sinh viên";
            // 
            // dtpRegistrationDate
            // 
            this.dtpRegistrationDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRegistrationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegistrationDate.Location = new System.Drawing.Point(848, 87);
            this.dtpRegistrationDate.Name = "dtpRegistrationDate";
            this.dtpRegistrationDate.Size = new System.Drawing.Size(180, 38);
            this.dtpRegistrationDate.TabIndex = 15;
            this.dtpRegistrationDate.Value = new System.DateTime(1900, 10, 10, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(842, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ngày đăng ký";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCreate);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnSkip);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(183, 129);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(726, 62);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(10, 10);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(10);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(158, 44);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Đăng ký";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(188, 10);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 44);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(366, 10);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 44);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.Location = new System.Drawing.Point(544, 10);
            this.btnSkip.Margin = new System.Windows.Forms.Padding(10);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(158, 44);
            this.btnSkip.TabIndex = 7;
            this.btnSkip.Text = "Bỏ qua";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 31);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(122, 191);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(209, 37);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ucCourseRegistrations
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dtpRegistrationDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboStudents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSubjects);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvCourseRegistrations);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1280, 760);
            this.MinimumSize = new System.Drawing.Size(1280, 760);
            this.Name = "ucCourseRegistrations";
            this.Size = new System.Drawing.Size(1280, 760);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseRegistrations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCourseRegistrations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboStudents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSubjects;
        private System.Windows.Forms.DateTimePicker dtpRegistrationDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
