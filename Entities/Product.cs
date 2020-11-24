using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        static int globalId;
        int id;
        string name;
        double unitPrice;

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }
        #endregion

        #region Constructors
        static Product()
        {
            globalId = 1;
        }

        public Product(string name, double unitPrice)
        {
            this.id = globalId++;
            this.name = name;
            this.unitPrice = unitPrice;
        }

        public Product() { }
        #endregion
    }
}
