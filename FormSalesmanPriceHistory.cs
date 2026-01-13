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
    public partial class FormSalesmanPriceHistory : Form
    {
        public FormSalesmanPriceHistory()
        {
            InitializeComponent();
        }
        private void FormSalesmanPriceHistory_Load(object sender, EventArgs e)
        {

        }

        private void rjButtonREP_Click(object sender, EventArgs e)
        {
            DGVPrinter dgvPrinter = new DGVPrinter();
            dgvPrinter.CreateReport("Отчет по истории цен", dataGridView1);
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
            priceHistoryBindingSource.AddNew();
        }

        private void rjButtonSave_Click(object sender, EventArgs e)
        {
        }

        private void rjButtonSave_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.priceHistoryBindingSource.EndEdit();
            this.priceHistoryTableAdapter.Update(this.simpleInventoryManagementDataSet.PriceHistory);
        }

        private void FormSalesmanPriceHistory_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "simpleInventoryManagementDataSet.PriceHistory". При необходимости она может быть перемещена или удалена.
            this.priceHistoryTableAdapter.Fill(this.simpleInventoryManagementDataSet.PriceHistory);

        }
    }
}
