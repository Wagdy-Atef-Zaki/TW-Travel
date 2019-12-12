namespace travels
{
    partial class allprog
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
            this.prognameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progdaybeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progdayendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progprogrammsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progtravelernumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proghotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programmTravelTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelDataSet8 = new travels.travelDataSet8();
            this.programmTravelTBTableAdapter = new travels.travelDataSet8TableAdapters.ProgrammTravelTBTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmTravelTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prognameDataGridViewTextBoxColumn,
            this.progdaybeginDataGridViewTextBoxColumn,
            this.progdayendDataGridViewTextBoxColumn,
            this.progprogrammsDataGridViewTextBoxColumn,
            this.progtravelernumberDataGridViewTextBoxColumn,
            this.proghotelDataGridViewTextBoxColumn,
            this.progcostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.programmTravelTBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // prognameDataGridViewTextBoxColumn
            // 
            this.prognameDataGridViewTextBoxColumn.DataPropertyName = "prog_name";
            this.prognameDataGridViewTextBoxColumn.HeaderText = "Program Name";
            this.prognameDataGridViewTextBoxColumn.Name = "prognameDataGridViewTextBoxColumn";
            // 
            // progdaybeginDataGridViewTextBoxColumn
            // 
            this.progdaybeginDataGridViewTextBoxColumn.DataPropertyName = "prog_daybegin";
            this.progdaybeginDataGridViewTextBoxColumn.HeaderText = "Date Begin";
            this.progdaybeginDataGridViewTextBoxColumn.Name = "progdaybeginDataGridViewTextBoxColumn";
            // 
            // progdayendDataGridViewTextBoxColumn
            // 
            this.progdayendDataGridViewTextBoxColumn.DataPropertyName = "prog_dayend";
            this.progdayendDataGridViewTextBoxColumn.HeaderText = "Date End";
            this.progdayendDataGridViewTextBoxColumn.Name = "progdayendDataGridViewTextBoxColumn";
            // 
            // progprogrammsDataGridViewTextBoxColumn
            // 
            this.progprogrammsDataGridViewTextBoxColumn.DataPropertyName = "prog_programms";
            this.progprogrammsDataGridViewTextBoxColumn.HeaderText = "ThePograms";
            this.progprogrammsDataGridViewTextBoxColumn.Name = "progprogrammsDataGridViewTextBoxColumn";
            // 
            // progtravelernumberDataGridViewTextBoxColumn
            // 
            this.progtravelernumberDataGridViewTextBoxColumn.DataPropertyName = "prog_travelernumber";
            this.progtravelernumberDataGridViewTextBoxColumn.HeaderText = "Traveler Number";
            this.progtravelernumberDataGridViewTextBoxColumn.Name = "progtravelernumberDataGridViewTextBoxColumn";
            // 
            // proghotelDataGridViewTextBoxColumn
            // 
            this.proghotelDataGridViewTextBoxColumn.DataPropertyName = "prog_hotel";
            this.proghotelDataGridViewTextBoxColumn.HeaderText = "Hotel";
            this.proghotelDataGridViewTextBoxColumn.Name = "proghotelDataGridViewTextBoxColumn";
            // 
            // progcostDataGridViewTextBoxColumn
            // 
            this.progcostDataGridViewTextBoxColumn.DataPropertyName = "prog_cost";
            this.progcostDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.progcostDataGridViewTextBoxColumn.Name = "progcostDataGridViewTextBoxColumn";
            // 
            // programmTravelTBBindingSource
            // 
            this.programmTravelTBBindingSource.DataMember = "ProgrammTravelTB";
            this.programmTravelTBBindingSource.DataSource = this.travelDataSet8;
            // 
            // travelDataSet8
            // 
            this.travelDataSet8.DataSetName = "travelDataSet8";
            this.travelDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programmTravelTBTableAdapter
            // 
            this.programmTravelTBTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::travels.Properties.Resources.HD_Wallpaper__209_;
            this.pictureBox1.Location = new System.Drawing.Point(1, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(740, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // allprog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 438);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "allprog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Program";
            this.Load += new System.EventHandler(this.allprog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmTravelTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private travelDataSet8 travelDataSet8;
        private System.Windows.Forms.BindingSource programmTravelTBBindingSource;
        private travelDataSet8TableAdapters.ProgrammTravelTBTableAdapter programmTravelTBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prognameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn progdaybeginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn progdayendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn progprogrammsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn progtravelernumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proghotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn progcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}