using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IChocolate<T> where T : Chocolate
    {
        /// <summary>
        /// Metodo de tipo Interfaz Chocolate
        /// agrega un chocolate a la lista
        /// </summary>
        /// <param name="chocolate"></param>
        /// <returns></returns>
        bool AgregarLista(T chocolate);
    }
}
