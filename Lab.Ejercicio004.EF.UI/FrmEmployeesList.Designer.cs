
namespace Lab.Ejercicio004.EF.UI
{
    partial class FrmEmployeesList
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
            this.dgvEmployeesList = new System.Windows.Forms.DataGridView();
            this.btnEmployeeInsert = new System.Windows.Forms.Button();
            this.btnEmployeeUpdate = new System.Windows.Forms.Button();
            this.btnEmployeeDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployeesList
            // 
            this.dgvEmployeesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeesList.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployeesList.Name = "dgvEmployeesList";
            this.dgvEmployeesList.Size = new System.Drawing.Size(607, 252);
            this.dgvEmployeesList.TabIndex = 0;
            // 
            // btnEmployeeInsert
            // 
            this.btnEmployeeInsert.Location = new System.Drawing.Point(93, 279);
            this.btnEmployeeInsert.Name = "btnEmployeeInsert";
            this.btnEmployeeInsert.Size = new System.Drawing.Size(109, 23);
            this.btnEmployeeInsert.TabIndex = 1;
            this.btnEmployeeInsert.Text = "Agregar Empleado";
            this.btnEmployeeInsert.UseVisualStyleBackColor = true;
            this.btnEmployeeInsert.Click += new System.EventHandler(this.btnEmployeeInsert_Click);
            // 
            // btnEmployeeUpdate
            // 
            this.btnEmployeeUpdate.Location = new System.Drawing.Point(261, 279);
            this.btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            this.btnEmployeeUpdate.Size = new System.Drawing.Size(109, 23);
            this.btnEmployeeUpdate.TabIndex = 2;
            this.btnEmployeeUpdate.Text = "Modificar Empleado";
            this.btnEmployeeUpdate.UseVisualStyleBackColor = true;
            this.btnEmployeeUpdate.Click += new System.EventHandler(this.btnEmployeeUpdate_Click);
            // 
            // btnEmployeeDelete
            // 
            this.btnEmployeeDelete.Location = new System.Drawing.Point(429, 279);
            this.btnEmployeeDelete.Name = "btnEmployeeDelete";
            this.btnEmployeeDelete.Size = new System.Drawing.Size(109, 23);
            this.btnEmployeeDelete.TabIndex = 3;
            this.btnEmployeeDelete.Text = "Eliminar Empleado";
            this.btnEmployeeDelete.UseVisualStyleBackColor = true;
            this.btnEmployeeDelete.Click += new System.EventHandler(this.btnEmployeeDelete_Click);
            // 
            // FrmEmployeesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 314);
            this.Controls.Add(this.btnEmployeeDelete);
            this.Controls.Add(this.btnEmployeeUpdate);
            this.Controls.Add(this.btnEmployeeInsert);
            this.Controls.Add(this.dgvEmployeesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmployeesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista de Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeesList;
        private System.Windows.Forms.Button btnEmployeeInsert;
        private System.Windows.Forms.Button btnEmployeeUpdate;
        private System.Windows.Forms.Button btnEmployeeDelete;
    }
}