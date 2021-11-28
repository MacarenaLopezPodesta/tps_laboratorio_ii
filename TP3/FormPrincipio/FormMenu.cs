using System;
using System.Windows.Forms;
using Entidades;
using Formularios;

namespace FormPrincipio
{
    public partial class Form_Menu : Form
    {
        CasaDeChocolate fabrica;
        string nombre = "Milka";

        /// <summary>
        /// Inicializa los componentes y crea una fabrica
        /// </summary>
        public Form_Menu()
        {
            InitializeComponent();
            fabrica = new CasaDeChocolate(nombre);
        }

        /// <summary>
        /// Evento del boton Registrar Chocolates
        /// LLama a el form FormSeleccionarChocolate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_AggChocolates_Click(object sender, EventArgs e)
        {
            FormSeleccionarChocolate formCargarChocolates = new FormSeleccionarChocolate();
            formCargarChocolates.ShowDialog();
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

        /// <summary>
        /// Evento del boton Fabricar
        /// LLama a el form FormLista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Fabricar_Click(object sender, EventArgs e)
        {

            FormLista formFabricar = new FormLista();
            formFabricar.ShowDialog();
        }

        /// <summary>
        /// Evento del boton Informe de registros
        /// LLama a el form FormInformes 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Informes_Click(object sender, EventArgs e)
        {
            FormInformes formInformes = new FormInformes();
            formInformes.ShowDialog();
        }

       
    }
}
