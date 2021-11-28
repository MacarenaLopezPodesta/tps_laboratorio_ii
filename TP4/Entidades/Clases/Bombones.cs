using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Bombones : Chocolate
    {
        private int gramos;
        private EAgregadoBombones agregadoBombones;
        private EFormaBombones formaBombones;


        /// <summary>
        /// Constructor que instancia un objeto llamando a la clase base
        /// </summary>
        /// <param name="chocolate"> Clase de chocolate</param>
        /// <param name="cantidadAProducir"> Cantidad de Bombones a producir</param>
        /// <param name="marca"> Marca del bombon</param>
        /// <param name="agregadoBombones"> agregado </param>
        /// <param name="formaBombones"> forma </param>
        public Bombones(EClaseChocolate chocolate, int cantidadAProducir, string marca, EAgregadoBombones agregadoBombones, EFormaBombones formaBombones) 
            : base(chocolate, cantidadAProducir, marca,agregadoBombones.ToString(),20,formaBombones.ToString())
        {}

        /// <summary>
        /// Muestra los datos del BOMBON
        /// </summary>
        /// <returns></returns> datos del objeto (string)
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.Mostrar()}");
     
            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del constructor ==
        /// compara si los datos de los dos bombones son iguales
        /// </summary>
        /// <param name="a"> bombon a comparar </param>
        /// <param name="b"> bombon a comparar </param>
        /// <returns></returns> true si son iguales, false si no son iguales
        public static bool operator ==(Bombones a, Bombones b)
        {
            if (!(a is null) && !(b is null))
            {
                return a==(Chocolate)b && a.agregadoBombones == b.agregadoBombones && a.gramos == b.gramos && a.formaBombones == b.formaBombones;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del contructor !=
        /// Reutiliza el codigo de == negandolo
        /// </summary>
        /// <param name="a"> bombon a comparar</param>
        /// <param name="b"> bombon a comparar</param>
        /// <returns></returns> true si no son iguales, false si son iguales
        public static bool operator !=(Bombones a, Bombones b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Sobrecarga de Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Bombones && this == (Bombones)obj; ;
        }

        /// <summary>
        /// Sobrecarga de GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() { return 0; }
    }
}
