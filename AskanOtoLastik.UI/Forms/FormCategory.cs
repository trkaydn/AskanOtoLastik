using AskanOtoLastik.Data;
using AskanOtoLastik.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AskanOtoLastik.UI.Forms
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
            RefreshList();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCategoryName.Text))
                {
                    MessageBox.Show("Kategori Adı Boş Olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var context = new AppDbContext();

                if (!context.Categories.Any(x => string.Equals(x.Name.ToLower(), txtCategoryName.Text.ToLower())))
                {
                    context.Categories.Add(new()
                    {
                        Name = txtCategoryName.Text,
                    });

                    context.SaveChanges();
                    RefreshList();
                    txtCategoryName.Text = "";
                }
                else
                    MessageBox.Show(string.Format("{0} Kategorisi Zaten Mevcut!", txtCategoryName.Text), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                ShowExceptionMessage(ex);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (category_list.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Lütfen bir seçim yapın!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var context = new AppDbContext();

                string categoryName = category_list.SelectedRows[0].Cells["Category"].Value.ToString();
                int categoryId = Convert.ToInt32(category_list.SelectedRows[0].Cells["Id"].Value);
                var category = context.Categories.Include(x => x.Products).FirstOrDefault(x => x.Id == categoryId);

                if (category.Products.Any())
                {
                    MessageBox.Show(categoryName + " kategorisinde kayıtlı ürün mevcut olduğu için silinemez.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var result = MessageBox.Show(category.Name + " isimli kategori silinecek. Emin Misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    context.Categories.Remove(category);
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
            category_list.DataSource = context.Categories.Select(x => new { x.Id, x.Name, Stock = x.Products.Sum(p => p.Stock) }).OrderBy(x => x.Name).ToList();
        }

        private void category_list_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            category_list.ClearSelection();
            int rowSelected = e.RowIndex;
            if (e.RowIndex != -1)
            {
                this.category_list.Rows[rowSelected].Selected = true;
            }
            e.ContextMenuStrip = CategoryContextMenu;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDeleteCategory_Click(sender, e);
        }

        private void category_list_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            category_list.ClearSelection();
        }

        private void ShowExceptionMessage(Exception ex)
        {
            MessageBox.Show(string.Format("Bir hata oluştu: \n {0}", ex.Message), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
