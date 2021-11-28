using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;
using Entidades.Clases;

namespace Formularios
{
    public partial class FormCrearBombones : Form
    {
        CasaDeChocolate fabrica;
        Bombones bombonesForm;

        
        public FormCrearBombones()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Settea los valores de los comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCrearBombones_Load(object sender, EventArgs e)
        {
            comboBox_AgregadoBombones.DataSource = Enum.GetValues(typeof(EAgregadoBombones));
            comboBox_ClaseChocolateBombones.DataSource = Enum.GetValues(typeof(EClaseChocolate));
            comboBox_FormaBombones.DataSource = Enum.GetValues(typeof(EFormaBombones));
            comboBox_AgregadoBombones.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_ClaseChocolateBombones.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_FormaBombones.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Propiedad de Lectura y Escrituta del numeric_CantidadAProducirBombones
        /// </summary>
        public int CantidadProducir
        {
            get { return (int)numeric_CantidadAProducirBombones.Value; }
            set { numeric_CantidadAProducirBombones.Value = value; }
        }

        /// <summary>
        /// Evento del boton Crear Diseño
        /// Emite un MessageBox si los valores del numeric_CantidadAProducirBombones y textBox_MarcaBombones no estan cargados
        /// Si todos los valores estan correctos de crea un nuevo bombon. 
        /// Si el bombon no esta repetido, se agrega a la lista de fabrica de CasaDeChocolate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CrearDiseñoBombones_Click(object sender, EventArgs e)
        {
            if (numeric_CantidadAProducirBombones.Value <= 0 || this.textBox_MarcaBombones.Text == "")
            {
                MessageBox.Show("EL CAMPO DE CANTIDAD A PRODUCIR O EL DE MARCA BOMBONES ESTAN VACIOS", "Valores invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bombonesForm = new Bombones((EClaseChocolate)comboBox_ClaseChocolateBombones.SelectedItem, CantidadProducir, textBox_MarcaBombones.Text, (EAgregadoBombones)comboBox_AgregadoBombones.SelectedItem, (EFormaBombones)comboBox_FormaBombones.SelectedItem);
                fabrica = CasaDeChocolate.GetFabrica("Milka");
                if(fabrica.AgregarLista(bombonesForm))
                {
                    MessageBox.Show($"Se ha registrado el BOMBON:\n{bombonesForm.Mostrar()}", "Exito", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show($"NO SE PUDO REGISTRAR EL BOMBON\nYa hay un diseño creado con los mismos datos", "Error", MessageBoxButtons.OK);
                }
                
                
                Limpiar();
            }
        }

        /// <summary>
        /// Metodo Limpiar. Settea los valores del numeric_CantidadAProducirBombones y textBox_MarcaBombones al estado inicial
        /// </summary>
        private void Limpiar()
        {
            numeric_CantidadAProducirBombones.Value = 0;
            textBox_MarcaBombones.Text = string.Empty;            
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

        private void comboBox_ClaseChocolateBombones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
