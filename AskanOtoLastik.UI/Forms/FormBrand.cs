using AskanOtoLastik.Data;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace AskanOtoLastik.UI.Forms
{
    public partial class FormBrand : Form
    {
        public FormBrand()
        {
            InitializeComponent();
            RefreshList();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBrandName.Text))
                {
                    MessageBox.Show("Marka Adı Boş Olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var context = new AppDbContext();

                if (!context.Brands.Any(x => x.Name.ToLower() == txtBrandName.Text.ToLower()))
                {
                    context.Brands.Add(new()
                    {
                        Name = txtBrandName.Text,
                    });

                    context.SaveChanges();
                    RefreshList();
                    txtBrandName.Text = "";
                }
                else
                    MessageBox.Show(string.Format("{0} Markası Zaten Kayıtlı!", txtBrandName.Text), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                ShowExceptionMessage(ex);
            }
        }

        private void btnDeleteBrand_Click(object sender, EventArgs e)
        {
            try
            {
                if (Brand_list.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Lütfen bir seçim yapın!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var context = new AppDbContext();

                int brandId = Convert.ToInt32(Brand_list.SelectedRows[0].Cells["Id"].Value);
                string brandName = Brand_list.SelectedRows[0].Cells["Brand"].Value.ToString();
                var brand = context.Brands.Include(x => x.Products).FirstOrDefault(x => x.Id == brandId);

                if (brand.Products.Any())
                {
                    MessageBox.Show(brandName + " markasında kayıtlı ürün mevcut olduğu için silinemez.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var result = MessageBox.Show(brandName + " isimli marka silinecek. Emin Misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    context.Brands.Remove(brand);
                    context.SaveChanges();
                    RefreshList();
                }
            }
            catch (Exception ex)
            {
                ShowExceptionMessage(ex);
            }
        }

        private void RefreshList()
        {
            using var context = new AppDbContext();

            Brand_list.DataSource = context.Brands
                .Select(x => new { x.Id, x.Name, Stock = x.Products.Sum(p => p.Stock) }).OrderBy(x => x.Name).ToList();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDeleteBrand_Click(sender, e);
        }

        private void Brand_list_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            Brand_list.ClearSelection();
            int rowSelected = e.RowIndex;
            if (e.RowIndex != -1)
            {
                this.Brand_list.Rows[rowSelected].Selected = true;
            }
            e.ContextMenuStrip = BrandContextMenu;
        }

        private void Brand_list_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Brand_list.ClearSelection();
        }
        private void ShowExceptionMessage(Exception ex)
        {
            MessageBox.Show(string.Format("Bir hata oluştu:\n{0}Bir hata oluştu:\n{0}", ex.Message), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
