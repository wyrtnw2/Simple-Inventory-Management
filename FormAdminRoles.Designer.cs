namespace Simple_Inventory_Management
{
    partial class FormAdminRoles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rjButtonSave = new Simple_Inventory_Management.RJButton();
            this.rjButton2 = new Simple_Inventory_Management.RJButton();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.ButtonFIllter = new Simple_Inventory_Management.RJButton();
            this.ButtonFind = new Simple_Inventory_Management.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelFiltering = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.ButtonClose = new Simple_Inventory_Management.RJButton();
            this.usersTableAdapter = new Simple_Inventory_Management.SimpleInventoryManagementDataSetTableAdapters.UsersTableAdapter();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simpleInventoryManagementDataSet = new Simple_Inventory_Management.SimpleInventoryManagementDataSet();
            this.productsViewDataGridView = new System.Windows.Forms.DataGridView();
            this.idRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new Simple_Inventory_Management.SimpleInventoryManagementDataSetTableAdapters.RolesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleInventoryManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rjButtonSave
            // 
            this.rjButtonSave.BackColor = System.Drawing.Color.Transparent;
            this.rjButtonSave.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButtonSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.rjButtonSave.BorderRadius = 6;
            this.rjButtonSave.BorderSize = 2;
            this.rjButtonSave.FlatAppearance.BorderSize = 0;
            this.rjButtonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(116)))), ((int)(((byte)(88)))));
            this.rjButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonSave.Font = new System.Drawing.Font("Orbitron SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.rjButtonSave.Location = new System.Drawing.Point(496, 334);
            this.rjButtonSave.Name = "rjButtonSave";
            this.rjButtonSave.Size = new System.Drawing.Size(97, 32);
            this.rjButtonSave.TabIndex = 70;
            this.rjButtonSave.Text = "SAVE";
            this.rjButtonSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.rjButtonSave.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.Transparent;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.rjButton2.BorderRadius = 6;
            this.rjButton2.BorderSize = 2;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(116)))), ((int)(((byte)(88)))));
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Orbitron SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.rjButton2.Location = new System.Drawing.Point(393, 334);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(97, 32);
            this.rjButton2.TabIndex = 69;
            this.rjButton2.Text = "ADD";
            this.rjButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(167)))));
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Электроника",
            "Компьютеры и ноутбуки",
            "Комплектующие для ПК",
            "Периферия",
            "Офисная техника",
            "Принтеры и МФУ",
            "Канцелярия",
            "Бумажная продукция",
            "Письменные принадлежности",
            "Хозяйственные товары",
            "Бытовая химия",
            "Мебель",
            "Продукты питания",
            "Напитки"});
            this.comboBox.Location = new System.Drawing.Point(111, 377);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(173, 24);
            this.comboBox.TabIndex = 67;
            // 
            // ButtonFIllter
            // 
            this.ButtonFIllter.BackColor = System.Drawing.Color.Transparent;
            this.ButtonFIllter.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonFIllter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.ButtonFIllter.BorderRadius = 6;
            this.ButtonFIllter.BorderSize = 2;
            this.ButtonFIllter.FlatAppearance.BorderSize = 0;
            this.ButtonFIllter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFIllter.Font = new System.Drawing.Font("Orbitron SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFIllter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.ButtonFIllter.Location = new System.Drawing.Point(290, 370);
            this.ButtonFIllter.Name = "ButtonFIllter";
            this.ButtonFIllter.Size = new System.Drawing.Size(97, 32);
            this.ButtonFIllter.TabIndex = 66;
            this.ButtonFIllter.Text = "FILLTER";
            this.ButtonFIllter.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.ButtonFIllter.UseVisualStyleBackColor = false;
            // 
            // ButtonFind
            // 
            this.ButtonFind.BackColor = System.Drawing.Color.Transparent;
            this.ButtonFind.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonFind.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.ButtonFind.BorderRadius = 6;
            this.ButtonFind.BorderSize = 2;
            this.ButtonFind.FlatAppearance.BorderSize = 0;
            this.ButtonFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFind.Font = new System.Drawing.Font("Orbitron SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.ButtonFind.Location = new System.Drawing.Point(290, 335);
            this.ButtonFind.Name = "ButtonFind";
            this.ButtonFind.Size = new System.Drawing.Size(97, 32);
            this.ButtonFind.TabIndex = 65;
            this.ButtonFind.Text = "FIND";
            this.ButtonFind.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.ButtonFind.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.panel2.Location = new System.Drawing.Point(110, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 1);
            this.panel2.TabIndex = 63;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(167)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Orbitron SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.textBoxSearch.Location = new System.Drawing.Point(110, 342);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(174, 17);
            this.textBoxSearch.TabIndex = 64;
            // 
            // labelFiltering
            // 
            this.labelFiltering.AutoSize = true;
            this.labelFiltering.Font = new System.Drawing.Font("Orbitron SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.labelFiltering.Location = new System.Drawing.Point(8, 377);
            this.labelFiltering.Name = "labelFiltering";
            this.labelFiltering.Size = new System.Drawing.Size(96, 17);
            this.labelFiltering.TabIndex = 62;
            this.labelFiltering.Text = "FILTERING:";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Orbitron SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.labelSearch.Location = new System.Drawing.Point(12, 345);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(82, 17);
            this.labelSearch.TabIndex = 61;
            this.labelSearch.Text = "SEARCH:";
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.ButtonClose.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.ButtonClose.BorderRadius = 6;
            this.ButtonClose.BorderSize = 2;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(116)))), ((int)(((byte)(88)))));
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Orbitron SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.ButtonClose.Location = new System.Drawing.Point(393, 370);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(97, 32);
            this.ButtonClose.TabIndex = 60;
            this.ButtonClose.Text = "CLEAR";
            this.ButtonClose.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.ButtonClose.UseVisualStyleBackColor = false;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.simpleInventoryManagementDataSet;
            // 
            // simpleInventoryManagementDataSet
            // 
            this.simpleInventoryManagementDataSet.DataSetName = "SimpleInventoryManagementDataSet";
            this.simpleInventoryManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsViewDataGridView
            // 
            this.productsViewDataGridView.AllowUserToAddRows = false;
            this.productsViewDataGridView.AllowUserToDeleteRows = false;
            this.productsViewDataGridView.AllowUserToOrderColumns = true;
            this.productsViewDataGridView.AllowUserToResizeColumns = false;
            this.productsViewDataGridView.AllowUserToResizeRows = false;
            this.productsViewDataGridView.AutoGenerateColumns = false;
            this.productsViewDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(167)))));
            this.productsViewDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsViewDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.productsViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRoleDataGridViewTextBoxColumn,
            this.nameRoleDataGridViewTextBoxColumn,
            this.discriptionDataGridViewTextBoxColumn});
            this.productsViewDataGridView.DataSource = this.rolesBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Orbitron Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(116)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsViewDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.productsViewDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsViewDataGridView.EnableHeadersVisualStyles = false;
            this.productsViewDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(116)))), ((int)(((byte)(88)))));
            this.productsViewDataGridView.Location = new System.Drawing.Point(0, 0);
            this.productsViewDataGridView.Name = "productsViewDataGridView";
            this.productsViewDataGridView.Size = new System.Drawing.Size(611, 305);
            this.productsViewDataGridView.TabIndex = 59;
            // 
            // idRoleDataGridViewTextBoxColumn
            // 
            this.idRoleDataGridViewTextBoxColumn.DataPropertyName = "IdRole";
            this.idRoleDataGridViewTextBoxColumn.HeaderText = "IdRole";
            this.idRoleDataGridViewTextBoxColumn.Name = "idRoleDataGridViewTextBoxColumn";
            this.idRoleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameRoleDataGridViewTextBoxColumn
            // 
            this.nameRoleDataGridViewTextBoxColumn.DataPropertyName = "NameRole";
            this.nameRoleDataGridViewTextBoxColumn.HeaderText = "NameRole";
            this.nameRoleDataGridViewTextBoxColumn.Name = "nameRoleDataGridViewTextBoxColumn";
            // 
            // discriptionDataGridViewTextBoxColumn
            // 
            this.discriptionDataGridViewTextBoxColumn.DataPropertyName = "Discription";
            this.discriptionDataGridViewTextBoxColumn.HeaderText = "Discription";
            this.discriptionDataGridViewTextBoxColumn.Name = "discriptionDataGridViewTextBoxColumn";
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.simpleInventoryManagementDataSet;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // FormAdminRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(611, 413);
            this.Controls.Add(this.rjButtonSave);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.ButtonFIllter);
            this.Controls.Add(this.ButtonFind);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelFiltering);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.productsViewDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdminRoles";
            this.Text = "FormAdminRoles";
            this.Load += new System.EventHandler(this.FormAdminRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleInventoryManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton rjButtonSave;
        private RJButton rjButton2;
        private System.Windows.Forms.ComboBox comboBox;
        private RJButton ButtonFIllter;
        private RJButton ButtonFind;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelFiltering;
        private System.Windows.Forms.Label labelSearch;
        private RJButton ButtonClose;
        private SimpleInventoryManagementDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private SimpleInventoryManagementDataSet simpleInventoryManagementDataSet;
        private System.Windows.Forms.DataGridView productsViewDataGridView;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private SimpleInventoryManagementDataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discriptionDataGridViewTextBoxColumn;
    }
}