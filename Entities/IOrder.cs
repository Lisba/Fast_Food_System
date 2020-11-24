using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    interface IOrder
    {
        List<Product> ProductsList { get; }
        double TotalPrice { get; }
        int Id { get; }

        void DeliverOrder();
    }
}
