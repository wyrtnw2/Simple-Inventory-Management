using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Inventory_Management
{
    public partial class FormSalesman : Form
    {
        public FormSalesman()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(ChildForm);
            panelChildForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            panelTop.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void buttonCLose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPositions_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSalesmanSuppliers());
        }

        private void buttonCabinets_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSalesmanStocks());
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSalesmanOrders());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSalesmanPriceHistory());
        }
    }
}
