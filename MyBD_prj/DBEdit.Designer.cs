namespace MyBD_prj
{
    partial class DBEdit
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
            System.Windows.Forms.Label deloNameLabel;
            System.Windows.Forms.Label deloDescLabel;
            System.Windows.Forms.Label deloBeginLabel;
            System.Windows.Forms.Label deloEndLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.opisComboBox2 = new System.Windows.Forms.ComboBox();
            this.delaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arhiveDataSet = new MyBD_prj.ArhiveDataSet();
            this.opisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foundsComboBox = new System.Windows.Forms.ComboBox();
            this.fondsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opisComboBox = new System.Windows.Forms.ComboBox();
            this.deloEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deloBeginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deloDescTextBox = new System.Windows.Forms.TextBox();
            this.deloNameTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deloNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deloDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deloBeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deloEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fondNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delaTableAdapter = new MyBD_prj.ArhiveDataSetTableAdapters.DelaTableAdapter();
            this.tableAdapterManager = new MyBD_prj.ArhiveDataSetTableAdapters.TableAdapterManager();
            this.opisTableAdapter = new MyBD_prj.ArhiveDataSetTableAdapters.OpisTableAdapter();
            this.fondsTableAdapter = new MyBD_prj.ArhiveDataSetTableAdapters.FondsTableAdapter();
            this.arhiveDataSet1 = new MyBD_prj.ArhiveDataSet();
            this.opisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            deloNameLabel = new System.Windows.Forms.Label();
            deloDescLabel = new System.Windows.Forms.Label();
            deloBeginLabel = new System.Windows.Forms.Label();
            deloEndLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arhiveDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arhiveDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opisBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // deloNameLabel
            // 
            deloNameLabel.AutoSize = true;
            deloNameLabel.Location = new System.Drawing.Point(9, 34);
            deloNameLabel.Name = "deloNameLabel";
            deloNameLabel.Size = new System.Drawing.Size(71, 13);
            deloNameLabel.TabIndex = 0;
            deloNameLabel.Text = "Номер дела:";
            // 
            // deloDescLabel
            // 
            deloDescLabel.AutoSize = true;
            deloDescLabel.Location = new System.Drawing.Point(20, 62);
            deloDescLabel.Name = "deloDescLabel";
            deloDescLabel.Size = new System.Drawing.Size(60, 13);
            deloDescLabel.TabIndex = 2;
            deloDescLabel.Text = "Описание:";
            // 
            // deloBeginLabel
            // 
            deloBeginLabel.AutoSize = true;
            deloBeginLabel.Location = new System.Drawing.Point(34, 117);
            deloBeginLabel.Name = "deloBeginLabel";
            deloBeginLabel.Size = new System.Drawing.Size(46, 13);
            deloBeginLabel.TabIndex = 4;
            deloBeginLabel.Text = "Начато:";
            // 
            // deloEndLabel
            // 
            deloEndLabel.AutoSize = true;
            deloEndLabel.Location = new System.Drawing.Point(21, 146);
            deloEndLabel.Name = "deloEndLabel";
            deloEndLabel.Size = new System.Drawing.Size(59, 13);
            deloEndLabel.TabIndex = 6;
            deloEndLabel.Text = "Окончено:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.opisComboBox2);
            this.splitContainer1.Panel1.Controls.Add(this.foundsComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.opisComboBox);
            this.splitContainer1.Panel1.Controls.Add(deloEndLabel);
            this.splitContainer1.Panel1.Controls.Add(this.deloEndDateTimePicker);
            this.splitContainer1.Panel1.Controls.Add(deloBeginLabel);
            this.splitContainer1.Panel1.Controls.Add(this.deloBeginDateTimePicker);
            this.splitContainer1.Panel1.Controls.Add(deloDescLabel);
            this.splitContainer1.Panel1.Controls.Add(this.deloDescTextBox);
            this.splitContainer1.Panel1.Controls.Add(deloNameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.deloNameTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(725, 404);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 0;
            // 
            // opisComboBox2
            // 
            this.opisComboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.delaBindingSource, "OpisNumber", true));
            this.opisComboBox2.DataSource = this.opisBindingSource1;
            this.opisComboBox2.DisplayMember = "OpisName";
            this.opisComboBox2.FormattingEnabled = true;
            this.opisComboBox2.Location = new System.Drawing.Point(89, 273);
            this.opisComboBox2.Name = "opisComboBox2";
            this.opisComboBox2.Size = new System.Drawing.Size(167, 21);
            this.opisComboBox2.TabIndex = 11;
            this.opisComboBox2.ValueMember = "id";
            // 
            // delaBindingSource
            // 
            this.delaBindingSource.DataMember = "Dela";
            this.delaBindingSource.DataSource = this.arhiveDataSet;
            // 
            // arhiveDataSet
            // 
            this.arhiveDataSet.DataSetName = "ArhiveDataSet";
            this.arhiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // opisBindingSource
            // 
            this.opisBindingSource.DataMember = "Opis";
            this.opisBindingSource.DataSource = this.arhiveDataSet;
            // 
            // foundsComboBox
            // 
            this.foundsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.opisBindingSource, "FonNumber", true));
            this.foundsComboBox.DataSource = this.fondsBindingSource;
            this.foundsComboBox.DisplayMember = "Имя";
            this.foundsComboBox.FormattingEnabled = true;
            this.foundsComboBox.Location = new System.Drawing.Point(91, 199);
            this.foundsComboBox.Name = "foundsComboBox";
            this.foundsComboBox.Size = new System.Drawing.Size(167, 21);
            this.foundsComboBox.TabIndex = 10;
            this.foundsComboBox.ValueMember = "Код";
            this.foundsComboBox.SelectedIndexChanged += new System.EventHandler(this.foundsComboBox_SelectedIndexChanged);
            this.foundsComboBox.SelectedValueChanged += new System.EventHandler(this.foundsComboBox_SelectedValueChanged);
            this.foundsComboBox.Click += new System.EventHandler(this.foundsComboBox_Click);
            // 
            // fondsBindingSource
            // 
            this.fondsBindingSource.DataMember = "Fonds";
            this.fondsBindingSource.DataSource = this.arhiveDataSet;
            // 
            // opisComboBox
            // 
            this.opisComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.delaBindingSource, "OpisNumber", true));
            this.opisComboBox.DataSource = this.opisBindingSource;
            this.opisComboBox.DisplayMember = "OpisName";
            this.opisComboBox.FormattingEnabled = true;
            this.opisComboBox.Location = new System.Drawing.Point(89, 246);
            this.opisComboBox.Name = "opisComboBox";
            this.opisComboBox.Size = new System.Drawing.Size(167, 21);
            this.opisComboBox.TabIndex = 9;
            this.opisComboBox.ValueMember = "id";
            // 
            // deloEndDateTimePicker
            // 
            this.deloEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.delaBindingSource, "DeloEnd", true));
            this.deloEndDateTimePicker.Location = new System.Drawing.Point(89, 142);
            this.deloEndDateTimePicker.Name = "deloEndDateTimePicker";
            this.deloEndDateTimePicker.Size = new System.Drawing.Size(167, 20);
            this.deloEndDateTimePicker.TabIndex = 7;
            // 
            // deloBeginDateTimePicker
            // 
            this.deloBeginDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.delaBindingSource, "DeloBegin", true));
            this.deloBeginDateTimePicker.Location = new System.Drawing.Point(91, 113);
            this.deloBeginDateTimePicker.Name = "deloBeginDateTimePicker";
            this.deloBeginDateTimePicker.Size = new System.Drawing.Size(165, 20);
            this.deloBeginDateTimePicker.TabIndex = 5;
            // 
            // deloDescTextBox
            // 
            this.deloDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delaBindingSource, "DeloDesc", true));
            this.deloDescTextBox.Location = new System.Drawing.Point(89, 59);
            this.deloDescTextBox.Multiline = true;
            this.deloDescTextBox.Name = "deloDescTextBox";
            this.deloDescTextBox.Size = new System.Drawing.Size(167, 48);
            this.deloDescTextBox.TabIndex = 3;
            // 
            // deloNameTextBox
            // 
            this.deloNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delaBindingSource, "DeloName", true));
            this.deloNameTextBox.Location = new System.Drawing.Point(89, 31);
            this.deloNameTextBox.Name = "deloNameTextBox";
            this.deloNameTextBox.Size = new System.Drawing.Size(167, 20);
            this.deloNameTextBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.deloNameDataGridViewTextBoxColumn,
            this.deloDescDataGridViewTextBoxColumn,
            this.deloBeginDataGridViewTextBoxColumn,
            this.deloEndDataGridViewTextBoxColumn,
            this.fondNumberDataGridViewTextBoxColumn,
            this.opisNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.delaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(451, 404);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // deloNameDataGridViewTextBoxColumn
            // 
            this.deloNameDataGridViewTextBoxColumn.DataPropertyName = "DeloName";
            this.deloNameDataGridViewTextBoxColumn.HeaderText = "Номер дела";
            this.deloNameDataGridViewTextBoxColumn.Name = "deloNameDataGridViewTextBoxColumn";
            this.deloNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deloDescDataGridViewTextBoxColumn
            // 
            this.deloDescDataGridViewTextBoxColumn.DataPropertyName = "DeloDesc";
            this.deloDescDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.deloDescDataGridViewTextBoxColumn.Name = "deloDescDataGridViewTextBoxColumn";
            this.deloDescDataGridViewTextBoxColumn.ReadOnly = true;
            this.deloDescDataGridViewTextBoxColumn.Width = 300;
            // 
            // deloBeginDataGridViewTextBoxColumn
            // 
            this.deloBeginDataGridViewTextBoxColumn.DataPropertyName = "DeloBegin";
            this.deloBeginDataGridViewTextBoxColumn.HeaderText = "Начато";
            this.deloBeginDataGridViewTextBoxColumn.Name = "deloBeginDataGridViewTextBoxColumn";
            this.deloBeginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deloEndDataGridViewTextBoxColumn
            // 
            this.deloEndDataGridViewTextBoxColumn.DataPropertyName = "DeloEnd";
            this.deloEndDataGridViewTextBoxColumn.HeaderText = "Окончено";
            this.deloEndDataGridViewTextBoxColumn.Name = "deloEndDataGridViewTextBoxColumn";
            this.deloEndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fondNumberDataGridViewTextBoxColumn
            // 
            this.fondNumberDataGridViewTextBoxColumn.DataPropertyName = "FondNumber";
            this.fondNumberDataGridViewTextBoxColumn.HeaderText = "FondNumber";
            this.fondNumberDataGridViewTextBoxColumn.Name = "fondNumberDataGridViewTextBoxColumn";
            this.fondNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.fondNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // opisNumberDataGridViewTextBoxColumn
            // 
            this.opisNumberDataGridViewTextBoxColumn.DataPropertyName = "OpisNumber";
            this.opisNumberDataGridViewTextBoxColumn.HeaderText = "OpisNumber";
            this.opisNumberDataGridViewTextBoxColumn.Name = "opisNumberDataGridViewTextBoxColumn";
            this.opisNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.opisNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // delaTableAdapter
            // 
            this.delaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DelaTableAdapter = null;
            this.tableAdapterManager.FondsTableAdapter = null;
            this.tableAdapterManager.OpisTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MyBD_prj.ArhiveDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // opisTableAdapter
            // 
            this.opisTableAdapter.ClearBeforeFill = true;
            // 
            // fondsTableAdapter
            // 
            this.fondsTableAdapter.ClearBeforeFill = true;
            // 
            // arhiveDataSet1
            // 
            this.arhiveDataSet1.DataSetName = "ArhiveDataSet";
            this.arhiveDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // opisBindingSource1
            // 
            this.opisBindingSource1.DataMember = "Opis";
            this.opisBindingSource1.DataSource = this.arhiveDataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // DBEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 404);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(741, 350);
            this.Name = "DBEdit";
            this.Text = "DBEdit";
            this.Load += new System.EventHandler(this.DBEdit_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.delaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arhiveDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arhiveDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opisBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ArhiveDataSet arhiveDataSet;
        private System.Windows.Forms.BindingSource delaBindingSource;
        private ArhiveDataSetTableAdapters.DelaTableAdapter delaTableAdapter;
        private System.Windows.Forms.DateTimePicker deloEndDateTimePicker;
        private System.Windows.Forms.DateTimePicker deloBeginDateTimePicker;
        private System.Windows.Forms.TextBox deloDescTextBox;
        private System.Windows.Forms.TextBox deloNameTextBox;
        private ArhiveDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deloNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deloDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deloBeginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deloEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fondNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource opisBindingSource;
        private ArhiveDataSetTableAdapters.OpisTableAdapter opisTableAdapter;
        private System.Windows.Forms.ComboBox opisComboBox;
        private System.Windows.Forms.ComboBox foundsComboBox;
        private System.Windows.Forms.BindingSource fondsBindingSource;
        private ArhiveDataSetTableAdapters.FondsTableAdapter fondsTableAdapter;
        private System.Windows.Forms.ComboBox opisComboBox2;
        private ArhiveDataSet arhiveDataSet1;
        private System.Windows.Forms.BindingSource opisBindingSource1;
        private System.Windows.Forms.Label label1;
    }
}