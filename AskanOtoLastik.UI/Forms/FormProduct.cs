using AskanOtoLastik.Data;
using AskanOtoLastik.Data.Entities;
using AskanOtoLastik.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace AskanOtoLastik.UI.Forms
{
    public partial class FormProduct : Form
    {
        public List<ProductViewModel> _products;
        public List<Brand> _brands;
        private readonly int _type;

        public FormProduct(int type)
        {
            this._type = type;
            InitializeComponent();
            LoadProducts();
            LoadCmbCategories();
            LoadCmbBrands();
        }
        private void LoadProducts()
        {
            try
            {
                using var context = new AppDbContext();

                _products = context.Products
                    .Include(x => x.Brand)
                    .Include(x => x.Category)
                    .Include(x => x.Measure)
                    .Where(x => x.Type == _type)
                    .Select(x => new ProductViewModel()
                    {
                        Id = x.Id,
                        Name = string.Format("{0} {1} {2}", x.Brand.Name, x.Model, x.Measure.Name),
                        Category = x.Category.Name,
                        Year = x.Year,
                        Stock = x.Stock,
                        Brand = x.Brand.Name,
                        Type = x.Type,
                    }).OrderBy(x => x.Brand).ToList();

                Product_List.DataSource = _products;
            }
            catch (Exception ex)
            {
                ShowExceptionMessage(ex);
            }
        }

        private void LoadCmbCategories()
        {
            try
            {
                using var context = new AppDbContext();

                cmbCategory.Items.Clear();
                cmbCategory.Items.Add("Tümü");

                context.Categories.OrderBy(x => x.Name).ToList().ForEach(x => cmbCategory.Items.Add(x.Name));

                cmbCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                ShowExceptionMessage(ex);
            }
        }

        private void LoadCmbBrands()
        {
            try
            {
                using var context = new AppDbContext();

                cmbBrand.Items.Clear();
                cmbBrand.Items.Add("Tümü");

                context.Brands
                    .OrderBy(x => x.Name)
                    .ToList()
                    .ForEach(x => cmbBrand.Items.Add(x.Name));

                cmbBrand.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                ShowExceptionMessage(ex);
            }
        }

        private void FilterProducts()
        {
            try
            {
                List<ProductViewModel> filteredData = _products.Where(x => x.Type == _type).OrderBy(x => x.Brand).ToList();

                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    string[] searchWords = txtSearch.Text.ToLower().Replace("/", "").Replace(" r", "").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    filteredData = filteredData.Where(item =>
                    {
                        foreach (var word in searchWords)
                        {
                            if (!item.Name.ToLower().Replace("/", "").Replace(" r", "").Contains(word))
                                return false;
                        }
                        return true;
                    }).ToList();
                }

                if (cmbCategory.SelectedIndex > 0)
                    filteredData = filteredData.Where(x => x.Category == cmbCategory.SelectedItem.ToString()).ToList();

                if (cmbBrand.SelectedIndex > 0)
                    filteredData = filteredData.Where(x => x.Name.ToLower().Contains(cmbBrand.SelectedItem.ToString().ToLower())).ToList();

                Product_List.DataSource = filteredData;
                Product_List.Refresh();

            }
            catch (Exception ex)
            {
                ShowExceptionMessage(ex);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterProducts();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterProducts();
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterProducts();
        }
        private void Brand_list_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            Product_List.ClearSelection();
            int rowSelected = e.RowIndex;
            if (e.RowIndex > -1)
            {
                this.Product_List.Rows[rowSelected].Selected = true;
            }
            e.ContextMenuStrip = ProductContextMenu;
        }

        private void btn_NewProduct_Click(object sender, EventArgs e)
        {
            FormAddProduct form = new(_type, 0, _products);

            if (form.ShowDialog(this) == DialogResult.OK)
                FilterProducts();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (Product_List.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Lütfen bir seçim yapın!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var context = new AppDbContext();
                int productId = Convert.ToInt32(Product_List.SelectedRows[0].Cells["Id"].Value);
                var product = context.Products.FirstOrDefault(x => x.Id == productId);
                if (product != null)
                {
                    string message = "";

                    if (product.Stock <= 0)
                        message = string.Format("{0} isimli ürün silenecek.\nEmin Misiniz?", Product_List.SelectedRows[0].Cells["NameCol"].Value.ToString());

                    else
                        message = string.Format("{0} isimli ürün için {1} adet stok mevcuttur.\nYine de silinsin mi?", Product_List.SelectedRows[0].Cells["NameCol"].Value.ToString(), product.Stock);

                    var result = MessageBox.Show(message, "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        context.Products.Remove(product);
                        context.SaveChanges();

                        var listitem = _products.FirstOrDefault(x => x.Id == productId);
                        _products.Remove(listitem);

                        FilterProducts();
                    }
                }
            }
            catch (Exception ex)
            {
                ShowExceptionMessage(ex);
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (Product_List.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Lütfen bir seçim yapın!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int productId = Convert.ToInt32(Product_List.SelectedRows[0].Cells["Id"].Value);

                if (productId > 0)
                {
                    FormAddProduct form = new FormAddProduct(_type, productId, _products);

                    if (form.ShowDialog(this) == DialogResult.OK)
                        FilterProducts();
                }
            }
            catch (Exception ex)
            {
                ShowExceptionMessage(ex);
            }
        }

        private void btnEditStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (Product_List.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Lütfen bir seçim yapın!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int productId = Convert.ToInt32(Product_List.SelectedRows[0].Cells["Id"].Value);

                int productStock = Convert.ToInt32(Product_List.SelectedRows[0].Cells["Stock"].Value);

                string productName = Product_List.SelectedRows[0].Cells["NameCol"].Value.ToString();

                FormEditStock form = new(productId, productStock, productName, _type, _products);

                if (form.ShowDialog(this) == DialogResult.OK)
                    FilterProducts();
            }
            catch (Exception ex)
            {
                ShowExceptionMessage(ex);
            }
        }

        private void Product_List_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEditStock_Click(sender, e);
        }

        private void Product_List_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Product_List.ClearSelection();
        }
        private void ShowExceptionMessage(Exception ex)
        {
            MessageBox.Show(string.Format("Bir hata oluştu: \n {0}", ex.Message), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
