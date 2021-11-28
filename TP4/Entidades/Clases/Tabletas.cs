using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Tabletas : Chocolate
    {
        private int gramos;
        private EAgregadoTableta agregadoTableta;
        private ETipoTableta tipoTableta;

        /// <summary>
        /// Constructor que instancia un objeto llamando a la clase base
        /// </summary>
        /// <param name="chocolate"> clase de chocolate</param>
        /// <param name="cantidadAProducir">cantidad de tabletas a producir</param>
        /// <param name="marca"> marca de la tableta</param>
        /// <param name="agregadoTableta"> agregado</param>
        /// <param name="tipoTableta"> tipo</param>
        public Tabletas(EClaseChocolate chocolate, int cantidadAProducir, string marca, EAgregadoTableta agregadoTableta, ETipoTableta tipoTableta)
            : base(chocolate, cantidadAProducir, marca, agregadoTableta.ToString(),150,tipoTableta.ToString())
        {
        }

        /// <summary>
        /// Metodo Mostrar, crea un string con los datos de la tableta
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.Mostrar()}");
          
            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga de == , Compara si las tabletas son iguales
        /// </summary>
        /// <param name="a">tableta a comparar</param>
        /// <param name="b">tableta a comparar</param>
        /// <returns> true si son iguales</returns>
        public static bool operator ==(Tabletas a, Tabletas b)
        {
            if (!(a is null) && !(b is null))
            {
                return a==(Chocolate)b && a.agregadoTableta == b.agregadoTableta && a.gramos == b.gramos && a.tipoTableta == b.tipoTableta;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del != , reutiliza la sobrecarga del == negandolo
        /// </summary>
        /// <param name="a">tableta a comparar</param>
        /// <param name="b">tableta a compara</param>
        /// <returns> true si son distintos</returns>
        public static bool operator !=(Tabletas a, Tabletas b)
        {
            return !(a==b);
        }

        /// <summary>
        /// Metodo Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Tabletas && this == (Tabletas)obj; ;
        }

        /// <summary>
        /// Metodo GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() { return 0; }
    }
}
