using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entities
{
    public static class DataBase
    {
        #region Fields
        static SqlConnection connection;
        static SqlCommand command;
        static SqlDataReader reader;
        static string stringConnection;
        static List<Product> productList;
        #endregion

        #region Constructors
        static DataBase()
        {
            stringConnection = @"Server=localhost\SQLEXPRESS; Database=FastFoodDB; Trusted_Connection=True";
            connection = new SqlConnection(stringConnection);
            command = new SqlCommand();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Inserta un pedido en la Base de Datos
        /// </summary>
        /// <param name="totalPrice"></param>
        /// <param name="delivery"></param>
        /// <param name="deliveryAddress"></param>
        /// <returns></returns>
        public static int InsertarProducto(double totalPrice, bool delivery, string deliveryAddress)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command.Parameters.Clear();

                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = @"INSERT INTO Orders (TotalPrice, Delivery, DeliveryAddress)
                                        VALUES (@TOTALPRICE, @DELIVERY, @DELIVERYADDRESS)";

                command.Parameters.Add("@TOTALPRICE", SqlDbType.Float).Value = totalPrice;
                command.Parameters.Add("@DELIVERY", SqlDbType.Bit).Value = delivery;
                command.Parameters.Add("@DELIVERYADDRESS", SqlDbType.VarChar).Value = deliveryAddress;

                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new FailSqlOpException("¡Operación con la base de datos fallida!");
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Consulta a la base de datos el numero de rows para establecer el id global.
        /// </summary>
        /// <returns>Numero de registros</returns>
        public static void ImportId()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT count(*) FROM Orders";

                int value = (int)command.ExecuteScalar();
                Order.GlobalId = ++value;
            }
            catch (Exception)
            {
                throw new FailSqlOpException("¡Operación con la base de datos fallida!");
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Trae todos los productos de la base de datos.
        /// </summary>
        /// <returns></returns>
        //public static List<Producto> TraerProductos()
        //{
        //    try
        //    {
        //        productList = new List<Producto>();

        //        if (connection.State != ConnectionState.Open)
        //        {
        //            connection.Open();
        //        }

        //        command.Connection = connection;
        //        command.CommandType = CommandType.Text;
        //        command.CommandText = "SELECT * FROM Productos";

        //        reader = command.ExecuteReader();


        //        while (reader.Read())
        //        {
        //            productList.Add(new Producto(
        //                int.Parse(reader["Id"].ToString()),
        //                reader["Nombre"].ToString(),
        //                int.Parse(reader["CantidadDisponible"].ToString()),
        //                double.Parse(reader["PrecioUnitario"].ToString())
        //                ));
        //        }

        //        return productList;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new FailSqlOpException("¡Operación con la base de datos fallida!", ex);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}
        #endregion
    }
}
