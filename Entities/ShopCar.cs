using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class ShopCar
    {
        #region Fields
        static List<Product> shopCarProductsList;
        #endregion

        #region Properties
        public static List<Product> ShopCarProductsList
        {
            get
            {
                return shopCarProductsList;
            }
        }
        #endregion

        #region Constructor
        static ShopCar()
        {
            shopCarProductsList = new List<Product>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Remueve un producto el carrito de compras.
        /// </summary>
        /// <param name="product"></param>
        public static void RemoveItemFromShopCar(Product product)
        {
            shopCarProductsList.Remove(product);
        }

        /// <summary>
        /// Vacía el carrito de compras.
        /// </summary>
        public static void RemoveAllItemsFromShopCar()
        {
            shopCarProductsList.Clear();
        }

        /// <summary>
        /// Obtiene el subtotal del carrito de compras.
        /// </summary>
        /// <returns>El subtotal</returns>
        public static double GetTotalPrice()
        {
            double total = 0;

            foreach (Product product in shopCarProductsList)
            {
                total += product.UnitPrice;
            }

            return total;
        }
        #endregion
    }
}
