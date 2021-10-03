using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        /// <summary>
        /// Inicializa los atributos de Suv llamando al constructor de la clase base
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Suv(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
        }

        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        public override ETamanio Tamanio
        {
            get{ return Vehiculo.ETamanio.Grande; }
        }

        /// <summary>
        /// Sobreescribe el metodo heredado de la clase base, con los datos del Suv
        /// </summary>
        /// <returns> devuelve los datos del Suv </returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
