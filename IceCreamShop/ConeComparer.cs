﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IceCreamShop
{
    internal class ConeComparer : IComparer<Cone>
    {
        public int Compare( Cone x, Cone y)
        {
            double difference = x.Cost - y.Cost;
            if(difference > 0)
            {
                return 1;
            }else if (difference < 0)
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
