using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order : IOrder
    {
        static int globalId;
        int id;
        List<Product> productsList;
        double totalPrice;
        bool delivery;
        string deliveryAddress;

        #region Properties
        public static int GlobalId
        {
            get { return globalId; }
            set { globalId = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public List<Product> ProductsList
        {
            get { return productsList; }
            set { productsList = value; }
        }

        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        public bool Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }

        public string DeliveryAddress
        {
            get { return deliveryAddress; }
            set { deliveryAddress = value; }
        }
        #endregion

        #region Constructors
        public Order(int id, List<Product> productsList, double totalPrice, bool delivery, string deliveryAddress) : this(id, productsList, totalPrice, delivery)
        {
            this.deliveryAddress = deliveryAddress;
        }
        
        public Order(int id, List<Product> productsList, double totalPrice, bool delivery) : this(productsList, totalPrice, delivery)
        {
            this.id = id;
        }

        public Order(List<Product> productsList, double totalPrice, bool delivery, string deliveryAddress) : this(productsList, totalPrice, delivery)
        {
            this.deliveryAddress = deliveryAddress;
        }

        public Order(List<Product> productsList, double totalPrice, bool delivery)
        {
            this.productsList = productsList;
            this.totalPrice = totalPrice;
            this.delivery = delivery;
        }

        public Order() { }
        #endregion

        public void DeliverOrder()
        {
            this.delivery = true;
        }
    }
}
