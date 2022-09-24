
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
            this.menuOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOrdersLists = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductsLists = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmployeesLists = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClients = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientsLists = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSuppliersLists = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMainForm
            // 
            this.menuMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOrders,
            this.menuProducts,
            this.menuPerson});
            this.menuMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuMainForm.Name = "menuMainForm";
            this.menuMainForm.Size = new System.Drawing.Size(675, 24);
            this.menuMainForm.TabIndex = 3;
            this.menuMainForm.Text = "Menu";
            // 
            // menuOrders
            // 
            this.menuOrders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOrdersLists});
            this.menuOrders.Name = "menuOrders";
            this.menuOrders.Size = new System.Drawing.Size(63, 20);
            this.menuOrders.Text = "Ordenes";
            // 
            // menuOrdersLists
            // 
            this.menuOrdersLists.Name = "menuOrdersLists";
            this.menuOrdersLists.Size = new System.Drawing.Size(202, 22);
            this.menuOrdersLists.Text = "Lista de Ordenes Activas";
            // 
            // menuProducts
            // 
            this.menuProducts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProductsLists});
            this.menuProducts.Name = "menuProducts";
            this.menuProducts.Size = new System.Drawing.Size(73, 20);
            this.menuProducts.Text = "Productos";
            // 
            // menuProductsLists
            // 
            this.menuProductsLists.Name = "menuProductsLists";
            this.menuProductsLists.Size = new System.Drawing.Size(180, 22);
            this.menuProductsLists.Text = "Lista de Productos";
            // 
            // menuPerson
            // 
            this.menuPerson.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEmployees,
            this.menuClients,
            this.menuSuppliers});
            this.menuPerson.Name = "menuPerson";
            this.menuPerson.Size = new System.Drawing.Size(66, 20);
            this.menuPerson.Text = "Personas";
            // 
            // menuEmployees
            // 
            this.menuEmployees.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEmployeesLists});
            this.menuEmployees.Name = "menuEmployees";
            this.menuEmployees.Size = new System.Drawing.Size(180, 22);
            this.menuEmployees.Text = "Empleados";
            // 
            // menuEmployeesLists
            // 
            this.menuEmployeesLists.Name = "menuEmployeesLists";
            this.menuEmployeesLists.Size = new System.Drawing.Size(180, 22);
            this.menuEmployeesLists.Text = "Lista de Empleados";
            this.menuEmployeesLists.Click += new System.EventHandler(this.menuEmployeesLists_Click);
            // 
            // menuClients
            // 
            this.menuClients.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientsLists});
            this.menuClients.Name = "menuClients";
            this.menuClients.Size = new System.Drawing.Size(180, 22);
            this.menuClients.Text = "Clientes";
            // 
            // menuClientsLists
            // 
            this.menuClientsLists.Name = "menuClientsLists";
            this.menuClientsLists.Size = new System.Drawing.Size(180, 22);
            this.menuClientsLists.Text = "Lista de Clientes";
            // 
            // menuSuppliers
            // 
            this.menuSuppliers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSuppliersLists});
            this.menuSuppliers.Name = "menuSuppliers";
            this.menuSuppliers.Size = new System.Drawing.Size(180, 22);
            this.menuSuppliers.Text = "Proveedores";
            // 
            // menuSuppliersLists
            // 
            this.menuSuppliersLists.Name = "menuSuppliersLists";
            this.menuSuppliersLists.Size = new System.Drawing.Size(182, 22);
            this.menuSuppliersLists.Text = "Lista de Proveedores";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 347);
            this.Controls.Add(this.menuMainForm);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "Sistema de Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuMainForm.ResumeLayout(false);
            this.menuMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMainForm;
        private System.Windows.Forms.ToolStripMenuItem menuOrders;
        private System.Windows.Forms.ToolStripMenuItem menuProducts;
        private System.Windows.Forms.ToolStripMenuItem menuPerson;
        private System.Windows.Forms.ToolStripMenuItem menuEmployees;
        private System.Windows.Forms.ToolStripMenuItem menuEmployeesLists;
        private System.Windows.Forms.ToolStripMenuItem menuClients;
        private System.Windows.Forms.ToolStripMenuItem menuSuppliers;
        private System.Windows.Forms.ToolStripMenuItem menuOrdersLists;
        private System.Windows.Forms.ToolStripMenuItem menuProductsLists;
        private System.Windows.Forms.ToolStripMenuItem menuClientsLists;
        private System.Windows.Forms.ToolStripMenuItem menuSuppliersLists;
    }
}

