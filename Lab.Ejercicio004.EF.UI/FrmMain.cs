using System;
using System.Windows.Forms;
using Lab.Ejercicio004.EF.Utils;

namespace Lab.Ejercicio004.EF.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void listOfSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormsValidations.CheckFrmForOpenTwice("FrmSuppliersList", this))
            {
                FrmSuppliersList oFrmSupplierList = new FrmSuppliersList();
                oFrmSupplierList.MdiParent = this;
                oFrmSupplierList.Show();
            }
        }

        private void listOfCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormsValidations.CheckFrmForOpenTwice("FrmCategoriesList", this))
            {
                FrmCategoriesList oFrmCategoriesList = new FrmCategoriesList();
                oFrmCategoriesList.MdiParent = this;
                oFrmCategoriesList.Show();
            }
        }

        private void listOfProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormsValidations.CheckFrmForOpenTwice("FrmProductsLists", this))
            {
                FrmProductsLists oFrmSProductsList = new FrmProductsLists();
                oFrmSProductsList.MdiParent = this;
                oFrmSProductsList.Show();
            }
        }
    }
}
