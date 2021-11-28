using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
   
    public class Chocolate
    {
        private EClaseChocolate chocolate;
        private int cantidadAProducir;
        private string marca;
        private string agregado;
        private int gramos;
        private string tipo;

        public Chocolate() { }
        /// <summary>
        /// Constructor publico
        /// </summary>
        /// <param name="chocolate"></param>
        /// <param name="cantidadAProducir"></param>
        /// <param name="marca"></param>
        /// <param name="agregado"></param>
        /// <param name="gramos"></param>
        /// <param name="tipo"></param>
        protected Chocolate(EClaseChocolate chocolate, int cantidadAProducir, string marca,string agregado,int gramos,string tipo)
        {
            ClaseDeChocolate = chocolate;
            CantidadAProducir = cantidadAProducir;
            Agregado = agregado;
            Gramos = gramos;
            Marca = marca;
            Tipo = tipo;
        }
        
        /// <summary>
        /// Propiedad de lectura y escritura del atributo gramos
        /// </summary>
        public int Gramos
        {
            get { return this.gramos; }
            set { this.gramos = value;}
        }

        /// <summary>
        ///  Propiedad de lectura y escritura del atributo agregado
        /// </summary>
        public string Agregado
        {
            get { return this.agregado; }
            set { this.agregado = value; }
        }

        /// <summary>
        ///  Propiedad de lectura y escritura del atributo tipo
        /// </summary>
        public string Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        /// <summary>
        ///  Propiedad de lectura y escritura del atributo chocolate
        /// </summary>
        public EClaseChocolate ClaseDeChocolate
        {
            get { return this.chocolate; }
            set { this.chocolate = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo cantidadAProducir
        /// </summary>
        public int CantidadAProducir
        {
            get { return this.cantidadAProducir; }
            set 
            {
                if (value > 0)
                {
                    this.cantidadAProducir = value;
                }       
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo marca
        /// </summary>
        public string Marca
        {
            get { return this.marca; }
            set
            {
                if (!(value.Equals(string.Empty)))
                    this.marca = value;
            }
        }
       
        /// <summary>
        /// Metodo mostrar
        /// Crea un string con los datos del chocolate
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Chocolate: {this.ClaseDeChocolate}");
            sb.AppendLine($"Cantidad a producir: {this.CantidadAProducir}");
            sb.AppendLine($"Marca: {this.Marca}");
            sb.AppendLine($"Producto: {this.GetType().Name}");
            sb.AppendLine($"Gramos: {this.Gramos}");
            sb.AppendLine($"Agregado: {this.Agregado}");
            sb.AppendLine($"Tipo: {this.Tipo}");
            return sb.ToString();
        }

        /// <summary>
        /// sobrecarga de ==
        /// Compara si los dos chocolates son iguales
        /// </summary>
        /// <param name="a"> chocolate a comparar</param>
        /// <param name="b"> chocolate a comparar</param>
        /// <returns> true si son iguales</returns>
        public static bool operator ==(Chocolate a, Chocolate b)
        {
            if (!(a is null) && !(b is null))
            {
                return a.marca == b.marca && a.chocolate == b.chocolate && a.gramos == b.gramos && a.tipo == b.tipo && a.agregado == b.agregado;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga de !=
        /// Reutiliza la sobrecarga del == negandolo
        /// </summary>
        /// <param name="a">chocolate a comparar</param>
        /// <param name="b">chocolate a comparar</param>
        /// <returns>true si son distintos</returns>
        public static bool operator !=(Chocolate a, Chocolate b)
        {
            return !(a==b);
        }
    }
}
