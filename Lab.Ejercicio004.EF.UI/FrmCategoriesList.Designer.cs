
namespace Lab.Ejercicio004.EF.UI
{
    partial class FrmCategoriesList
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
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnInsertCategory = new System.Windows.Forms.Button();
            this.dgvCategoryList = new System.Windows.Forms.DataGridView();
            this.splitCategories = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitCategories)).BeginInit();
            this.splitCategories.Panel1.SuspendLayout();
            this.splitCategories.Panel2.SuspendLayout();
            this.splitCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(428, 3);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(109, 23);
            this.btnDeleteCategory.TabIndex = 11;
            this.btnDeleteCategory.Text = "Delete Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(260, 3);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(109, 23);
            this.btnUpdateCategory.TabIndex = 10;
            this.btnUpdateCategory.Text = "Update Category";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnInsertCategory
            // 
            this.btnInsertCategory.Location = new System.Drawing.Point(92, 3);
            this.btnInsertCategory.Name = "btnInsertCategory";
            this.btnInsertCategory.Size = new System.Drawing.Size(109, 23);
            this.btnInsertCategory.TabIndex = 9;
            this.btnInsertCategory.Text = "Insert Category";
            this.btnInsertCategory.UseVisualStyleBackColor = true;
            this.btnInsertCategory.Click += new System.EventHandler(this.btnInsertCategory_Click);
            // 
            // dgvCategoryList
            // 
            this.dgvCategoryList.AllowUserToAddRows = false;
            this.dgvCategoryList.AllowUserToDeleteRows = false;
            this.dgvCategoryList.AllowUserToResizeColumns = false;
            this.dgvCategoryList.AllowUserToResizeRows = false;
            this.dgvCategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategoryList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategoryList.Location = new System.Drawing.Point(0, 0);
            this.dgvCategoryList.MultiSelect = false;
            this.dgvCategoryList.Name = "dgvCategoryList";
            this.dgvCategoryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoryList.Size = new System.Drawing.Size(628, 226);
            this.dgvCategoryList.TabIndex = 8;
            // 
            // splitCategories
            // 
            this.splitCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitCategories.Location = new System.Drawing.Point(0, 0);
            this.splitCategories.Name = "splitCategories";
            this.splitCategories.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitCategories.Panel1
            // 
            this.splitCategories.Panel1.Controls.Add(this.dgvCategoryList);
            // 
            // splitCategories.Panel2
            // 
            this.splitCategories.Panel2.Controls.Add(this.btnUpdateCategory);
            this.splitCategories.Panel2.Controls.Add(this.btnDeleteCategory);
            this.splitCategories.Panel2.Controls.Add(this.btnInsertCategory);
            this.splitCategories.Size = new System.Drawing.Size(628, 453);
            this.splitCategories.SplitterDistance = 226;
            this.splitCategories.TabIndex = 12;
            // 
            // FrmCategoriesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 453);
            this.Controls.Add(this.splitCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCategoriesList";
            this.ShowIcon = false;
            this.Text = "List of Categories";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCategoriesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).EndInit();
            this.splitCategories.Panel1.ResumeLayout(false);
            this.splitCategories.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCategories)).EndInit();
            this.splitCategories.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnInsertCategory;
        private System.Windows.Forms.DataGridView dgvCategoryList;
        private System.Windows.Forms.SplitContainer splitCategories;
    }
}