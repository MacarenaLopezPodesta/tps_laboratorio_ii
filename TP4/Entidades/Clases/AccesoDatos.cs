using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Entidades
{

    public class AccederDatos
    {
        #region Atributos

        private static string cadena_conexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        #endregion

        #region Constructores
        /// <summary>
        /// Constructor establece los datos de la conexion
        /// </summary>
        static AccederDatos()
        {
            AccederDatos.cadena_conexion = @"Server=LAPTOP-JCR9PNRV;Database=TP4_Macarena;Trusted_Connection=True;";
        }
        /// <summary>
        /// Constructor establece conexion
        /// </summary>
        public AccederDatos()
        {
            this.conexion = new SqlConnection(AccederDatos.cadena_conexion);
        }

        #endregion

        #region Métodos

        #region Probar conexión
        /// <summary>
        /// Se encarga de testear la conexion
        /// </summary>
        /// <returns>retorna false si ocurrio algun problema, de lo contrario retorna false</returns>
        public bool ProbarConexion()
        {
            bool rta = true;

            try
            {
                this.conexion.Open();
            }
            catch (Exception e)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #region Select
        /// <summary>
        /// obtiene una lista de asegurados de la base de datos
        /// </summary>
        /// <returns> retorna lista de asegurados recuperada de la base de datos</returns>
        public List<Chocolate> ObtenerLista()
        {
            List<Chocolate> lista = new List<Chocolate>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM Chocolates";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                   
                    Chocolate item = new Chocolate();

                    item.ClaseDeChocolate = (EClaseChocolate)Enum.Parse(typeof(EClaseChocolate), lector["chocolate"].ToString());
                    item.CantidadAProducir = int.Parse( lector["cantidadAProducir"].ToString());
                    item.Marca = lector["marca"].ToString();
                    item.Agregado = lector["agregado"].ToString();
                    item.Gramos = int.Parse(lector["gramos"].ToString());
                    item.Tipo= lector["tipo"].ToString();
                    
                     lista.Add(item);

                 }

                lector.Close();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return lista;
        }

        #endregion

        #region Insert

        /// <summary>
        /// Agrega un asegurado a la tabla de la base de datos
        /// </summary>
        /// <param name="param"></param>
        /// <returns>retorna true si pudo agregar el asegurado, de lo contrario false</returns>
        public bool AgregarDato(Chocolate param)
        {
            bool rta = true;

            try
            {


                string sql = "INSERT INTO Chocolates (chocolate,cantidadAProducir,marca,agregado,gramos,tipo) VALUES(";


                sql = sql + ((int)param.ClaseDeChocolate).ToString() + "," + ((int)param.CantidadAProducir).ToString() + "," + "'" + param.Marca + "'," + "'" + param.Agregado + "',"
                      + "'" + ((int)param.Gramos).ToString() + "','" + param.Tipo + "')";

                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #endregion
    }
}
