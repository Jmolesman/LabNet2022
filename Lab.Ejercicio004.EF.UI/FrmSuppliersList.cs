using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab.Ejercicio004.EF.Entities;
using Lab.Ejercicio004.EF.Logic;
using Lab.Ejercicio004.EF.Utils;

namespace Lab.Ejercicio004.EF.UI
{
    public partial class FrmSuppliersList : Form
    {
        private List<Suppliers> _fullSupplierList;
        private SuppliersLogic _suppliersLogic;
        public FrmSuppliersList()
        {
            InitializeComponent();
            ConfigureSplitPanel();
        }

        private void FrmSuppliersList_Load(object sender, EventArgs e)
        {
            _suppliersLogic = new SuppliersLogic();
            ShowSupplierData();
        }

        private void ShowSupplierData()
        {
            _fullSupplierList = _suppliersLogic.GetAll();
            dgvSupplierList.DataSource = _fullSupplierList;
            ConfigDataGridView();
        }

        private void ConfigDataGridView()
        {
            dgvSupplierList.BorderStyle = BorderStyle.FixedSingle;
            dgvSupplierList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            for (int i = 0; i < dgvSupplierList.Columns.Count; i++)
            {
                dgvSupplierList.Columns[i].Visible = false;
            }
            dgvSupplierList.Columns["CompanyName"].Visible = true;
            dgvSupplierList.Columns["ContactName"].Visible = true;
            dgvSupplierList.Columns["ContactTitle"].Visible = true;

        }

        private void btnInsertSupplier_Click(object sender, EventArgs e)
        {
            FrmSupplierInsertUpdate oFrmSupplierInsert = new FrmSupplierInsertUpdate(null);
            oFrmSupplierInsert.ShowDialog();
            if (oFrmSupplierInsert.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(_suppliersLogic.Add(oFrmSupplierInsert.NewSupplier));
                ShowSupplierData();
            }
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            int id = Helpers.GetIdFromObject(dgvSupplierList.SelectedRows[0].Cells[0].Value);

            if (Helpers.ExecuteEntityLogic(id))
            {
                string result = _suppliersLogic.Del(id);

                if (result.Contains("conflicted"))
                {
                    DialogResult response;
                    response = MessageBox.Show("The supplier you want to delete is actually in use, do you want to delete all the references to this supplier?", "Supplier in use", MessageBoxButtons.OKCancel);
                    if (response == DialogResult.OK)
                    {
                        ProductsLogic productLogic = new ProductsLogic();
                        result = productLogic.SetSupplierToNull(id);
                        if (result.Contains("successfully"))
                        {
                            MessageBox.Show(_suppliersLogic.Del(id));
                        }
                    }
                }
                else
                {
                    MessageBox.Show(result);
                }
                ShowSupplierData();
            }
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            int id = Helpers.GetIdFromObject(dgvSupplierList.SelectedRows[0].Cells[0].Value);

            if (Helpers.ExecuteEntityLogic(id))
            {
                Suppliers updateSupplier = _suppliersLogic.GetEntityByID(id);

                if (updateSupplier != null)
                {
                    FrmSupplierInsertUpdate oFrmSupplierUpdate = new FrmSupplierInsertUpdate(updateSupplier);

                    oFrmSupplierUpdate.ShowDialog();
                    if (oFrmSupplierUpdate.DialogResult == DialogResult.OK)
                    {
                        MessageBox.Show(_suppliersLogic.Update(oFrmSupplierUpdate.NewSupplier));
                        ShowSupplierData();
                    }
                }
            }
        }

        private void ConfigureSplitPanel()
        {

            splitSuppliers.SplitterDistance = splitSuppliers.Width - splitSuppliers.SplitterWidth;
        }
    }
}
