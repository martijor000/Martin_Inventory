using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Inventory
{
    class Lawn_Mowers : IShippable
    {
        private decimal _shipCost = 24.00M;
        private string _product = "Lawn Mower";

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
