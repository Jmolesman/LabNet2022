
namespace Lab.Ejercicio004.EF.UI
{
    partial class FrmMain
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
            this.menuMainForm = new System.Windows.Forms.MenuStrip();
            this.menuProductsLists = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMainForm
            // 
            this.menuMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suppliersToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.productsToolStripMenuItem});
            this.menuMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuMainForm.Name = "menuMainForm";
            this.menuMainForm.Size = new System.Drawing.Size(675, 24);
            this.menuMainForm.TabIndex = 3;
            this.menuMainForm.Text = "Menu";
            // 
            // menuProductsLists
            // 
            this.menuProductsLists.Name = "menuProductsLists";
            this.menuProductsLists.Size = new System.Drawing.Size(32, 19);
            // 
            // listaDeProveedoresToolStripMenuItem
            // 
            this.listaDeProveedoresToolStripMenuItem.Name = "listaDeProveedoresToolStripMenuItem";
            this.listaDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // listaDeCategoriasToolStripMenuItem
            // 
            this.listaDeCategoriasToolStripMenuItem.Name = "listaDeCategoriasToolStripMenuItem";
            this.listaDeCategoriasToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfSuppliersToolStripMenuItem});
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            // 
            // listOfSuppliersToolStripMenuItem
            // 
            this.listOfSuppliersToolStripMenuItem.Name = "listOfSuppliersToolStripMenuItem";
            this.listOfSuppliersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listOfSuppliersToolStripMenuItem.Text = "List of Suppliers";
            this.listOfSuppliersToolStripMenuItem.Click += new System.EventHandler(this.listOfSuppliersToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfCategoriesToolStripMenuItem});
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoryToolStripMenuItem.Text = "Categories";
            // 
            // listOfCategoriesToolStripMenuItem
            // 
            this.listOfCategoriesToolStripMenuItem.Name = "listOfCategoriesToolStripMenuItem";
            this.listOfCategoriesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listOfCategoriesToolStripMenuItem.Text = "List of Categories";
            this.listOfCategoriesToolStripMenuItem.Click += new System.EventHandler(this.listOfCategoriesToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfProductsToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // listOfProductsToolStripMenuItem
            // 
            this.listOfProductsToolStripMenuItem.Name = "listOfProductsToolStripMenuItem";
            this.listOfProductsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listOfProductsToolStripMenuItem.Text = "List of Products";
            this.listOfProductsToolStripMenuItem.Click += new System.EventHandler(this.listOfProductsToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 347);
            this.Controls.Add(this.menuMainForm);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "Lab.Ejer004";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuMainForm.ResumeLayout(false);
            this.menuMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMainForm;
        private System.Windows.Forms.ToolStripMenuItem menuProductsLists;
        private System.Windows.Forms.ToolStripMenuItem listaDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfSuppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfProductsToolStripMenuItem;
    }
}

