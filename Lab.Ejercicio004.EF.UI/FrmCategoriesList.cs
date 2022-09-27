using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab.Ejercicio004.EF.Entities;
using Lab.Ejercicio004.EF.Logic;
using Lab.Ejercicio004.EF.Utils;

namespace Lab.Ejercicio004.EF.UI
{
    public partial class FrmCategoriesList : Form
    {
        private List<Categories> _fullCategoriesList;
        private CategoriesLogic _categoriesLogic;

        public FrmCategoriesList()
        {
            InitializeComponent();
            ConfigureSplitPanel();
        }

        private void FrmCategoriesList_Load(object sender, EventArgs e)
        {
            _categoriesLogic = new CategoriesLogic();
            ShowCategoriesData();
        }

        private void ShowCategoriesData()
        {
            _fullCategoriesList = _categoriesLogic.GetAll();
            dgvCategoryList.DataSource = _fullCategoriesList;
            ConfigDataGridView();
        }

        private void ConfigDataGridView()
        {
            dgvCategoryList.BorderStyle = BorderStyle.FixedSingle;
            dgvCategoryList.Columns["Description"].AutoSizeMode = (DataGridViewAutoSizeColumnMode)DataGridViewAutoSizeColumnsMode.AllCells;

            for (int i = 0; i < dgvCategoryList.Columns.Count; i++)
            {
                dgvCategoryList.Columns[i].Visible = false;
            }
            dgvCategoryList.Columns["CategoryName"].Visible = true;
            dgvCategoryList.Columns["Description"].Visible = true;
        }

        private void btnInsertCategory_Click(object sender, EventArgs e)
        {
            FrmCategoriesInsertUpdate oFrmCategoriesInsert = new FrmCategoriesInsertUpdate(null);
            oFrmCategoriesInsert.ShowDialog();
            if (oFrmCategoriesInsert.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(_categoriesLogic.Add(oFrmCategoriesInsert.NewCategory));
                ShowCategoriesData();
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            int id = Helpers.GetIdFromObject(dgvCategoryList.SelectedRows[0].Cells[0].Value);
            if (Helpers.ExecuteEntityLogic(id))
            {
                Categories updateCategory = _categoriesLogic.GetEntityByID(id);

                if (updateCategory != null)
                {
                    FrmCategoriesInsertUpdate oFrmCategoriesUpdate = new FrmCategoriesInsertUpdate(updateCategory);

                    oFrmCategoriesUpdate.ShowDialog();
                    if (oFrmCategoriesUpdate.DialogResult == DialogResult.OK)
                    {
                        MessageBox.Show(_categoriesLogic.Update(oFrmCategoriesUpdate.NewCategory));
                        ShowCategoriesData();
                    }
                }
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Helpers.GetIdFromObject(dgvCategoryList.SelectedRows[0].Cells[0].Value);
            if (Helpers.ExecuteEntityLogic(id))
            {
                string result = _categoriesLogic.Del(id);

                if (result.Contains("conflicted"))
                {
                    DialogResult response;
                    response = MessageBox.Show("The category you want to delete is actually in use, do you want to delete all the references to this category?", "Category in use", MessageBoxButtons.OKCancel);
                    if (response == DialogResult.OK)
                    {
                        ProductsLogic productLogic = new ProductsLogic();
                        result = productLogic.SetCategoryToNull(id);
                        if (result.Contains("successfully"))
                        {
                            MessageBox.Show(_categoriesLogic.Del(id));
                        }
                    }
                }
                else
                {
                    MessageBox.Show(result);
                }
                ShowCategoriesData();
            }
        }

        private void ConfigureSplitPanel()
        {

            splitCategories.SplitterDistance = splitCategories.Width - splitCategories.SplitterWidth;
        }

    }
}
