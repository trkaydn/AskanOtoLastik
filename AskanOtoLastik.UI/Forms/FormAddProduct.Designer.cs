namespace AskanOtoLastik.UI.Forms
{
    partial class FormAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProduct));
            cmbBrand = new ComboBox();
            brandBindingSource = new BindingSource(components);
            lblBrand = new Label();
            lblModel = new Label();
            cmbCategory = new ComboBox();
            categoryBindingSource = new BindingSource(components);
            lblCategory = new Label();
            txtModel = new TextBox();
            cmb_SelectInch = new ComboBox();
            measureInchBindingSource = new BindingSource(components);
            lbl_Inch = new Label();
            cmb_SelectMeasure = new ComboBox();
            measureBindingSource = new BindingSource(components);
            measureBindingSource1 = new BindingSource(components);
            lbl_mesaure = new Label();
            lblYear = new Label();
            lblType = new Label();
            lblStock = new Label();
            txtStock = new NumericUpDown();
            txtYear = new NumericUpDown();
            btn_Save = new Button();
            radio_first = new RadioButton();
            radio_second = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)brandBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)measureInchBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)measureBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)measureBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtYear).BeginInit();
            SuspendLayout();
            // 
            // cmbBrand
            // 
            cmbBrand.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBrand.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbBrand.DataSource = brandBindingSource;
            cmbBrand.DisplayMember = "Name";
            cmbBrand.FormattingEnabled = true;
            cmbBrand.IntegralHeight = false;
            cmbBrand.Location = new Point(158, 32);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(299, 40);
            cmbBrand.TabIndex = 0;
            cmbBrand.ValueMember = "Id";
            // 
            // brandBindingSource
            // 
            brandBindingSource.DataSource = typeof(Data.Entities.Brand);
            // 
            // lblBrand
            // 
            lblBrand.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(47, 35);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(100, 32);
            lblBrand.TabIndex = 1;
            lblBrand.Text = "Marka:";
            // 
            // lblModel
            // 
            lblModel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblModel.AutoSize = true;
            lblModel.Location = new Point(47, 102);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(100, 32);
            lblModel.TabIndex = 3;
            lblModel.Text = "Model:";
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategory.DataSource = categoryBindingSource;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.FormattingEnabled = true;
            cmbCategory.IntegralHeight = false;
            cmbCategory.Location = new Point(158, 165);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(299, 40);
            cmbCategory.TabIndex = 2;
            cmbCategory.ValueMember = "Id";
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Data.Entities.Category);
            // 
            // lblCategory
            // 
            lblCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(18, 168);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(129, 32);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Kategori:";
            // 
            // txtModel
            // 
            txtModel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtModel.BorderStyle = BorderStyle.FixedSingle;
            txtModel.Location = new Point(158, 99);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(299, 39);
            txtModel.TabIndex = 1;
            // 
            // cmb_SelectInch
            // 
            cmb_SelectInch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmb_SelectInch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_SelectInch.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmb_SelectInch.DataSource = measureInchBindingSource;
            cmb_SelectInch.DisplayMember = "Inch";
            cmb_SelectInch.FormattingEnabled = true;
            cmb_SelectInch.IntegralHeight = false;
            cmb_SelectInch.Location = new Point(158, 232);
            cmb_SelectInch.Name = "cmb_SelectInch";
            cmb_SelectInch.Size = new Size(299, 40);
            cmb_SelectInch.TabIndex = 3;
            cmb_SelectInch.ValueMember = "Id";
            cmb_SelectInch.SelectedIndexChanged += cmb_SelectInch_SelectedIndexChanged;
            // 
            // measureInchBindingSource
            // 
            measureInchBindingSource.DataSource = typeof(Data.Entities.MeasureInch);
            // 
            // lbl_Inch
            // 
            lbl_Inch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Inch.AutoSize = true;
            lbl_Inch.Location = new Point(5, 235);
            lbl_Inch.Name = "lbl_Inch";
            lbl_Inch.Size = new Size(142, 32);
            lbl_Inch.TabIndex = 7;
            lbl_Inch.Text = "Jant Çapı:";
            // 
            // cmb_SelectMeasure
            // 
            cmb_SelectMeasure.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmb_SelectMeasure.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_SelectMeasure.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmb_SelectMeasure.DataSource = measureBindingSource;
            cmb_SelectMeasure.DisplayMember = "Name";
            cmb_SelectMeasure.FormattingEnabled = true;
            cmb_SelectMeasure.IntegralHeight = false;
            cmb_SelectMeasure.Location = new Point(158, 299);
            cmb_SelectMeasure.Name = "cmb_SelectMeasure";
            cmb_SelectMeasure.Size = new Size(299, 40);
            cmb_SelectMeasure.TabIndex = 4;
            cmb_SelectMeasure.ValueMember = "Id";
            // 
            // measureBindingSource
            // 
            measureBindingSource.DataSource = typeof(Data.Entities.Measure);
            // 
            // measureBindingSource1
            // 
            measureBindingSource1.DataSource = typeof(Data.Entities.Measure);
            // 
            // lbl_mesaure
            // 
            lbl_mesaure.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_mesaure.AutoSize = true;
            lbl_mesaure.Location = new Point(66, 302);
            lbl_mesaure.Name = "lbl_mesaure";
            lbl_mesaure.Size = new Size(81, 32);
            lbl_mesaure.TabIndex = 9;
            lbl_mesaure.Text = "Ölçü:";
            // 
            // lblYear
            // 
            lblYear.Anchor = AnchorStyles.Left;
            lblYear.AutoSize = true;
            lblYear.Location = new Point(14, 432);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(55, 32);
            lblYear.TabIndex = 10;
            lblYear.Text = "Yıl:";
            // 
            // lblType
            // 
            lblType.Anchor = AnchorStyles.Left;
            lblType.AutoSize = true;
            lblType.Location = new Point(85, 372);
            lblType.Name = "lblType";
            lblType.Size = new Size(62, 32);
            lblType.TabIndex = 11;
            lblType.Text = "Tip:";
            // 
            // lblStock
            // 
            lblStock.Anchor = AnchorStyles.Left;
            lblStock.AutoSize = true;
            lblStock.Location = new Point(242, 432);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(79, 32);
            lblStock.TabIndex = 12;
            lblStock.Text = "Stok:";
            // 
            // txtStock
            // 
            txtStock.Anchor = AnchorStyles.Left;
            txtStock.Location = new Point(327, 430);
            txtStock.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(130, 39);
            txtStock.TabIndex = 8;
            // 
            // txtYear
            // 
            txtYear.Anchor = AnchorStyles.Left;
            txtYear.Location = new Point(75, 430);
            txtYear.Maximum = new decimal(new int[] { 2500, 0, 0, 0 });
            txtYear.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(130, 39);
            txtYear.TabIndex = 7;
            txtYear.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // btn_Save
            // 
            btn_Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Save.BackColor = Color.PaleGreen;
            btn_Save.Cursor = Cursors.Hand;
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.Location = new Point(337, 494);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(120, 50);
            btn_Save.TabIndex = 9;
            btn_Save.Text = "Kaydet";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // radio_first
            // 
            radio_first.Anchor = AnchorStyles.Left;
            radio_first.AutoSize = true;
            radio_first.Location = new Point(158, 370);
            radio_first.Name = "radio_first";
            radio_first.Size = new Size(89, 36);
            radio_first.TabIndex = 5;
            radio_first.TabStop = true;
            radio_first.Text = "Sıfır";
            radio_first.UseVisualStyleBackColor = true;
            // 
            // radio_second
            // 
            radio_second.Anchor = AnchorStyles.Left;
            radio_second.AutoSize = true;
            radio_second.Location = new Point(253, 370);
            radio_second.Name = "radio_second";
            radio_second.Size = new Size(126, 36);
            radio_second.TabIndex = 6;
            radio_second.TabStop = true;
            radio_second.Text = "Çıkma ";
            radio_second.UseVisualStyleBackColor = true;
            // 
            // FormAddProduct
            // 
            AcceptButton = btn_Save;
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(476, 556);
            Controls.Add(radio_second);
            Controls.Add(radio_first);
            Controls.Add(btn_Save);
            Controls.Add(txtYear);
            Controls.Add(txtStock);
            Controls.Add(lblStock);
            Controls.Add(lblType);
            Controls.Add(lblYear);
            Controls.Add(lbl_mesaure);
            Controls.Add(cmb_SelectMeasure);
            Controls.Add(lbl_Inch);
            Controls.Add(cmb_SelectInch);
            Controls.Add(txtModel);
            Controls.Add(lblCategory);
            Controls.Add(lblModel);
            Controls.Add(cmbCategory);
            Controls.Add(lblBrand);
            Controls.Add(cmbBrand);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(500, 620);
            Name = "FormAddProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Yeni Ürün Girişi";
            ((System.ComponentModel.ISupportInitialize)brandBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)measureInchBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)measureBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)measureBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBrand;
        private Label lblBrand;
        private Label lblModel;
        private ComboBox cmbCategory;
        private Label lblCategory;
        private TextBox txtModel;
        private ComboBox cmb_SelectInch;
        private Label lbl_Inch;
        private ComboBox cmb_SelectMeasure;
        private Label lbl_mesaure;
        private Label lblYear;
        private Label lblType;
        private Label lblStock;
        private NumericUpDown txtStock;
        private NumericUpDown txtYear;
        private Button btn_Save;
        private RadioButton radio_first;
        private RadioButton radio_second;
        private BindingSource brandBindingSource;
        private BindingSource categoryBindingSource;
        private BindingSource measureInchBindingSource;
        private BindingSource measureBindingSource;
        private BindingSource measureBindingSource1;
    }
}