using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo { CuatroPuertas, CincoPuertas }
        private ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// Inicializa los atributos de Sedan llamando al constructor de cuatro parametros
        /// </summary>
        /// <param name="marca"></param> Emarca
        /// <param name="chasis"></param> string
        /// <param name="color"></param> ConsoleColor
        public Sedan(EMarca marca, string chasis, ConsoleColor color) : this(marca, chasis, color, ETipo.CuatroPuertas)
        {}

        /// <summary>
        /// Inicializa los atributos de Sedan llamando al constructor de la clase base
        /// </summary>
        /// <param name="marca"></param> Emarca
        /// <param name="chasis"></param> string
        /// <param name="color"></param> ConsoleColor
        /// <param name="tipo"></param> Etipo
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) : base(chasis, marca, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        public override ETamanio Tamanio
        {
            get { return Vehiculo.ETamanio.Mediano; }
        }

        /// <summary>
        /// Sobreescribe el metodo heredado de la clase base, con los datos del Sedan
        /// </summary>
        /// <returns> devuelve los datos del Sedan </returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.Append(base.Mostrar());
            sb.AppendLine($"TIPO : {this.tipo}\n");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
