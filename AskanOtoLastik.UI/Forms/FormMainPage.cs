namespace AskanOtoLastik.UI.Forms
{
    public partial class FormMainPage : Form
    {
        public FormMainPage()
        {
            InitializeComponent();
        }

        private void btnHomeStock_Click(object sender, EventArgs e)
        {
            var mainForm = (MainForm)this.ParentForm;
            mainForm.btnProductList.PerformClick();
        }

        private void btnHomeStock_c_Click(object sender, EventArgs e)
        {
            var mainForm = (MainForm)this.ParentForm;
            mainForm.btnProductList_c.PerformClick();
        }

        private void btnHomeBrand_Click(object sender, EventArgs e)
        {
            var mainForm = (MainForm)this.ParentForm;
            mainForm.btnBrandList.PerformClick();
        }

        private void btnHomebtnMeasure_Click(object sender, EventArgs e)
        {
            var mainForm = (MainForm)this.ParentForm;
            mainForm.btnMeasureList.PerformClick();
        }

        private void btnHomeCategory_Click(object sender, EventArgs e)
        {
            var mainForm = (MainForm)this.ParentForm;
            mainForm.btnCategoryList.PerformClick();
        }

        private void btnHomeExit_Click(object sender, EventArgs e)
        {
            var mainForm = (MainForm)this.ParentForm;
            mainForm.btnExit.PerformClick();
        }
    }
}
