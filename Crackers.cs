using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Inventory
{
    class Crackers : IShippable
    {
        private decimal _shipCost = 0.57M;
        private string _product = "Crackers";

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
