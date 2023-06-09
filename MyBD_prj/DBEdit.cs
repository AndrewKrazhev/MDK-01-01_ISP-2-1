﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBD_prj
{
    public partial class DBEdit : Form
    {
        public DBEdit()
        {
            InitializeComponent();
        }

        private void delaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            /*
            this.Validate();
            this.delaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.arhiveDataSet);*/

        }

        private void DBEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arhiveDataSet1.Opis". При необходимости она может быть перемещена или удалена.
            this.opisTableAdapter.Fill(this.arhiveDataSet1.Opis);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arhiveDataSet.Dela". При необходимости она может быть перемещена или удалена.
            this.delaTableAdapter.Fill(this.arhiveDataSet.Dela);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arhiveDataSet.Fonds". При необходимости она может быть перемещена или удалена.
            //this.fondsTableAdapter.Fill(this.arhiveDataSet.Fonds);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arhiveDataSet.Opis". При необходимости она может быть перемещена или удалена.
            //this.opisTableAdapter.Fill(this.arhiveDataSet.Opis);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arhiveDataSet.Dela". При необходимости она может быть перемещена или удалена.
            //this.delaTableAdapter.Fill(this.arhiveDataSet.Dela);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;   
            

        }

        private void deloBeginDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void deloDescLabel_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                this.fondsTableAdapter.FillBy(this.arhiveDataSet.Fonds);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            */
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.editModeToolStripMenuItem.Checked)
            {
                var result = MessageBox.Show("Вы уверены, что хотите " +
                    "удалить текущую запись",
                    "Удаление", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Information);

                switch (result)
                {
                    case DialogResult.Yes:
                        resultLabel.Text = "Да";

                        try
                        {
                            this.delaBindingSource.RemoveCurrent();
                            this.delaBindingSource.EndEdit();
                            this.delaTableAdapter.Update(this.arhiveDataSet.Dela);
                        }
                        catch (Exception _ex)
                        {
                            MessageBox.Show(_ex.Message.ToString());
                        }


                        break;

                    case DialogResult.No:
                        resultLabel.Text = "Нет";
                        break;

                    case DialogResult.Cancel:
                        resultLabel.Text = "Отмена";
                        break;

                    default:
                        resultLabel.Text = "------";
                        break;
                }
            }
            else { MessageBox.Show("Включите режим редактирования");}
            }

        private void режимРедактированияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void editModeToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dbBack_Click(object sender, EventArgs e)
        {
            this.delaBindingSource.MovePrevious();
        }

        private void dbForward_Click(object sender, EventArgs e)
        {
            this.delaBindingSource.MoveNext();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void editModeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
