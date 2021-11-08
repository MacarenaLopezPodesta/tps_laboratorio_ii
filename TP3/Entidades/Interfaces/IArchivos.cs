using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IArchivos<T>
    {
        /// <summary>
        /// Metodo de tipo Interfaz para guardar un archivo 
        /// </summary>
        /// <param name="archivo">ruta del archivo</param>
        /// <param name="datos">datos</param>
        /// <returns></returns>
        bool Guardar(string archivo, T datos);

        /// <summary>
        /// Metodo de tipo Interfaz para leer un archivo 
        /// </summary>
        /// <param name="archivo">datos del archivo</param>
        /// <param name="datos">ruta del archivo</param>
        /// <returns></returns>
        bool Leer(string archivo, out T datos);
    }
}
