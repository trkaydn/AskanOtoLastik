namespace AskanOtoLastik.UI.Forms
{
    partial class FormEditStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditStock));
            btn_Save = new Button();
            txtStock = new NumericUpDown();
            lblStock = new Label();
            lblProduct = new Label();
            lblProductName = new Label();
            lblTypeName = new Label();
            lblType = new Label();
            ((System.ComponentModel.ISupportInitialize)txtStock).BeginInit();
            SuspendLayout();
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.PaleGreen;
            btn_Save.Cursor = Cursors.Hand;
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.Location = new Point(344, 192);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(120, 50);
            btn_Save.TabIndex = 2;
            btn_Save.Text = "Kaydet";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // txtStock
            // 
            txtStock.Anchor = AnchorStyles.Left;
            txtStock.Location = new Point(101, 131);
            txtStock.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(150, 39);
            txtStock.TabIndex = 1;
            // 
            // lblStock
            // 
            lblStock.Anchor = AnchorStyles.Left;
            lblStock.AutoSize = true;
            lblStock.Location = new Point(16, 131);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(79, 32);
            lblStock.TabIndex = 15;
            lblStock.Text = "Stok:";
            // 
            // lblProduct
            // 
            lblProduct.Anchor = AnchorStyles.Left;
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(12, 23);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(83, 32);
            lblProduct.TabIndex = 16;
            lblProduct.Text = "Ürün:";
            // 
            // lblProductName
            // 
            lblProductName.Anchor = AnchorStyles.Left;
            lblProductName.AutoEllipsis = true;
            lblProductName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(90, 23);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(372, 32);
            lblProductName.TabIndex = 17;
            lblProductName.Text = "ProductName";
            // 
            // lblTypeName
            // 
            lblTypeName.Anchor = AnchorStyles.Left;
            lblTypeName.AutoEllipsis = true;
            lblTypeName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTypeName.Location = new Point(111, 78);
            lblTypeName.Name = "lblTypeName";
            lblTypeName.Size = new Size(372, 32);
            lblTypeName.TabIndex = 19;
            lblTypeName.Text = "TypeName";
            // 
            // lblType
            // 
            lblType.Anchor = AnchorStyles.Left;
            lblType.AutoSize = true;
            lblType.Location = new Point(12, 78);
            lblType.Name = "lblType";
            lblType.Size = new Size(106, 32);
            lblType.TabIndex = 18;
            lblType.Text = "Durum:";
            // 
            // FormEditStock
            // 
            AcceptButton = btn_Save;
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 254);
            Controls.Add(lblTypeName);
            Controls.Add(lblType);
            Controls.Add(lblProductName);
            Controls.Add(lblProduct);
            Controls.Add(btn_Save);
            Controls.Add(txtStock);
            Controls.Add(lblStock);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimumSize = new Size(500, 250);
            Name = "FormEditStock";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Stok Güncelle";
            ((System.ComponentModel.ISupportInitialize)txtStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Save;
        private NumericUpDown txtStock;
        private Label lblStock;
        private Label lblProduct;
        private Label lblProductName;
        private Label lblTypeName;
        private Label lblType;
    }
}