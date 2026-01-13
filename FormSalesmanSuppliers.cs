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
    public partial class FormSalesmanSuppliers : Form
    {
        public FormSalesmanSuppliers()
        {
            InitializeComponent();
        }

        private void FormSalesmanSuppliers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "simpleInventoryManagementDataSet.Suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.simpleInventoryManagementDataSet.Suppliers);

        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < documentTypesDataGridView.RowCount; i++)
            {
                documentTypesDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < documentTypesDataGridView.ColumnCount; j++)
                    if (documentTypesDataGridView.Rows[i].Cells[j].Value != null)
                        if (documentTypesDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch.Text))
                        {
                            documentTypesDataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}
