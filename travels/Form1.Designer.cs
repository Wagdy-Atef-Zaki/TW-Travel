namespace travels
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empjopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emppasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empworkhoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empvacationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empsalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empidcardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empgenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empadressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empqualificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empstatueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelDataSet9 = new travels.travelDataSet9();
            this.employeeTBTableAdapter = new travels.travelDataSet9TableAdapters.EmployeeTBTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empnameDataGridViewTextBoxColumn,
            this.empjopDataGridViewTextBoxColumn,
            this.emppasswordDataGridViewTextBoxColumn,
            this.empworkhoursDataGridViewTextBoxColumn,
            this.empvacationsDataGridViewTextBoxColumn,
            this.empsalaryDataGridViewTextBoxColumn,
            this.empidcardDataGridViewTextBoxColumn,
            this.empgenderDataGridViewTextBoxColumn,
            this.empadressDataGridViewTextBoxColumn,
            this.empphoneDataGridViewTextBoxColumn,
            this.empageDataGridViewTextBoxColumn,
            this.empqualificationDataGridViewTextBoxColumn,
            this.empstatueDataGridViewTextBoxColumn,
            this.empemailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeTBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // empnameDataGridViewTextBoxColumn
            // 
            this.empnameDataGridViewTextBoxColumn.DataPropertyName = "emp_name";
            this.empnameDataGridViewTextBoxColumn.HeaderText = "Employee name";
            this.empnameDataGridViewTextBoxColumn.Name = "empnameDataGridViewTextBoxColumn";
            // 
            // empjopDataGridViewTextBoxColumn
            // 
            this.empjopDataGridViewTextBoxColumn.DataPropertyName = "emp_jop";
            this.empjopDataGridViewTextBoxColumn.HeaderText = "Jop";
            this.empjopDataGridViewTextBoxColumn.Name = "empjopDataGridViewTextBoxColumn";
            // 
            // emppasswordDataGridViewTextBoxColumn
            // 
            this.emppasswordDataGridViewTextBoxColumn.DataPropertyName = "emp_password";
            this.emppasswordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.emppasswordDataGridViewTextBoxColumn.Name = "emppasswordDataGridViewTextBoxColumn";
            // 
            // empworkhoursDataGridViewTextBoxColumn
            // 
            this.empworkhoursDataGridViewTextBoxColumn.DataPropertyName = "emp_workhours";
            this.empworkhoursDataGridViewTextBoxColumn.HeaderText = "Workhours";
            this.empworkhoursDataGridViewTextBoxColumn.Name = "empworkhoursDataGridViewTextBoxColumn";
            // 
            // empvacationsDataGridViewTextBoxColumn
            // 
            this.empvacationsDataGridViewTextBoxColumn.DataPropertyName = "emp_vacations";
            this.empvacationsDataGridViewTextBoxColumn.HeaderText = "Vacations";
            this.empvacationsDataGridViewTextBoxColumn.Name = "empvacationsDataGridViewTextBoxColumn";
            // 
            // empsalaryDataGridViewTextBoxColumn
            // 
            this.empsalaryDataGridViewTextBoxColumn.DataPropertyName = "emp_salary";
            this.empsalaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.empsalaryDataGridViewTextBoxColumn.Name = "empsalaryDataGridViewTextBoxColumn";
            // 
            // empidcardDataGridViewTextBoxColumn
            // 
            this.empidcardDataGridViewTextBoxColumn.DataPropertyName = "emp_idcard";
            this.empidcardDataGridViewTextBoxColumn.HeaderText = "Idcard";
            this.empidcardDataGridViewTextBoxColumn.Name = "empidcardDataGridViewTextBoxColumn";
            // 
            // empgenderDataGridViewTextBoxColumn
            // 
            this.empgenderDataGridViewTextBoxColumn.DataPropertyName = "emp_gender";
            this.empgenderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.empgenderDataGridViewTextBoxColumn.Name = "empgenderDataGridViewTextBoxColumn";
            // 
            // empadressDataGridViewTextBoxColumn
            // 
            this.empadressDataGridViewTextBoxColumn.DataPropertyName = "emp_adress";
            this.empadressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.empadressDataGridViewTextBoxColumn.Name = "empadressDataGridViewTextBoxColumn";
            // 
            // empphoneDataGridViewTextBoxColumn
            // 
            this.empphoneDataGridViewTextBoxColumn.DataPropertyName = "emp_phone";
            this.empphoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.empphoneDataGridViewTextBoxColumn.Name = "empphoneDataGridViewTextBoxColumn";
            // 
            // empageDataGridViewTextBoxColumn
            // 
            this.empageDataGridViewTextBoxColumn.DataPropertyName = "emp_age";
            this.empageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.empageDataGridViewTextBoxColumn.Name = "empageDataGridViewTextBoxColumn";
            // 
            // empqualificationDataGridViewTextBoxColumn
            // 
            this.empqualificationDataGridViewTextBoxColumn.DataPropertyName = "emp_qualification";
            this.empqualificationDataGridViewTextBoxColumn.HeaderText = "Qualification";
            this.empqualificationDataGridViewTextBoxColumn.Name = "empqualificationDataGridViewTextBoxColumn";
            // 
            // empstatueDataGridViewTextBoxColumn
            // 
            this.empstatueDataGridViewTextBoxColumn.DataPropertyName = "emp_statue";
            this.empstatueDataGridViewTextBoxColumn.HeaderText = "Statue";
            this.empstatueDataGridViewTextBoxColumn.Name = "empstatueDataGridViewTextBoxColumn";
            // 
            // empemailDataGridViewTextBoxColumn
            // 
            this.empemailDataGridViewTextBoxColumn.DataPropertyName = "emp_email";
            this.empemailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.empemailDataGridViewTextBoxColumn.Name = "empemailDataGridViewTextBoxColumn";
            // 
            // employeeTBBindingSource
            // 
            this.employeeTBBindingSource.DataMember = "EmployeeTB";
            this.employeeTBBindingSource.DataSource = this.travelDataSet9;
            // 
            // travelDataSet9
            // 
            this.travelDataSet9.DataSetName = "travelDataSet9";
            this.travelDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTBTableAdapter
            // 
            this.employeeTBTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::travels.Properties.Resources.HD_Wallpaper__209_;
            this.pictureBox1.Location = new System.Drawing.Point(2, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(736, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 443);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Employee";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private travelDataSet9 travelDataSet9;
        private System.Windows.Forms.BindingSource employeeTBBindingSource;
        private travelDataSet9TableAdapters.EmployeeTBTableAdapter employeeTBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empjopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emppasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empworkhoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empvacationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empsalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidcardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empgenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empadressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empqualificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empstatueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}