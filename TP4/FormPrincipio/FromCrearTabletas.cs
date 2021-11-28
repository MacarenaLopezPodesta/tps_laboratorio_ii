using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Clases;
using Entidades;
namespace Formularios
{
    public partial class FormCrearTabletas : Form
    {
        CasaDeChocolate fabrica;
        Tabletas tabletaForm;
        public FormCrearTabletas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Settea los valores de los comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FromCrearTabletas_Load(object sender, EventArgs e)
        {
            comboBox_AgregadoTabletas.DataSource = Enum.GetValues(typeof(EAgregadoTableta));
            comboBox_ClaseChocolateTabletas.DataSource = Enum.GetValues(typeof(EClaseChocolate));
            comboBox_TipoTabletas.DataSource = Enum.GetValues(typeof(ETipoTableta));
            comboBox_AgregadoTabletas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_ClaseChocolateTabletas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_TipoTabletas.DropDownStyle = ComboBoxStyle.DropDownList;     
        }


        /// <summary>
        /// Propiedad de Lectura y Escrituta del numeric_CantidadAProducirTabletas
        /// </summary>
        public int CantidadProducir
        {
            get { return (int)numeric_CantidadAProducirTabletas.Value; }
            set { numeric_CantidadAProducirTabletas.Value = value; }
        }

        /// <summary>
        /// Evento del boton Crear Diseño
        /// Emite un MessageBox si los valores del numeric_CantidadAProducirTabletas y textBox_MarcaBombones no estan cargados
        /// Si todos los valores estan correctos de crea una nueva tableta. 
        /// Si la tableta no esta repetida, se agrega a la lista de fabrica de CasaDeChocolate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CrearTabletas_Click(object sender, EventArgs e)
        {
            if (numeric_CantidadAProducirTabletas.Value <= 0 || this.textBox_MarcaTableta.Text == "")
            {
                MessageBox.Show("EL CAMPO DE CANTIDAD A PRODUCIR O EL DE MARCA DE TABLETAS ESTAN VACIOS", "Valores invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                tabletaForm = new Tabletas((EClaseChocolate)comboBox_ClaseChocolateTabletas.SelectedIndex, CantidadProducir, textBox_MarcaTableta.Text, (EAgregadoTableta)comboBox_AgregadoTabletas.SelectedItem, (ETipoTableta)comboBox_TipoTabletas.SelectedItem);
                fabrica = CasaDeChocolate.GetFabrica("Milka");
                if (fabrica.AgregarLista(tabletaForm))
                {
                    MessageBox.Show($"Se ha registrado la TABLETA:\n{tabletaForm.Mostrar()}", "Exito", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show($"NO SE PUDO REGISTRAR LA TABLETA\nYa hay un diseño creado con los mismos datos", "Error", MessageBoxButtons.OK);
                }
                Limpiar();
            }
        }

        /// <summary>
        ///   Metodo Limpiar.
        ///  Settea los valores del numeric_CantidadAProducirTabletas y textBox_MarcaTableta al estado inicial
        /// </summary>
        private void Limpiar()
        {
            numeric_CantidadAProducirTabletas.Value = 0;
            textBox_MarcaTableta.Text = string.Empty;
        }

        /// <summary>
        /// Evento del boton Salir
        /// Emite un MessageBox preguntando si quiere salir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
