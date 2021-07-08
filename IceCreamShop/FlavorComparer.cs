using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public class FlavorComparer : IComparer<Flavor>
    {
        /*
        public int Compare(Flavor x, Flavor y)
        {
            return string.Compare(x.Name, y.Name);
        }
        */
        public int Compare(Flavor x, Flavor y)
        {
            int first = x.Allergens.Count;
            int second = y.Allergens.Count;
            return (first - second < 0) ? -1 : 1;
        }
        
    }
}
