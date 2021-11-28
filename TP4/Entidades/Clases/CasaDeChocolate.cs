using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Excepciones;
using Entidades.Interfaces;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Entidades.Clases;
namespace Entidades
{
    public class CasaDeChocolate : IChocolate<Chocolate>
    {
        private List<Chocolate> listaDeChocolates;
        private string nombre;
        private static CasaDeChocolate prueba;

        /// <summary>
        /// Contructor sin parametro que inicializa la lista
        /// </summary>
        public CasaDeChocolate()
        {
            this.listaDeChocolates = new List<Chocolate>();
        }

        /// <summary>
        /// Constructor con un parametro 
        /// </summary>
        /// <param name="nombre"> nombre de la fabrica</param>
        public CasaDeChocolate(string nombre) : this()
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Propiedad de Lectura de la listaDeChocolates
        /// </summary>
        public List<Chocolate> ListaDeChocolates
        {
            get { return this.listaDeChocolates; }
            set { this.listaDeChocolates = value;  }
        }

        /// <summary>
        /// Propiedad de Lectura del atributo nombre
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
        }

        /// <summary>
        /// Metodo estatico  
        /// Verifica que ya exista una instancia de Fabrica y la retorna. En caso contrario, instancia la clase y lo retorna.
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static CasaDeChocolate GetFabrica(string nombre)
        {
            if (prueba is null)
            {
                return prueba = new CasaDeChocolate(nombre);
            }else
            {
                prueba.nombre = nombre;
                return prueba;
            }
        }

        /// <summary>
        /// Agrega un Chocolate a la lista si no se repite
        /// </summary>
        /// <param name="chocolate"></param>
        /// <returns> true si se agrego el chocolate a la lista, false si no</returns>
        public bool AgregarLista(Chocolate chocolate)
        {
            bool rt = false;
            if (this != chocolate)
            {
                this.ListaDeChocolates.Add(chocolate);
                rt = true;
            }

            return rt;
        }

        /// <summary>
        /// Elimina el chocolate recibido como parametro de la lista
        /// </summary>
        /// <param name="chocolate"></param> chocolate a eliminar 
        /// <returns> true si se pudo eliminar, false caso contrario</returns>
        public bool EliminarLista(Chocolate chocolate)
        {
            bool rt = false;
            if (this == chocolate)
            {
                this.ListaDeChocolates.Remove(chocolate);
                rt = true;
            }

            return rt;
        }
       
        /// <summary>
        /// Sobrecarga del  ==
        /// </summary>
        /// <param name="casaDeChocolate">CasaDeChocolate</param>
        /// <param name="chocolate">Chocolate</param>
        /// <returns>true si son iguales</returns>
        public static bool operator ==(CasaDeChocolate casaDeChocolate, Chocolate chocolate)
        {
            bool resultado = false;

            foreach (Chocolate item in casaDeChocolate.listaDeChocolates)
            {
                if (item == chocolate)
                {
                    resultado = true;
                }
            }
            return resultado;
        }

        /// <summary>
        /// Sobrecarga del !=
        /// Reutiliza la sobrecarga del == negandola
        /// </summary>
        /// <param name="casaDeChocolate">CasaDeChocolate</param>
        /// <param name="chocolate">Chocolate</param>
        /// <returns>true si no son iguales</returns>
        public static bool operator !=(CasaDeChocolate casaDeChocolate, Chocolate chocolate)
        {
            return !(casaDeChocolate == chocolate);
        }

        /// <summary>
        /// Sobrecarga del GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() { return 0; }

        /// <summary>
        /// Metodo estatico
        /// Crea un string con todos los datos de la lista
        /// </summary>
        /// <param name="casa"></param>
        /// <returns></returns>
        public static string Mostrar(CasaDeChocolate choco)
        {

            StringBuilder data = new StringBuilder();
            data.AppendLine($"Cantidad de modelos de Chocolates: ({choco.listaDeChocolates.Count})");
            data.AppendLine("Lista:");
            data.AppendLine("***************************");
            foreach (Chocolate item in choco.listaDeChocolates)
            {
                data.AppendLine(item.Mostrar());
            }
            return data.ToString();
        }
        /// <summary>
        /// Metodo que guarda en un archivo .txt
        /// </summary>
        /// <param name="carrito">carrito a guardar</param>
        /// <returns>true si se guardó correctamente, caso contrario devuelve false</returns>
        public static bool Guardar(CasaDeChocolate carrito)
        {
            Texto texto = null;
            bool rt = false;
            try
            {
                texto = new Texto();
                
                texto.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\CasaChocolate", carrito.ToString());
                rt = true;
            }
            catch (Exception)
            {
                throw;
            }

            return rt;
        }

        /// <summary>
        /// Sobre carga del ToString
        /// </summary>
        /// <returns>retorna un string con todos los datos de la lista</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Chocolate chocolate in this.ListaDeChocolates)
            {
                sb.AppendLine(chocolate.Mostrar());
            }
            return sb.ToString();
        }
        /// <summary>
        /// Metodo que lee un carrito en un archivo con extension .txt
        /// </summary>
        /// <returns>cadena de string con los datos del carrito leido</returns>
        public static string Leer()
        {
            Texto texto = null;
            string carrito = null;

            try
            {
                texto = new Texto();
                texto.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\CasaChocolate.txt", out carrito);
            }
            catch (Exception)
            {

                throw;
            }

            return carrito;
        }
    }
}
