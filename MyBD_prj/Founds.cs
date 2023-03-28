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
    public partial class Founds : Form
    {
        public Founds()
        {
            InitializeComponent();
        }

        private void fondsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fondsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.arhiveDataSet);

        }

        private void Founds_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arhiveDataSet.Fonds". При необходимости она может быть перемещена или удалена.
            this.fondsTableAdapter.Fill(this.arhiveDataSet.Fonds);

        }
    }
}
