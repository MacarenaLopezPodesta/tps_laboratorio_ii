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
    public partial class btn_FromMenu : Form
    {
        CasaDeChocolate fabrica;
        public btn_FromMenu()
        {
            InitializeComponent();
            fabrica = new CasaDeChocolate("Rapanui");
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void button_MateriaPrima_Click_1(object sender, EventArgs e)
        {
            FormMateriaPrima formMateriaPrima = new FormMateriaPrima();
            formMateriaPrima.ShowDialog();
        }

        private void button_Registrar_Click(object sender, EventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro();
            formRegistro.ShowDialog();
        }

        private void button_Editar_Click(object sender, EventArgs e)
        {
            FormEditar formEditar = new FormEditar();
            formEditar.ShowDialog();
        }

        private void button_Fabricar_Click(object sender, EventArgs e)
        {
            fabrica = CasaDeChocolate.GetFabrica(fabrica.Nombre);

            if (fabrica.ListaDeChocolates.Count > 0)
            {
                FormFabricar formFabricar = new FormFabricar(fabrica.Nombre);
                formFabricar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tiene que haber almenos un juguete registrado", "Registrate Algo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
