using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IceCreamShop
{
    internal class FlavorComparer : IComparer<Flavor>
    {
        //public int Compare( Flavor x, Flavor y)
        //{
        //    return string.Compare(x.Name, y.Name);
        //} Default string comparer: we're overriding this for the Bonus
        public int Compare( Flavor x, Flavor y)
        {
            if(x.Allergens.Count > y.Allergens.Count)
            {
                return 1;
            }else if(x.Allergens.Count < y.Allergens.Count)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
