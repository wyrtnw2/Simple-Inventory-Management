using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            this.Close();
        }

        private void FormMnagerProducts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "simpleInventoryManagementDataSet.ProductsView". При необходимости она может быть перемещена или удалена.
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
            productsViewBindingSource.Filter = "CategoryName = '" + comboBoxFiltering.Text + "'";
        }
    }
}
