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
namespace Formularios
{
    public partial class FormFabricar : Form
    {
        private CasaDeChocolate fabrica;
        public FormFabricar()
        {
            InitializeComponent();
        }
        public FormFabricar(string nombre) : this()
        {
            fabrica = CasaDeChocolate.GetFabrica(nombre);
            //this.serializer = new Serializer<Juguete>();
        }
        private void FormFabricar_Load(object sender, EventArgs e)
        {

        }

        private void button_Salir_Click(object sender, EventArgs e)
        {

        }
    }
}
