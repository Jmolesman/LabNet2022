using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab.Ejercicio004.EF.Entities;
using Lab.Ejercicio004.EF.Logic;
using Lab.Ejercicio004.EF.Utils;

namespace Lab.Ejercicio004.EF.UI
{
    public partial class FrmProductsLists : Form
    {
        private List<Products> _fullProductsList;
        private ProductsLogic _productsLogic;

        public FrmProductsLists()
        {
            InitializeComponent();
            ConfigureSplitPanel();
        }

        private void btnInsertProduct_Click(object sender, EventArgs e)
        {
            FrmProductsInsertUpdate oFrmProductsInsert = new FrmProductsInsertUpdate(null);
            oFrmProductsInsert.ShowDialog();
            if (oFrmProductsInsert.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(_productsLogic.Add(oFrmProductsInsert.NewProduct));
                ShowProductData();
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            int id = Helpers.GetIdFromObject(dgvProductsList.SelectedRows[0].Cells[0].Value);

            if (Helpers.ExecuteEntityLogic(id))
            {
                Products updateProduct = _productsLogic.GetEntityByID(id);

                if (updateProduct != null)
                {
                    FrmProductsInsertUpdate oFrmProductUpdate = new FrmProductsInsertUpdate(updateProduct);

                    oFrmProductUpdate.ShowDialog();
                    if (oFrmProductUpdate.DialogResult == DialogResult.OK)
                    {
                        MessageBox.Show(_productsLogic.Update(oFrmProductUpdate.NewProduct));
                        ShowProductData();
                    }
                }
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int id = Helpers.GetIdFromObject(dgvProductsList.SelectedRows[0].Cells[0].Value);

            if (Helpers.ExecuteEntityLogic(id))
            {
                string result = _productsLogic.Del(id);
                MessageBox.Show(result);
                ShowProductData();
            }
        }

        private void FrmProductsLists_Load(object sender, EventArgs e)
        {
            _productsLogic = new ProductsLogic();
            ShowProductData();
        }

        private void ShowProductData()
        {
            _fullProductsList = _productsLogic.GetAll();
            dgvProductsList.DataSource = _fullProductsList;
            ConfigDataGridView();
        }

        private void ConfigDataGridView()
        {
            dgvProductsList.BorderStyle = BorderStyle.FixedSingle;
            dgvProductsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            for (int i = 0; i < dgvProductsList.Columns.Count; i++)
            {
                dgvProductsList.Columns[i].Visible = false;
            }
            dgvProductsList.Columns["ProductName"].Visible = true;
            dgvProductsList.Columns["QuantityPerUnit"].Visible = true;
            dgvProductsList.Columns["UnitPrice"].Visible = true;
            dgvProductsList.Columns["Discontinued"].Visible = true;
        }

        private void ConfigureSplitPanel()
        {

            splitProducts.SplitterDistance = splitProducts.Width - splitProducts.SplitterWidth;
        }
    }
}
