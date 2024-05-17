using AskanOtoLastik.Data;
using AskanOtoLastik.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AskanOtoLastik.UI.Forms
{
    public partial class FormMeasure : Form
    {
        public FormMeasure()
        {
            InitializeComponent();
            Load_SelectInch();
        }

        private void btnAddMeasure_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMeasureName.Text) || select_inch_new.SelectedIndex < 0)
                {
                    MessageBox.Show("Ölçü Alanı Boş Olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var context = new AppDbContext();

                string newMeasureName = txtMeasureName.Text + " R" + select_inch_new.Text.Replace("\"", "");
                if (!context.Measures.Any(x => x.Name.ToLower() == newMeasureName.ToLower()))
                {
                    context.Measures.Add(new()
                    {
                        Name = newMeasureName,
                        MeasureInchId = Convert.ToInt32(select_inch_new.SelectedValue)
                    });

                    context.SaveChanges();
                    Load_MeasureList();
                    txtMeasureName.Text = "";

                    MessageBox.Show(string.Format("{0} ölçüsü kaydedildi!", newMeasureName), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(string.Format("{0} ölçüsü zaten kayıtlı!", newMeasureName), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                ShowExceptionMessage(ex);
            }
        }

        private void btnDeleteMeasure_Click(object sender, EventArgs e)
        {
            try
            {
                if (Measure_list.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Lütfen bir seçim yapın!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var context = new AppDbContext();

                string MeasureName = Measure_list.SelectedRows[0].Cells["Measure"].Value.ToString();
                int MeasureId = Convert.ToInt32(Measure_list.SelectedRows[0].Cells["Id"].Value);
                var Measure = context.Measures.Include(x => x.Products).FirstOrDefault(x => x.Id == MeasureId);

                if (Measure.Products.Any())
                {
                    MessageBox.Show(MeasureName + " ölçüsünde stok mevcut olduğu için silinemez.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var result = MessageBox.Show(Measure.Name + " ölçüsü silinecek. Emin Misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    context.Measures.Remove(Measure);
                    context.SaveChanges();
                    Load_MeasureList();
                }
            }
            catch (Exception ex)
            {
                ShowExceptionMessage(ex);
            }
        }

        private void btnSaveInch_Click(object sender, EventArgs e)
        {
            try
            {
                int newInch;
                if (string.IsNullOrEmpty(txtInch.Text) || !int.TryParse(txtInch.Text, out newInch))
                {
                    MessageBox.Show("Lütfen sadece sayı girin! \n Örnek : 12", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using var context = new AppDbContext();

                string newInchText = newInch.ToString() + '"';
                if (!context.MeasureInch.Any(x => x.Inch == newInchText))
                {
                    context.MeasureInch.Add(new() { Inch = newInchText });
                    context.SaveChanges();

                    txtInch.Text = "";
                    Load_SelectInch();

                    MessageBox.Show(string.Format("{0} ölçüsü kaydedildi!", newInchText), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Format("{0} ölçüsü sistemde zaten kayıtlı!", newInchText), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                ShowExceptionMessage(ex);
            }
        }

        private void btnDeleteInch_Click(object sender, EventArgs e)
        {
            try
            {
                int newInch;
                txtInch.Text = txtInch.Text.Replace("\"", "");
                if (string.IsNullOrEmpty(txtInch.Text) || !int.TryParse(txtInch.Text, out newInch))
                {
                    MessageBox.Show("Lütfen sadece sayı girin! \n Örnek : 12", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var context = new AppDbContext();

                string newInchText = newInch.ToString() + '"';

                var measureInch = context.MeasureInch.Include(x => x.Measures).ThenInclude(x => x.Products).FirstOrDefault(x => x.Inch == newInchText);

                if (measureInch != null)
                {
                    if (measureInch.Measures.Any(x => x.Products.Count > 0))
                    {
                        MessageBox.Show(newInchText + " ölçüsünde kayıtlı ürün mevcut olduğu için silinemez.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }


                    var result = MessageBox.Show(newInchText + " ölçüsü silinecek. Emin Misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        context.MeasureInch.Remove(measureInch);
                        context.SaveChanges();

                        txtInch.Text = "";
                        Load_SelectInch();
                    }
                }
                else
                {
                    MessageBox.Show(string.Format("{0} ölçüsü sistemde kayıtlı değil!", newInchText), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                ShowExceptionMessage(ex);
            }
        }
        private void Load_SelectInch()
        {
            using var context = new AppDbContext();

            var inches = context.MeasureInch.OrderBy(x => x.Inch).ToList();
            select_inch.DataSource = inches;

            select_inch_new.DataSource = inches.ToList();
            Load_MeasureList();
        }

        private void Load_MeasureList()
        {
            using var context = new AppDbContext();

            Measure_list.DataSource = context.Measures.Include(x => x.Products)
                .Where(x => x.MeasureInchId == Convert.ToInt32(select_inch.SelectedValue))
                .Select(x => new { x.Id, x.Name, Stock = x.Products.Sum(p => p.Stock) })
                .OrderBy(x => x.Name).ToList();
        }

        private void select_inch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_MeasureList();
        }

        private void MeasureList_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            Measure_list.ClearSelection();
            int rowSelected = e.RowIndex;
            if (e.RowIndex != -1)
            {
                this.Measure_list.Rows[rowSelected].Selected = true;
            }
            e.ContextMenuStrip = MeasureContextMenu;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDeleteMeasure_Click(sender, e);
        }

        private void Measure_list_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Measure_list.ClearSelection();
        }

        private void ShowExceptionMessage(Exception ex)
        {
            MessageBox.Show(string.Format("Bir hata oluştu: \n {0}", ex.Message), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
