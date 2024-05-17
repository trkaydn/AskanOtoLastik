namespace AskanOtoLastik.UI.Forms
{
    partial class FormMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainPage));
            stockOperations = new GroupBox();
            btnHomeExit = new Button();
            btnHomeCategory = new Button();
            btnHomebtnMeasure = new Button();
            btnHomeBrand = new Button();
            btnHomeStock_c = new Button();
            btnHomeStock = new Button();
            stockOperations.SuspendLayout();
            SuspendLayout();
            // 
            // stockOperations
            // 
            stockOperations.Anchor = AnchorStyles.None;
            stockOperations.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            stockOperations.Controls.Add(btnHomeExit);
            stockOperations.Controls.Add(btnHomeCategory);
            stockOperations.Controls.Add(btnHomebtnMeasure);
            stockOperations.Controls.Add(btnHomeBrand);
            stockOperations.Controls.Add(btnHomeStock_c);
            stockOperations.Controls.Add(btnHomeStock);
            stockOperations.Cursor = Cursors.Hand;
            stockOperations.FlatStyle = FlatStyle.Flat;
            stockOperations.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stockOperations.Location = new Point(34, 29);
            stockOperations.Margin = new Padding(5, 6, 5, 6);
            stockOperations.Name = "stockOperations";
            stockOperations.Padding = new Padding(5, 6, 5, 6);
            stockOperations.Size = new Size(1275, 676);
            stockOperations.TabIndex = 2;
            stockOperations.TabStop = false;
            stockOperations.Text = "Ana Sayfa";
            // 
            // btnHomeExit
            // 
            btnHomeExit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnHomeExit.BackColor = Color.White;
            btnHomeExit.FlatStyle = FlatStyle.Flat;
            btnHomeExit.Image = (Image)resources.GetObject("btnHomeExit.Image");
            btnHomeExit.Location = new Point(866, 400);
            btnHomeExit.Margin = new Padding(5, 6, 5, 6);
            btnHomeExit.Name = "btnHomeExit";
            btnHomeExit.Size = new Size(362, 208);
            btnHomeExit.TabIndex = 5;
            btnHomeExit.Text = "Çıkış";
            btnHomeExit.TextAlign = ContentAlignment.BottomCenter;
            btnHomeExit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHomeExit.UseVisualStyleBackColor = false;
            btnHomeExit.Click += btnHomeExit_Click;
            // 
            // btnHomeCategory
            // 
            btnHomeCategory.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnHomeCategory.BackColor = Color.White;
            btnHomeCategory.FlatStyle = FlatStyle.Flat;
            btnHomeCategory.Image = (Image)resources.GetObject("btnHomeCategory.Image");
            btnHomeCategory.Location = new Point(477, 400);
            btnHomeCategory.Margin = new Padding(5, 6, 5, 6);
            btnHomeCategory.Name = "btnHomeCategory";
            btnHomeCategory.Size = new Size(362, 208);
            btnHomeCategory.TabIndex = 4;
            btnHomeCategory.Text = "Kategori İşlemleri";
            btnHomeCategory.TextAlign = ContentAlignment.BottomCenter;
            btnHomeCategory.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHomeCategory.UseVisualStyleBackColor = false;
            btnHomeCategory.Click += btnHomeCategory_Click;
            // 
            // btnHomebtnMeasure
            // 
            btnHomebtnMeasure.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnHomebtnMeasure.BackColor = Color.White;
            btnHomebtnMeasure.FlatStyle = FlatStyle.Flat;
            btnHomebtnMeasure.Image = (Image)resources.GetObject("btnHomebtnMeasure.Image");
            btnHomebtnMeasure.Location = new Point(84, 400);
            btnHomebtnMeasure.Margin = new Padding(5, 6, 5, 6);
            btnHomebtnMeasure.Name = "btnHomebtnMeasure";
            btnHomebtnMeasure.Size = new Size(362, 208);
            btnHomebtnMeasure.TabIndex = 3;
            btnHomebtnMeasure.Text = "Ölçü İşlemleri";
            btnHomebtnMeasure.TextAlign = ContentAlignment.BottomCenter;
            btnHomebtnMeasure.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHomebtnMeasure.UseVisualStyleBackColor = false;
            btnHomebtnMeasure.Click += btnHomebtnMeasure_Click;
            // 
            // btnHomeBrand
            // 
            btnHomeBrand.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnHomeBrand.BackColor = Color.White;
            btnHomeBrand.FlatStyle = FlatStyle.Flat;
            btnHomeBrand.Image = (Image)resources.GetObject("btnHomeBrand.Image");
            btnHomeBrand.Location = new Point(866, 124);
            btnHomeBrand.Margin = new Padding(5, 6, 5, 6);
            btnHomeBrand.Name = "btnHomeBrand";
            btnHomeBrand.Size = new Size(362, 208);
            btnHomeBrand.TabIndex = 2;
            btnHomeBrand.Text = "Marka İşlemleri";
            btnHomeBrand.TextAlign = ContentAlignment.BottomCenter;
            btnHomeBrand.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHomeBrand.UseVisualStyleBackColor = false;
            btnHomeBrand.Click += btnHomeBrand_Click;
            // 
            // btnHomeStock_c
            // 
            btnHomeStock_c.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnHomeStock_c.BackColor = Color.White;
            btnHomeStock_c.FlatStyle = FlatStyle.Flat;
            btnHomeStock_c.Image = (Image)resources.GetObject("btnHomeStock_c.Image");
            btnHomeStock_c.Location = new Point(477, 124);
            btnHomeStock_c.Margin = new Padding(5, 6, 5, 6);
            btnHomeStock_c.Name = "btnHomeStock_c";
            btnHomeStock_c.Size = new Size(362, 208);
            btnHomeStock_c.TabIndex = 1;
            btnHomeStock_c.Text = "Çıkma İşlemleri ";
            btnHomeStock_c.TextAlign = ContentAlignment.BottomCenter;
            btnHomeStock_c.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHomeStock_c.UseVisualStyleBackColor = false;
            btnHomeStock_c.Click += btnHomeStock_c_Click;
            // 
            // btnHomeStock
            // 
            btnHomeStock.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnHomeStock.BackColor = Color.White;
            btnHomeStock.BackgroundImageLayout = ImageLayout.Stretch;
            btnHomeStock.FlatStyle = FlatStyle.Flat;
            btnHomeStock.Image = (Image)resources.GetObject("btnHomeStock.Image");
            btnHomeStock.Location = new Point(84, 124);
            btnHomeStock.Margin = new Padding(5, 6, 5, 6);
            btnHomeStock.Name = "btnHomeStock";
            btnHomeStock.Size = new Size(362, 208);
            btnHomeStock.TabIndex = 0;
            btnHomeStock.Text = "Stok İşlemleri";
            btnHomeStock.TextAlign = ContentAlignment.BottomCenter;
            btnHomeStock.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHomeStock.UseVisualStyleBackColor = false;
            btnHomeStock.Click += btnHomeStock_Click;
            // 
            // FormMainPage
            // 
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1344, 740);
            Controls.Add(stockOperations);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            MinimizeBox = false;
            Name = "FormMainPage";
            Padding = new Padding(39, 40, 39, 40);
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormMainPage";
            stockOperations.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox stockOperations;
        private Button btnHomeStock;
        private Button btnHomebtnMeasure;
        private Button btnHomeBrand;
        private Button btnHomeStock_c;
        private Button btnHomeCategory;
        private Button btnHomeExit;
    }
}