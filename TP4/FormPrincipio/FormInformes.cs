using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Clases;
namespace Formularios
{
    public delegate void DelegadoTaskSBarra();
    public partial class FormInformes : Form
    {
        Informes info;

        public FormInformes()
        {
            InitializeComponent();
            this.info = new Informes();
        }

        /// <summary>
        /// Carga los informes en el label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormInformes_Load(object sender, EventArgs e)
        {
            this.label_Informes.Text = "";
            this.label_Informes.AutoSize = true;
            Task task = new Task(() => GenerarInformes());
            task.Start();
        }
        /// <summary>
        /// Simula el proceso de calcular estadisticas
        /// </summary>
        private void GenerarInformes()
        {
            while (this.progressBar_Estadisticas.Maximum > this.progressBar_Estadisticas.Value)
            {
                Thread.Sleep(200);
                Progreso();
            }
        }
        /// <summary>
        /// Aumenta la barra de proceso
        /// </summary>
        private void Progreso()
        {
            if (this.progressBar_Estadisticas.InvokeRequired)
            {
                DelegadoTaskSBarra delegado = new DelegadoTaskSBarra(this.Progreso);
                Invoke(delegado);
            }
            else
            {
                if (progressBar_Estadisticas.Value < 100)
                {
                    progressBar_Estadisticas.Value++;
                    label_Progreso.Text = $"Calculando: {progressBar_Estadisticas.Value}%";
                }


                if (progressBar_Estadisticas.Value == 100)
                {
                    label_Progreso.Text = "¡¡Completado!!";
                    this.label_Informes.Text = info.ToString();
                }
            }
        }
        /// <summary>
        /// Evento del boton Aceptar
        /// Cierra el formulario actual 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
