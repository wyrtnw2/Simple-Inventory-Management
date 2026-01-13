namespace Simple_Inventory_Management
{
    partial class FormSalesmanPriceHistory
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
            this.purchaseOrdersTableAdapter = new Simple_Inventory_Management.SimpleInventoryManagementDataSetTableAdapters.PurchaseOrdersTableAdapter();
            this.purchaseOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simpleInventoryManagementDataSet = new Simple_Inventory_Management.SimpleInventoryManagementDataSet();
            this.categoriesTableAdapter = new Simple_Inventory_Management.SimpleInventoryManagementDataSetTableAdapters.CategoriesTableAdapter();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rjButtonREP = new Simple_Inventory_Management.RJButton();
            this.ButtonFind = new Simple_Inventory_Management.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.categoriesTableAdapter1 = new Simple_Inventory_Management.SimpleInventoryManagementDataSetTableAdapters.CategoriesTableAdapter();
            this.rjButtonSave = new Simple_Inventory_Management.RJButton();
            this.rjButton2 = new Simple_Inventory_Management.RJButton();
            this.labelSearch = new System.Windows.Forms.Label();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new Simple_Inventory_Management.SimpleInventoryManagementDataSetTableAdapters.StockTableAdapter();
            this.priceHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceHistoryTableAdapter = new Simple_Inventory_Management.SimpleInventoryManagementDataSetTableAdapters.PriceHistoryTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.priceHistoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changedByUserIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleInventoryManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // purchaseOrdersTableAdapter
            // 
            this.purchaseOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseOrdersBindingSource
            // 
            this.purchaseOrdersBindingSource.DataMember = "PurchaseOrders";
            this.purchaseOrdersBindingSource.DataSource = this.simpleInventoryManagementDataSet;
            // 
            // simpleInventoryManagementDataSet
            // 
            this.simpleInventoryManagementDataSet.DataSetName = "SimpleInventoryManagementDataSet";
            this.simpleInventoryManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.simpleInventoryManagementDataSet;
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
            this.rjButtonREP.Location = new System.Drawing.Point(397, 341);
            this.rjButtonREP.Name = "rjButtonREP";
            this.rjButtonREP.Size = new System.Drawing.Size(97, 32);
            this.rjButtonREP.TabIndex = 73;
            this.rjButtonREP.Text = "REPORT";
            this.rjButtonREP.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.rjButtonREP.UseVisualStyleBackColor = false;
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
            this.ButtonFind.Location = new System.Drawing.Point(294, 341);
            this.ButtonFind.Name = "ButtonFind";
            this.ButtonFind.Size = new System.Drawing.Size(97, 32);
            this.ButtonFind.TabIndex = 72;
            this.ButtonFind.Text = "FIND";
            this.ButtonFind.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.ButtonFind.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.panel2.Location = new System.Drawing.Point(114, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 1);
            this.panel2.TabIndex = 70;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(167)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Orbitron SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.textBoxSearch.Location = new System.Drawing.Point(114, 348);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(174, 17);
            this.textBoxSearch.TabIndex = 71;
            // 
            // categoriesTableAdapter1
            // 
            this.categoriesTableAdapter1.ClearBeforeFill = true;
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
            this.rjButtonSave.Location = new System.Drawing.Point(500, 340);
            this.rjButtonSave.Name = "rjButtonSave";
            this.rjButtonSave.Size = new System.Drawing.Size(97, 32);
            this.rjButtonSave.TabIndex = 75;
            this.rjButtonSave.Text = "SAVE";
            this.rjButtonSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.rjButtonSave.UseVisualStyleBackColor = false;
            this.rjButtonSave.Click += new System.EventHandler(this.rjButtonSave_Click_1);
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
            this.rjButton2.Location = new System.Drawing.Point(397, 378);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(97, 32);
            this.rjButton2.TabIndex = 74;
            this.rjButton2.Text = "ADD";
            this.rjButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Orbitron SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(5)))));
            this.labelSearch.Location = new System.Drawing.Point(16, 351);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(82, 17);
            this.labelSearch.TabIndex = 69;
            this.labelSearch.Text = "SEARCH:";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.simpleInventoryManagementDataSet;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // priceHistoryBindingSource
            // 
            this.priceHistoryBindingSource.DataMember = "PriceHistory";
            this.priceHistoryBindingSource.DataSource = this.simpleInventoryManagementDataSet;
            // 
            // priceHistoryTableAdapter
            // 
            this.priceHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.priceHistoryIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.priceTypeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.changedByUserIdDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.priceHistoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(616, 335);
            this.dataGridView1.TabIndex = 76;
            // 
            // priceHistoryIdDataGridViewTextBoxColumn
            // 
            this.priceHistoryIdDataGridViewTextBoxColumn.DataPropertyName = "PriceHistoryId";
            this.priceHistoryIdDataGridViewTextBoxColumn.HeaderText = "PriceHistoryId";
            this.priceHistoryIdDataGridViewTextBoxColumn.Name = "priceHistoryIdDataGridViewTextBoxColumn";
            this.priceHistoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            // 
            // priceTypeDataGridViewTextBoxColumn
            // 
            this.priceTypeDataGridViewTextBoxColumn.DataPropertyName = "PriceType";
            this.priceTypeDataGridViewTextBoxColumn.HeaderText = "PriceType";
            this.priceTypeDataGridViewTextBoxColumn.Name = "priceTypeDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // changedByUserIdDataGridViewTextBoxColumn
            // 
            this.changedByUserIdDataGridViewTextBoxColumn.DataPropertyName = "ChangedByUserId";
            this.changedByUserIdDataGridViewTextBoxColumn.HeaderText = "ChangedByUserId";
            this.changedByUserIdDataGridViewTextBoxColumn.Name = "changedByUserIdDataGridViewTextBoxColumn";
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            // 
            // FormSalesmanPriceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(611, 413);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rjButtonREP);
            this.Controls.Add(this.ButtonFind);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.rjButtonSave);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.labelSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSalesmanPriceHistory";
            this.Text = "FormSelesmanPriceHistory";
            this.Load += new System.EventHandler(this.FormSalesmanPriceHistory_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleInventoryManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SimpleInventoryManagementDataSetTableAdapters.PurchaseOrdersTableAdapter purchaseOrdersTableAdapter;
        private System.Windows.Forms.BindingSource purchaseOrdersBindingSource;
        private SimpleInventoryManagementDataSet simpleInventoryManagementDataSet;
        private SimpleInventoryManagementDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private RJButton rjButtonREP;
        private RJButton ButtonFind;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private SimpleInventoryManagementDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
        private RJButton rjButtonSave;
        private RJButton rjButton2;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private SimpleInventoryManagementDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.BindingSource priceHistoryBindingSource;
        private SimpleInventoryManagementDataSetTableAdapters.PriceHistoryTableAdapter priceHistoryTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceHistoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changedByUserIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
    }
}