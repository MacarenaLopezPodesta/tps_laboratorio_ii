using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Entidades.Clases;
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
            {
                this.Close();
            }

                
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

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            Horario horario = new Horario();
            horario.HorarioCambiado += AsignarHorario;
            horario.Iniciar();
        }
        public void AsignarHorario(Horario horario)
        {
            if (label_Horario.InvokeRequired)
            {
                Action<Horario> delegado = AsignarHorario;


                label_Horario.Invoke(delegado, horario);

            }
            else
            {
                label_Horario.Text = horario.ToString();

            }

        }

        private void button_BaseDeDatos_Click(object sender, EventArgs e)
        {
            
            AccederDatos accederDatos = new AccederDatos();
            fabrica = CasaDeChocolate.GetFabrica(nombre);
            if (accederDatos.ProbarConexion())
            {

                if (MessageBox.Show($"Esta seguro de que desea importar los datos?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        this.fabrica.ListaDeChocolates = accederDatos.ObtenerLista();
                     
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrio un problema al importar los datos");
                        
                    }

                }
                MessageBox.Show(fabrica.ToString());
            }
            else
            {
                MessageBox.Show("Ocurrio un problema con la conexión");
            }
        }

        private void button_ExportarBaseDeDatos_Click(object sender, EventArgs e)
        {
            fabrica = CasaDeChocolate.GetFabrica(nombre);
            AccederDatos accederDatos = new AccederDatos();
            foreach (Chocolate item in this.fabrica.ListaDeChocolates)
            {
                if (!accederDatos.AgregarDato(item))
                {
                    MessageBox.Show("Ocurrio un problema al agregar el asegurado");
                 
                }
               

            }
            MessageBox.Show("Exportado con exito!");

        }
    }
}
