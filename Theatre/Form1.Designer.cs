namespace Theatre
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.spec = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.spectacleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iS_THEATREDataSet2 = new Theatre.IS_THEATREDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.TextBox();
            this.SUM = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iS_THEATREDataSet = new Theatre.IS_THEATREDataSet();
            this.ticketTableAdapter = new Theatre.IS_THEATREDataSetTableAdapters.ticketTableAdapter();
            this.iSTHEATREDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spectacleTableAdapter = new Theatre.IS_THEATREDataSet2TableAdapters.SpectacleTableAdapter();
            this.dataSet1 = new Theatre.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theathreDataSet = new Theatre.theathreDataSet();
            this.ticketBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTableAdapter1 = new Theatre.theathreDataSetTableAdapters.ticketTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTheatreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSpectacleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatr9dDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatmest0DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectacleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS_THEATREDataSet2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS_THEATREDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSTHEATREDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theathreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(705, 422);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.spec);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.Data);
            this.tabPage1.Controls.Add(this.SUM);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(697, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // spec
            // 
            this.spec.Location = new System.Drawing.Point(471, 164);
            this.spec.Margin = new System.Windows.Forms.Padding(2);
            this.spec.Name = "spec";
            this.spec.Size = new System.Drawing.Size(199, 20);
            this.spec.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idTheatreDataGridViewTextBoxColumn,
            this.idSpectacleDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.seatr9dDataGridViewTextBoxColumn,
            this.seatmest0DataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ticketBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(440, 399);
            this.dataGridView1.TabIndex = 8;
            // 
            // spectacleBindingSource
            // 
            this.spectacleBindingSource.DataMember = "Spectacle";
            this.spectacleBindingSource.DataSource = this.iS_THEATREDataSet2;
            // 
            // iS_THEATREDataSet2
            // 
            this.iS_THEATREDataSet2.DataSetName = "IS_THEATREDataSet2";
            this.iS_THEATREDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 186);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(471, 140);
            this.Data.Margin = new System.Windows.Forms.Padding(2);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(199, 20);
            this.Data.TabIndex = 6;
            // 
            // SUM
            // 
            this.SUM.ForeColor = System.Drawing.Color.IndianRed;
            this.SUM.Location = new System.Drawing.Point(471, 210);
            this.SUM.Margin = new System.Windows.Forms.Padding(2);
            this.SUM.Name = "SUM";
            this.SUM.ReadOnly = true;
            this.SUM.Size = new System.Drawing.Size(199, 20);
            this.SUM.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(697, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 5);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(27, 49);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(92, 80);
            this.treeView1.TabIndex = 0;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "ticket";
            this.ticketBindingSource.DataSource = this.iS_THEATREDataSet;
            // 
            // iS_THEATREDataSet
            // 
            this.iS_THEATREDataSet.DataSetName = "IS_THEATREDataSet";
            this.iS_THEATREDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // iSTHEATREDataSetBindingSource
            // 
            this.iSTHEATREDataSetBindingSource.DataSource = this.iS_THEATREDataSet;
            this.iSTHEATREDataSetBindingSource.Position = 0;
            // 
            // spectacleTableAdapter
            // 
            this.spectacleTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // theathreDataSet
            // 
            this.theathreDataSet.DataSetName = "theathreDataSet";
            this.theathreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketBindingSource1
            // 
            this.ticketBindingSource1.DataMember = "ticket";
            this.ticketBindingSource1.DataSource = this.theathreDataSet;
            // 
            // ticketTableAdapter1
            // 
            this.ticketTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idTheatreDataGridViewTextBoxColumn
            // 
            this.idTheatreDataGridViewTextBoxColumn.DataPropertyName = "id_Theatre";
            this.idTheatreDataGridViewTextBoxColumn.HeaderText = "id_Theatre";
            this.idTheatreDataGridViewTextBoxColumn.Name = "idTheatreDataGridViewTextBoxColumn";
            this.idTheatreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSpectacleDataGridViewTextBoxColumn
            // 
            this.idSpectacleDataGridViewTextBoxColumn.DataPropertyName = "id_Spectacle";
            this.idSpectacleDataGridViewTextBoxColumn.HeaderText = "id_Spectacle";
            this.idSpectacleDataGridViewTextBoxColumn.Name = "idSpectacleDataGridViewTextBoxColumn";
            this.idSpectacleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seatr9dDataGridViewTextBoxColumn
            // 
            this.seatr9dDataGridViewTextBoxColumn.DataPropertyName = "seat_r9d";
            this.seatr9dDataGridViewTextBoxColumn.HeaderText = "seat_r9d";
            this.seatr9dDataGridViewTextBoxColumn.Name = "seatr9dDataGridViewTextBoxColumn";
            this.seatr9dDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seatmest0DataGridViewTextBoxColumn
            // 
            this.seatmest0DataGridViewTextBoxColumn.DataPropertyName = "seat_mest0";
            this.seatmest0DataGridViewTextBoxColumn.HeaderText = "seat_mest0";
            this.seatmest0DataGridViewTextBoxColumn.Name = "seatmest0DataGridViewTextBoxColumn";
            this.seatmest0DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 422);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectacleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS_THEATREDataSet2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iS_THEATREDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSTHEATREDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theathreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private IS_THEATREDataSet iS_THEATREDataSet;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private IS_THEATREDataSetTableAdapters.ticketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.BindingSource iSTHEATREDataSetBindingSource;
        private IS_THEATREDataSet2 iS_THEATREDataSet2;
        private System.Windows.Forms.BindingSource spectacleBindingSource;
        private IS_THEATREDataSet2TableAdapters.SpectacleTableAdapter spectacleTableAdapter;
        private System.Windows.Forms.TextBox SUM;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Data;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox spec;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private theathreDataSet theathreDataSet;
        private System.Windows.Forms.BindingSource ticketBindingSource1;
        private theathreDataSetTableAdapters.ticketTableAdapter ticketTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTheatreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSpectacleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatr9dDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatmest0DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}

