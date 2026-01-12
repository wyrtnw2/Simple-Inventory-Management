using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Simple_Inventory_Management
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            textBoxPassword.UseSystemPasswordChar = true;
        }
        
        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }
        private void buttonCLose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            panelTop.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
        }

        private void ButtonSingIn_Click(object sender, EventArgs e)
        {
            string username = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-H77ER4U\SQLEXPRESS;Initial Catalog=SimpleInventoryManagement;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT role, status FROM Users WHERE username=@username AND password=@password AND status=@status", conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@status", 1);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                int role = reader.GetInt32(0);
                int status = reader.GetInt32(1);
                if (status == 1)
                {
                    if (role == 1)
                    {
                        MessageBox.Show("You have successfully logged in as a manager!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormManager manager = new FormManager();
                        manager.Show();
                        this.Hide();
                    }
                    else if (role == 2)
                    {
                        MessageBox.Show("You have successfully logged in as a storekeeper!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormStorekeeper storekeeper = new FormStorekeeper();
                        storekeeper.Show();
                        this.Hide();
                    }
                    else if (role == 3)
                    {
                        MessageBox.Show("You have successfully logged in as a accountant!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormAccountant accountant = new FormAccountant();
                        accountant.Show();
                        this.Hide();
                    }
                    else if (role == 4)
                    {
                        MessageBox.Show("You have successfully logged in as an administrator!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormAdmin admin = new FormAdmin();
                        admin.Show();
                        this.Hide();
                    }
                    else if (role == 5)
                    {
                        MessageBox.Show("You have successfully logged in as an salesman", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormSalesman salesman = new FormSalesman();
                        salesman.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();

            }
            else
            {
                MessageBox.Show("Отказано в доступе! Неверный логин, пароль или вы заблокированы в системе", "Аккаунт заблокирован!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!rjToggleButton1.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
        }

        private void linkLabelFaq_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Latest information and guidance: github.com/wyrtnw2/Simple-Inventory-Management", "Information.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
