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
    public partial class FormAdminDocType : Form
    {
        public FormAdminDocType()
        {
            InitializeComponent();
        }

        private void FormAdminDocType_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "simpleInventoryManagementDataSet.DocumentTypes". При необходимости она может быть перемещена или удалена.
            this.documentTypesTableAdapter.Fill(this.simpleInventoryManagementDataSet.DocumentTypes);

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

        private void rjButtonREP_Click(object sender, EventArgs e)
        {
            DGVPrinter dgvPrinter = new DGVPrinter();
            dgvPrinter.CreateReport("Отчет по категориям", documentTypesDataGridView);
        }

        private void ButtonFIllter_Click(object sender, EventArgs e)
        {
            //documentTypesBindingSource.Filter = " = '" + comboBox.Text + "'";
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            documentTypesBindingSource.AddNew();
        }

        private void rjButtonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.documentTypesBindingSource.EndEdit();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            documentTypesBindingSource.Filter = "";

        }
    }
}
