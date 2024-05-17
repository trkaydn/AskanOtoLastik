using AskanOtoLastik.Data;
using AskanOtoLastik.Data.Models;

namespace AskanOtoLastik.UI.Forms
{
    public partial class FormEditStock : Form
    {
        private readonly int _productId;
        private List<ProductViewModel> _vm;

        public FormEditStock(int productId, int stock, string productName, int type, List<ProductViewModel> vm)
        {
            InitializeComponent();
            _productId = productId;
            lblProductName.Text = productName;
            txtStock.Value = stock;
            _vm = vm;
            lblTypeName.Text = type == 1 ? "Sıfır" : "Çıkma";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                using var context = new AppDbContext();
                var product = context.Products.FirstOrDefault(x => x.Id == _productId);

                product.Stock = (int)txtStock.Value;
                context.SaveChanges();

                _vm.FirstOrDefault(x => x.Id == _productId).Stock = (int)txtStock.Value;

                this.DialogResult = DialogResult.OK;
                this.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                ShowExceptionMessage(ex);
            }
        }
        private void ShowExceptionMessage(Exception ex)
        {
            MessageBox.Show(string.Format("Bir hata oluştu: \n {0}", ex.Message), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
