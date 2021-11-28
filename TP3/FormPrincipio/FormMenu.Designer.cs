
namespace FormPrincipio
{
    partial class Form_Menu
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
            this.button_Salir = new System.Windows.Forms.Button();
            this.button_AggChocolates = new System.Windows.Forms.Button();
            this.button_Fabricar = new System.Windows.Forms.Button();
            this.button_Informes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Salir
            // 
            this.button_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Salir.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Salir.Location = new System.Drawing.Point(40, 366);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(163, 46);
            this.button_Salir.TabIndex = 3;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = false;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // button_AggChocolates
            // 
            this.button_AggChocolates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_AggChocolates.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_AggChocolates.Location = new System.Drawing.Point(12, 81);
            this.button_AggChocolates.Name = "button_AggChocolates";
            this.button_AggChocolates.Size = new System.Drawing.Size(217, 42);
            this.button_AggChocolates.TabIndex = 1;
            this.button_AggChocolates.Text = "REGISTRAR CHOCOLATES";
            this.button_AggChocolates.UseVisualStyleBackColor = false;
            this.button_AggChocolates.Click += new System.EventHandler(this.button_AggChocolates_Click);
            // 
            // button_Fabricar
            // 
            this.button_Fabricar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_Fabricar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Fabricar.Location = new System.Drawing.Point(12, 260);
            this.button_Fabricar.Name = "button_Fabricar";
            this.button_Fabricar.Size = new System.Drawing.Size(217, 42);
            this.button_Fabricar.TabIndex = 4;
            this.button_Fabricar.Text = "FABRICAR";
            this.button_Fabricar.UseVisualStyleBackColor = false;
            this.button_Fabricar.Click += new System.EventHandler(this.button_Fabricar_Click);
            // 
            // button_Informes
            // 
            this.button_Informes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_Informes.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Informes.Location = new System.Drawing.Point(12, 169);
            this.button_Informes.Name = "button_Informes";
            this.button_Informes.Size = new System.Drawing.Size(217, 42);
            this.button_Informes.TabIndex = 5;
            this.button_Informes.Text = "INFORMES DE REGISTROS";
            this.button_Informes.UseVisualStyleBackColor = false;
            this.button_Informes.Click += new System.EventHandler(this.button_Informes_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(241, 469);
            this.Controls.Add(this.button_Informes);
            this.Controls.Add(this.button_Fabricar);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.button_AggChocolates);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.Button button_AggChocolates;
        private System.Windows.Forms.Button button_Fabricar;
        private System.Windows.Forms.Button button_Informes;
    }
}

