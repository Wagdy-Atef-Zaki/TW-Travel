namespace travels
{
    partial class alltool
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
            this.trantypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trantimetakingoffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trantimearrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trancostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trantripnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trantripsystemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trandirectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportToolsTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelDataSet7 = new travels.travelDataSet7();
            this.transportToolsTBTableAdapter = new travels.travelDataSet7TableAdapters.TransportToolsTBTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportToolsTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trantypeDataGridViewTextBoxColumn,
            this.trangradeDataGridViewTextBoxColumn,
            this.trantimetakingoffDataGridViewTextBoxColumn,
            this.trantimearrivalDataGridViewTextBoxColumn,
            this.trancostDataGridViewTextBoxColumn,
            this.trantripnumberDataGridViewTextBoxColumn,
            this.trantripsystemDataGridViewTextBoxColumn,
            this.trandirectionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transportToolsTBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 234);
            this.dataGridView1.TabIndex = 0;
            // 
            // trantypeDataGridViewTextBoxColumn
            // 
            this.trantypeDataGridViewTextBoxColumn.DataPropertyName = "tran_type";
            this.trantypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.trantypeDataGridViewTextBoxColumn.Name = "trantypeDataGridViewTextBoxColumn";
            // 
            // trangradeDataGridViewTextBoxColumn
            // 
            this.trangradeDataGridViewTextBoxColumn.DataPropertyName = "tran_grade";
            this.trangradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.trangradeDataGridViewTextBoxColumn.Name = "trangradeDataGridViewTextBoxColumn";
            // 
            // trantimetakingoffDataGridViewTextBoxColumn
            // 
            this.trantimetakingoffDataGridViewTextBoxColumn.DataPropertyName = "tran_timetakingoff";
            this.trantimetakingoffDataGridViewTextBoxColumn.HeaderText = "Date Takingoff";
            this.trantimetakingoffDataGridViewTextBoxColumn.Name = "trantimetakingoffDataGridViewTextBoxColumn";
            // 
            // trantimearrivalDataGridViewTextBoxColumn
            // 
            this.trantimearrivalDataGridViewTextBoxColumn.DataPropertyName = "tran_timearrival";
            this.trantimearrivalDataGridViewTextBoxColumn.HeaderText = "Date Arrival";
            this.trantimearrivalDataGridViewTextBoxColumn.Name = "trantimearrivalDataGridViewTextBoxColumn";
            // 
            // trancostDataGridViewTextBoxColumn
            // 
            this.trancostDataGridViewTextBoxColumn.DataPropertyName = "tran_cost";
            this.trancostDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.trancostDataGridViewTextBoxColumn.Name = "trancostDataGridViewTextBoxColumn";
            // 
            // trantripnumberDataGridViewTextBoxColumn
            // 
            this.trantripnumberDataGridViewTextBoxColumn.DataPropertyName = "tran_tripnumber";
            this.trantripnumberDataGridViewTextBoxColumn.HeaderText = "Tripnumber";
            this.trantripnumberDataGridViewTextBoxColumn.Name = "trantripnumberDataGridViewTextBoxColumn";
            // 
            // trantripsystemDataGridViewTextBoxColumn
            // 
            this.trantripsystemDataGridViewTextBoxColumn.DataPropertyName = "tran_tripsystem";
            this.trantripsystemDataGridViewTextBoxColumn.HeaderText = "Tripsystem";
            this.trantripsystemDataGridViewTextBoxColumn.Name = "trantripsystemDataGridViewTextBoxColumn";
            // 
            // trandirectionDataGridViewTextBoxColumn
            // 
            this.trandirectionDataGridViewTextBoxColumn.DataPropertyName = "tran_direction";
            this.trandirectionDataGridViewTextBoxColumn.HeaderText = "Direction";
            this.trandirectionDataGridViewTextBoxColumn.Name = "trandirectionDataGridViewTextBoxColumn";
            // 
            // transportToolsTBBindingSource
            // 
            this.transportToolsTBBindingSource.DataMember = "TransportToolsTB";
            this.transportToolsTBBindingSource.DataSource = this.travelDataSet7;
            // 
            // travelDataSet7
            // 
            this.travelDataSet7.DataSetName = "travelDataSet7";
            this.travelDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transportToolsTBTableAdapter
            // 
            this.transportToolsTBTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::travels.Properties.Resources.HD_Wallpaper__209_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // alltool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 437);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "alltool";
            this.Text = "All Transportation";
            this.Load += new System.EventHandler(this.alltool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportToolsTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private travelDataSet7 travelDataSet7;
        private System.Windows.Forms.BindingSource transportToolsTBBindingSource;
        private travelDataSet7TableAdapters.TransportToolsTBTableAdapter transportToolsTBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn trantypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trantimetakingoffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trantimearrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trancostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trantripnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trantripsystemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trandirectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}