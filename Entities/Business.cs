using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class Business
    {
        static Queue<Order> preparationOrdersQueue;
        static Queue<Order> readyOrdersQueue;
        static List<Product> productsAvailablesList;
        static Order auxOrder;

        #region Properties
        static public Queue<Order> PreparationOrdersQueue
        {
            get { return preparationOrdersQueue; }
        }

        static public Queue<Order> ReadyOrdersQueue
        {
            get { return readyOrdersQueue; }
        }

        static public List<Product> ProductsAvailablesList
        {
            get { return productsAvailablesList; }
        }
        #endregion

        #region Constructors
        static Business()
        {
            preparationOrdersQueue = new Queue<Order>();
            readyOrdersQueue = new Queue<Order>();
            productsAvailablesList = new List<Product>();
            AddProductsAvailables();
        }
        #endregion

        public static void AddProductsAvailables()
        {
            productsAvailablesList.Add(new Product("Hamburguesa", 500));
            productsAvailablesList.Add(new Product("Pizza", 500));
            productsAvailablesList.Add(new Product("Burrito", 350));
            productsAvailablesList.Add(new Product("Empanada", 40.10));
            productsAvailablesList.Add(new Product("Milanesa", 350.50));
        }

        public static void MoveOrder()
        {
            if(preparationOrdersQueue.Count > 0)
            {
                auxOrder = preparationOrdersQueue.Dequeue();
                readyOrdersQueue.Enqueue(auxOrder);
                try
                {
                    if(auxOrder.DeliveryAddress is null)
                    {
                        DataBase.InsertarProducto(auxOrder.TotalPrice, auxOrder.Delivery, "");
                    }
                    else
                    {
                        DataBase.InsertarProducto(auxOrder.TotalPrice, auxOrder.Delivery, auxOrder.DeliveryAddress);
                    }
                }
                catch (FailSqlOpException ex)
                {
                    throw new FailSqlOpException(ex.Message);
                }
            }
        }
    }
}
