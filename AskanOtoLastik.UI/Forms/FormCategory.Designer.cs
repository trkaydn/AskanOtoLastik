namespace AskanOtoLastik.UI.Forms
{
    partial class FormCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategory));
            categoryBindingSource = new BindingSource(components);
            category_list = new DataGridView();
            Image = new DataGridViewImageColumn();
            Id = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            CategoryMenuStrip = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            newCategoryGroup = new GroupBox();
            btnAddCategory = new Button();
            txtCategoryName = new TextBox();
            label1 = new Label();
            btnDeleteCategory = new Button();
            CategoryContextMenu = new ContextMenuStrip(components);
            silToolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)category_list).BeginInit();
            CategoryMenuStrip.SuspendLayout();
            newCategoryGroup.SuspendLayout();
            CategoryContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Data.Entities.Category);
            // 
            // category_list
            // 
            category_list.AllowUserToAddRows = false;
            category_list.AllowUserToDeleteRows = false;
            category_list.AllowUserToResizeColumns = false;
            category_list.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 248);
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            category_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            category_list.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            category_list.AutoGenerateColumns = false;
            category_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            category_list.BackgroundColor = Color.White;
            category_list.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            category_list.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            category_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            category_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            category_list.Columns.AddRange(new DataGridViewColumn[] { Image, Id, Category, Stock });
            category_list.ContextMenuStrip = CategoryMenuStrip;
            category_list.DataSource = categoryBindingSource;
            category_list.Location = new Point(53, 43);
            category_list.Margin = new Padding(4, 3, 4, 3);
            category_list.MultiSelect = false;
            category_list.Name = "category_list";
            category_list.ReadOnly = true;
            category_list.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            category_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            category_list.RowHeadersVisible = false;
            category_list.RowHeadersWidth = 72;
            category_list.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            category_list.RowTemplate.ContextMenuStrip = CategoryMenuStrip;
            category_list.ScrollBars = ScrollBars.Vertical;
            category_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            category_list.Size = new Size(1231, 438);
            category_list.TabIndex = 0;
            category_list.CellContextMenuStripNeeded += category_list_CellContextMenuStripNeeded;
            category_list.DataBindingComplete += category_list_DataBindingComplete;
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
            // Category
            // 
            Category.DataPropertyName = "Name";
            Category.HeaderText = "Kategori";
            Category.MinimumWidth = 9;
            Category.Name = "Category";
            Category.ReadOnly = true;
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
            // CategoryMenuStrip
            // 
            CategoryMenuStrip.ImageScalingSize = new Size(28, 28);
            CategoryMenuStrip.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem });
            CategoryMenuStrip.Name = "CategoryMenuStrip";
            CategoryMenuStrip.Size = new Size(108, 40);
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(107, 36);
            silToolStripMenuItem.Text = "Sil";
            // 
            // newCategoryGroup
            // 
            newCategoryGroup.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            newCategoryGroup.Controls.Add(btnAddCategory);
            newCategoryGroup.Controls.Add(txtCategoryName);
            newCategoryGroup.Controls.Add(label1);
            newCategoryGroup.Location = new Point(56, 499);
            newCategoryGroup.Margin = new Padding(4, 3, 4, 3);
            newCategoryGroup.Name = "newCategoryGroup";
            newCategoryGroup.Padding = new Padding(4, 3, 4, 3);
            newCategoryGroup.Size = new Size(481, 195);
            newCategoryGroup.TabIndex = 1;
            newCategoryGroup.TabStop = false;
            newCategoryGroup.Text = "Yeni Kategori Girişi";
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = Color.PaleGreen;
            btnAddCategory.Cursor = Cursors.Hand;
            btnAddCategory.FlatStyle = FlatStyle.Flat;
            btnAddCategory.Location = new Point(340, 125);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(120, 50);
            btnAddCategory.TabIndex = 4;
            btnAddCategory.Text = "Kaydet";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(191, 66);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(269, 39);
            txtCategoryName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 69);
            label1.Name = "label1";
            label1.Size = new Size(178, 32);
            label1.TabIndex = 0;
            label1.Text = "Kategori Adı:";
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteCategory.BackColor = Color.Tomato;
            btnDeleteCategory.Cursor = Cursors.Hand;
            btnDeleteCategory.FlatStyle = FlatStyle.Flat;
            btnDeleteCategory.ForeColor = SystemColors.ControlText;
            btnDeleteCategory.Location = new Point(1117, 499);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(170, 50);
            btnDeleteCategory.TabIndex = 2;
            btnDeleteCategory.Text = "Seçileni Sil";
            btnDeleteCategory.UseVisualStyleBackColor = false;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // CategoryContextMenu
            // 
            CategoryContextMenu.ImageScalingSize = new Size(28, 28);
            CategoryContextMenu.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem1 });
            CategoryContextMenu.Name = "contextMenuStrip1";
            CategoryContextMenu.Size = new Size(108, 40);
            // 
            // silToolStripMenuItem1
            // 
            silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            silToolStripMenuItem1.Size = new Size(107, 36);
            silToolStripMenuItem1.Text = "Sil";
            silToolStripMenuItem1.Click += silToolStripMenuItem_Click;
            // 
            // FormCategory
            // 
            AcceptButton = btnAddCategory;
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1344, 740);
            Controls.Add(btnDeleteCategory);
            Controls.Add(newCategoryGroup);
            Controls.Add(category_list);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormCategory";
            Padding = new Padding(53, 43, 53, 43);
            Text = "FrmCategory";
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)category_list).EndInit();
            CategoryMenuStrip.ResumeLayout(false);
            newCategoryGroup.ResumeLayout(false);
            newCategoryGroup.PerformLayout();
            CategoryContextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private BindingSource categoryBindingSource;
        private DataGridView category_list;
        private GroupBox newCategoryGroup;
        private TextBox txtCategoryName;
        private Label label1;
        private Button btnAddCategory;
        private Button btnDeleteCategory;
        private ContextMenuStrip CategoryMenuStrip;
        private ToolStripMenuItem silToolStripMenuItem;
        private ContextMenuStrip CategoryContextMenu;
        private ToolStripMenuItem silToolStripMenuItem1;
        private DataGridViewImageColumn Image;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Stock;
    }
}