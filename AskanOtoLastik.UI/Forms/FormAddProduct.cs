using AskanOtoLastik.Data;
using AskanOtoLastik.Data.Entities;
using AskanOtoLastik.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AskanOtoLastik.UI.Forms
{
    public partial class FormAddProduct : Form
    {
        private List<Brand> _brands;
        private List<Category> _categories;
        private List<MeasureInch> _inches;
        private List<Measure> _measures;
        private List<ProductViewModel> _vm;
        private readonly int _type;
        private readonly int _updatingItem;

        public FormAddProduct(int type, int updatingItem, List<ProductViewModel> vm)
        {
            _type = type;
            _vm = vm;
            _updatingItem = updatingItem;
            InitializeComponent();
            FillAreas();
        }

        public void FillAreas()
        {
            try
            {
                using AppDbContext context = new();

                _brands = context.Brands.OrderBy(x => x.Name).ToList();
                cmbBrand.DataSource = _brands;
                cmbBrand.SelectedIndex = -1;

                _categories = context.Categories.OrderBy(x => x.Name).ToList();
                cmbCategory.DataSource = _categories;
                cmbCategory.SelectedIndex = -1;

                _inches = context.MeasureInch.OrderBy(x => x.Inch).ToList();
                cmb_SelectInch.DataSource = _inches;
                cmb_SelectInch.SelectedIndex = -1;

                _measures = new List<Measure>();
                cmb_SelectMeasure.DataSource = _measures;
                cmb_SelectMeasure.SelectedIndex = -1;

                radio_first.Checked = _type == 1;
                radio_second.Checked = _type == 2;

                txtYear.Value = DateTime.Now.Year;

                if (_updatingItem > 0)
                {
                    var product = context.Products
                        .Include(x => x.Measure).FirstOrDefault(x => x.Id == _updatingItem);

                    if (product != null)
                    {
                        this.Text = "Ürün Düzenle";
                        cmbBrand.SelectedValue = product.BrandId;
                        txtModel.Text = product.Model;
                        cmbCategory.SelectedValue = product.CategoryId;
                        cmb_SelectInch.SelectedValue = product.Measure.MeasureInchId;
                        cmb_SelectMeasure.SelectedValue = product.MeasureId;
                        radio_first.Checked = product.Type == 1;
                        radio_second.Checked = product.Type == 2;
                        txtYear.Value = product.Year;
                        txtStock.Value = product.Stock;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowExceptionMessage(ex);
            }
        }

        private void cmb_SelectInch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_measures is null) return;

                if (cmb_SelectInch.SelectedIndex >= 0)
                {
                    using var context = new AppDbContext();

                    _measures = context.Measures
                        .Where(x => x.MeasureInchId == (int)cmb_SelectInch.SelectedValue).OrderBy(x => x.Name).ToList();
                }
                else
                    _measures.Clear();

                cmb_SelectMeasure.DataSource = _measures;
                cmb_SelectMeasure.Update();
                cmb_SelectMeasure.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ShowExceptionMessage(ex);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                var errors = ValidateInputs();

                if (errors.Count > 0)
                {
                    string errorMessage = "Aşağıdaki alanlar eksik veya hatalı:\n" + string.Join("\n", errors).Replace(":", "");
                    MessageBox.Show(errorMessage, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using AppDbContext context = new();

                    if (_updatingItem > 0)
                    {
                        var product = context.Products.FirstOrDefault(x => x.Id == _updatingItem);

                        if (product != null)
                        {
                            product.Model = txtModel.Text;
                            product.BrandId = (int)cmbBrand.SelectedValue;
                            product.CategoryId = (int)cmbCategory.SelectedValue;
                            product.MeasureId = (int)cmb_SelectMeasure.SelectedValue;
                            product.Year = (int)txtYear.Value;
                            product.Stock = (int)txtStock.Value;
                            product.Type = radio_first.Checked ? 1 : radio_second.Checked ? 2 : 0;
                        }

                        var vm_product = _vm.FirstOrDefault(x => x.Id == _updatingItem);
                        vm_product.Name = string.Format("{0} {1} {2}", cmbBrand.Text, txtModel.Text, cmb_SelectMeasure.Text);
                        vm_product.Category = cmbCategory.Text;
                        vm_product.Year = (int)txtYear.Value;
                        vm_product.Stock = (int)txtStock.Value;
                        vm_product.Brand = cmbBrand.Text;
                        vm_product.Type = radio_first.Checked ? 1 : radio_second.Checked ? 2 : 0;
                        context.SaveChanges();
                    }
                    else
                    {
                        var newProduct = new Product()
                        {
                            Model = txtModel.Text,
                            BrandId = (int)cmbBrand.SelectedValue,
                            CategoryId = (int)cmbCategory.SelectedValue,
                            MeasureId = (int)cmb_SelectMeasure.SelectedValue,
                            Year = (int)txtYear.Value,
                            Stock = (int)txtStock.Value,
                            Type = radio_first.Checked ? 1 : radio_second.Checked ? 2 : 0
                        };

                        context.Products.Add(newProduct);
                        context.SaveChanges();

                        _vm.Add(new()
                        {
                            Id = newProduct.Id,
                            Name = string.Format("{0} {1} {2}", cmbBrand.Text, txtModel.Text, cmb_SelectMeasure.Text),
                            Category = cmbCategory.Text,
                            Year = (int)txtYear.Value,
                            Stock = (int)txtStock.Value,
                            Type = radio_first.Checked ? 1 : radio_second.Checked ? 2 : 0
                        });
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                ShowExceptionMessage(ex);
            }
        }

        private List<string> ValidateInputs()
        {
            List<string> errors = new();
            int parsedValue = 0;

            if (cmbBrand.SelectedIndex < 0)
                errors.Add(
                string.IsNullOrEmpty(cmbBrand.Text) ?
                    string.Format("{0} alanını doldurun.", lblBrand.Text) :
                    string.Format("{0} isimli {1} mevcut değil.", cmbBrand.Text, lblBrand.Text));

            if (string.IsNullOrEmpty(txtModel.Text))
                errors.Add(string.Format("{0} alanını doldurun.", lblModel.Text));

            if (cmbCategory.SelectedIndex < 0)
                errors.Add(
                     string.IsNullOrEmpty(cmbCategory.Text) ?
                         string.Format("{0} alanını doldurun.", lblCategory.Text) :
                         string.Format("{0} isimli {1} mevcut değil.", cmbCategory.Text, lblCategory.Text));

            if (cmb_SelectInch.SelectedIndex < 0)
                errors.Add(
                      string.IsNullOrEmpty(cmb_SelectInch.Text) ?
                          string.Format("{0} alanını doldurun.", lbl_Inch.Text) :
                          string.Format("{0} isimli {1} mevcut değil.", cmb_SelectInch.Text, lbl_Inch.Text));

            if (cmb_SelectMeasure.SelectedIndex < 0)
                errors.Add(
                     string.IsNullOrEmpty(cmb_SelectMeasure.Text) ?
                         string.Format("{0} alanını doldurun.", lbl_mesaure.Text) :
                         string.Format("{0} isimli {1} mevcut değil.", cmb_SelectMeasure.Text, lbl_mesaure.Text));

            if (!radio_first.Checked && !radio_second.Checked)
                errors.Add(string.Format("{0} alanını doldurun.", lblType.Text));

            if (!int.TryParse(txtYear.Value.ToString(), out parsedValue))
                errors.Add(string.Format("{0} alanını doldurun.", lblYear.Text));

            if (!int.TryParse(txtStock.Value.ToString(), out parsedValue))
                errors.Add(string.Format("{0} alanını doldurun.", lblStock.Text));

            return errors;
        }
        private void ShowExceptionMessage(Exception ex)
        {
            MessageBox.Show(string.Format("Bir hata oluştu:\n{0}Bir hata oluştu:\n{0}", ex.Message), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
