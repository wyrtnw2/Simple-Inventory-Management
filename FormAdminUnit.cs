using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Inventory_Management
{
    public partial class FormAdminUnit : Form
    {
        public FormAdminUnit()
        {
            InitializeComponent();
        }

        private void FormAdminUnit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "simpleInventoryManagementDataSet.Units". При необходимости она может быть перемещена или удалена.
            this.unitsTableAdapter.Fill(this.simpleInventoryManagementDataSet.Units);

        }
        private void ButtonFind_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < productsViewDataGridView.RowCount; i++)
            {
                productsViewDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < productsViewDataGridView.ColumnCount; j++)
                    if (productsViewDataGridView.Rows[i].Cells[j].Value != null)
                        if (productsViewDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch.Text))
                        {
                            productsViewDataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void rjButtonREP_Click(object sender, EventArgs e)
        {
            DGVPrinter dgvPrinter = new DGVPrinter();
            dgvPrinter.CreateReport("Отчет по категориям", productsViewDataGridView);
        }

        private void ButtonFIllter_Click(object sender, EventArgs e)
        {
            unitsBindingSource.Filter = "CategoryName = '" + comboBox.Text + "'";
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            unitsBindingSource.AddNew();
        }

        private void rjButtonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.unitsBindingSource.EndEdit();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            unitsBindingSource.Filter = "";

        }
    }
}
