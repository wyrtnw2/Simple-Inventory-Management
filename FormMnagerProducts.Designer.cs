namespace Simple_Inventory_Management
{
    partial class FormMnagerProducts
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
            this.simpleInventoryManagementDataSet = new Simple_Inventory_Management.SimpleInventoryManagementDataSet();
            this.productsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsViewTableAdapter = new Simple_Inventory_Management.SimpleInventoryManagementDataSetTableAdapters.ProductsViewTableAdapter();
            this.tableAdapterManager = new Simple_Inventory_Management.SimpleInventoryManagementDataSetTableAdapters.TableAdapterManager();
            this.productsViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelFiltering = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxFiltering = new System.Windows.Forms.ComboBox();
            this.ButtonFIllter = new Simple_Inventory_Management.RJButton();
            this.ButtonFind = new Simple_Inventory_Management.RJButton();
            this.ButtonClose = new Simple_Inventory_Management.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.simpleInventoryManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleInventoryManagementDataSet
            // 
            this.simpleInventoryManagementDataSet.DataSetName = "SimpleInventoryManagementDataSet";
            this.simpleInventoryManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsViewBindingSource
            // 
            this.productsViewBindingSource.DataMember = "ProductsView";
            this.productsViewBindingSource.DataSource = this.simpleInventoryManagementDataSet;
            // 
            // productsViewTableAdapter
            // 
            this.productsViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DocumentItemsTableAdapter = null;
            this.tableAdapterManager.DocumentsTableAdapter = null;
            this.tableAdapterManager.DocumentTypesTableAdapter = null;
            this.tableAdapterManager.PriceHistoryTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.PurchaseOrdersTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.StatusesOrdersTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UnitsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Simple_Inventory_Management.SimpleInventoryManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.WarehousesTableAdapter = null;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.productsViewDataGridView.DataSource = this.productsViewBindingSource;
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
            this.productsViewDataGridView.Size = new System.Drawing.Size(611, 328);
            this.productsViewDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Article";
            this.dataGridViewTextBoxColumn1.HeaderText = "Article";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 89;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CategoryName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Category";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 73;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 84;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Manufacturer";
            this.dataGridViewTextBoxColumn5.HeaderText = "Manufacturer";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 94;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MinStockLevel";
            this.dataGridViewTextBoxColumn6.HeaderText = "Minimal stock level";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 90;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MaxStockLevel";
            this.dataGridViewTextBoxColumn7.HeaderText = "Maximum stock level";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 98;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PurchasePrice";
            this.dataGridViewTextBoxColumn8.HeaderText = "Purchase price";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 94;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "SalePrice";
            this.dataGridViewTextBoxColumn9.HeaderText = "Sale price";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 72;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsActive";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Is active";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 47;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SupplierName";
            this.dataGridViewTextBoxColumn10.HeaderText = "Supplier";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 69;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "UnitName";
            this.dataGridViewTextBoxColumn11.HeaderText = "Unit name";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 73;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Orbitron SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.labelSearch.Location = new System.Drawing.Point(12, 337);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(69, 17);
            this.labelSearch.TabIndex = 3;
            this.labelSearch.Text = "Search:";
            // 
            // labelFiltering
            // 
            this.labelFiltering.AutoSize = true;
            this.labelFiltering.Font = new System.Drawing.Font("Orbitron SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.labelFiltering.Location = new System.Drawing.Point(12, 365);
            this.labelFiltering.Name = "labelFiltering";
            this.labelFiltering.Size = new System.Drawing.Size(74, 17);
            this.labelFiltering.TabIndex = 4;
            this.labelFiltering.Text = "Filtering:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.panel2.Location = new System.Drawing.Point(87, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 1);
            this.panel2.TabIndex = 30;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(167)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Orbitron SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.textBoxSearch.Location = new System.Drawing.Point(87, 334);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(226, 17);
            this.textBoxSearch.TabIndex = 31;
            // 
            // comboBoxFiltering
            // 
            this.comboBoxFiltering.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(167)))));
            this.comboBoxFiltering.Font = new System.Drawing.Font("Orbitron SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.comboBoxFiltering.FormattingEnabled = true;
            this.comboBoxFiltering.Items.AddRange(new object[] {
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
            this.comboBoxFiltering.Location = new System.Drawing.Point(87, 360);
            this.comboBoxFiltering.Name = "comboBoxFiltering";
            this.comboBoxFiltering.Size = new System.Drawing.Size(226, 24);
            this.comboBoxFiltering.TabIndex = 32;
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
            this.ButtonFIllter.Location = new System.Drawing.Point(319, 365);
            this.ButtonFIllter.Name = "ButtonFIllter";
            this.ButtonFIllter.Size = new System.Drawing.Size(97, 20);
            this.ButtonFIllter.TabIndex = 34;
            this.ButtonFIllter.Text = "FILLTER";
            this.ButtonFIllter.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.ButtonFIllter.UseVisualStyleBackColor = false;
            this.ButtonFIllter.Click += new System.EventHandler(this.ButtonFIllter_Click);
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
            this.ButtonFind.Location = new System.Drawing.Point(319, 334);
            this.ButtonFind.Name = "ButtonFind";
            this.ButtonFind.Size = new System.Drawing.Size(97, 20);
            this.ButtonFind.TabIndex = 33;
            this.ButtonFind.Text = "FIND";
            this.ButtonFind.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.ButtonFind.UseVisualStyleBackColor = false;
            this.ButtonFind.Click += new System.EventHandler(this.ButtonFind_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.ButtonClose.BackgroundColor = System.Drawing.Color.Transparent;
            this.ButtonClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.ButtonClose.BorderRadius = 10;
            this.ButtonClose.BorderSize = 2;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(116)))), ((int)(((byte)(88)))));
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Orbitron SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.ButtonClose.Location = new System.Drawing.Point(449, 342);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(150, 40);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.Text = "CLOSE";
            this.ButtonClose.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // FormMnagerProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(611, 394);
            this.Controls.Add(this.ButtonFIllter);
            this.Controls.Add(this.ButtonFind);
            this.Controls.Add(this.comboBoxFiltering);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelFiltering);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.productsViewDataGridView);
            this.Controls.Add(this.ButtonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMnagerProducts";
            this.Text = "FormMnagerProducts";
            this.Load += new System.EventHandler(this.FormMnagerProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.simpleInventoryManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton ButtonClose;
        private SimpleInventoryManagementDataSet simpleInventoryManagementDataSet;
        private System.Windows.Forms.BindingSource productsViewBindingSource;
        private SimpleInventoryManagementDataSetTableAdapters.ProductsViewTableAdapter productsViewTableAdapter;
        private SimpleInventoryManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView productsViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelFiltering;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxFiltering;
        private RJButton ButtonFind;
        private RJButton ButtonFIllter;
    }
}