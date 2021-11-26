using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases
{
    public class Informes
    {
        CasaDeChocolate fabrica;
        string nombre = "Milka";

        /// <summary>
        /// Constructor de Informes, trae la lista completa
        /// </summary>
        public Informes()
        {
            fabrica = CasaDeChocolate.GetFabrica(nombre);
        }

        /// <summary>
        /// Propiedad retorna cantidad de registros
        /// </summary>
        public int CantidadRegistros
        {
            get
            {
                return this.fabrica.ListaDeChocolates.Count;
            }

        }

        /// <summary>
        /// Propiedad retorna porcentaje de bombones
        /// </summary>
        public float PorcentajeDeBombones
        {
            get
            {
                return this.CalcularPorcentajePorTipoBombones(fabrica);
            }
        }

        /// <summary>
        /// Propiedad retorna porcentaje de tabletas
        /// </summary>
        public float PorcentajeDeTabletas
        {
            get
            {

                return this.CalcularPorcentajePorTipoTabletas(fabrica);
            }
        }

        /// <summary>
        /// calcula porcentaje de tipo de bombones
        /// </summary>
        /// <param name="fabrica"></param>
        /// <returns> devuelve el porcentaje </returns>
        private float CalcularPorcentajePorTipoBombones(CasaDeChocolate fabrica)
        {
            fabrica = CasaDeChocolate.GetFabrica(nombre);
            int total = this.CantidadRegistros;
            int cantidad= 0;
            float retorno = 0;
            foreach (Chocolate item in this.fabrica.ListaDeChocolates)
            {
                if (item is Bombones)
                {
                    cantidad++;
                }
            }
            if (total > 0)
            {
                retorno = (float)cantidad * 100 / total;
            }
            return retorno;
        }

        /// <summary>
        /// calcula porcentaje de tipo de tabletas
        /// </summary>
        /// <param name="fabrica"></param>
        /// <returns> devuelve el porcentaje</returns>
        private float CalcularPorcentajePorTipoTabletas(CasaDeChocolate fabrica)
        {
            fabrica = CasaDeChocolate.GetFabrica(nombre);
            int total = this.CantidadRegistros;
            int cantidad = 0;
            float retorno = 0;
            foreach (Chocolate item in this.fabrica.ListaDeChocolates)
            {
                if (item is Tabletas)
                {
                    cantidad++;
                }
            }
            if (total > 0)
            {
                retorno = (float)cantidad * 100 / total;
            }
            return retorno;
        }

        /// <summary>
        /// Propiedad retorna porcentaje de chocolate de leche
        /// </summary>
        public float PorcentajeChococolateLeche
        {
            get
            {
                return this.CalcularPorChocolate(EClaseChocolate.Leche);
            }
        }

        /// <summary>
        /// Propiedad retorna porcentaje de chocolate amargo
        /// </summary>
        public float PorcentajeChococolateAmargo
        {
            get
            {
                return this.CalcularPorChocolate(EClaseChocolate.Amargo);
            }
        }

        /// <summary>
        /// Propiedad retorna porcentaje de chocolate blanco
        /// </summary>
        public float PorcentajeChococolateBlanco
        {
            get
            {
                return this.CalcularPorChocolate(EClaseChocolate.Blanco);
            }
        }

        /// <summary>
        /// Propiedad retorna porcentaje de chocolate Semiamargo
        /// </summary>
        public float PorcentajeChococolateSemiamargo
        {
            get
            {
                return this.CalcularPorChocolate(EClaseChocolate.Semiamargo);
            }
        }

        /// <summary>
        /// calcula porcentaje de clase de chocolate
        /// </summary>
        /// <param name="claseChoc"> clase de chocolate a sacar porcentaje</param>
        /// <returns> retorna el valor del porcentaje</returns>
        private float CalcularPorChocolate(EClaseChocolate claseChoc)
        {
            fabrica = CasaDeChocolate.GetFabrica(nombre);
            int total = this.CantidadRegistros;
            int cantidad = 0;
            float retorno = 0;
            foreach (Chocolate item in this.fabrica.ListaDeChocolates)
            {
                if (item.ClaseDeChocolate == claseChoc)
                {
                    cantidad++;
                }
            }
            if(total > 0)
            {
               retorno = (float)cantidad * 100 / total;
            }
            return retorno;
        }

   

        /// <summary>
        /// Muestra las estadisticas
        /// </summary>
        /// <returns> string con todas las estadistica</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"\nTotal registros de Chocolates: {this.CantidadRegistros}");
            sb.AppendLine($"\nPorcentaje de tabletas registradas: {this.PorcentajeDeTabletas}%");
            sb.AppendLine($"\nPorcentaje de bombones registrados: {this.PorcentajeDeBombones}%");
            sb.AppendLine($"\nPorcentaje de chocolates de leche: {this.PorcentajeChococolateLeche}%");
            sb.AppendLine($"\nPorcentaje de chocolates amargos: {this.PorcentajeChococolateAmargo}%");
            sb.AppendLine($"\nPorcentaje de chocolates semiamargos: {this.PorcentajeChococolateSemiamargo}%");
            sb.AppendLine($"\nPorcentaje de chocolates blancos: {this.PorcentajeChococolateBlanco}%");
            return sb.ToString();
        }
    }
}
