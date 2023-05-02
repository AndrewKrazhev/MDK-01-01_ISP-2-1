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
            System.Windows.Forms.Label opisNumberLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.resultLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.opisNumberComboBox = new System.Windows.Forms.ComboBox();
            this.delaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arhiveDataSet = new MyBD_prj.ArhiveDataSet();
            this.opisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arhiveDataSet1 = new MyBD_prj.ArhiveDataSet();
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
            this.dbBack = new System.Windows.Forms.Button();
            this.dbForward = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dbStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deloNameLabel = new System.Windows.Forms.Label();
            deloDescLabel = new System.Windows.Forms.Label();
            deloBeginLabel = new System.Windows.Forms.Label();
            deloEndLabel = new System.Windows.Forms.Label();
            opisNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arhiveDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arhiveDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            // opisNumberLabel
            // 
            opisNumberLabel.AutoSize = true;
            opisNumberLabel.Location = new System.Drawing.Point(12, 193);
            opisNumberLabel.Name = "opisNumberLabel";
            opisNumberLabel.Size = new System.Drawing.Size(71, 13);
            opisNumberLabel.TabIndex = 8;
            opisNumberLabel.Text = "Opis Number:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.dbForward);
            this.splitContainer1.Panel1.Controls.Add(this.dbBack);
            this.splitContainer1.Panel1.Controls.Add(this.resultLabel);
            this.splitContainer1.Panel1.Controls.Add(this.deleteButton);
            this.splitContainer1.Panel1.Controls.Add(opisNumberLabel);
            this.splitContainer1.Panel1.Controls.Add(this.opisNumberComboBox);
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
            this.splitContainer1.Size = new System.Drawing.Size(725, 411);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 0;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(222, 314);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(35, 13);
            this.resultLabel.TabIndex = 11;
            this.resultLabel.Text = "label1";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(101, 330);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // opisNumberComboBox
            // 
            this.opisNumberComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.delaBindingSource, "OpisNumber", true));
            this.opisNumberComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.delaBindingSource, "OpisNumber", true));
            this.opisNumberComboBox.DataSource = this.opisBindingSource;
            this.opisNumberComboBox.DisplayMember = "OpisName";
            this.opisNumberComboBox.FormattingEnabled = true;
            this.opisNumberComboBox.Location = new System.Drawing.Point(89, 190);
            this.opisNumberComboBox.Name = "opisNumberComboBox";
            this.opisNumberComboBox.Size = new System.Drawing.Size(167, 21);
            this.opisNumberComboBox.TabIndex = 9;
            this.opisNumberComboBox.ValueMember = "id";
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
            this.opisBindingSource.DataSource = this.arhiveDataSet1;
            // 
            // arhiveDataSet1
            // 
            this.arhiveDataSet1.DataSetName = "ArhiveDataSet";
            this.arhiveDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
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
            this.dataGridView1.Size = new System.Drawing.Size(451, 411);
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
            // dbBack
            // 
            this.dbBack.Location = new System.Drawing.Point(20, 330);
            this.dbBack.Name = "dbBack";
            this.dbBack.Size = new System.Drawing.Size(75, 23);
            this.dbBack.TabIndex = 12;
            this.dbBack.Text = "<<Назад";
            this.dbBack.UseVisualStyleBackColor = true;
            this.dbBack.Click += new System.EventHandler(this.dbBack_Click);
            // 
            // dbForward
            // 
            this.dbForward.Location = new System.Drawing.Point(182, 330);
            this.dbForward.Name = "dbForward";
            this.dbForward.Size = new System.Drawing.Size(75, 23);
            this.dbForward.TabIndex = 13;
            this.dbForward.Text = "Вперёд>>";
            this.dbForward.UseVisualStyleBackColor = true;
            this.dbForward.Click += new System.EventHandler(this.dbForward_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dbStateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dbStateToolStripMenuItem
            // 
            this.dbStateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editModeToolStripMenuItem});
            this.dbStateToolStripMenuItem.Name = "dbStateToolStripMenuItem";
            this.dbStateToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.dbStateToolStripMenuItem.Text = "dbState";
            // 
            // editModeToolStripMenuItem
            // 
            this.editModeToolStripMenuItem.CheckOnClick = true;
            this.editModeToolStripMenuItem.Name = "editModeToolStripMenuItem";
            this.editModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editModeToolStripMenuItem.Text = "editMode";
            this.editModeToolStripMenuItem.Click += new System.EventHandler(this.editModeToolStripMenuItem_Click);
            // 
            // DBEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 435);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(741, 150);
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
            ((System.ComponentModel.ISupportInitialize)(this.arhiveDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox opisNumberComboBox;
        private ArhiveDataSet arhiveDataSet1;
        private System.Windows.Forms.BindingSource opisBindingSource;
        private ArhiveDataSetTableAdapters.OpisTableAdapter opisTableAdapter;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button dbForward;
        private System.Windows.Forms.Button dbBack;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dbStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editModeToolStripMenuItem;
    }
}