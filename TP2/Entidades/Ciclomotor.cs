using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        /// <summary>
        /// Inicializa los atributos del Ciclomotor llamando a la clase base 
        /// </summary>
        /// <param name="marca"></param> Emarca
        /// <param name="chasis"></param> string
        /// <param name="color"></param> ConsoleColor
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color):base(chasis,marca,color)
        {
        }
        
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        public override ETamanio Tamanio
        {
            get{ return Vehiculo.ETamanio.Chico;}
        }

        /// <summary>
        /// Sobreescribe el metodo heredado de la clase base, con los datos del Ciclomotor
        /// </summary>
        /// <returns> devuelve los datos del Ciclomotor </returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
