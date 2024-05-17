namespace AskanOtoLastik.UI
{
    public partial class MainForm : Form
    {
        private Form _activeForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMainPage(), sender);
        }

        private void ActivateButton(object sender)
        {
            try
            {
                foreach (Control prev in navbar.Controls)
                {
                    if (prev.GetType() == typeof(Button))
                        prev.BackColor = Color.FromArgb(45, 69, 146);
                }

                var button = (Button)sender;
                button.BackColor = Color.FromArgb(105, 129, 206);
            }
            catch { }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            try
            {
                if (_activeForm != null)
                {
                    _activeForm.Close();
                    _activeForm.Dispose();
                }

                if (btnSender is Button)
                {
                    var button = (Button)btnSender;
                    header.Text = button.AccessibleDescription;
                }

                _activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(childForm);
                mainPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Bir hata oluştu: \n {0}",ex.Message),"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMainPage(), sender);
            ActivateButton(sender);
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProduct(1), sender);
            ActivateButton(sender);
        }

        private void btnProductList_c_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProduct(2), sender);
            ActivateButton(sender);
        }

        private void btnBrandList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBrand(), sender);
            ActivateButton(sender);
        }

        private void btnMeasureList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMeasure(), sender);
            ActivateButton(sender);
        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCategory(), sender);
            ActivateButton(sender);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
