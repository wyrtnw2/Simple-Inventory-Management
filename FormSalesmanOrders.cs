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
    public partial class FormSalesmanOrders : Form
    {
        public FormSalesmanOrders()
        {
            InitializeComponent();
        }

        private void FormSalesmanOrders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "simpleInventoryManagementDataSet.PurchaseOrders". При необходимости она может быть перемещена или удалена.
            this.purchaseOrdersTableAdapter.Fill(this.simpleInventoryManagementDataSet.PurchaseOrders);

        }
        private void rjButtonREP_Click(object sender, EventArgs e)
        {
            DGVPrinter dgvPrinter = new DGVPrinter();
            dgvPrinter.CreateReport("Отчет по остаткам", dataGridView1);
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            stockBindingSource.AddNew();
        }

        private void rjButtonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stockBindingSource.EndEdit();
        }

        private void rjButtonSave_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.purchaseOrdersBindingSource.EndEdit();
            this.purchaseOrdersTableAdapter.Update(this.simpleInventoryManagementDataSet.PurchaseOrders);
        }
    }
}
