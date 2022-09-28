using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab.Ejercicio004.EF.Entities;
using Lab.Ejercicio004.EF.Logic;
using Lab.Ejercicio004.EF.Utils;

namespace Lab.Ejercicio004.EF.UI
{
    public partial class FrmProductsInsertUpdate : Form
    {
        public Products NewProduct { get; private set; }
        private CategoriesLogic _categoriesLogic;
        private SuppliersLogic _suppliersLogic;
        private List<Categories> _categoriesList;
        private List<Suppliers> _suppliersList;

        public FrmProductsInsertUpdate(Products oProduct)
        {
            InitializeComponent();
            LoadComboBoxData();

            if (oProduct != null)
            {
                NewProduct = oProduct;
                LoadUpdateData();

            }
            else
            {
                this.Text = "Insert new Product";
            }
        }

        private void LoadUpdateData()
        {
            txtProductName.Text = NewProduct.ProductName;
            txtQuantityPerUnit.Text = NewProduct.QuantityPerUnit;
            txtUnitPrice.Text = NewProduct.UnitPrice.ToString();
            
            if (NewProduct.Categories != null)
            {
                cmbCategoryList.SelectedIndex = cmbCategoryList.Items.IndexOf($"{NewProduct.Categories.CategoryID} - {NewProduct.Categories.CategoryName}");
            }
            else
            {
                cmbCategoryList.SelectedIndex = cmbCategoryList.Items.IndexOf("No Category");
            }

            if (NewProduct.Suppliers != null)
            {
                cmbSupplierList.SelectedIndex = cmbSupplierList.Items.IndexOf($"{NewProduct.Suppliers.SupplierID} - {NewProduct.Suppliers.CompanyName}");
            }
            else
            {
                cmbSupplierList.SelectedIndex = cmbSupplierList.Items.IndexOf("No Supplier");
            }

            if (NewProduct.Discontinued)
            {
                chkbDiscontinued.Checked = true;
            }

            this.Text = "Update current Product";
        }

        private void LoadComboBoxData()
        {
            LoadCategoryComboBox();
            LoadSupplierComboBox();
        }

        private void LoadCategoryComboBox()
        {
            _categoriesLogic = new CategoriesLogic();
            _categoriesList = _categoriesLogic.GetAll();
            foreach (var item in _categoriesList)
            {
                cmbCategoryList.Items.Add($"{item.CategoryID} - {item.CategoryName}");
            }
            cmbCategoryList.Items.Add("No Category");
        }

        private void LoadSupplierComboBox()
        {
            _suppliersLogic = new SuppliersLogic();
            _suppliersList = _suppliersLogic.GetAll();
            foreach (var item in _suppliersList)
            {
                cmbSupplierList.Items.Add($"{item.SupplierID} - {item.CompanyName}");
            }
            cmbSupplierList.Items.Add("No Supplier");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ProductsValidation.ValidateProduct(txtProductName.Text, txtQuantityPerUnit.Text, txtUnitPrice.Text))
            {
                if (NewProduct != null)
                {
                    NewProduct.ProductName = txtProductName.Text;
                    NewProduct.QuantityPerUnit = txtQuantityPerUnit.Text;

                    if (string.IsNullOrWhiteSpace(txtUnitPrice.Text))
                    {
                        NewProduct.UnitPrice = null;
                    }
                    else
                    {
                        NewProduct.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                    }

                    NewProduct.SupplierID = ProductsValidation.ValidateComboBoxNullItem(cmbSupplierList.SelectedItem);
                    NewProduct.CategoryID = ProductsValidation.ValidateComboBoxNullItem(cmbCategoryList.SelectedItem);
                    NewProduct.Discontinued = chkbDiscontinued.Checked;
                }
                else
                {
                    NewProduct = new Products();
                    NewProduct.ProductName = txtProductName.Text;
                    NewProduct.QuantityPerUnit = txtQuantityPerUnit.Text;

                    if (string.IsNullOrWhiteSpace(txtUnitPrice.Text))
                    {
                        NewProduct.UnitPrice = null;
                    }
                    else
                    {
                        NewProduct.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                    }

                    NewProduct.SupplierID = ProductsValidation.ValidateComboBoxNullItem(cmbSupplierList.SelectedItem);
                    NewProduct.CategoryID = ProductsValidation.ValidateComboBoxNullItem(cmbCategoryList.SelectedItem);
                    NewProduct.Discontinued = chkbDiscontinued.Checked;
                }
            }
            else
            {
                MessageBox.Show("The product name cant have more than 40 characters or be null, the quantity per unit cant have more than 20 characters" +
                    " and the unit price has to be blank or be a valid number", "Error in the supplied data");
                this.DialogResult = DialogResult.None;
            }

        }


    }
}
