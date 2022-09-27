using System;
using System.Windows.Forms;
using Lab.Ejercicio004.EF.Entities;
using Lab.Ejercicio004.EF.Utils;

namespace Lab.Ejercicio004.EF.UI
{
    public partial class FrmCategoriesInsertUpdate : Form
    {
        public Categories NewCategory { get; private set; }

        public FrmCategoriesInsertUpdate(Categories oCategory)
        {
            InitializeComponent();

            if (oCategory != null)
            {
                NewCategory = oCategory;
                txtCategoryName.Text = NewCategory.CategoryName;
                txtDescription.Text = NewCategory.Description;
                this.Text = "Update current Category";
            }
            else
            {
                this.Text = "Insert new Category";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CategoriesValidation.ValidateCategory(txtCategoryName.Text, txtDescription.Text))
            {
                if (NewCategory != null)
                {
                    NewCategory.CategoryName = txtCategoryName.Text;
                    NewCategory.Description = txtDescription.Text;
                }
                else
                {
                    NewCategory = new Categories();
                    NewCategory.CategoryName = txtCategoryName.Text;
                    NewCategory.Description = txtDescription.Text;
                }
            }
            else
            {
                MessageBox.Show("The category name cant have more than 15 characters, and the description cant have more than 1,073,741,823 characters", "Error in the supplied data");
                this.DialogResult = DialogResult.None;
            }
        }
    }
}
