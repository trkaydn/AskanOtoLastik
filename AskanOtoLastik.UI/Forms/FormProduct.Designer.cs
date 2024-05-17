namespace AskanOtoLastik.UI.Forms
{
    partial class FormProduct
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            Product_List = new DataGridView();
            Image = new DataGridViewImageColumn();
            Id = new DataGridViewTextBoxColumn();
            NameCol = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            ProductContextMenu = new ContextMenuStrip(components);
            AddProductToolStripMenuItem = new ToolStripMenuItem();
            UpdateStockToolStripMenuItem = new ToolStripMenuItem();
            EditProductToolStripMenuItem = new ToolStripMenuItem();
            DeleteProductToolStripMenuItem = new ToolStripMenuItem();
            productBindingSource = new BindingSource(components);
            txtSearch = new TextBox();
            lblSearch = new Label();
            cmbCategory = new ComboBox();
            grpFilter = new GroupBox();
            lblBrand = new Label();
            cmbBrand = new ComboBox();
            lblCategory = new Label();
            grpActions = new GroupBox();
            btnEditStock = new Button();
            btnEditProduct = new Button();
            btnDeleteProduct = new Button();
            btn_NewProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)Product_List).BeginInit();
            ProductContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            grpFilter.SuspendLayout();
            grpActions.SuspendLayout();
            SuspendLayout();
            // 
            // Product_List
            // 
            Product_List.AllowUserToAddRows = false;
            Product_List.AllowUserToDeleteRows = false;
            Product_List.AllowUserToResizeColumns = false;
            Product_List.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 248);
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            Product_List.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            Product_List.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Product_List.AutoGenerateColumns = false;
            Product_List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Product_List.BackgroundColor = Color.White;
            Product_List.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Product_List.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Product_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Product_List.ColumnHeadersHeight = 40;
            Product_List.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Product_List.Columns.AddRange(new DataGridViewColumn[] { Image, Id, NameCol, Category, Year, Stock });
            Product_List.ContextMenuStrip = ProductContextMenu;
            Product_List.DataSource = productBindingSource;
            Product_List.Location = new Point(61, 265);
            Product_List.Margin = new Padding(4, 3, 4, 3);
            Product_List.MultiSelect = false;
            Product_List.Name = "Product_List";
            Product_List.ReadOnly = true;
            Product_List.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Product_List.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            Product_List.RowHeadersVisible = false;
            Product_List.RowHeadersWidth = 72;
            Product_List.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            Product_List.RowTemplate.ContextMenuStrip = ProductContextMenu;
            Product_List.ScrollBars = ScrollBars.Vertical;
            Product_List.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Product_List.Size = new Size(1227, 429);
            Product_List.TabIndex = 8;
            Product_List.CellContextMenuStripNeeded += Brand_list_CellContextMenuStripNeeded;
            Product_List.CellMouseDoubleClick += Product_List_CellMouseDoubleClick;
            Product_List.DataBindingComplete += Product_List_DataBindingComplete;
            // 
            // Image
            // 
            Image.FillWeight = 10F;
            Image.HeaderText = "";
            Image.Image = (Image)resources.GetObject("Image.Image");
            Image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Image.MinimumWidth = 9;
            Image.Name = "Image";
            Image.ReadOnly = true;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 9;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // NameCol
            // 
            NameCol.DataPropertyName = "Name";
            NameCol.HeaderText = "Ürün";
            NameCol.MinimumWidth = 9;
            NameCol.Name = "NameCol";
            NameCol.ReadOnly = true;
            // 
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.FillWeight = 30F;
            Category.HeaderText = "Kategori";
            Category.MinimumWidth = 9;
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // Year
            // 
            Year.DataPropertyName = "Year";
            Year.FillWeight = 15F;
            Year.HeaderText = "Yıl";
            Year.MinimumWidth = 9;
            Year.Name = "Year";
            Year.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.DataPropertyName = "Stock";
            Stock.FillWeight = 15F;
            Stock.HeaderText = "Stok";
            Stock.MinimumWidth = 9;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // ProductContextMenu
            // 
            ProductContextMenu.ImageScalingSize = new Size(28, 28);
            ProductContextMenu.Items.AddRange(new ToolStripItem[] { AddProductToolStripMenuItem, UpdateStockToolStripMenuItem, EditProductToolStripMenuItem, DeleteProductToolStripMenuItem });
            ProductContextMenu.Name = "ProductMenuStrip";
            ProductContextMenu.Size = new Size(212, 148);
            // 
            // AddProductToolStripMenuItem
            // 
            AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem";
            AddProductToolStripMenuItem.Size = new Size(211, 36);
            AddProductToolStripMenuItem.Text = "Ürün Ekle";
            AddProductToolStripMenuItem.Click += btn_NewProduct_Click;
            // 
            // UpdateStockToolStripMenuItem
            // 
            UpdateStockToolStripMenuItem.Name = "UpdateStockToolStripMenuItem";
            UpdateStockToolStripMenuItem.Size = new Size(211, 36);
            UpdateStockToolStripMenuItem.Text = "Stok Güncelle";
            UpdateStockToolStripMenuItem.Click += btnEditStock_Click;
            // 
            // EditProductToolStripMenuItem
            // 
            EditProductToolStripMenuItem.Name = "EditProductToolStripMenuItem";
            EditProductToolStripMenuItem.Size = new Size(211, 36);
            EditProductToolStripMenuItem.Text = "Düzenle";
            EditProductToolStripMenuItem.Click += btnEditProduct_Click;
            // 
            // DeleteProductToolStripMenuItem
            // 
            DeleteProductToolStripMenuItem.Name = "DeleteProductToolStripMenuItem";
            DeleteProductToolStripMenuItem.Size = new Size(211, 36);
            DeleteProductToolStripMenuItem.Text = "Sil";
            DeleteProductToolStripMenuItem.Click += btnDeleteProduct_Click;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Data.Entities.Product);
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(154, 49);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(359, 39);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Microsoft Sans Serif", 12F);
            lblSearch.Location = new Point(19, 52);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(66, 32);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Ara:";
            // 
            // cmbCategory
            // 
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.IntegralHeight = false;
            cmbCategory.Location = new Point(154, 102);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(359, 40);
            cmbCategory.TabIndex = 2;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(lblBrand);
            grpFilter.Controls.Add(cmbBrand);
            grpFilter.Controls.Add(lblCategory);
            grpFilter.Controls.Add(cmbCategory);
            grpFilter.Controls.Add(txtSearch);
            grpFilter.Controls.Add(lblSearch);
            grpFilter.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpFilter.Location = new Point(61, 21);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new Size(539, 218);
            grpFilter.TabIndex = 4;
            grpFilter.TabStop = false;
            grpFilter.Text = "Ürün Filtrele";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Microsoft Sans Serif", 12F);
            lblBrand.Location = new Point(19, 159);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(100, 32);
            lblBrand.TabIndex = 6;
            lblBrand.Text = "Marka:";
            // 
            // cmbBrand
            // 
            cmbBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBrand.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbBrand.FormattingEnabled = true;
            cmbBrand.IntegralHeight = false;
            cmbBrand.Location = new Point(154, 156);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(359, 40);
            cmbBrand.TabIndex = 3;
            cmbBrand.SelectedIndexChanged += cmbBrand_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Microsoft Sans Serif", 12F);
            lblCategory.Location = new Point(19, 105);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(129, 32);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Kategori:";
            // 
            // grpActions
            // 
            grpActions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grpActions.Controls.Add(btnEditStock);
            grpActions.Controls.Add(btnEditProduct);
            grpActions.Controls.Add(btnDeleteProduct);
            grpActions.Controls.Add(btn_NewProduct);
            grpActions.Location = new Point(749, 21);
            grpActions.Name = "grpActions";
            grpActions.Size = new Size(539, 218);
            grpActions.TabIndex = 5;
            grpActions.TabStop = false;
            grpActions.Text = "İşlemler";
            // 
            // btnEditStock
            // 
            btnEditStock.BackColor = Color.PaleTurquoise;
            btnEditStock.Cursor = Cursors.Hand;
            btnEditStock.FlatStyle = FlatStyle.Flat;
            btnEditStock.ForeColor = SystemColors.ControlText;
            btnEditStock.Location = new Point(15, 145);
            btnEditStock.Name = "btnEditStock";
            btnEditStock.Size = new Size(210, 56);
            btnEditStock.TabIndex = 5;
            btnEditStock.Text = "Stok Güncelle";
            btnEditStock.UseVisualStyleBackColor = false;
            btnEditStock.Click += btnEditStock_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.BackColor = Color.LemonChiffon;
            btnEditProduct.Cursor = Cursors.Hand;
            btnEditProduct.FlatStyle = FlatStyle.Flat;
            btnEditProduct.ForeColor = SystemColors.ControlText;
            btnEditProduct.Location = new Point(244, 145);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(143, 56);
            btnEditProduct.TabIndex = 6;
            btnEditProduct.Text = "Düzenle";
            btnEditProduct.UseVisualStyleBackColor = false;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.Tomato;
            btnDeleteProduct.Cursor = Cursors.Hand;
            btnDeleteProduct.FlatStyle = FlatStyle.Flat;
            btnDeleteProduct.ForeColor = SystemColors.ControlText;
            btnDeleteProduct.Location = new Point(406, 145);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(119, 56);
            btnDeleteProduct.TabIndex = 7;
            btnDeleteProduct.Text = "Sil";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btn_NewProduct
            // 
            btn_NewProduct.BackColor = SystemColors.GradientActiveCaption;
            btn_NewProduct.Cursor = Cursors.Hand;
            btn_NewProduct.FlatStyle = FlatStyle.Flat;
            btn_NewProduct.Location = new Point(15, 49);
            btn_NewProduct.Name = "btn_NewProduct";
            btn_NewProduct.Size = new Size(510, 66);
            btn_NewProduct.TabIndex = 4;
            btn_NewProduct.Text = "Ürün Ekle";
            btn_NewProduct.UseVisualStyleBackColor = false;
            btn_NewProduct.Click += btn_NewProduct_Click;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1344, 740);
            Controls.Add(grpActions);
            Controls.Add(grpFilter);
            Controls.Add(Product_List);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormProduct";
            Padding = new Padding(53, 43, 53, 43);
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormProduct";
            ((System.ComponentModel.ISupportInitialize)Product_List).EndInit();
            ProductContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            grpFilter.ResumeLayout(false);
            grpFilter.PerformLayout();
            grpActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Product_List;
        private BindingSource productBindingSource;
        private TextBox txtSearch;
        private Label lblSearch;
        private ComboBox cmbCategory;
        private GroupBox grpFilter;
        private Label lblBrand;
        private ComboBox cmbBrand;
        private Label lblCategory;
        private ContextMenuStrip ProductContextMenu;
        private ToolStripMenuItem EditProductToolStripMenuItem;
        private ToolStripMenuItem DeleteProductToolStripMenuItem;
        private ToolStripMenuItem UpdateStockToolStripMenuItem;
        private ToolStripMenuItem AddProductToolStripMenuItem;
        private GroupBox grpActions;
        private Button btnDeleteProduct;
        private Button btnEditProduct;
        private Button btnEditStock;
        private Button btn_NewProduct;
        private DataGridViewImageColumn Image;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Stock;
    }
}