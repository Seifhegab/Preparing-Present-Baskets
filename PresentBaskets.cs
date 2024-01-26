using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    // *****************************************
    // DON'T CHANGE CLASS OR FUNCTION NAME
    // YOU CAN ADD FUNCTIONS IF YOU NEED TO
    // *****************************************
    public static class PresentBaskets
    {
        #region YOUR CODE IS HERE
        /// <summary>
        /// fill the 2 baskets with the most expensive collection of fruits.
        /// </summary>
        /// <param name="W1">weight of 1st basket</param>
        /// <param name="W2">weight of 2nd basket</param>
        /// <param name="items">Pair of weight (Key) & cost (Value) of each item</param>
        /// <returns>max total cost to fill two baskets</returns>
        static public double PreparePresentBaskets(int W1, int W2, KeyValuePair<int, int>[] items)
        {
            //REMOVE THIS LINE BEFORE START CODING
            //throw new NotImplementedException();

            int Weight = W1 + W2;
            double TotalCost = 0.0;
            double [] CostPerWeight = new double[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                CostPerWeight[i] = (double)((double)items[i].Value / (double)items[i].Key);
            }

            
            Array.Sort(CostPerWeight, items);

            for (int i = items.Length - 1; i >= 0; i--)
            {
                if (items[i].Key == 0)
                {
                    continue;
                }

                if (items[i].Key <= Weight)
                {
                    TotalCost = TotalCost + items[i].Value;
                    Weight = Weight - items[i].Key;
                }
                else
                {
                    TotalCost = TotalCost + (CostPerWeight[i] * Weight);
                    Weight = Weight - Weight;
                }

                if (Weight == 0)
                {
                    break;
                }

            }

            return TotalCost;
        }

        
        #endregion
    }
}
