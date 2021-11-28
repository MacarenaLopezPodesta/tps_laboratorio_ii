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
using System.Collections;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Entidades.Excepciones;

namespace Formularios
{
    public partial class FormLista : Form
    {
        CasaDeChocolate fabrica;
        string nombre = "Milka";
        string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ChocolatesXml.xml");
        
        /// <summary>
        /// LLama a los metodos InitializeComponent
        /// </summary>
        public FormLista()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento del boton Fabricar
        /// Si la lista esta cargada, llama a el metodo Guardar (Que guarda los datos de la lista en un archivo)
        /// Y luego limpia la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Fabricar_Click(object sender, EventArgs e)
        {
            fabrica = CasaDeChocolate.GetFabrica(nombre);
            if(fabrica.ListaDeChocolates.Count == 0)
            {
                MessageBox.Show("La lista esta vacia, para poder fabricar tiene que registrar algun CHOCOLATE", "NO SE PUDO FABRICAR", MessageBoxButtons.OK);
            }
            else if(CasaDeChocolate.Guardar(fabrica))
            {
                MessageBox.Show("Se han fabricado los chocolates con exito!\n Se creo un archivo en su escritorio llamado CasaChocolate.txt donde podra ver todos los datos", "Fabricacion completa", MessageBoxButtons.OK);
                fabrica.ListaDeChocolates.Clear();
                this.Close();
            }
        }

        /// <summary>
        /// Evento del boton Cancelar
        ///  Emite un MessageBox preguntando si quiere salir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        /// <summary>
        /// Metodo ActualizarDataGrid
        /// Recorre la lista de CasaDeChocolate y llama a el metoto CargaDataGrid segun el item
        /// </summary>
        /// <param name="fabrica"></param> 
        private void ActualizarDataGrid( CasaDeChocolate fabrica)
        {
            while(dataGrid.RowCount > 1){

                dataGrid.Rows.Remove(dataGrid.CurrentRow);

            }
            fabrica = CasaDeChocolate.GetFabrica(nombre);
            foreach (Chocolate item in fabrica.ListaDeChocolates)
            {
                if (item is Bombones)
                {
                    CargaDataGrid(item.Marca, item.ClaseDeChocolate, "Bombones", item.Gramos, item.Agregado, item.Tipo, item.CantidadAProducir);
                }
                else
                {
                    if (item is Tabletas)
                    {
                        CargaDataGrid(item.Marca, item.ClaseDeChocolate, "Tabletas", item.Gramos, item.Agregado, item.Tipo, item.CantidadAProducir);
                    }else
                    {
                        if (item is Chocolate)
                        {
                            CargaDataGrid(item.Marca, item.ClaseDeChocolate, "Chocolate", item.Gramos, item.Agregado, item.Tipo, item.CantidadAProducir);
                        }
                    }
                }
            } 
            
        }

        /// <summary>
        /// Metodo CargaDataGrid
        /// Carga los valores del DataGrid en las posiciones correctas segun los parametros recibidos
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chocolate"></param>
        /// <param name="Producto"></param>
        /// <param name="gramos"></param>
        /// <param name="agregado"></param>
        /// <param name="tipo"></param>
        /// <param name="cantidad"></param>
        public void CargaDataGrid(string marca, EClaseChocolate chocolate, string Producto, int gramos, string agregado, string tipo, int cantidad)
        {

            int posiciones = dataGrid.Rows.Add();
            dataGrid[0, posiciones].Value = Producto;
            dataGrid[1, posiciones].Value = marca;
            dataGrid[2, posiciones].Value = chocolate;
            dataGrid[3, posiciones].Value = gramos;
            dataGrid[4, posiciones].Value = agregado;
            dataGrid[5, posiciones].Value = tipo;
            dataGrid[6, posiciones].Value = cantidad;

        }

        /// <summary>
        /// Ni bien comienza el form se carga la dataGrid con los datos de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLista_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid(fabrica);
        }

        /// <summary>
        /// Evento del boton importar
        /// Se lee un archivo de texto y se agregan los chocolates a la fabrica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ImportarXml_Click(object sender, EventArgs e)
        {
           
                if (MessageBox.Show($"Esta seguro de abrir un archivo?\n", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    fabrica = CasaDeChocolate.GetFabrica(nombre);
                    CasaDeChocolate fabrica2 = new CasaDeChocolate();
                    XmlSerializer serializer;
                    XmlTextReader reader = null;
                   
                    try
                    {
                        serializer = new XmlSerializer(typeof(CasaDeChocolate));
                        reader = new XmlTextReader(ruta);
                         fabrica2 = (CasaDeChocolate)serializer.Deserialize(reader);

                    }
                    catch (Exception ex)
                    {
                        throw new ArchivosException(ex);
                    }
                    finally
                    {
                        if (reader != null)
                        {
                            reader.Close();
                        }

                    }
                foreach (Chocolate item in fabrica2.ListaDeChocolates)
                {
                    this.fabrica.AgregarLista(item);
                }

                MessageBox.Show($"Se importo la lista de ChocolatesXml\n Path:{this.ruta}");
                ActualizarDataGrid(fabrica);
                this.button_ImportarXml.Enabled = false;

            }
            
        }
    }
}
