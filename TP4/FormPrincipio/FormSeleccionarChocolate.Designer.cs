
namespace Formularios
{
    partial class FormSeleccionarChocolate
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
            this.button_SeleccionarTabletas = new System.Windows.Forms.Button();
            this.button_SeleccionarBombones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_SeleccionarTabletas
            // 
            this.button_SeleccionarTabletas.Image = global::Formularios.Properties.Resources.TabletaChocolate;
            this.button_SeleccionarTabletas.Location = new System.Drawing.Point(41, 32);
            this.button_SeleccionarTabletas.Name = "button_SeleccionarTabletas";
            this.button_SeleccionarTabletas.Size = new System.Drawing.Size(206, 188);
            this.button_SeleccionarTabletas.TabIndex = 0;
            this.button_SeleccionarTabletas.UseVisualStyleBackColor = true;
            this.button_SeleccionarTabletas.Click += new System.EventHandler(this.button_SeleccionarTabletas_Click);
            // 
            // button_SeleccionarBombones
            // 
            this.button_SeleccionarBombones.Image = global::Formularios.Properties.Resources.b08a1496bc92ed8f8b09426573dac401__dessert_chocolate_chocolate_cakes;
            this.button_SeleccionarBombones.Location = new System.Drawing.Point(41, 271);
            this.button_SeleccionarBombones.Name = "button_SeleccionarBombones";
            this.button_SeleccionarBombones.Size = new System.Drawing.Size(206, 196);
            this.button_SeleccionarBombones.TabIndex = 1;
            this.button_SeleccionarBombones.UseVisualStyleBackColor = true;
            this.button_SeleccionarBombones.Click += new System.EventHandler(this.button_SeleccionarBombones_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(100, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "BOMBONES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(100, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "TABLETAS";
            // 
            // button_Salir
            // 
            this.button_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Salir.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Salir.Location = new System.Drawing.Point(65, 483);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(166, 36);
            this.button_Salir.TabIndex = 6;
            this.button_Salir.Text = "Cancelar";
            this.button_Salir.UseVisualStyleBackColor = false;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // FormSeleccionarChocolate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 531);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_SeleccionarBombones);
            this.Controls.Add(this.button_SeleccionarTabletas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSeleccionarChocolate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_SeleccionarTabletas;
        private System.Windows.Forms.Button button_SeleccionarBombones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Salir;
    }
}