namespace AskanOtoLastik.UI.Forms
{
    partial class FormMeasure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMeasure));
            MeasureBindingSource = new BindingSource(components);
            measureBindingSource2 = new BindingSource(components);
            MeasureBindingSource1 = new BindingSource(components);
            measureInchBindingSource = new BindingSource(components);
            Measure_list = new DataGridView();
            Image = new DataGridViewImageColumn();
            Id = new DataGridViewTextBoxColumn();
            Measure = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            measureBindingSource3 = new BindingSource(components);
            select_inch = new ComboBox();
            label2 = new Label();
            btnDeleteMeasure = new Button();
            newBrandGroup = new GroupBox();
            select_inch_new = new ComboBox();
            label4 = new Label();
            btnAddMeasure = new Button();
            txtMeasureName = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnDeleteInch = new Button();
            btnSaveInch = new Button();
            txtInch = new TextBox();
            label3 = new Label();
            MeasureContextMenu = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)MeasureBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)measureBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MeasureBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)measureInchBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Measure_list).BeginInit();
            ((System.ComponentModel.ISupportInitialize)measureBindingSource3).BeginInit();
            newBrandGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            MeasureContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // measureBindingSource2
            // 
            measureBindingSource2.DataSource = typeof(Data.Entities.Measure);
            // 
            // measureInchBindingSource
            // 
            measureInchBindingSource.DataSource = typeof(Data.Entities.MeasureInch);
            // 
            // Measure_list
            // 
            Measure_list.AllowUserToAddRows = false;
            Measure_list.AllowUserToDeleteRows = false;
            Measure_list.AllowUserToResizeColumns = false;
            Measure_list.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 248);
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            Measure_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            Measure_list.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Measure_list.AutoGenerateColumns = false;
            Measure_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Measure_list.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Measure_list.BackgroundColor = Color.White;
            Measure_list.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Measure_list.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Measure_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Measure_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Measure_list.Columns.AddRange(new DataGridViewColumn[] { Image, Id, Measure, Stock });
            Measure_list.DataSource = measureBindingSource3;
            Measure_list.Location = new Point(56, 110);
            Measure_list.Margin = new Padding(4, 3, 4, 3);
            Measure_list.MultiSelect = false;
            Measure_list.Name = "Measure_list";
            Measure_list.ReadOnly = true;
            Measure_list.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Measure_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            Measure_list.RowHeadersVisible = false;
            Measure_list.RowHeadersWidth = 72;
            Measure_list.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            Measure_list.RowTemplate.Resizable = DataGridViewTriState.False;
            Measure_list.ScrollBars = ScrollBars.Vertical;
            Measure_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Measure_list.Size = new Size(1231, 368);
            Measure_list.TabIndex = 2;
            Measure_list.CellContextMenuStripNeeded += MeasureList_CellContextMenuStripNeeded;
            Measure_list.DataBindingComplete += Measure_list_DataBindingComplete;
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
            // Measure
            // 
            Measure.DataPropertyName = "Name";
            Measure.HeaderText = "Ebat";
            Measure.MinimumWidth = 9;
            Measure.Name = "Measure";
            Measure.ReadOnly = true;
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
            // measureBindingSource3
            // 
            measureBindingSource3.DataSource = typeof(Data.Entities.Measure);
            // 
            // select_inch
            // 
            select_inch.Cursor = Cursors.Hand;
            select_inch.DataSource = measureInchBindingSource;
            select_inch.DisplayMember = "Inch";
            select_inch.DropDownStyle = ComboBoxStyle.DropDownList;
            select_inch.FlatStyle = FlatStyle.Flat;
            select_inch.FormattingEnabled = true;
            select_inch.IntegralHeight = false;
            select_inch.Location = new Point(171, 40);
            select_inch.Name = "select_inch";
            select_inch.Size = new Size(327, 40);
            select_inch.TabIndex = 1;
            select_inch.ValueMember = "Id";
            select_inch.SelectedIndexChanged += select_inch_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 43);
            label2.Name = "label2";
            label2.Size = new Size(109, 32);
            label2.TabIndex = 8;
            label2.Text = "Filtrele:";
            // 
            // btnDeleteMeasure
            // 
            btnDeleteMeasure.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteMeasure.BackColor = Color.Tomato;
            btnDeleteMeasure.Cursor = Cursors.Hand;
            btnDeleteMeasure.FlatStyle = FlatStyle.Flat;
            btnDeleteMeasure.ForeColor = SystemColors.ControlText;
            btnDeleteMeasure.Location = new Point(1117, 499);
            btnDeleteMeasure.Name = "btnDeleteMeasure";
            btnDeleteMeasure.Size = new Size(170, 50);
            btnDeleteMeasure.TabIndex = 3;
            btnDeleteMeasure.Text = "Seçileni Sil";
            btnDeleteMeasure.UseVisualStyleBackColor = false;
            btnDeleteMeasure.Click += btnDeleteMeasure_Click;
            // 
            // newBrandGroup
            // 
            newBrandGroup.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            newBrandGroup.Controls.Add(select_inch_new);
            newBrandGroup.Controls.Add(label4);
            newBrandGroup.Controls.Add(btnAddMeasure);
            newBrandGroup.Controls.Add(txtMeasureName);
            newBrandGroup.Controls.Add(label1);
            newBrandGroup.Location = new Point(56, 499);
            newBrandGroup.Margin = new Padding(4, 3, 4, 3);
            newBrandGroup.Name = "newBrandGroup";
            newBrandGroup.Padding = new Padding(4, 3, 4, 3);
            newBrandGroup.Size = new Size(601, 195);
            newBrandGroup.TabIndex = 9;
            newBrandGroup.TabStop = false;
            newBrandGroup.Text = "Yeni Ebat Girişi";
            // 
            // select_inch_new
            // 
            select_inch_new.Cursor = Cursors.Hand;
            select_inch_new.DisplayMember = "Inch";
            select_inch_new.DropDownStyle = ComboBoxStyle.DropDownList;
            select_inch_new.FlatStyle = FlatStyle.Flat;
            select_inch_new.FormattingEnabled = true;
            select_inch_new.IntegralHeight = false;
            select_inch_new.Location = new Point(156, 121);
            select_inch_new.Name = "select_inch_new";
            select_inch_new.Size = new Size(269, 40);
            select_inch_new.TabIndex = 5;
            select_inch_new.ValueMember = "Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 124);
            label4.Name = "label4";
            label4.Size = new Size(142, 32);
            label4.TabIndex = 3;
            label4.Text = "Jant Çapı:";
            // 
            // btnAddMeasure
            // 
            btnAddMeasure.BackColor = Color.PaleGreen;
            btnAddMeasure.Cursor = Cursors.Hand;
            btnAddMeasure.FlatStyle = FlatStyle.Flat;
            btnAddMeasure.Location = new Point(464, 124);
            btnAddMeasure.Name = "btnAddMeasure";
            btnAddMeasure.Size = new Size(120, 50);
            btnAddMeasure.TabIndex = 6;
            btnAddMeasure.Text = "Kaydet";
            btnAddMeasure.UseVisualStyleBackColor = false;
            btnAddMeasure.Click += btnAddMeasure_Click;
            // 
            // txtMeasureName
            // 
            txtMeasureName.Location = new Point(156, 66);
            txtMeasureName.Name = "txtMeasureName";
            txtMeasureName.PlaceholderText = "195/65";
            txtMeasureName.Size = new Size(269, 39);
            txtMeasureName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 69);
            label1.Name = "label1";
            label1.Size = new Size(81, 32);
            label1.TabIndex = 0;
            label1.Text = "Ölçü:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(btnDeleteInch);
            groupBox1.Controls.Add(btnSaveInch);
            groupBox1.Controls.Add(txtInch);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(676, 499);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(387, 195);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Jant Çapı Girişi";
            // 
            // btnDeleteInch
            // 
            btnDeleteInch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteInch.BackColor = Color.Tomato;
            btnDeleteInch.Cursor = Cursors.Hand;
            btnDeleteInch.FlatStyle = FlatStyle.Flat;
            btnDeleteInch.ForeColor = SystemColors.ControlText;
            btnDeleteInch.Location = new Point(115, 124);
            btnDeleteInch.Name = "btnDeleteInch";
            btnDeleteInch.Size = new Size(120, 50);
            btnDeleteInch.TabIndex = 9;
            btnDeleteInch.Text = "Sil";
            btnDeleteInch.UseVisualStyleBackColor = false;
            btnDeleteInch.Click += btnDeleteInch_Click;
            // 
            // btnSaveInch
            // 
            btnSaveInch.BackColor = Color.PaleGreen;
            btnSaveInch.Cursor = Cursors.Hand;
            btnSaveInch.FlatStyle = FlatStyle.Flat;
            btnSaveInch.Location = new Point(248, 124);
            btnSaveInch.Name = "btnSaveInch";
            btnSaveInch.Size = new Size(120, 50);
            btnSaveInch.TabIndex = 8;
            btnSaveInch.Text = "Kaydet";
            btnSaveInch.UseVisualStyleBackColor = false;
            btnSaveInch.Click += btnSaveInch_Click;
            // 
            // txtInch
            // 
            txtInch.Location = new Point(157, 66);
            txtInch.Name = "txtInch";
            txtInch.PlaceholderText = "12";
            txtInch.Size = new Size(207, 39);
            txtInch.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 69);
            label3.Name = "label3";
            label3.Size = new Size(142, 32);
            label3.TabIndex = 0;
            label3.Text = "Jant Çapı:";
            // 
            // MeasureContextMenu
            // 
            MeasureContextMenu.ImageScalingSize = new Size(28, 28);
            MeasureContextMenu.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem });
            MeasureContextMenu.Name = "MeasureMenuStrip";
            MeasureContextMenu.Size = new Size(108, 40);
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(107, 36);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // FormMeasure
            // 
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1344, 740);
            Controls.Add(groupBox1);
            Controls.Add(newBrandGroup);
            Controls.Add(btnDeleteMeasure);
            Controls.Add(label2);
            Controls.Add(Measure_list);
            Controls.Add(select_inch);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMeasure";
            Padding = new Padding(53, 43, 53, 43);
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmMeasure";
            ((System.ComponentModel.ISupportInitialize)MeasureBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)measureBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)MeasureBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)measureInchBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)Measure_list).EndInit();
            ((System.ComponentModel.ISupportInitialize)measureBindingSource3).EndInit();
            newBrandGroup.ResumeLayout(false);
            newBrandGroup.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            MeasureContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource MeasureBindingSource;
        private BindingSource MeasureBindingSource1;
        private BindingSource measureBindingSource2;
        private BindingSource measureInchBindingSource;
        private DataGridView Measure_list;
        private ComboBox select_inch;
        private Label label2;
        private Button btnDeleteMeasure;
        private GroupBox newBrandGroup;
        private Button btnAddMeasure;
        private TextBox txtMeasureName;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Button btnSaveInch;
        private TextBox txtInch;
        private ComboBox select_inch_new;
        private Label label4;
        private Button btnDeleteInch;
        private BindingSource measureBindingSource3;
        private ContextMenuStrip MeasureContextMenu;
        private ToolStripMenuItem silToolStripMenuItem;
        private DataGridViewImageColumn Image;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Measure;
        private DataGridViewTextBoxColumn Stock;
    }
}