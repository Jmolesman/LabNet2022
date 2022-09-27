using System;
using System.Windows.Forms;
using Lab.Ejercicio004.EF.Entities;
using Lab.Ejercicio004.EF.Utils;

namespace Lab.Ejercicio004.EF.UI
{
    public partial class FrmSupplierInsertUpdate : Form
    {
        public Suppliers NewSupplier { get; private set; }
        public FrmSupplierInsertUpdate(Suppliers oSupplier)
        {
            InitializeComponent();
            if (oSupplier != null)
            {
                NewSupplier = oSupplier;
                txtCompanyName.Text = NewSupplier.CompanyName;
                txtContactName.Text = NewSupplier.ContactName;
                txtContactTitle.Text = NewSupplier.ContactTitle;
                this.Text = "Update current Supplier";
            }
            else
            {
                this.Text = "Insert new Supplier";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SuppliersValidation.ValidateSupplier(txtCompanyName.Text, txtContactName.Text, txtContactTitle.Text))
            {
                if (NewSupplier != null)
                {
                    NewSupplier.CompanyName = txtCompanyName.Text;
                    NewSupplier.ContactName = txtContactName.Text;
                    NewSupplier.ContactTitle = txtContactTitle.Text;

                }
                else
                {
                    NewSupplier = new Suppliers();
                    NewSupplier.CompanyName = txtCompanyName.Text;
                    NewSupplier.ContactName = txtContactName.Text;
                    NewSupplier.ContactTitle = txtContactTitle.Text;
                }
            }
            else
            {
                MessageBox.Show("The supplier name cant have more than 40 characters or be null, and the contact name and contact title cant have more than 30 characters", "Error in the supplied data");
                this.DialogResult = DialogResult.None;
            }
        }
    }
}
