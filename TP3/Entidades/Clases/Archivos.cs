using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Entidades.Interfaces;
using Entidades.Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivos<T>
    {
        /// <summary>
        /// Guarda un archivo  .xml
        /// </summary>
        /// <param name="archivo"> ruta del archivo</param>
        /// <param name="datos"> datos leidos del archivo</param>
        /// <returns> true si se pudo guardar</returns>
        public bool Guardar(string archivo, T datos)
        {
            bool guardado = false;
            XmlTextWriter textWriter = null;
            XmlSerializer serializer;
            try
            {
                textWriter = new XmlTextWriter($"{archivo}.xml", Encoding.UTF8);
                serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(textWriter, datos);
                guardado = true;
            }
            catch (Exception ex)
            {

                throw new ArchivosException(ex);
            }
            finally
            {
                if (textWriter != null)
                {
                    textWriter.Close();
                }
            }

            return guardado;
        }

        /// <summary>
        /// lee archivo .xml
        /// </summary>
        /// <param name="archivo">ruta del archivo</param>
        /// <param name="datos"> datos a leer del archivo</param>
        /// <returns> true si se pudo leer</returns>
        public bool Leer(string archivo, out T datos)
        {
            bool leido = false;
            XmlSerializer serializer;
            XmlTextReader reader = null;

            try
            {
                serializer = new XmlSerializer(typeof(T));
                reader = new XmlTextReader($"{archivo}.xml");
                datos = (T)serializer.Deserialize(reader);
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
