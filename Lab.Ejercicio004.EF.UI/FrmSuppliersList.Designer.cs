
namespace Lab.Ejercicio004.EF.UI
{
    partial class FrmSuppliersList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.btnUpdateSupplier = new System.Windows.Forms.Button();
            this.btnInsertSupplier = new System.Windows.Forms.Button();
            this.dgvEmployeesList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Location = new System.Drawing.Point(429, 277);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(109, 23);
            this.btnDeleteSupplier.TabIndex = 7;
            this.btnDeleteSupplier.Text = "Eliminar Empleado";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.Location = new System.Drawing.Point(261, 277);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(109, 23);
            this.btnUpdateSupplier.TabIndex = 6;
            this.btnUpdateSupplier.Text = "Modificar Empleado";
            this.btnUpdateSupplier.UseVisualStyleBackColor = true;
            // 
            // btnInsertSupplier
            // 
            this.btnInsertSupplier.Location = new System.Drawing.Point(93, 277);
            this.btnInsertSupplier.Name = "btnInsertSupplier";
            this.btnInsertSupplier.Size = new System.Drawing.Size(109, 23);
            this.btnInsertSupplier.TabIndex = 5;
            this.btnInsertSupplier.Text = "Agregar Empleado";
            this.btnInsertSupplier.UseVisualStyleBackColor = true;
            // 
            // dgvEmployeesList
            // 
            this.dgvEmployeesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeesList.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployeesList.Name = "dgvEmployeesList";
            this.dgvEmployeesList.Size = new System.Drawing.Size(607, 252);
            this.dgvEmployeesList.TabIndex = 4;
            // 
            // FrmSuppliersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 305);
            this.Controls.Add(this.btnDeleteSupplier);
            this.Controls.Add(this.btnUpdateSupplier);
            this.Controls.Add(this.btnInsertSupplier);
            this.Controls.Add(this.dgvEmployeesList);
            this.Name = "FrmSuppliersList";
            this.Text = "Lista de Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button btnUpdateSupplier;
        private System.Windows.Forms.Button btnInsertSupplier;
        private System.Windows.Forms.DataGridView dgvEmployeesList;
    }
}