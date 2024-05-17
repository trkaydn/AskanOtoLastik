namespace AskanOtoLastik.UI.Forms
{
    partial class FormBrand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBrand));
            Brand_list = new DataGridView();
            Image = new DataGridViewImageColumn();
            Id = new DataGridViewTextBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            BrandContextMenu = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            brandBindingSource = new BindingSource(components);
            measuresBindingSource = new BindingSource(components);
            measureInchBindingSource = new BindingSource(components);
            newBrandGroup = new GroupBox();
            btnAddBrand = new Button();
            txtBrandName = new TextBox();
            label1 = new Label();
            btnDeleteBrand = new Button();
            ((System.ComponentModel.ISupportInitialize)Brand_list).BeginInit();
            BrandContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)brandBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)measuresBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)measureInchBindingSource).BeginInit();
            newBrandGroup.SuspendLayout();
            SuspendLayout();
            // 
            // Brand_list
            // 
            Brand_list.AllowUserToAddRows = false;
            Brand_list.AllowUserToDeleteRows = false;
            Brand_list.AllowUserToResizeColumns = false;
            Brand_list.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 248);
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            Brand_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            Brand_list.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Brand_list.AutoGenerateColumns = false;
            Brand_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Brand_list.BackgroundColor = Color.White;
            Brand_list.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Brand_list.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Brand_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Brand_list.ColumnHeadersHeight = 40;
            Brand_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Brand_list.Columns.AddRange(new DataGridViewColumn[] { Image, Id, Brand, Stock });
            Brand_list.ContextMenuStrip = BrandContextMenu;
            Brand_list.DataSource = brandBindingSource;
            Brand_list.Location = new Point(53, 43);
            Brand_list.Margin = new Padding(4, 3, 4, 3);
            Brand_list.MultiSelect = false;
            Brand_list.Name = "Brand_list";
            Brand_list.ReadOnly = true;
            Brand_list.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Brand_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            Brand_list.RowHeadersVisible = false;
            Brand_list.RowHeadersWidth = 72;
            Brand_list.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            Brand_list.RowTemplate.ContextMenuStrip = BrandContextMenu;
            Brand_list.ScrollBars = ScrollBars.Vertical;
            Brand_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Brand_list.Size = new Size(1231, 438);
            Brand_list.TabIndex = 0;
            Brand_list.CellContextMenuStripNeeded += Brand_list_CellContextMenuStripNeeded;
            Brand_list.DataBindingComplete += Brand_list_DataBindingComplete;
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
            // Brand
            // 
            Brand.DataPropertyName = "Name";
            Brand.HeaderText = "Marka";
            Brand.MinimumWidth = 9;
            Brand.Name = "Brand";
            Brand.ReadOnly = true;
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
            // BrandContextMenu
            // 
            BrandContextMenu.ImageScalingSize = new Size(28, 28);
            BrandContextMenu.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem });
            BrandContextMenu.Name = "BrandContextMenu";
            BrandContextMenu.Size = new Size(108, 40);
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(107, 36);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // brandBindingSource
            // 
            brandBindingSource.DataSource = measuresBindingSource;
            // 
            // measuresBindingSource
            // 
            measuresBindingSource.DataMember = "Measures";
            measuresBindingSource.DataSource = measureInchBindingSource;
            // 
            // measureInchBindingSource
            // 
            measureInchBindingSource.DataSource = typeof(Data.Entities.MeasureInch);
            // 
            // newBrandGroup
            // 
            newBrandGroup.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            newBrandGroup.Controls.Add(btnAddBrand);
            newBrandGroup.Controls.Add(txtBrandName);
            newBrandGroup.Controls.Add(label1);
            newBrandGroup.Location = new Point(56, 499);
            newBrandGroup.Margin = new Padding(4, 3, 4, 3);
            newBrandGroup.Name = "newBrandGroup";
            newBrandGroup.Padding = new Padding(4, 3, 4, 3);
            newBrandGroup.Size = new Size(481, 195);
            newBrandGroup.TabIndex = 1;
            newBrandGroup.TabStop = false;
            newBrandGroup.Text = "Yeni Marka Girişi";
            // 
            // btnAddBrand
            // 
            btnAddBrand.BackColor = Color.PaleGreen;
            btnAddBrand.Cursor = Cursors.Hand;
            btnAddBrand.FlatStyle = FlatStyle.Flat;
            btnAddBrand.Location = new Point(340, 125);
            btnAddBrand.Name = "btnAddBrand";
            btnAddBrand.Size = new Size(120, 50);
            btnAddBrand.TabIndex = 3;
            btnAddBrand.Text = "Kaydet";
            btnAddBrand.UseVisualStyleBackColor = false;
            btnAddBrand.Click += btnAddBrand_Click;
            // 
            // txtBrandName
            // 
            txtBrandName.Location = new Point(191, 66);
            txtBrandName.Name = "txtBrandName";
            txtBrandName.Size = new Size(269, 39);
            txtBrandName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 69);
            label1.Name = "label1";
            label1.Size = new Size(149, 32);
            label1.TabIndex = 0;
            label1.Text = "Marka Adı:";
            // 
            // btnDeleteBrand
            // 
            btnDeleteBrand.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteBrand.BackColor = Color.Tomato;
            btnDeleteBrand.Cursor = Cursors.Hand;
            btnDeleteBrand.FlatStyle = FlatStyle.Flat;
            btnDeleteBrand.ForeColor = SystemColors.ControlText;
            btnDeleteBrand.Location = new Point(1117, 499);
            btnDeleteBrand.Name = "btnDeleteBrand";
            btnDeleteBrand.Size = new Size(170, 50);
            btnDeleteBrand.TabIndex = 1;
            btnDeleteBrand.Text = "Seçileni Sil";
            btnDeleteBrand.UseVisualStyleBackColor = false;
            btnDeleteBrand.Click += btnDeleteBrand_Click;
            // 
            // FormBrand
            // 
            AcceptButton = btnAddBrand;
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1344, 740);
            Controls.Add(btnDeleteBrand);
            Controls.Add(newBrandGroup);
            Controls.Add(Brand_list);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormBrand";
            Padding = new Padding(53, 43, 53, 43);
            Text = "FrmBrand";
            ((System.ComponentModel.ISupportInitialize)Brand_list).EndInit();
            BrandContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)brandBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)measuresBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)measureInchBindingSource).EndInit();
            newBrandGroup.ResumeLayout(false);
            newBrandGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView Brand_list;
        private GroupBox newBrandGroup;
        private TextBox txtBrandName;
        private Label label1;
        private Button btnAddBrand;
        private Button btnDeleteBrand;
        private BindingSource brandBindingSource;
        private BindingSource measureInchBindingSource;
        private BindingSource measuresBindingSource;
        private ContextMenuStrip BrandContextMenu;
        private ToolStripMenuItem silToolStripMenuItem;
        private DataGridViewImageColumn Image;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn Stock;
    }
}