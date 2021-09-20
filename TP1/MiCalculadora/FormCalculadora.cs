using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Obtiene el resultado del calculo realizado en el método Operar del class library.
        /// </summary>
        /// <param name="numero1"></param> primer operando
        /// <param name="numero2"></param> segundo operando
        /// <param name="operador"></param> operador entre los dos operando 
        /// <returns></returns>
        private double Operar(string numero1, string numero2, string operador)
        {
            return Calculadora.Operar(new Operando(numero1), new Operando(numero2), char.Parse(operador));
        }

        /// <summary>
        /// Cuando arranca el form, esta funcion llama a la funcion Limpiar()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();         
        }

        /// <summary>
        /// Borra todos los datos de los dos TextBox, ComboBox y Label de la pantalla.
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.SelectedIndex = -1;
            this.lblResultado.Text = "0";

            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }

        /// <summary>
        /// Ejecuta la operacion entre Dos numeros segun el operador seleccionado del ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (this.txtNumero1.Text == "" || this.txtNumero2.Text == "" )
            {
                MessageBox.Show("FALTAN INGRESAR VALORES", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(this.cmbOperador.SelectedIndex == -1)
                {
                    cmbOperador.Text = "+";
                }
                
                double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
                this.lblResultado.Text = resultado.ToString();
                this.lstOperaciones_SelectedIndexChanged(sender, e);

                if (cmbOperador.Text == "/" && this.txtNumero2.Text == "0")
                {
                    MessageBox.Show("ERROR A DIVIDIR POR CERO\n SINTAX ERROR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                btnConvertirABinario.Enabled = true;
                btnConvertirADecimal.Enabled = true;
            }       
        }

        /// <summary>
        /// Al tocar el boton Cerrar, muestra un MessageBox donde el usuario podra elegir si quiere cerrar la calculadora 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Al tocar el boton Limpiar, se implementa el metodo Limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Al tocar el boton, si es posible, convierte el numero decimal en binario
        /// Si no es posible, arroja un MessageBox de error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblResultado.Text, out double aux))
            {
                Operando res = new Operando(lblResultado.Text);
                string numeroBinario = res.DecimalBinario(lblResultado.Text);
                if (aux >= 0)
                {
                    lstOperaciones.Items.Add($"{lblResultado.Text}D = {numeroBinario}B");
                }
                lblResultado.Text = numeroBinario;
            }
            else
            {
                MessageBox.Show("Debe ingresar un valor válido decimal para poder convertirlo a binario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Al tocar el boton, si es posible, convierte el numero binario en decimal
        /// Si no es posible, arroja un MessageBox de error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if(double.TryParse(lblResultado.Text,out _))
            {
                Operando resultado = new Operando(lblResultado.Text);
                string numeroDecimal = resultado.BinarioDecimal(lblResultado.Text);

                if (int.TryParse(numeroDecimal, out _))
                {
                    lstOperaciones.Items.Add($"{lblResultado.Text}B = {numeroDecimal}D");
                }
                lblResultado.Text = numeroDecimal;
            }
            else
            {
                MessageBox.Show("Debe ingresar un valor válido binario para poder convertirlo a Decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Muestra en el listBox, las operaciones realizadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lstOperaciones.Items.Add(txtNumero1.Text + " " + cmbOperador.Text + " " + txtNumero2.Text + " = " + this.lblResultado.Text);
        }

        /// <summary>
        /// Ejecuta un  MessageBox, para confirmar que el usuario quiere salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonCerrar(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        /// <summary>
        /// Valida que el usuario en el textBox 1, unicamente ingrese [Positivos/Negativos] o numeros con [ , ]
        /// Si ingresa otros digitos, se muestra un  MessageBox de aviso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || (e.KeyChar.ToString().Equals(",") && !(this.txtNumero1.Text.Contains(","))) || (e.KeyChar.ToString().Equals("-") && this.txtNumero1.Text.Length == 0))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admite numeros [Positivos/Negativos] o numeros con [ , ]", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
           
        }

        /// <summary>
        /// Valida que el usuario en el textBox 1, unicamente ingrese [Positivos/Negativos] o numeros con [ , ]
        /// Si ingresa otros digitos, se muestra un  MessageBox de aviso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().Equals(".") || Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || (e.KeyChar.ToString().Equals(",") && !(this.txtNumero2.Text.Contains(","))) || (e.KeyChar.ToString().Equals("-") && this.txtNumero2.Text.Length == 0))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admite numeros [Positivos/Negativos] o numeros con [ , ]", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        private void lblResultado_Click(object sender, EventArgs e)
        { }
        private void txtNumero1_TextChanged(object sender, EventArgs e)
        { }
        private void txtNumero2_TextChanged(object sender, EventArgs e)
        { }
        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        { }
    }
}
