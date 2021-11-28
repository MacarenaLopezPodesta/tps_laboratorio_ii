using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades.Interfaces;
using Entidades.Excepciones;
namespace Entidades.Clases
{
    public class Texto : IArchivos<string>
    {
        /// <summary>
        /// Guarda un archivo con extension .txt
        /// </summary>
        /// <param name="archivo">ruta del archivo</param>
        /// <param name="datos">datos a guardar</param>
        /// <returns>true si se pudo guardar</returns>
        public bool Guardar(string archivo, string datos)
        {
            bool guardado = false;
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter($"{archivo}.txt", true);
                writer.WriteLine(datos);
              
                guardado = true;
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
            return guardado;
        }

        /// <summary>
        /// Lee un archivo .txt
        /// </summary>
        /// <param name="archivo">ruta del archivo</param>
        /// <param name="datos">los datos leidos del archivo</param>
        /// <returns>true si se pudo leer</returns>
        public bool Leer(string archivo, out string datos)
        {
            bool leido = false;
            StreamReader reader = null;
            datos = null;

            try
            {
                reader = new StreamReader($"{archivo}.txt");
                datos = reader.ReadToEnd();
                leido = true;
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return leido;
        }
    }
}
