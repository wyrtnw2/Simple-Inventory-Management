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
            this.simpleInventoryManagementDataSet = new Simple_Inventory_Management.SimpleInventoryManagementDataSet();
            this.productsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsViewTableAdapter = new Simple_Inventory_Management.SimpleInventoryManagementDataSetTableAdapters.ProductsViewTableAdapter();
            this.tableAdapterManager = new Simple_Inventory_Management.SimpleInventoryManagementDataSetTableAdapters.TableAdapterManager();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelFiltering = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.rjButtonREP = new Simple_Inventory_Management.RJButton();
            this.ButtonFIllter = new Simple_Inventory_Management.RJButton();
            this.ButtonFind = new Simple_Inventory_Management.RJButton();
            this.ButtonClose = new Simple_Inventory_Management.RJButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minStockLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxStockLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.simpleInventoryManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Orbitron SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.labelSearch.Location = new System.Drawing.Point(22, 318);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(82, 17);
            this.labelSearch.TabIndex = 3;
            this.labelSearch.Text = "SEARCH:";
            // 
            // labelFiltering
            // 
            this.labelFiltering.AutoSize = true;
            this.labelFiltering.Font = new System.Drawing.Font("Orbitron SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.labelFiltering.Location = new System.Drawing.Point(18, 350);
            this.labelFiltering.Name = "labelFiltering";
            this.labelFiltering.Size = new System.Drawing.Size(96, 17);
            this.labelFiltering.TabIndex = 4;
            this.labelFiltering.Text = "FILTERING:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.panel2.Location = new System.Drawing.Point(120, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 1);
            this.panel2.TabIndex = 30;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(167)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Orbitron SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.textBoxSearch.Location = new System.Drawing.Point(120, 315);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(170, 17);
            this.textBoxSearch.TabIndex = 31;
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
            this.comboBox.Location = new System.Drawing.Point(121, 350);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(169, 24);
            this.comboBox.TabIndex = 35;
            // 
            // rjButtonREP
            // 
            this.rjButtonREP.BackColor = System.Drawing.Color.Transparent;
            this.rjButtonREP.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButtonREP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.rjButtonREP.BorderRadius = 6;
            this.rjButtonREP.BorderSize = 2;
            this.rjButtonREP.FlatAppearance.BorderSize = 0;
            this.rjButtonREP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(116)))), ((int)(((byte)(88)))));
            this.rjButtonREP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonREP.Font = new System.Drawing.Font("Orbitron SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonREP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.rjButtonREP.Location = new System.Drawing.Point(399, 309);
            this.rjButtonREP.Name = "rjButtonREP";
            this.rjButtonREP.Size = new System.Drawing.Size(97, 32);
            this.rjButtonREP.TabIndex = 36;
            this.rjButtonREP.Text = "REPORT";
            this.rjButtonREP.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.rjButtonREP.UseVisualStyleBackColor = false;
            this.rjButtonREP.Click += new System.EventHandler(this.rjButtonREP_Click);
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
            this.ButtonFIllter.Location = new System.Drawing.Point(296, 344);
            this.ButtonFIllter.Name = "ButtonFIllter";
            this.ButtonFIllter.Size = new System.Drawing.Size(97, 32);
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
            this.ButtonFind.Location = new System.Drawing.Point(296, 309);
            this.ButtonFind.Name = "ButtonFind";
            this.ButtonFind.Size = new System.Drawing.Size(97, 32);
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
            this.ButtonClose.BorderRadius = 6;
            this.ButtonClose.BorderSize = 2;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(116)))), ((int)(((byte)(88)))));
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Orbitron SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.ButtonClose.Location = new System.Drawing.Point(399, 344);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(97, 32);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.Text = "CLEAR";
            this.ButtonClose.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articleDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.minStockLevelDataGridViewTextBoxColumn,
            this.maxStockLevelDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.salePriceDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.unitNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 305);
            this.dataGridView1.TabIndex = 61;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Article";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            // 
            // minStockLevelDataGridViewTextBoxColumn
            // 
            this.minStockLevelDataGridViewTextBoxColumn.DataPropertyName = "MinStockLevel";
            this.minStockLevelDataGridViewTextBoxColumn.HeaderText = "MinStockLevel";
            this.minStockLevelDataGridViewTextBoxColumn.Name = "minStockLevelDataGridViewTextBoxColumn";
            // 
            // maxStockLevelDataGridViewTextBoxColumn
            // 
            this.maxStockLevelDataGridViewTextBoxColumn.DataPropertyName = "MaxStockLevel";
            this.maxStockLevelDataGridViewTextBoxColumn.HeaderText = "MaxStockLevel";
            this.maxStockLevelDataGridViewTextBoxColumn.Name = "maxStockLevelDataGridViewTextBoxColumn";
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            this.salePriceDataGridViewTextBoxColumn.DataPropertyName = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn.HeaderText = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            // 
            // unitNameDataGridViewTextBoxColumn
            // 
            this.unitNameDataGridViewTextBoxColumn.DataPropertyName = "UnitName";
            this.unitNameDataGridViewTextBoxColumn.HeaderText = "UnitName";
            this.unitNameDataGridViewTextBoxColumn.Name = "unitNameDataGridViewTextBoxColumn";
            // 
            // FormMnagerProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(611, 386);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rjButtonREP);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.ButtonFIllter);
            this.Controls.Add(this.ButtonFind);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelFiltering);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.ButtonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMnagerProducts";
            this.Text = "FormMnagerProducts";
            this.Load += new System.EventHandler(this.FormMnagerProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.simpleInventoryManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton ButtonClose;
        private SimpleInventoryManagementDataSet simpleInventoryManagementDataSet;
        private System.Windows.Forms.BindingSource productsViewBindingSource;
        private SimpleInventoryManagementDataSetTableAdapters.ProductsViewTableAdapter productsViewTableAdapter;
        private SimpleInventoryManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelFiltering;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private RJButton ButtonFind;
        private RJButton ButtonFIllter;
        private System.Windows.Forms.ComboBox comboBox;
        private RJButton rjButtonREP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minStockLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxStockLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitNameDataGridViewTextBoxColumn;
    }
}