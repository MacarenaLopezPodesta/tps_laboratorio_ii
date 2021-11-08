using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormSeleccionarChocolate : Form
    {
        public FormSeleccionarChocolate()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento del boton seleccionar Bombones
        /// LLama a el form : FormCrearBombones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_SeleccionarBombones_Click(object sender, EventArgs e)
        {
            FormCrearBombones formCrearBombones = new FormCrearBombones();
            formCrearBombones.ShowDialog();
        }

        /// <summary>
        /// Evento del boton seleccionar Tabletas
        /// Llama a el form : FormCrearTabletas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_SeleccionarTabletas_Click(object sender, EventArgs e)
        {
            FormCrearTabletas formCrearTabletas = new FormCrearTabletas();
            formCrearTabletas.ShowDialog();
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
