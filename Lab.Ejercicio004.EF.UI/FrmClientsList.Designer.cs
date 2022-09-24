
namespace Lab.Ejercicio004.EF.UI
{
    partial class FrmClientsList
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
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnInsertClient = new System.Windows.Forms.Button();
            this.dgvClientsList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(429, 279);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(109, 23);
            this.btnDeleteClient.TabIndex = 7;
            this.btnDeleteClient.Text = "Eliminar Empleado";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Location = new System.Drawing.Point(261, 279);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(109, 23);
            this.btnUpdateClient.TabIndex = 6;
            this.btnUpdateClient.Text = "Modificar Empleado";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            // 
            // btnInsertClient
            // 
            this.btnInsertClient.Location = new System.Drawing.Point(93, 279);
            this.btnInsertClient.Name = "btnInsertClient";
            this.btnInsertClient.Size = new System.Drawing.Size(109, 23);
            this.btnInsertClient.TabIndex = 5;
            this.btnInsertClient.Text = "Agregar Empleado";
            this.btnInsertClient.UseVisualStyleBackColor = true;
            // 
            // dgvClientsList
            // 
            this.dgvClientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientsList.Location = new System.Drawing.Point(12, 12);
            this.dgvClientsList.Name = "dgvClientsList";
            this.dgvClientsList.Size = new System.Drawing.Size(607, 252);
            this.dgvClientsList.TabIndex = 4;
            // 
            // FrmClientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 311);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.btnInsertClient);
            this.Controls.Add(this.dgvClientsList);
            this.Name = "FrmClientsList";
            this.Text = "Lista de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnInsertClient;
        private System.Windows.Forms.DataGridView dgvClientsList;
    }
}