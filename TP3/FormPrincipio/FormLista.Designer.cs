
namespace Formularios
{
    partial class FormLista
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chocolate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gramos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadAProducir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.button_Fabricar = new System.Windows.Forms.Button();
            this.button_ImportarXml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Marca,
            this.Chocolate,
            this.Gramos,
            this.Agregado,
            this.Tipo,
            this.CantidadAProducir});
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowTemplate.Height = 25;
            this.dataGrid.Size = new System.Drawing.Size(721, 355);
            this.dataGrid.TabIndex = 17;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Chocolate
            // 
            this.Chocolate.HeaderText = "Chocolate";
            this.Chocolate.Name = "Chocolate";
            this.Chocolate.ReadOnly = true;
            // 
            // Gramos
            // 
            this.Gramos.HeaderText = "Gramos";
            this.Gramos.Name = "Gramos";
            this.Gramos.ReadOnly = true;
            // 
            // Agregado
            // 
            this.Agregado.HeaderText = "Agregado";
            this.Agregado.Name = "Agregado";
            this.Agregado.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // CantidadAProducir
            // 
            this.CantidadAProducir.HeaderText = "Cantidad";
            this.CantidadAProducir.Name = "CantidadAProducir";
            this.CantidadAProducir.ReadOnly = true;
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Cancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Cancelar.Location = new System.Drawing.Point(12, 403);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(163, 46);
            this.button_Cancelar.TabIndex = 18;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = false;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // button_Fabricar
            // 
            this.button_Fabricar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Fabricar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Fabricar.Location = new System.Drawing.Point(570, 403);
            this.button_Fabricar.Name = "button_Fabricar";
            this.button_Fabricar.Size = new System.Drawing.Size(163, 46);
            this.button_Fabricar.TabIndex = 19;
            this.button_Fabricar.Text = "Fabricar";
            this.button_Fabricar.UseVisualStyleBackColor = false;
            this.button_Fabricar.Click += new System.EventHandler(this.button_Fabricar_Click);
            // 
            // button_ImportarXml
            // 
            this.button_ImportarXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_ImportarXml.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_ImportarXml.Location = new System.Drawing.Point(288, 403);
            this.button_ImportarXml.Name = "button_ImportarXml";
            this.button_ImportarXml.Size = new System.Drawing.Size(163, 46);
            this.button_ImportarXml.TabIndex = 21;
            this.button_ImportarXml.Text = "Importar Archivo";
            this.button_ImportarXml.UseVisualStyleBackColor = false;
            this.button_ImportarXml.Click += new System.EventHandler(this.button_ImportarXml_Click);
            // 
            // FormLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 475);
            this.Controls.Add(this.button_ImportarXml);
            this.Controls.Add(this.button_Fabricar);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.dataGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.FormLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chocolate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gramos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agregado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadAProducir;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Button button_Fabricar;
        private System.Windows.Forms.Button button_ImportarXml;
    }
}