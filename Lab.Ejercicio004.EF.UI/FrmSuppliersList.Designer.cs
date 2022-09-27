
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
            this.dgvSupplierList = new System.Windows.Forms.DataGridView();
            this.splitSuppliers = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitSuppliers)).BeginInit();
            this.splitSuppliers.Panel1.SuspendLayout();
            this.splitSuppliers.Panel2.SuspendLayout();
            this.splitSuppliers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Location = new System.Drawing.Point(430, 3);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(109, 23);
            this.btnDeleteSupplier.TabIndex = 7;
            this.btnDeleteSupplier.Text = "Delete Supplier";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.Location = new System.Drawing.Point(262, 3);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(109, 23);
            this.btnUpdateSupplier.TabIndex = 6;
            this.btnUpdateSupplier.Text = "Update Supplier";
            this.btnUpdateSupplier.UseVisualStyleBackColor = true;
            this.btnUpdateSupplier.Click += new System.EventHandler(this.btnUpdateSupplier_Click);
            // 
            // btnInsertSupplier
            // 
            this.btnInsertSupplier.Location = new System.Drawing.Point(94, 3);
            this.btnInsertSupplier.Name = "btnInsertSupplier";
            this.btnInsertSupplier.Size = new System.Drawing.Size(109, 23);
            this.btnInsertSupplier.TabIndex = 5;
            this.btnInsertSupplier.Text = "Insert Supplier";
            this.btnInsertSupplier.UseVisualStyleBackColor = true;
            this.btnInsertSupplier.Click += new System.EventHandler(this.btnInsertSupplier_Click);
            // 
            // dgvSupplierList
            // 
            this.dgvSupplierList.AllowUserToAddRows = false;
            this.dgvSupplierList.AllowUserToDeleteRows = false;
            this.dgvSupplierList.AllowUserToResizeColumns = false;
            this.dgvSupplierList.AllowUserToResizeRows = false;
            this.dgvSupplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplierList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupplierList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSupplierList.Location = new System.Drawing.Point(0, 0);
            this.dgvSupplierList.MultiSelect = false;
            this.dgvSupplierList.Name = "dgvSupplierList";
            this.dgvSupplierList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplierList.Size = new System.Drawing.Size(632, 234);
            this.dgvSupplierList.TabIndex = 4;
            // 
            // splitSuppliers
            // 
            this.splitSuppliers.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitSuppliers.Location = new System.Drawing.Point(0, 0);
            this.splitSuppliers.Name = "splitSuppliers";
            this.splitSuppliers.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitSuppliers.Panel1
            // 
            this.splitSuppliers.Panel1.Controls.Add(this.dgvSupplierList);
            // 
            // splitSuppliers.Panel2
            // 
            this.splitSuppliers.Panel2.Controls.Add(this.btnUpdateSupplier);
            this.splitSuppliers.Panel2.Controls.Add(this.btnDeleteSupplier);
            this.splitSuppliers.Panel2.Controls.Add(this.btnInsertSupplier);
            this.splitSuppliers.Size = new System.Drawing.Size(632, 469);
            this.splitSuppliers.SplitterDistance = 234;
            this.splitSuppliers.TabIndex = 8;
            // 
            // FrmSuppliersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(630, 469);
            this.Controls.Add(this.splitSuppliers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmSuppliersList";
            this.ShowIcon = false;
            this.Text = "List of Current Suppliers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSuppliersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierList)).EndInit();
            this.splitSuppliers.Panel1.ResumeLayout(false);
            this.splitSuppliers.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitSuppliers)).EndInit();
            this.splitSuppliers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button btnUpdateSupplier;
        private System.Windows.Forms.Button btnInsertSupplier;
        private System.Windows.Forms.DataGridView dgvSupplierList;
        private System.Windows.Forms.SplitContainer splitSuppliers;
    }
}