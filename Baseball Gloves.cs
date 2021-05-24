using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Inventory
{
    class Baseball_Gloves : IShippable
    {
        private decimal _shipCost = 3.23M;
        private string _product = "Baseball Glove";

        public string Product
        {
            get => _product;
        }

        public decimal ShipCost
        {
            get => _shipCost;
        }
    }
}
