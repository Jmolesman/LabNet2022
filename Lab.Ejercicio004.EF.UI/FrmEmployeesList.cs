using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.Ejercicio004.EF.UI
{
    public partial class FrmEmployeesList : Form
    {
        public FrmEmployeesList()
        {
            InitializeComponent();
        }

        private void btnEmployeeInsert_Click(object sender, EventArgs e)
        {
            FrmEmployeesInsertUpdate frmEmployeeInsert = new FrmEmployeesInsertUpdate();
            frmEmployeeInsert.Text = "Agregar Empleado";
            frmEmployeeInsert.ShowDialog();

            if (frmEmployeeInsert.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Guardar los datos");
                MessageBox.Show("Recargar DGV");
            }
        }

        private void btnEmployeeUpdate_Click(object sender, EventArgs e)
        {
            FrmEmployeesInsertUpdate frmEmployeeUpdate = new FrmEmployeesInsertUpdate();
            frmEmployeeUpdate.Text = "Modificar Empleado";

            LoadDataToForm();

            frmEmployeeUpdate.ShowDialog();

            if (frmEmployeeUpdate.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Guardar los datos");
                MessageBox.Show("Recargar DGV");
            }
        }

        private void LoadDataToForm()
        { 
        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Borrar datos los datos");
            MessageBox.Show("Volver a cargar el DGV");
        }
    }
}
