using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop 
{
    public class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            double delta = x.Cost - y.Cost;
            return double.IsNegative(delta) ? -1 : 1;
        }
    }
}
