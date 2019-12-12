namespace travels
{
    partial class allcust
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
            this.custnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custcountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custadressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custsortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custidcardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelDataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelDataSet11 = new travels.travelDataSet11();
            this.customerTBTableAdapter = new travels.travelDataSet11TableAdapters.CustomerTBTableAdapter();
            this.transportToolsTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportToolsTBTableAdapter = new travels.travelDataSet11TableAdapters.TransportToolsTBTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportToolsTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custnameDataGridViewTextBoxColumn,
            this.custcountryDataGridViewTextBoxColumn,
            this.custadressDataGridViewTextBoxColumn,
            this.custsortDataGridViewTextBoxColumn,
            this.custidcardDataGridViewTextBoxColumn,
            this.custphoneDataGridViewTextBoxColumn,
            this.custemailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerTBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // custnameDataGridViewTextBoxColumn
            // 
            this.custnameDataGridViewTextBoxColumn.DataPropertyName = "cust_name";
            this.custnameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.custnameDataGridViewTextBoxColumn.Name = "custnameDataGridViewTextBoxColumn";
            // 
            // custcountryDataGridViewTextBoxColumn
            // 
            this.custcountryDataGridViewTextBoxColumn.DataPropertyName = "cust_country";
            this.custcountryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.custcountryDataGridViewTextBoxColumn.Name = "custcountryDataGridViewTextBoxColumn";
            // 
            // custadressDataGridViewTextBoxColumn
            // 
            this.custadressDataGridViewTextBoxColumn.DataPropertyName = "cust_adress";
            this.custadressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.custadressDataGridViewTextBoxColumn.Name = "custadressDataGridViewTextBoxColumn";
            // 
            // custsortDataGridViewTextBoxColumn
            // 
            this.custsortDataGridViewTextBoxColumn.DataPropertyName = "cust_sort";
            this.custsortDataGridViewTextBoxColumn.HeaderText = "Sort";
            this.custsortDataGridViewTextBoxColumn.Name = "custsortDataGridViewTextBoxColumn";
            // 
            // custidcardDataGridViewTextBoxColumn
            // 
            this.custidcardDataGridViewTextBoxColumn.DataPropertyName = "cust_idcard";
            this.custidcardDataGridViewTextBoxColumn.HeaderText = "Idcard";
            this.custidcardDataGridViewTextBoxColumn.Name = "custidcardDataGridViewTextBoxColumn";
            // 
            // custphoneDataGridViewTextBoxColumn
            // 
            this.custphoneDataGridViewTextBoxColumn.DataPropertyName = "cust_phone";
            this.custphoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.custphoneDataGridViewTextBoxColumn.Name = "custphoneDataGridViewTextBoxColumn";
            // 
            // custemailDataGridViewTextBoxColumn
            // 
            this.custemailDataGridViewTextBoxColumn.DataPropertyName = "cust_email";
            this.custemailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.custemailDataGridViewTextBoxColumn.Name = "custemailDataGridViewTextBoxColumn";
            // 
            // customerTBBindingSource
            // 
            this.customerTBBindingSource.DataMember = "CustomerTB";
            this.customerTBBindingSource.DataSource = this.travelDataSet11BindingSource;
            // 
            // travelDataSet11BindingSource
            // 
            this.travelDataSet11BindingSource.DataSource = this.travelDataSet11;
            this.travelDataSet11BindingSource.Position = 0;
            // 
            // travelDataSet11
            // 
            this.travelDataSet11.DataSetName = "travelDataSet11";
            this.travelDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTBTableAdapter
            // 
            this.customerTBTableAdapter.ClearBeforeFill = true;
            // 
            // transportToolsTBBindingSource
            // 
            this.transportToolsTBBindingSource.DataMember = "TransportToolsTB";
            this.transportToolsTBBindingSource.DataSource = this.travelDataSet11BindingSource;
            // 
            // transportToolsTBTableAdapter
            // 
            this.transportToolsTBTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::travels.Properties.Resources.HD_Wallpaper__209_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(744, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // allcust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 445);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "allcust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Customer";
            this.Load += new System.EventHandler(this.allcust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportToolsTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource travelDataSet11BindingSource;
        private travelDataSet11 travelDataSet11;
        private System.Windows.Forms.BindingSource customerTBBindingSource;
        private travelDataSet11TableAdapters.CustomerTBTableAdapter customerTBTableAdapter;
        private System.Windows.Forms.BindingSource transportToolsTBBindingSource;
        private travelDataSet11TableAdapters.TransportToolsTBTableAdapter transportToolsTBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn custnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custcountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custadressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custsortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custidcardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}