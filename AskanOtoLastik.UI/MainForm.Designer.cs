namespace AskanOtoLastik.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            navbar = new Panel();
            btnExit = new Button();
            btnCategoryList = new Button();
            btnMeasureList = new Button();
            btnBrandList = new Button();
            btnProductList_c = new Button();
            btnProductList = new Button();
            btnMainPage = new Button();
            panel2 = new Panel();
            imageList1 = new ImageList(components);
            mainPanel = new Panel();
            panel1 = new Panel();
            header = new Label();
            navbar.SuspendLayout();
            mainPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // navbar
            // 
            navbar.BackColor = Color.FromArgb(45, 69, 146);
            navbar.Controls.Add(btnExit);
            navbar.Controls.Add(btnCategoryList);
            navbar.Controls.Add(btnMeasureList);
            navbar.Controls.Add(btnBrandList);
            navbar.Controls.Add(btnProductList_c);
            navbar.Controls.Add(btnProductList);
            navbar.Controls.Add(btnMainPage);
            navbar.Controls.Add(panel2);
            navbar.Dock = DockStyle.Left;
            navbar.Location = new Point(0, 0);
            navbar.Margin = new Padding(2);
            navbar.Name = "navbar";
            navbar.Size = new Size(202, 511);
            navbar.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.AccessibleDescription = "Çıkış";
            btnExit.BackColor = Color.FromArgb(45, 69, 146);
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Dock = DockStyle.Top;
            btnExit.FlatAppearance.BorderColor = Color.White;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Gainsboro;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 439);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(6, 0, 0, 0);
            btnExit.Size = new Size(202, 53);
            btnExit.TabIndex = 7;
            btnExit.Text = "Çıkış";
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnCategoryList
            // 
            btnCategoryList.AccessibleDescription = "KATEGORİ İŞLEMLERİ";
            btnCategoryList.BackColor = Color.FromArgb(45, 69, 146);
            btnCategoryList.BackgroundImageLayout = ImageLayout.Zoom;
            btnCategoryList.Cursor = Cursors.Hand;
            btnCategoryList.Dock = DockStyle.Top;
            btnCategoryList.FlatAppearance.BorderColor = Color.White;
            btnCategoryList.FlatAppearance.BorderSize = 0;
            btnCategoryList.FlatStyle = FlatStyle.Flat;
            btnCategoryList.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCategoryList.ForeColor = Color.Gainsboro;
            btnCategoryList.Image = (Image)resources.GetObject("btnCategoryList.Image");
            btnCategoryList.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategoryList.Location = new Point(0, 386);
            btnCategoryList.Margin = new Padding(2);
            btnCategoryList.Name = "btnCategoryList";
            btnCategoryList.Padding = new Padding(6, 0, 0, 0);
            btnCategoryList.Size = new Size(202, 53);
            btnCategoryList.TabIndex = 6;
            btnCategoryList.Text = "Kategori İşlemleri";
            btnCategoryList.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategoryList.UseVisualStyleBackColor = false;
            btnCategoryList.Click += btnCategoryList_Click;
            // 
            // btnMeasureList
            // 
            btnMeasureList.AccessibleDescription = "ÖLÇÜ İŞLEMLERİ";
            btnMeasureList.BackColor = Color.FromArgb(45, 69, 146);
            btnMeasureList.BackgroundImageLayout = ImageLayout.Zoom;
            btnMeasureList.Cursor = Cursors.Hand;
            btnMeasureList.Dock = DockStyle.Top;
            btnMeasureList.FlatAppearance.BorderColor = Color.White;
            btnMeasureList.FlatAppearance.BorderSize = 0;
            btnMeasureList.FlatStyle = FlatStyle.Flat;
            btnMeasureList.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMeasureList.ForeColor = Color.Gainsboro;
            btnMeasureList.Image = (Image)resources.GetObject("btnMeasureList.Image");
            btnMeasureList.ImageAlign = ContentAlignment.MiddleLeft;
            btnMeasureList.Location = new Point(0, 333);
            btnMeasureList.Margin = new Padding(2);
            btnMeasureList.Name = "btnMeasureList";
            btnMeasureList.Padding = new Padding(6, 0, 0, 0);
            btnMeasureList.Size = new Size(202, 53);
            btnMeasureList.TabIndex = 5;
            btnMeasureList.Text = "Ölçü İşlemleri";
            btnMeasureList.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMeasureList.UseVisualStyleBackColor = false;
            btnMeasureList.Click += btnMeasureList_Click;
            // 
            // btnBrandList
            // 
            btnBrandList.AccessibleDescription = "MARKA İŞLEMLERİ";
            btnBrandList.BackColor = Color.FromArgb(45, 69, 146);
            btnBrandList.BackgroundImageLayout = ImageLayout.Zoom;
            btnBrandList.Cursor = Cursors.Hand;
            btnBrandList.Dock = DockStyle.Top;
            btnBrandList.FlatAppearance.BorderColor = Color.White;
            btnBrandList.FlatAppearance.BorderSize = 0;
            btnBrandList.FlatStyle = FlatStyle.Flat;
            btnBrandList.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrandList.ForeColor = Color.Gainsboro;
            btnBrandList.Image = (Image)resources.GetObject("btnBrandList.Image");
            btnBrandList.ImageAlign = ContentAlignment.MiddleLeft;
            btnBrandList.Location = new Point(0, 280);
            btnBrandList.Margin = new Padding(2);
            btnBrandList.Name = "btnBrandList";
            btnBrandList.Padding = new Padding(6, 0, 0, 0);
            btnBrandList.Size = new Size(202, 53);
            btnBrandList.TabIndex = 4;
            btnBrandList.Text = "Marka İşlemleri";
            btnBrandList.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBrandList.UseVisualStyleBackColor = false;
            btnBrandList.Click += btnBrandList_Click;
            // 
            // btnProductList_c
            // 
            btnProductList_c.AccessibleDescription = "ÇIKMA İŞLEMLERİ";
            btnProductList_c.BackColor = Color.FromArgb(45, 69, 146);
            btnProductList_c.BackgroundImageLayout = ImageLayout.Zoom;
            btnProductList_c.Cursor = Cursors.Hand;
            btnProductList_c.Dock = DockStyle.Top;
            btnProductList_c.FlatAppearance.BorderColor = Color.White;
            btnProductList_c.FlatAppearance.BorderSize = 0;
            btnProductList_c.FlatStyle = FlatStyle.Flat;
            btnProductList_c.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductList_c.ForeColor = Color.Gainsboro;
            btnProductList_c.Image = (Image)resources.GetObject("btnProductList_c.Image");
            btnProductList_c.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductList_c.Location = new Point(0, 227);
            btnProductList_c.Margin = new Padding(2);
            btnProductList_c.Name = "btnProductList_c";
            btnProductList_c.Padding = new Padding(6, 0, 0, 0);
            btnProductList_c.Size = new Size(202, 53);
            btnProductList_c.TabIndex = 3;
            btnProductList_c.Text = "Çıkma İşlemleri";
            btnProductList_c.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProductList_c.UseVisualStyleBackColor = false;
            btnProductList_c.Click += btnProductList_c_Click;
            // 
            // btnProductList
            // 
            btnProductList.AccessibleDescription = "STOK İŞLEMLERİ";
            btnProductList.BackColor = Color.FromArgb(45, 69, 146);
            btnProductList.BackgroundImageLayout = ImageLayout.Zoom;
            btnProductList.Cursor = Cursors.Hand;
            btnProductList.Dock = DockStyle.Top;
            btnProductList.FlatAppearance.BorderColor = Color.White;
            btnProductList.FlatAppearance.BorderSize = 0;
            btnProductList.FlatStyle = FlatStyle.Flat;
            btnProductList.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductList.ForeColor = Color.Gainsboro;
            btnProductList.Image = (Image)resources.GetObject("btnProductList.Image");
            btnProductList.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductList.Location = new Point(0, 174);
            btnProductList.Margin = new Padding(2);
            btnProductList.Name = "btnProductList";
            btnProductList.Padding = new Padding(6, 0, 0, 0);
            btnProductList.Size = new Size(202, 53);
            btnProductList.TabIndex = 2;
            btnProductList.Text = "Stok İşlemleri";
            btnProductList.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProductList.UseVisualStyleBackColor = false;
            btnProductList.Click += btnProductList_Click;
            // 
            // btnMainPage
            // 
            btnMainPage.AccessibleDescription = "AŞKAN OTO LASTİK";
            btnMainPage.BackColor = Color.FromArgb(105, 129, 206);
            btnMainPage.BackgroundImageLayout = ImageLayout.Zoom;
            btnMainPage.Cursor = Cursors.Hand;
            btnMainPage.Dock = DockStyle.Top;
            btnMainPage.FlatAppearance.BorderColor = Color.White;
            btnMainPage.FlatAppearance.BorderSize = 0;
            btnMainPage.FlatStyle = FlatStyle.Flat;
            btnMainPage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMainPage.ForeColor = Color.Gainsboro;
            btnMainPage.Image = (Image)resources.GetObject("btnMainPage.Image");
            btnMainPage.ImageAlign = ContentAlignment.MiddleLeft;
            btnMainPage.Location = new Point(0, 121);
            btnMainPage.Margin = new Padding(2);
            btnMainPage.Name = "btnMainPage";
            btnMainPage.Padding = new Padding(6, 0, 0, 0);
            btnMainPage.Size = new Size(202, 53);
            btnMainPage.TabIndex = 1;
            btnMainPage.Text = "Ana Sayfa";
            btnMainPage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMainPage.UseVisualStyleBackColor = false;
            btnMainPage.Click += btnMainPage_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(202, 121);
            panel2.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // mainPanel
            // 
            mainPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainPanel.BackColor = SystemColors.Control;
            mainPanel.Controls.Add(panel1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mainPanel.Location = new Point(202, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.RightToLeft = RightToLeft.No;
            mainPanel.Size = new Size(782, 511);
            mainPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 69, 146);
            panel1.Controls.Add(header);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Microsoft Sans Serif", 12F);
            panel1.ForeColor = Color.Gainsboro;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 55);
            panel1.TabIndex = 0;
            // 
            // header
            // 
            header.Dock = DockStyle.Top;
            header.FlatStyle = FlatStyle.Flat;
            header.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(782, 55);
            header.TabIndex = 0;
            header.Text = "AŞKAN OTO LASTİK";
            header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Control;
            CausesValidation = false;
            ClientSize = new Size(984, 511);
            Controls.Add(mainPanel);
            Controls.Add(navbar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MinimumSize = new Size(1000, 550);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aşkan Oto Lastik Stok Yönetimi";
            Load += MainForm_Load;
            navbar.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel navbar;
        private Panel panel2;
        private ImageList imageList1;
        private Panel mainPanel;
        private Panel panel1;
        private Label header;
        public Button btnMainPage;
        public Button btnProductList;
        public Button btnBrandList;
        public Button btnProductList_c;
        public Button btnCategoryList;
        public Button btnMeasureList;
        public Button btnExit;
    }
}
