using DGVPrinterHelper;
using System;
using System.Windows.Forms;


namespace Simple_Inventory_Management
{
    public partial class FormMnagerProducts : Form
    {
        public FormMnagerProducts()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            productsViewBindingSource.Filter = "";
        }

        private void FormMnagerProducts_Load(object sender, EventArgs e)
        {
            // sss
            this.productsViewTableAdapter.Fill(this.simpleInventoryManagementDataSet.ProductsView);

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

        private void ButtonFIllter_Click(object sender, EventArgs e)
        {
            productsViewBindingSource.Filter = "CategoryName = '" + comboBox.Text + "'";
        }

        private void rjButtonREP_Click(object sender, EventArgs e)
        {
            DGVPrinter dgvPrinter = new DGVPrinter();
            dgvPrinter.CreateReport("Отчет по продуктам", productsViewDataGridView);
        }
    }
}
