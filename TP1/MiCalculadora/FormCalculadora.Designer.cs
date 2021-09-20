
namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConvertirADecimal = new System.Windows.Forms.Button();
            this.btnConvertirABinario = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.lstOperaciones = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbOperador
            // 
            this.cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperador.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.cmbOperador.Location = new System.Drawing.Point(140, 44);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(123, 43);
            this.cmbOperador.TabIndex = 2;
            this.cmbOperador.SelectedIndexChanged += new System.EventHandler(this.cmbOperador_SelectedIndexChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(227, 9);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(166, 28);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "0";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // btnOperar
            // 
            this.btnOperar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOperar.Location = new System.Drawing.Point(12, 131);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(131, 41);
            this.btnOperar.TabIndex = 4;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(149, 131);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(114, 41);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConvertirADecimal
            // 
            this.btnConvertirADecimal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConvertirADecimal.Location = new System.Drawing.Point(208, 178);
            this.btnConvertirADecimal.Name = "btnConvertirADecimal";
            this.btnConvertirADecimal.Size = new System.Drawing.Size(185, 44);
            this.btnConvertirADecimal.TabIndex = 8;
            this.btnConvertirADecimal.Text = "Convertir a Decimal";
            this.btnConvertirADecimal.UseVisualStyleBackColor = true;
            this.btnConvertirADecimal.Click += new System.EventHandler(this.btnConvertirADecimal_Click);
            // 
            // btnConvertirABinario
            // 
            this.btnConvertirABinario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConvertirABinario.Location = new System.Drawing.Point(12, 178);
            this.btnConvertirABinario.Name = "btnConvertirABinario";
            this.btnConvertirABinario.Size = new System.Drawing.Size(190, 44);
            this.btnConvertirABinario.TabIndex = 7;
            this.btnConvertirABinario.Text = "Convertir a Binario";
            this.btnConvertirABinario.UseVisualStyleBackColor = true;
            this.btnConvertirABinario.Click += new System.EventHandler(this.btnConvertirABinario_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(269, 131);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(124, 41);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtNumero2
            // 
            this.txtNumero2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumero2.Location = new System.Drawing.Point(269, 44);
            this.txtNumero2.Multiline = true;
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(124, 42);
            this.txtNumero2.TabIndex = 3;
            this.txtNumero2.TextChanged += new System.EventHandler(this.txtNumero2_TextChanged);
            this.txtNumero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero2_KeyPress);
            // 
            // txtNumero1
            // 
            this.txtNumero1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumero1.Location = new System.Drawing.Point(12, 44);
            this.txtNumero1.Multiline = true;
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(122, 42);
            this.txtNumero1.TabIndex = 1;
            this.txtNumero1.TextChanged += new System.EventHandler(this.txtNumero1_TextChanged);
            this.txtNumero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero1_KeyPress);
            // 
            // lstOperaciones
            // 
            this.lstOperaciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstOperaciones.FormattingEnabled = true;
            this.lstOperaciones.ItemHeight = 15;
            this.lstOperaciones.Location = new System.Drawing.Point(401, 2);
            this.lstOperaciones.Name = "lstOperaciones";
            this.lstOperaciones.Size = new System.Drawing.Size(129, 214);
            this.lstOperaciones.TabIndex = 10;
            this.lstOperaciones.SelectedIndexChanged += new System.EventHandler(this.lstOperaciones_SelectedIndexChanged);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 10F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 234);
            this.Controls.Add(this.lstOperaciones);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.cmbOperador);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnConvertirABinario);
            this.Controls.Add(this.btnConvertirADecimal);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.lblResultado);
            this.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Macarena Lopez Podesta del curso 2°A";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.botonCerrar);
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConvertirADecimal;
        private System.Windows.Forms.Button btnConvertirABinario;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.ListBox lstOperaciones;
    }
}

