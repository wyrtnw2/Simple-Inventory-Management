using DGVPrinterHelper;
using System;

using System.Windows.Forms;

namespace Simple_Inventory_Management
{
    public partial class FormManagerCatigories : Form
    {
        public FormManagerCatigories()
        {
            InitializeComponent();
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void FormManagerCatigories_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "simpleInventoryManagementDataSet.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.simpleInventoryManagementDataSet.Categories);

        }

        private void rjButtonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            categoriesBindingSource.AddNew();
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
            categoriesBindingSource.Filter = "CategoryName = '" + comboBox.Text + "'";
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            categoriesBindingSource.Filter = "";
        }

        private void rjButtonREP_Click(object sender, EventArgs e)
        {
            DGVPrinter dgvPrinter = new DGVPrinter();
            dgvPrinter.CreateReport("Отчет по категориям", productsViewDataGridView);
        }
    }
}
