using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Inventory
{
    class Shipper
    {

        private decimal tempCost = 0;
        private int amount;
        private int[] storeAmount = new int[10];
        private int[] removeDuplicatesAmounts = new int[10];
        private string tempProduct;
        private decimal[] storeCost = new decimal[10];
        private string[] storeProducts = new string[10];
        private string[] removeDuplicatesProducts = new string[10];



        public string Add(IShippable [] obj)
        {

            for(int i = 0; i < 1; i++)
            {
                tempCost = obj[i].ShipCost;
                tempProduct = obj[i].Product;
            }

  
                for(int i = 0; i < storeCost.Length; i++)
                {
                    if(storeCost[i] == 0)
                    {
                        storeCost[i] = tempCost;
                        storeProducts[i] = tempProduct;
                        break;
                    }
                }

            return "1 " + tempProduct + " has been added.";
        }

        public void List()
        {
            for (int i = 0; i < storeProducts.Length; i++)
            {
                amount = 0;

                if (storeProducts[i] == null)
                {
                    break;
                }

                for (int t = 0; t < storeProducts.Length; t++)
                {
                    if (storeProducts[i] == storeProducts[t])
                    {
                        amount = amount + 1;
                    }
                    if (storeProducts[t] == null)
                    {
                        break;
                    }
                }

                removeDuplicatesProducts = storeProducts.Distinct().ToArray();
                storeAmount[i] = amount;
                removeDuplicatesAmounts = storeAmount.Distinct().ToArray();
            }

            Console.WriteLine("Shipment manifest:");

            for(int i = 0; i < removeDuplicatesProducts.Length; i++)
            {
                if (removeDuplicatesProducts[i] == null)
                {
                    break;
                }

                if (removeDuplicatesAmounts[i] > 1)
                {
                    Console.WriteLine(removeDuplicatesAmounts[i] + " " + removeDuplicatesProducts[i] + "s");
                }
                else
                {
                    Console.WriteLine(removeDuplicatesAmounts[i] + " " + removeDuplicatesProducts[i]);
                }
            }
        }

        public decimal TotalCost()
        {
            tempCost = 0;

            for(int i = 0; i < storeCost.Length; i++)
            {
                tempCost = tempCost + storeCost[i];
            }
            return tempCost;
        }
    }
}
