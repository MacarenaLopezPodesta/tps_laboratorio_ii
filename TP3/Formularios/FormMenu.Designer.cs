
namespace Formularios
{
    partial class btn_FromMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_MateriaPrima = new System.Windows.Forms.Button();
            this.button_Registrar = new System.Windows.Forms.Button();
            this.button_Editar = new System.Windows.Forms.Button();
            this.button_Fabricar = new System.Windows.Forms.Button();
            this.button_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_MateriaPrima
            // 
            this.button_MateriaPrima.Location = new System.Drawing.Point(12, 39);
            this.button_MateriaPrima.Name = "button_MateriaPrima";
            this.button_MateriaPrima.Size = new System.Drawing.Size(224, 23);
            this.button_MateriaPrima.TabIndex = 0;
            this.button_MateriaPrima.Text = "Materia Prima";
            this.button_MateriaPrima.UseVisualStyleBackColor = true;
            this.button_MateriaPrima.Click += new System.EventHandler(this.button_MateriaPrima_Click_1);
            // 
            // button_Registrar
            // 
            this.button_Registrar.Location = new System.Drawing.Point(12, 107);
            this.button_Registrar.Name = "button_Registrar";
            this.button_Registrar.Size = new System.Drawing.Size(224, 23);
            this.button_Registrar.TabIndex = 1;
            this.button_Registrar.Text = "Registrar Chocolates";
            this.button_Registrar.UseVisualStyleBackColor = true;
            this.button_Registrar.Click += new System.EventHandler(this.button_Registrar_Click);
            // 
            // button_Editar
            // 
            this.button_Editar.Location = new System.Drawing.Point(12, 170);
            this.button_Editar.Name = "button_Editar";
            this.button_Editar.Size = new System.Drawing.Size(224, 23);
            this.button_Editar.TabIndex = 2;
            this.button_Editar.Text = "Editar registros";
            this.button_Editar.UseVisualStyleBackColor = true;
            this.button_Editar.Click += new System.EventHandler(this.button_Editar_Click);
            // 
            // button_Fabricar
            // 
            this.button_Fabricar.Location = new System.Drawing.Point(12, 231);
            this.button_Fabricar.Name = "button_Fabricar";
            this.button_Fabricar.Size = new System.Drawing.Size(224, 23);
            this.button_Fabricar.TabIndex = 3;
            this.button_Fabricar.Text = "Fabricar";
            this.button_Fabricar.UseVisualStyleBackColor = true;
            this.button_Fabricar.Click += new System.EventHandler(this.button_Fabricar_Click);
            // 
            // button_Salir
            // 
            this.button_Salir.Location = new System.Drawing.Point(12, 293);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(224, 23);
            this.button_Salir.TabIndex = 4;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // btn_FromMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(767, 372);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.button_Fabricar);
            this.Controls.Add(this.button_Editar);
            this.Controls.Add(this.button_Registrar);
            this.Controls.Add(this.button_MateriaPrima);
            this.Name = "btn_FromMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_MateriaPrima;
        private System.Windows.Forms.Button button_Registrar;
        private System.Windows.Forms.Button button_Editar;
        private System.Windows.Forms.Button button_Fabricar;
        private System.Windows.Forms.Button button_Salir;
    }
}

