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
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        
        private void btn_Tabletas_Click(object sender, EventArgs e)
        {
            FormRegistrarTabletas formRegistrarTabletas= new FormRegistrarTabletas();
            formRegistrarTabletas.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistrarBombones formRegistrarBombones = new FormRegistrarBombones();
            formRegistrarBombones.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
