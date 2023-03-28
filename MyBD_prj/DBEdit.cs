using System;
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
    }
}
