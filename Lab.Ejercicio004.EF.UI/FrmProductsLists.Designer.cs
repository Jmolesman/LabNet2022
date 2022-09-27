
namespace Lab.Ejercicio004.EF.UI
{
    partial class FrmProductsLists
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
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnInsertProduct = new System.Windows.Forms.Button();
            this.dgvProductsList = new System.Windows.Forms.DataGridView();
            this.splitProducts = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitProducts)).BeginInit();
            this.splitProducts.Panel1.SuspendLayout();
            this.splitProducts.Panel2.SuspendLayout();
            this.splitProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(428, 2);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(109, 23);
            this.btnDeleteProduct.TabIndex = 11;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(260, 2);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(109, 23);
            this.btnUpdateProduct.TabIndex = 10;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnInsertProduct
            // 
            this.btnInsertProduct.Location = new System.Drawing.Point(92, 2);
            this.btnInsertProduct.Name = "btnInsertProduct";
            this.btnInsertProduct.Size = new System.Drawing.Size(109, 23);
            this.btnInsertProduct.TabIndex = 9;
            this.btnInsertProduct.Text = "Insert Product";
            this.btnInsertProduct.UseVisualStyleBackColor = true;
            this.btnInsertProduct.Click += new System.EventHandler(this.btnInsertProduct_Click);
            // 
            // dgvProductsList
            // 
            this.dgvProductsList.AllowUserToAddRows = false;
            this.dgvProductsList.AllowUserToDeleteRows = false;
            this.dgvProductsList.AllowUserToResizeColumns = false;
            this.dgvProductsList.AllowUserToResizeRows = false;
            this.dgvProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductsList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductsList.Location = new System.Drawing.Point(0, 0);
            this.dgvProductsList.MultiSelect = false;
            this.dgvProductsList.Name = "dgvProductsList";
            this.dgvProductsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductsList.Size = new System.Drawing.Size(628, 226);
            this.dgvProductsList.TabIndex = 8;
            // 
            // splitProducts
            // 
            this.splitProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitProducts.Location = new System.Drawing.Point(0, 0);
            this.splitProducts.Name = "splitProducts";
            this.splitProducts.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitProducts.Panel1
            // 
            this.splitProducts.Panel1.Controls.Add(this.dgvProductsList);
            // 
            // splitProducts.Panel2
            // 
            this.splitProducts.Panel2.Controls.Add(this.btnUpdateProduct);
            this.splitProducts.Panel2.Controls.Add(this.btnDeleteProduct);
            this.splitProducts.Panel2.Controls.Add(this.btnInsertProduct);
            this.splitProducts.Size = new System.Drawing.Size(628, 453);
            this.splitProducts.SplitterDistance = 226;
            this.splitProducts.TabIndex = 12;
            // 
            // FrmProductsLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 453);
            this.Controls.Add(this.splitProducts);
            this.Name = "FrmProductsLists";
            this.ShowIcon = false;
            this.Text = "List of Products";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProductsLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).EndInit();
            this.splitProducts.Panel1.ResumeLayout(false);
            this.splitProducts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitProducts)).EndInit();
            this.splitProducts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnInsertProduct;
        private System.Windows.Forms.DataGridView dgvProductsList;
        private System.Windows.Forms.SplitContainer splitProducts;
    }
}